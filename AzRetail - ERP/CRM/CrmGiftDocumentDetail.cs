using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using ERP.General;

namespace ERP.CRM
{
    public partial class CrmGiftDocumentDetail : XtraForm
    {
        public CrmGiftDocumentDetail()
        {
            InitializeComponent();
            BranchLookUp.Properties.DataSource = User.Branch;
        }
        private readonly int _type;
        public string Id;
        public string Officecode;
        public int DocType;
        public CrmGiftDocumentDetail(int type)
        {
            _type = type;
            InitializeComponent();
            BranchLookUp.Properties.DataSource = User.Branch;

        }

        public  string ToInvarianTitleCase(string self)
        {
            if (string.IsNullOrWhiteSpace(self))
            {
                return self;
            }

            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(self.ToLower());
        }

        public void GetCustomer()
        {
            string mainQuery = string.Format(@"
        SELECT CUSTOMER.LOGICALREF,CUSTOMER.NAME,CUSTOMER.SURNAME,IDENT.FATHERNAME,
        IDENT.BIRTHDATE,CARTNO,IDENT.TCNUMBER,
        (CASE IDENT.MARRIED WHEN '0' THEN 'Evli' WHEN '1' THEN 'Subay' ELSE '' END ) MARRIED,
        ADDRES.[ADDRESS],ADDRES.MOBILTEL,
         (CASE PERSONAL.SEX WHEN '0' THEN N'Kişi' WHEN '1' THEN N'Qadın' ELSE '' END) SEX,
         (CASE CUSTOMER.STATUS WHEN 0 THEN 'Aktiv' ELSE 'Passiv' END ) STATUS,PERSONAL.COMPANYDEF,CAST(ISNULL(P.Puan,0) AS INT) PUAN
        FROM       {0}LK_{1}_CRMCART CART (NOLOCK)
        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF  AND  CART.CARTNO='{2}'
        INNER JOIN  {0}LK_{1}_CRMIDENTITY IDENT (NOLOCK) ON IDENT.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN  {0}LK_{1}_CRMADDRESS ADDRES (NOLOCK) ON ADDRES.CARTREF=CUSTOMER.LOGICALREF
        LEFT JOIN  {0}LK_{1}_CRMPERSONAL PERSONAL (NOLOCK) ON PERSONAL.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN inter_puan..INTERBONUS_PUAN P ON P.Cari_kod COLLATE DATABASE_DEFAULT=CARTNO
                                             ", Variables.FirmDb, Variables.FirmNr, CartNo.Text);

            var customerTable = Functions.GetSqlServerDataTable(Variables.TigerConnection, mainQuery);
          
            if (customerTable.Rows.Count > 0)
            {
                DataRow row = customerTable.Rows[0];
                CartNo.Text = row["CARTNO"].ToString();
                NameTxbx.Text = ToInvarianTitleCase(row["NAME"].ToString());
                SNameTxbx.Text = ToInvarianTitleCase(row["SURNAME"].ToString());
                FNameTxbx.Text = ToInvarianTitleCase(row["FATHERNAME"].ToString());
                ContactTxbx.Text = row["MOBILTEL"].ToString();
                Position.SelectedText = row["COMPANYDEF"].ToString();
                Position.Properties.NullText = row["COMPANYDEF"].ToString();
                if (row["MOBILTEL"].ToString().Length > 3)
                {
                    ContactCode.Text = row["MOBILTEL"].ToString().Substring(0, 3);
                    ContactTxbx.Text = row["MOBILTEL"].ToString().Substring(3);
                }
                if (!string.IsNullOrEmpty(row["BIRTHDATE"].ToString().Trim()))
                {
                    DateTime dt; DateTime.TryParse(row["BIRTHDATE"].ToString(), out dt);
                    BDayText.DateTime = dt;
                }


                if (row["MARRIED"].ToString().Trim() == "Evli")
                    MaritialRadio.SelectedIndex = 0;

                else if (row["MARRIED"].ToString().Trim() == "Subay")
                    MaritialRadio.SelectedIndex = 1;


                if (row["SEX"].ToString().Trim() == "Kişi")
                    SexRadio.SelectedIndex = 0;
                else if (row["SEX"].ToString().Trim() == "Qadın")
                    SexRadio.SelectedIndex = 1;

                bonusTxt.Text = row["PUAN"].ToString().Trim();
                Logicalref.Text = row["LOGICALREF"].ToString();
            }
        }

        public bool CheckForValidation()
        {
           
            if (CartNo.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Müştəri Seçilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            int errorCount = 0;
            if (NameTxbx.Text.Trim().Length < 3)
            {
                alertControl1.Show(this, "Səhv", "Ad ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }
            if (SNameTxbx.Text.Trim().Length < 3)
            {
                alertControl1.Show(this, "Səhv", "Soyad ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }
            if (FNameTxbx.Text.Trim().Length < 3)
            {
                alertControl1.Show(this, "Səhv", "Ata adı ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }

            if (BDayText.Text.Length == 0)
            {
                alertControl1.Show(this, "Səhv", "Doğum tarixi daxil edilməyib!");
                errorCount++;
            }
            if ((DateTime.Now.Year - BDayText.DateTime.Year) < 16 || (DateTime.Now.Year - BDayText.DateTime.Year) > 80)
            {
                alertControl1.Show(this, "Səhv", "Doğum tarixi 16 - 80 yaş aralığında olmalıdır!");
                errorCount++;
            }

            if (MaritialRadio.SelectedIndex == -1)
            {
                alertControl1.Show(this, "Səhv", "Aile vəziyyəti seçilməyib!");
                errorCount++;
            }

            if (SexRadio.SelectedIndex == -1)
            {
                alertControl1.Show(this, "Səhv", "Cins seçilməyib!");
                errorCount++;
            }

            if (ContactCode.Text.Trim().Length < 3 || ContactTxbx.Text.Trim().Length < 7)
            {
                alertControl1.Show(this, "Səhv", "Əlaqə nömrəsi qeyd edilməyib!");
                errorCount++;
            }

            if (Position.Text.Trim().Length < 3 || ContactTxbx.Text.Trim().Length < 7)
            {
                alertControl1.Show(this, "Səhv", "Vəzifə qeyd edilməyib!");
                errorCount++;
            }
            if (errorCount > 0)
            {
                XtraMessageBox.Show("Hədiyyə verilməsi və ya qaytarılması üçün bütün məlumatlar doldurulmalıdır!",
                    @"Səhv!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            if (BranchLookUp.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Filial Seçilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (gridView1.RowCount == 0)
            {
                XtraMessageBox.Show("Hədiyyə seçilməyib!", "Xəta!", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return false;
            }
            if (DocType == 0)
            {
                #region Doctype0

                if (gridView1.Columns["TOTALBONUS"].Summary[0].SummaryValue.ToString().Trim().Length > 0)
                    if (int.Parse(bonusTxt.Text) < (int) gridView1.Columns["TOTALBONUS"].Summary[0].SummaryValue)
                    {
                        XtraMessageBox.Show("Hediyyə toplamı bonus miqdarından artıqdır!", "Xəta!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return false;
                    }
                    else if ((int) gridView1.Columns["TOTALBONUS"].Summary[0].SummaryValue == 0)
                    {
                        XtraMessageBox.Show("Hədiyyə seçilməyib!!", "Xəta!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return false;
                    }

                #endregion
            }
            else
            {
                #region Doctype1
                if ((int)gridView1.Columns["TOTALBONUS"].Summary[0].SummaryValue == 0)
                {
                    XtraMessageBox.Show("Hədiyyə seçilməyib!!", "Xəta!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return false;
                }
                var connection = new SqlConnection(Variables.ConnectionString);
                connection.Open();
                var command = connection.CreateCommand();
                    command.CommandTimeout = 0;
                    command.CommandText = $@"
                    DECLARE @AMOUNT INT,@CUSTOMERID INT;                  
                    SET @CUSTOMERID={Logicalref.Text}
                    SET @AMOUNT=(
                     ISNULL((SELECT SUM(AMOUNT) FROM ERP_CRM_GIFT GIFT 
                     INNER JOIN  ERP_CRM_GIFTLINES LINES ON GIFT.ID=LINES.MASTERID AND GIFT.TYPE=0 AND ITEMID=@ITEMID AND CUSTOMERID=@CUSTOMERID AND GIFT.APPROVED=1),0)-
                     ISNULL((SELECT SUM(AMOUNT) FROM ERP_CRM_GIFT GIFT 
                     INNER JOIN  ERP_CRM_GIFTLINES LINES ON GIFT.ID=LINES.MASTERID AND GIFT.TYPE=1 AND ITEMID=@ITEMID AND CUSTOMERID=@CUSTOMERID AND GIFT.APPROVED=1),0))
                    SELECT @AMOUNT
                   ";
                for (var i = 0; i < gridView1.RowCount; i++)
                {

                    var rowHandle = gridView1.GetVisibleRowHandle(i);
                    var row = gridView1.GetDataRow(rowHandle);
                    if ((int)row["AMOUNT"] == 0) continue;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ITEMID", row["ITEMID"]);
                    var amount = (int) command.ExecuteScalar();
                    if ((int) row["AMOUNT"] > amount)
                    {
                        if (amount < 0)
                        {
                            XtraMessageBox.Show("Bu hədiyyədən verilməyib!" + Environment.NewLine + row["NAME"], "Xəta!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            XtraMessageBox.Show("Verilmə miqdarı qaytarma miqdarından azdır!" + Environment.NewLine + row["NAME"], "Xəta!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                connection.Close();
                #endregion
            }
            return true;
        }
            
        private void Cartnobtnedit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var crmForm = new CrmList { CardNoTxbx = { Text = CartNo.Text } };
            if (crmForm.ShowDialog() == DialogResult.OK)
            {
                var row = crmForm.gridView1.GetFocusedDataRow();

                if (!row["STATUS"].ToString().Trim().Equals("Aktiv"))
                {
                    XtraMessageBox.Show("Passiv kart seçilib!", @"Səhv!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                CartNo.Text = row["CARTNO"].ToString();
                NameTxbx.Text = ToInvarianTitleCase(row["NAME"].ToString());
                SNameTxbx.Text = ToInvarianTitleCase(row["SURNAME"].ToString());
                FNameTxbx.Text = ToInvarianTitleCase(row["FATHERNAME"].ToString());
                ContactTxbx.Text = row["MOBILTEL"].ToString();
                Position.SelectedText = row["COMPANYDEF"].ToString();
                Position.Properties.NullText = row["COMPANYDEF"].ToString();
                if (row["MOBILTEL"].ToString().Length > 3)
                {
                    ContactCode.Text = row["MOBILTEL"].ToString().Substring(0, 3);
                    ContactTxbx.Text = row["MOBILTEL"].ToString().Substring(3);
                }
                if (!string.IsNullOrEmpty(row["BIRTHDATE"].ToString().Trim()))
                {
                    DateTime dt; DateTime.TryParse(row["BIRTHDATE"].ToString(), out dt);
                    BDayText.DateTime = dt;
                }


                if (row["MARRIED"].ToString().Trim() == "Evli")
                    MaritialRadio.SelectedIndex = 0;

                else if (row["MARRIED"].ToString().Trim() == "Subay")
                    MaritialRadio.SelectedIndex = 1;


                if (row["SEX"].ToString().Trim() == "Kişi")
                    SexRadio.SelectedIndex = 0;
                else if (row["SEX"].ToString().Trim() == "Qadın")
                    SexRadio.SelectedIndex = 1;

                bonusTxt.Text = row["PUAN"].ToString().Trim();
                Logicalref.Text = row["LOGICALREF"].ToString();

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(CheckForValidation())
            switch (_type)
            {
                case 1:
                        if (XtraMessageBox.Show("Davam edirsiz?", "Diqqət",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                        if (InsertNewDocument()) DialogResult = DialogResult.OK;  break;
                case 2:
                        if (XtraMessageBox.Show("Davam edirsiz?", "Diqqət",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            return; if(UpdateDocument()) DialogResult = DialogResult.OK; break;
            }

        }
        private bool InsertNewDocument()
        {
            
            SqlTransaction transaction = null;
            try
            {

                var connection = new SqlConnection(Variables.ConnectionString);
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "HEDIYYE VERILMESI");
                var command = connection.CreateCommand();
                command.CommandTimeout = 0;
                command.Transaction = transaction;
                command.CommandText = "INSERT INTO ERP_CRM_GIFT (FIRM,BRANCH,CREATEDUSER,[TYPE],CUSTOMERID,CUSTOMERCARDNO) " +
                                      "VALUES (@FIRMNR,@BRANCH,@CREATEDUSERID,@TYPE,@CUSTOMERID,@CUSTOMERCARDNO) SELECT SCOPE_IDENTITY()";
                command.Parameters.AddWithValue("@FIRMNR", Variables.FirmNr);
                command.Parameters.AddWithValue("@BRANCH", BranchLookUp.Text.Trim());
                command.Parameters.AddWithValue("@CREATEDUSERID", User.UserId);
                command.Parameters.AddWithValue("@TYPE", DocType);
                command.Parameters.AddWithValue("@CUSTOMERID", Logicalref.Text);
                command.Parameters.AddWithValue("@CUSTOMERCARDNO", CartNo.Text);
                var identity = command.ExecuteScalar();
                Id =  identity.ToString();
                command.CommandText = "INSERT INTO ERP_CRM_GIFTLINES (MASTERID,ITEMID,AMOUNT,BONUS,TOTALBONUS) " +
                                      "VALUES (@MASTERID,@ITEMID,@AMOUNT,@BONUS,@TOTALBONUS)";
                for (var i = 0; i < gridView1.RowCount; i++)
                {

                    var rowHandle = gridView1.GetVisibleRowHandle(i);
                    var row = gridView1.GetDataRow(rowHandle);
                    if((int)row["AMOUNT"]==0) continue;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@MASTERID", identity);
                    command.Parameters.AddWithValue("@ITEMID", row["ITEMID"]);
                    command.Parameters.AddWithValue("@AMOUNT", row["AMOUNT"]);
                    command.Parameters.AddWithValue("@BONUS", row["BONUS"]);
                    command.Parameters.AddWithValue("@TOTALBONUS", row["TOTALBONUS"]);
                    command.ExecuteNonQuery();

                }

                transaction.Commit();
                return true;
            }
            catch (Exception exception)
            {
                transaction?.Rollback();
                XtraMessageBox.Show(exception.Message + "\n" + exception, "Xəta!", MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return false;
            }
           
        }
        private bool UpdateDocument()
        {
          
            SqlTransaction transaction = null;
            try
            {
                var connection = new SqlConnection(Variables.ConnectionString);
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "QIYMET DEYISIMI");
                var command = connection.CreateCommand();
                command.CommandTimeout = 0;
                command.Transaction = transaction;
                command.CommandText = "UPDATE ERP_CRM_GIFT SET BRANCH = @BRANCH,MODIFIEDUSER=@MODIFIEDUSER,CUSTOMERID=@CUSTOMERID, " +
                                      "CUSTOMERCARDNO=@CUSTOMERCARDNO WHERE ID=@ID";
                command.Parameters.AddWithValue("@ID", Id);
                command.Parameters.AddWithValue("@BRANCH", BranchLookUp.Text.Trim());
                command.Parameters.AddWithValue("@MODIFIEDUSER", User.UserId);
                command.Parameters.AddWithValue("@CUSTOMERID", Logicalref.Text);
                command.Parameters.AddWithValue("@CUSTOMERCARDNO", CartNo.Text);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand("INSERT INTO ERP_CRM_GIFTLINES (MASTERID,ITEMID,AMOUNT,BONUS,TOTALBONUS) " +
                                      "VALUES (@MASTERID,@ITEMID,@AMOUNT,@BONUS,@TOTALBONUS)", connection, transaction);
                adapter.InsertCommand.Parameters.AddWithValue("@MASTERID", Id);
                adapter.InsertCommand.Parameters.Add("@ITEMID", SqlDbType.Int, Int32.MaxValue, "ITEMID");
                adapter.InsertCommand.Parameters.Add("@AMOUNT", SqlDbType.Int, sizeof(int), "AMOUNT");
                adapter.InsertCommand.Parameters.Add("@BONUS", SqlDbType.Int, sizeof(int), "BONUS");
                adapter.InsertCommand.Parameters.Add("@TOTALBONUS", SqlDbType.Int, sizeof(int), "TOTALBONUS");
               
                

                adapter.UpdateCommand = new SqlCommand(@"UPDATE ERP_CRM_GIFTLINES SET
                                          ITEMID = @ITEMID, BONUS = @BONUS, TOTALBONUS = @TOTALBONUS, 
                                          AMOUNT = @AMOUNT  WHERE ID = @ID", connection, transaction);
                adapter.UpdateCommand.Parameters.Add("@ITEMID", SqlDbType.Int, Int32.MaxValue, "ITEMID");
                adapter.UpdateCommand.Parameters.Add("@AMOUNT", SqlDbType.Int, sizeof(int), "AMOUNT");
                adapter.UpdateCommand.Parameters.Add("@BONUS", SqlDbType.Int, sizeof(int), "BONUS");
                adapter.UpdateCommand.Parameters.Add("@TOTALBONUS", SqlDbType.Int, sizeof(int), "TOTALBONUS");
                adapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, Int32.MaxValue, "ID");


                adapter.DeleteCommand = new SqlCommand("DELETE ERP_CRM_GIFTLINES WHERE ID= @ID", connection, transaction);
                adapter.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, Int32.MaxValue, "ID");

                adapter.Update(_dt);
                transaction.Commit();
                return true;
            }
            catch (Exception exception)
            {
                transaction?.Rollback();
                XtraMessageBox.Show(exception.Message + "\n" + exception, "Xəta!", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return false;
            }
        }

      
        DataTable _dt = new DataTable();
        public void New()
        {
            _dt.Columns.Add("ID", typeof(int));
            _dt.Columns.Add("ITEMID", typeof(int));
            _dt.Columns.Add("BARCODE", typeof(string));
            _dt.Columns.Add("CODE", typeof(string));
            _dt.Columns.Add("NAME", typeof(string));
            _dt.Columns.Add("AMOUNT", typeof(int));
            _dt.Columns.Add("BONUS", typeof(int));
            _dt.Columns.Add("TOTALBONUS", typeof(int));
            gridControl1.DataSource = _dt;
        }
        public void Read()
        {

            var query = string.Format(@"
                 SELECT DTL.ID , ITEM.LOGICALREF ITEMID,
           (SELECT TOP 1 BARCODE FROM {0}LG_{1}_UNITBARCODE BARCODE WHERE BARCODE.ITEMREF=ITEM.LOGICALREF) BARCODE
            ,ITEM.CODE,
            ITEM.NAME, DTL.AMOUNT,DTL.BONUS,DTL.TOTALBONUS         
            FROM             {0}LG_{1}_ITEMS ITEM 
            INNER JOIN  ERP_CRM_GIFTLINES DTL ON ITEM.LOGICALREF=DTL.ITEMID AND DTL.MASTERID={2} 
			ORDER BY DTL.ID
                                      ", Variables.FirmDb, Variables.FirmNr, Id);
            _dt = Functions.GetSqlServerDataTable(Variables.ConnectionString, query);
            gridControl1.DataSource = _dt;
        }
        void AddRow(DataRowView row)
        {
            if (!_dt.Select($"ITEMID={row["ITEMID"]}").Any())
                _dt.Rows.Add(0, row.Row["ITEMID"], row.Row["BARCODE"], row.Row["CODE"], row.Row["NAME"], 1, row.Row["BONUS"], row.Row["BONUS"]);
        }
        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            #region Remove
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                var row = gridView1.GetFocusedDataRow();
                if (row == null)
                {
                    e.Handled = true;
                    return;
                }

                if (XtraMessageBox.Show("Sətir silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Handled = true;
                    return;
                }
            }
            #endregion

            #region Append

            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
               
                CrmGiftItems list = new CrmGiftItems();

                if (list.ShowDialog() == DialogResult.OK)
                {

                    int[] selectedRows = list.view.GetSelectedRows();
                    foreach (var rowId in selectedRows)
                    {
                        AddRow((DataRowView)list.view.GetRow(rowId));
                    }
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }

            }
            #endregion


        }

        private void OnLoad(object sender, EventArgs e)
        {
            switch (_type)
            {
                case 0:
                    BranchLookUp.Text = BranchLookUp.Properties.NullText = Officecode;
                    gridControl1.EmbeddedNavigator.Buttons.Append.Enabled = false;
                    gridControl1.EmbeddedNavigator.Buttons.Remove.Enabled = false;
                    SaveBtn.Enabled = false;
                    CartNo.Enabled = false;
                    foreach (GridColumn col in gridView1.Columns)
                        col.OptionsColumn.ReadOnly = true;
                    Read();
                    GetCustomer();
                    Approve.Enabled = false;
                    break;
                case 1:
                    New();
                    break;
                case 2:
                    BranchLookUp.Text = BranchLookUp.Properties.NullText = Officecode;
                    Read();
                    GetCustomer();
                    break;
                case 3:
                    BranchLookUp.Text = BranchLookUp.Properties.NullText = Officecode;
                    gridControl1.EmbeddedNavigator.Buttons.Append.Enabled = false;
                    gridControl1.EmbeddedNavigator.Buttons.Remove.Enabled = false;
                    SaveBtn.Enabled = false;
                    CartNo.Enabled = false;
                    foreach (GridColumn col in gridView1.Columns)
                        col.OptionsColumn.ReadOnly = true;
                    Read();
                    GetCustomer();
                    break;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gridView1.Columns["AMOUNT"])
            {
                DataRowView row = (DataRowView)gridView1.GetRow(e.RowHandle);
                if (string.IsNullOrEmpty(e.Value.ToString().Trim()))
                    row.Row["AMOUNT"] = 0;
                row.Row["TOTALBONUS"] = (int)row.Row["AMOUNT"]* (int)row.Row["BONUS"];
                gridView1.RefreshRow(e.RowHandle);
               
            }
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            if(!CheckForValidation()) return;
                if (XtraMessageBox.Show("Davam edirsiz?", "Diqqət",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            switch (_type)
            {
                case 1:
                    if (!InsertNewDocument()) return; break;
                case 2:
                    if (!UpdateDocument()) return; break;
            }

            SqlTransaction transaction = null;
            try
            {
                var connection = new SqlConnection(Variables.ConnectionString);
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "HEDIYYE VERILMESI");
                var command = connection.CreateCommand();
                command.CommandTimeout = 0;
                command.Transaction = transaction;
                command.CommandText = $@"UPDATE ERP_CRM_GIFT SET APPROVED=1 WHERE ID=@ID
                         UPDATE inter_puan..INTERBONUS_PUAN SET PUAN   {(DocType == 0 ? "-" : "+")}= @BONUS WHERE Cari_Kod='{CartNo.Text}' 
                                        ";
                command.Parameters.AddWithValue("@ID",Id);
                command.Parameters.AddWithValue("@BONUS", gridView1.Columns["TOTALBONUS"].Summary[0].SummaryValue);
                command.ExecuteNonQuery();
                command.CommandText = $@"                           
                    INSERT INTO inter_puan..INTERBONUS_PUANHAREKET(Tarih,Belge_No,Belge_Tipi,Cari_Kod,Puan,ToplamTutar,
                    Kasa_No,Offline,DATECREATED,Aciklama)
                    VALUES(GETDATE(),0,0,'{CartNo.Text.Trim()}',{(DocType == 0 ? " - " : " + ")}@BONUS,0,0,0,GETDATE(),@TYPE_DESC)   
                      
                 DECLARE @TRANID INT;
                     SET @TRANID = (SELECT SCOPE_IDENTITY())  
                 
                        UPDATE ERP_CRM_GIFTLINES SET INTERBONUSID = @TRANID,TYPE={DocType}
                        WHERE ID=@ID                     
 
                        INSERT INTO ERP_CRMLOGS(TRANID,TYPE,DESCRIPTION,EXPLANATION,CRMCARD,USERID,BRANCH)
                         VALUES(@TRANID,@DOCTYPE,@TYPE,@TYPE_DESC,'{CartNo.Text.Trim()}',{User.UserId},{BranchLookUp.Text.Trim()})

                       ";
                for (var i = 0; i < gridView1.RowCount; i++)
                {
                    var rowHandle = gridView1.GetVisibleRowHandle(i);
                    var row = gridView1.GetDataRow(rowHandle);
                    if ((int)row["AMOUNT"] == 0) continue;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ID", row["ID"]);
                    command.Parameters.AddWithValue("@BONUS", row["TOTALBONUS"]);
                    command.Parameters.AddWithValue("@TYPE", User.UserName+": Hediyye " + (DocType == 0 ? "verilme" : "qaytarma"));
                    command.Parameters.AddWithValue("@TYPE_DESC", row["CODE"] +"*"+ row["AMOUNT"] + " Hediyye " + (DocType == 0 ? "verilme" : "qaytarma")); 
                    command.Parameters.AddWithValue("@DOCTYPE", DocType == 0 ? 4 : 5);
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                transaction?.Rollback();
                XtraMessageBox.Show(exception.Message + "\n" + exception, "Xəta!", MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }

        }
    }
}