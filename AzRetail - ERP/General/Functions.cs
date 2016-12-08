using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP.General
{
    internal class Functions     
    {
        #region Security
        #region Consts

        internal const string Inputkey = "埃米尔18CDエミル-日本語- 에밀리오日本語";
        #endregion

        #region Rijndael Encryption


        public static string EncryptRijndael(string text)
        {
            if (String.IsNullOrEmpty(text))
                throw new ArgumentNullException("text");
            string salt = "Emil-エミル-日本語";
            var aesAlg = NewRijndaelManaged(salt);

            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            var msEncrypt = new MemoryStream();
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(text);
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
        }
        #endregion

        #region Rijndael Dycryption

        private static bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            return (base64String.Length % 4 == 0) &&
                   Regex.IsMatch(base64String, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

        }


        public static string DecryptRijndael(string cipherText)
        {
            if (!IsBase64String(cipherText))
                throw new Exception("The cipherText input parameter is not base64 encoded");
            string salt = "Emil-エミル-日本語";
            string text;

            var aesAlg = NewRijndaelManaged(salt);
            var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            var cipher = Convert.FromBase64String(cipherText);

            using (var msDecrypt = new MemoryStream(cipher))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        text = srDecrypt.ReadToEnd();
                    }
                }
            }
            return text;
        }
        #endregion
        #region NewRijndaelManaged

        private static RijndaelManaged NewRijndaelManaged(string salt)
        {

            var saltBytes = Encoding.ASCII.GetBytes(salt);
            var key = new Rfc2898DeriveBytes(Inputkey, saltBytes);

            var aesAlg = new RijndaelManaged();
            aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
            aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

            return aesAlg;
        }
        #endregion
        #endregion

        #region data

        public static string GetSqlServerConnectionString(string serverName, string dataBaseName, string user,string password)
        {

          return  string.Format(
                     @"Data Source={0}; Initial Catalog={1}; Persist Security Info=False; User ID={2}; Password={3} ;Connection Timeout=0",//
                     serverName.Trim(), dataBaseName.Trim(), user.Trim(), password.Trim());
            
        }
        
        public static void SetParametrs(string [] properites)
        {

            Variables.ConnectionString = string.Format(
                       @"Data Source={0}; Initial Catalog={1}; Persist Security Info=False; User ID={2}; Password={3} ;Connection Timeout=0 ;",
                       properites[0].Trim(), properites[1].Trim(), properites[2].Trim(), properites[3].Trim());
            Variables.FirmNr = properites[4].Trim();
            Variables.TigerUser = properites[5].Trim();
            Variables.TigerPasssword = properites[6].Trim();
            //Variables.MainConnention = string.Format(
            //           @"Data Source={0}; Initial Catalog={1}; Persist Security Info=False; User ID={2}; Password={3} ; Connection Timeout=600000 ;",
            //           properites[0].Trim(), properites[7].Trim(), properites[2].Trim(), properites[3].Trim());

        }
        public static bool TestSqlServerConnection(string connectionString)
        {
            bool result = false;
            using (var sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    sqlConnection.Open();
                    if (sqlConnection.State == ConnectionState.Open)
                    {

                      
                        sqlConnection.Close();
                        result = true;
                    }
                }
                catch 
                {
                    //MessageBox.Show(@"Bağlantı yoxdur", @"Nəticə", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            return result;
        }
        public static DataTable GetSqlServerDataTable(SqlConnection sqlConnection, string sqlStatement)
        {
            DataTable dtTable = new DataTable();
            using (SqlDataAdapter sqlDataAdapterAdapter = new SqlDataAdapter(sqlStatement, sqlConnection))
            {
                sqlDataAdapterAdapter.Fill(dtTable);
            }
            return dtTable;
        }
        public static DataTable GetSqlServerDataTable(string connectionString, string sqlStatement)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            DataTable dtTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlStatement, sqlConnection);
            da.Fill(dtTable);
            return dtTable;
        }
        public static DataSet GetSqlServerDataset(string connectionString, string sqlStatement)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            DataSet dtTable = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlStatement, sqlConnection);
            da.Fill(dtTable);
            return dtTable;
        }
        public static bool ExecuteStatement(string conString, string sqlStatement)
         {
             bool result;
             try
             {
                  var conn = new SqlConnection(conString);
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sqlStatement;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                 result = true;
             }
             catch (Exception ex)
             {
                 XtraMessageBox.Show(ex.Message, @"Səhf!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 result = false;
             }

             return result;
         }
        public static bool ExecuteStatement(SqlConnection conn, string sqlStatement)
        {
            bool result;
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sqlStatement;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                result = true;
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "LOG.txt", true))
                {
                    sw.WriteLine(ex.Message);
                }
                result = false;
            }

            return result;
        }
        public static bool ExecuteStatement(string conString, SqlCommand command)
         {
            if (command == null) throw new ArgumentNullException(nameof(command));
            bool result;
             try
             {
                 var conn = new SqlConnection(conString);
                 command.Connection = conn;
                 conn.Open();command.ExecuteNonQuery();
                 conn.Close();
                 result = true;
             }
             catch (Exception ex)
             {
                 XtraMessageBox.Show(ex.Message, "Səhf!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 result = false;
             }

             return result;
         }
        public static string ExecuteScalar(string conString, string query)
        {
           
            string result;
            try
            {
                var conn = new SqlConnection(conString);
                var command = conn.CreateCommand();
                command.CommandText = query;
                conn.Open();
                result = command.ExecuteScalar().ToString();
                conn.Close();
                
            }
            catch
            {
               
                result = string.Empty;
            }

            return result;
        }
        public enum JoinType
        {
            /// <summary>
            /// Same as regular join. Inner join produces only the set of records that match in both Table A and Table B.
            /// </summary>
            Inner = 0,
            /// <summary>
            /// Same as Left Outer join. Left outer join produces a complete set of records from Table A, with the matching records (where available) in Table B. If there is no match, the right side will contain null.
            /// </summary>
            Left = 1
        }
        public static DataTable JoinTwoDataTablesOnOneColumn(DataTable dtblLeft, DataTable dtblRight, string colToJoinOn, JoinType joinType)
        {
            //Change column name to a temp name so the LINQ for getting row data will work properly.
            string strTempColName = colToJoinOn + "_2";
            if (dtblRight.Columns.Contains(colToJoinOn))
                dtblRight.Columns[colToJoinOn].ColumnName = strTempColName;

            //Get columns from dtblLeft
            DataTable dtblResult = dtblLeft.Clone();

            //Get columns from dtblRight
            var dt2Columns = dtblRight.Columns.OfType<DataColumn>().Select(dc => new DataColumn(dc.ColumnName, dc.DataType, dc.Expression, dc.ColumnMapping));

            //Get columns from dtblRight that are not in dtblLeft
            var dt2FinalColumns = from dc in dt2Columns.AsEnumerable()
                                  where !dtblResult.Columns.Contains(dc.ColumnName)
                                  select dc;

            //Add the rest of the columns to dtblResult
            dtblResult.Columns.AddRange(dt2FinalColumns.ToArray());

            //No reason to continue if the colToJoinOn does not exist in both DataTables.
            if (!dtblLeft.Columns.Contains(colToJoinOn) || (!dtblRight.Columns.Contains(colToJoinOn) && !dtblRight.Columns.Contains(strTempColName)))
            {
                if (!dtblResult.Columns.Contains(colToJoinOn))
                    dtblResult.Columns.Add(colToJoinOn);
                return dtblResult;
            }

            switch (joinType)
            {

                default:

                    #region Inner
                    //get row data
                    //To use the DataTable.AsEnumerable() extension method you need to add a reference to the System.Data.DataSetExtension assembly in your project. 
                    var rowDataLeftInner = from rowLeft in dtblLeft.AsEnumerable()
                                           join rowRight in dtblRight.AsEnumerable() on rowLeft[colToJoinOn] equals rowRight[strTempColName]
                                           select rowLeft.ItemArray.Concat(rowRight.ItemArray).ToArray();


                    //Add row data to dtblResult
                    foreach (object[] values in rowDataLeftInner)
                        dtblResult.Rows.Add(values);

                    #endregion
                    break;
                case JoinType.Left:
                    #region Left
                    var rowDataLeftOuter = from rowLeft in dtblLeft.AsEnumerable()
                                           join rowRight in dtblRight.AsEnumerable() on rowLeft[colToJoinOn] equals rowRight[strTempColName] into gj
                                           from subRight in gj.DefaultIfEmpty()
                                           select rowLeft.ItemArray.Concat((subRight == null) ? (dtblRight.NewRow().ItemArray) : subRight.ItemArray).ToArray();


                    //Add row data to dtblResult
                    foreach (object[] values in rowDataLeftOuter)
                        dtblResult.Rows.Add(values);

                    #endregion
                    break;
            }

            //Change column name back to original
            dtblRight.Columns[strTempColName].ColumnName = colToJoinOn;

            //Remove extra column from Result
            dtblResult.Columns.Remove(strTempColName);

            return dtblResult;
        }
        #endregion

        public static string GetWHouse()
        {
            return String.Format(@"SELECT DIVISNR AS DIVNR,NR AS WHOUSENR,NAME FROM L_CAPIWHOUSE WHERE FIRMNR={0}",
                Variables.FirmNr);
        }

        public static string GetCheckedComboboxValue(CheckedComboBoxEdit combo,bool isChechked)
        {
            string result = string.Empty;
            if (isChechked)
            {
                foreach (var items in combo.Properties.Items.GetCheckedValues())
                {
                    result += items.ToString() + ",";
                }
            }
            else{
                
                foreach (DataRow item in ((DataTable)combo.Properties.DataSource).Rows)
                {
                    result += item["NR"] + ",";
                }
            }
            return (result.Trim().Length > 0) ? result.Trim().Remove(result.Trim().Length - 1) : string.Empty;
        }
        public static string GetCheckedComboboxValue(CheckedComboBoxEdit combo, bool isChechked,char Seperator)
        {
            string result = string.Empty;
            if (isChechked)
            {
                foreach (var items in combo.Properties.Items.GetCheckedValues())
                {
                    result +=Seperator+items.ToString()+Seperator + ",";
                }
            }
            else
            {

                foreach (DataRow item in ((DataTable)combo.Properties.DataSource).Rows)
                {
                    result += item["NR"] + ",";
                }
            }
            return (result.Trim().Length > 0) ? result.Trim().Remove(result.Trim().Length - 1) : string.Empty;
        }

        public static void SetFirmDb()
        {
            var dt = GetSqlServerDataTable(Variables.ConnectionString, String.Format(@"SELECT DBNAME FROM L_CAPIFIRM WHERE NR={0}", Variables.FirmNr));
            if (dt.Rows.Count == 0) Variables.FirmDb = null;
            else
            {
                Variables.FirmDb = dt.Rows[0][0].ToString().Trim() + "..";
            }
        }

        public static string GetDivisions()
        {
            return $@"SELECT NR,NAME FROM L_CAPIDIV WHERE FIRMNR={Variables.FirmNr}";
        }

        public static void GridToExcel(GridView grid)
        {
            var sv = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "Excel | *.xlsx",
                Filter = @"Excel | *.xlsx"
            };
            if (sv.ShowDialog() != DialogResult.OK) return;
            if (sv.FileName == string.Empty)
            {
                MessageBox.Show(@"Ad boşdur");
                return;
            }
            grid.ExportToXlsx(sv.FileName);
        }

        #region fileTodb

        public static void DatabaseFilePut(string varFilePath)
        {
            byte[] file;
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            using (var varConnection = new SqlConnection(Variables.ConnectionString))
            using (var sqlWrite = new SqlCommand("INSERT INTO Raporty (RaportPlik) Values(@File)", varConnection))
            {
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                sqlWrite.ExecuteNonQuery();
            }
        }

        public static void DatabaseFileRead(string varId, string varPathToNewLocation)
        {
            using (var varConnection = new SqlConnection(Variables.ConnectionString))
            using (var sqlQuery = new SqlCommand(@"SELECT [RaportPlik] FROM [dbo].[Raporty] WHERE [RaportID] = @varID", varConnection))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varId);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                {
                    sqlQueryResult.Read();
                    var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                    sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                    using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                        fs.Write(blob, 0, blob.Length);
                }
            }
        }

        public static MemoryStream DatabaseFileRead(string varId)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (var varConnection = new SqlConnection(Variables.ConnectionString))
            using (var sqlQuery = new SqlCommand(@"SELECT [RaportPlik] FROM [dbo].[Raporty] WHERE [RaportID] = @varID", varConnection))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varId);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                {
                    sqlQueryResult.Read();
                    var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                    sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                    //using (var fs = new MemoryStream(memoryStream, FileMode.Create, FileAccess.Write)) {
                    memoryStream.Write(blob, 0, blob.Length);
                    //}
                }
            }
            return memoryStream;
        }

        public static int databaseFilePut(MemoryStream fileToPut)
        {
            int varID = 0;
            byte[] file = fileToPut.ToArray();
            const string preparedCommand = @"
                    INSERT INTO [dbo].[Raporty]
                               ([RaportPlik])
                         VALUES
                               (@File)
                        SELECT [RaportID] FROM [dbo].[Raporty]
            WHERE [RaportID] = SCOPE_IDENTITY()
                    ";
            using (var varConnection = new SqlConnection(Variables.ConnectionString))
            using (var sqlWrite = new SqlCommand(preparedCommand, varConnection))
            {
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;

                using (var sqlWriteQuery = sqlWrite.ExecuteReader())
                    while (sqlWriteQuery.Read())
                    {
                        varID = sqlWriteQuery["RaportID"] is int ? (int)sqlWriteQuery["RaportID"] : 0;
                    }
            }
            return varID;
        }
        #endregion

    }
}
