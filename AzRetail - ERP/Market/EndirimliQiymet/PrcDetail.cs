using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using ERP.General;
using DataTable = System.Data.DataTable;

namespace ERP.Market.EndirimliQiymet
{
    public partial class PrcDetail : XtraForm
    {
        public PrcDetail()
        {
            InitializeComponent();
            BranchLookUp.Properties.DataSource = User.Branch;
        }


        private readonly int _type;
        public string Id;
        public PrcDetail(int type)
        {
            _type = type;
            InitializeComponent();
            BranchLookUp.Properties.DataSource = User.Branch;

        }

        private void PrcDetail_Load(object sender, EventArgs e)
        {
            switch (_type)
            {
                case 0:
                    BranchLookUp.Text = BranchLookUp.Properties.NullText = Officecode;
                    gridControl1.EmbeddedNavigator.Buttons.Append.Enabled = false;
                    gridControl1.EmbeddedNavigator.Buttons.Remove.Enabled = false;
                    SaveBtn.Enabled = false;
                    foreach (GridColumn col in gridView1.Columns)
                        col.OptionsColumn.ReadOnly = true;
                    Read();
                    break;
                case 1: New();
                    break;
                case 2:
                    BranchLookUp.Text = BranchLookUp.Properties.NullText = Officecode;
                    Read();
                    break;
            }
        }

        public string Officecode;
        public void Read()
        {
           
            var query = string.Format(@"
                SELECT 
                LINES.ID,
                ITEM.LOGICALREF ITEMID,
                BARCODE.BARCODE,               
                ITEM2.NAME,
                LINES.AMOUNT, 
                LINES.APPROVEDAMOUNT,        
                BUYPRICE ,
                LINES.PRICE,
                LINES.APPROVEDPRICE,
                LINES.COMMENT, 
                ITEM2.CODE,
                LINES.CANCELLED
                FROM {0}LK_{1}_ITEMSDIVERTMST MST WITH (NOLOCK)
                INNER JOIN {0}LG_{1}_ITEMS ITEM WITH (NOLOCK) ON ITEM.LOGICALREF=ITEMREF
                INNER JOIN {0}LK_{1}_ITEMSDIVERTDTL DTL  WITH (NOLOCK)ON DTL.MASTERREF=MST.LOGICALREF
                INNER JOIN {0}LG_{1}_ITEMS ITEM2 WITH (NOLOCK) ON ITEM2.LOGICALREF=DTL.ITEMREF
                INNER JOIN ARAZERP..ERP_PRCCHANGELINES LINES WITH (NOLOCK) ON LINES.ITEMID=ITEM.LOGICALREF AND LINES.MASTERID={2}
                INNER JOIN ARAZERP..ERP_PRCCHANGE PRCCHANGE WITH (NOLOCK) ON PRCCHANGE.ID=LINES.MASTERID  
                INNER JOIN {0}LK_{1}_PRCLIST PRC WITH (NOLOCK) ON PRC.STREF=ITEM2.LOGICALREF  AND OFFICECODE=PRCCHANGE.BRANCH  
                LEFT JOIN  {0}LG_{1}_UNITBARCODE BARCODE WITH (NOLOCK) ON BARCODE.ITEMREF=DTL.ITEMREF AND BARCODE.LINENR=1
                                      ", Variables.FirmDb, Variables.FirmNr,Id);
            _dt = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
            gridControl1.DataSource = _dt;
        }
        DataTable _dt = new DataTable();
        public void New()
        {
            _dt.Columns.Add("ID", typeof (int));
            _dt.Columns.Add("ITEMID", typeof(int));
            _dt.Columns.Add("BARCODE", typeof(string));
            _dt.Columns.Add("NAME", typeof(string));
            _dt.Columns.Add("AMOUNT", typeof(float));
            _dt.Columns.Add("APPROVEDAMOUNT", typeof(double));
            _dt.Columns.Add("BUYPRICE", typeof(double));
            _dt.Columns.Add("PRICE", typeof(double));
            _dt.Columns.Add("APPROVEDPRICE", typeof(double));
            _dt.Columns.Add("COMMENT", typeof(string));
            _dt.Columns.Add("CODE", typeof(string));
            _dt.Columns.Add("CANCELLED", typeof(bool));
            gridControl1.DataSource = _dt;
        }

        void AddRow(DataRowView row)
        {
            var price = row.Row["BUYPRICE"];
            if (!_dt.Select($"ITEMID={row["ITEMID"]}").Any())
                _dt.Rows.Add(0, row.Row["ITEMID"], row.Row["BARCODE"], row.Row["NAME"], 0,0, price, price, price, string.Empty, row.Row["CODE"],false);
        }
        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e){
            #region Remove
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                var row = gridView1.GetFocusedDataRow();
                if (row == null)
                {
                    e.Handled = true;
                    return;
                }

                if (bool.Parse(row["CANCELLED"].ToString()))
                {
                    XtraMessageBox.Show("Material ləğv olunub!", "Xəta!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    e.Handled = true;
                    return;
                }

              
                if (XtraMessageBox.Show("Sətir silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            }
            #endregion

            #region Append

            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                if (BranchLookUp.Text.Trim().Length == 0)
                {

                    XtraMessageBox.Show("Filial Seçilməyib!", "Xəta!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    e.Handled = true;
                    return;
                }
                PrcItems list = new PrcItems(BranchLookUp.Text.Trim());

                if (list.ShowDialog() == DialogResult.OK)
                {

                    int[] selectedRows = list.view.GetSelectedRows();
                    foreach (var rowId in selectedRows)
                    {
                        AddRow((DataRowView) list.view.GetRow(rowId));
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BranchLookUp.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Filial Seçilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (gridView1.RowCount == 0)
            {
                 XtraMessageBox.Show("Material seçilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            switch (_type)
            {
                case 1: InsertNewDocument(); break;
                case 2:UpdateDocument(); break;
            }
           
        }
        private void InsertNewDocument()
        {

            if (BranchLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Filial Seçilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (XtraMessageBox.Show("Davam edirsiz?", "Diqqət",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            
            SqlTransaction transaction = null;
            try
            {

           
            var connection = new SqlConnection(Variables.ConnectionString);
            connection.Open();
            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "QIYMET DEYISIMI");
            var command = connection.CreateCommand();
            command.CommandTimeout = 0;
            command.Transaction = transaction;
            command.CommandText = "INSERT INTO ERP_PRCCHANGE (FIRMNR,BRANCH,CREATEDUSERID) VALUES (@FIRMNR,@BRANCH,@CREATEDUSERID) SELECT SCOPE_IDENTITY()";
                command.Parameters.AddWithValue("@FIRMNR", Variables.FirmNr);
                command.Parameters.AddWithValue("@BRANCH", BranchLookUp.Text.Trim());
                command.Parameters.AddWithValue("@CREATEDUSERID", User.UserId);

                var identity = command.ExecuteScalar();

            command.CommandText = "INSERT INTO ERP_PRCCHANGELINES (MASTERID,ITEMID,PRICE,APPROVEDPRICE,AMOUNT,APPROVEDAMOUNT) " +
                                  "VALUES (@MASTERID,@ITEMID,ROUND(@PRICE,2),ROUND(@APPROVEDPRICE,2),ROUND(@AMOUNT,2),ROUND(@APPROVEDAMOUNT,2))";
                for (var i = 0; i < gridView1.RowCount; i++)
                {
                   
                        var rowHandle = gridView1.GetVisibleRowHandle(i);
                        var row = gridView1.GetDataRow(rowHandle);
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@MASTERID", identity);
                        command.Parameters.AddWithValue("@ITEMID", row["ITEMID"]);
                        command.Parameters.AddWithValue("@PRICE", row["PRICE"]);
                        command.Parameters.AddWithValue("@APPROVEDPRICE",row["APPROVEDPRICE"]);
                        command.Parameters.AddWithValue("@AMOUNT", row["AMOUNT"]);
                        command.Parameters.AddWithValue("@APPROVEDAMOUNT", row["APPROVEDAMOUNT"]);
                        command.ExecuteNonQuery();
                  
                }

                transaction.Commit();
                Close();
            }
            catch (Exception exception)
            {
                transaction?.Rollback();
                XtraMessageBox.Show(exception.Message + "\n" + exception.ToString(), "Xəta!", MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }
        }
        private void UpdateDocument()
        {
            if (XtraMessageBox.Show("Davam edirsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            SqlTransaction transaction = null;
            try
            {


                var connection = new SqlConnection(Variables.ConnectionString);
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "QIYMET DEYISIMI");
                var command = connection.CreateCommand();
                command.CommandTimeout = 0;
                command.Transaction = transaction;
                command.CommandText = "UPDATE ERP_PRCCHANGE SET BRANCH = @BRANCH,MODIFIEDUSER=@MODIFIEDUSER,MODIFIEDDATE=GETDATE() WHERE ID=@ID ";
                command.Parameters.AddWithValue("@ID", Id);
                command.Parameters.AddWithValue("@BRANCH", BranchLookUp.Text.Trim());
                command.Parameters.AddWithValue("@MODIFIEDUSER", User.UserId);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter();
                
                adapter.InsertCommand = new SqlCommand("INSERT INTO ERP_PRCCHANGELINES (MASTERID,ITEMID,PRICE,APPROVEDPRICE,AMOUNT,APPROVEDAMOUNT) " +
                                          "VALUES (@MASTERID,@ITEMID,@PRICE,@APPROVEDPRICE,@AMOUNT,@APPROVEDAMOUNT)", connection,transaction);
                adapter.InsertCommand.Parameters.Add("@ITEMID", SqlDbType.Int, Int32.MaxValue, "ITEMID");
                adapter.InsertCommand.Parameters.Add("@PRICE", SqlDbType.Float, sizeof(float), "PRICE");
                adapter.InsertCommand.Parameters.Add("@APPROVEDPRICE", SqlDbType.Int, sizeof(float), "APPROVEDPRICE");
                adapter.InsertCommand.Parameters.Add("@AMOUNT", SqlDbType.Float, sizeof(float), "AMOUNT");
                adapter.InsertCommand.Parameters.Add("@APPROVEDAMOUNT", SqlDbType.Int, sizeof(float), "APPROVEDAMOUNT");
                adapter.InsertCommand.Parameters.AddWithValue("@MASTERID", Id);

                adapter.UpdateCommand = new SqlCommand(@"UPDATE ERP_PRCCHANGELINES SET
                                          ITEMID = @ITEMID, PRICE = @PRICE, APPROVEDPRICE = @APPROVEDPRICE, 
                                          AMOUNT = @AMOUNT, APPROVEDAMOUNT = @APPROVEDAMOUNT WHERE ID = @ID", connection, transaction);
                adapter.UpdateCommand.Parameters.Add("@ITEMID", SqlDbType.Int, Int32.MaxValue, "ITEMID");
                adapter.UpdateCommand.Parameters.Add("@PRICE", SqlDbType.Float,sizeof(float), "PRICE");
                adapter.UpdateCommand.Parameters.Add("@APPROVEDPRICE", SqlDbType.Int, sizeof(float), "APPROVEDPRICE");
                adapter.UpdateCommand.Parameters.Add("@AMOUNT", SqlDbType.Float, sizeof(float), "AMOUNT");
                adapter.UpdateCommand.Parameters.Add("@APPROVEDAMOUNT", SqlDbType.Int, sizeof(float), "APPROVEDAMOUNT");
                adapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, Int32.MaxValue, "ID");


                adapter.DeleteCommand = new SqlCommand("DELETE ERP_PRCCHANGELINES WHERE ID= @ID", connection, transaction);
                adapter.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int,Int32.MaxValue, "ID");

                adapter.Update(_dt);

                transaction.Commit();
                Close();
            }
            catch (Exception exception)
            {
                transaction?.Rollback();
                XtraMessageBox.Show(exception.Message +"\n" + exception.ToString(), "Xəta!", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e){
            if (e.Column == gridView1.Columns["PRICE"])
            {
                 if (bool.Parse(gridView1.GetDataRow(e.RowHandle)["CANCELLED"].ToString()))
                {
                    XtraMessageBox.Show("Material ləğv olunub!", "Xəta!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    gridView1.GetDataRow(e.RowHandle).CancelEdit();
                    return;
                }
                gridView1.GetDataRow(e.RowHandle)["APPROVEDPRICE"] = $"{e.Value:#####0.00}"; 
                return;
            }

            if (e.Column == gridView1.Columns["AMOUNT"])
            {
                if (bool.Parse(gridView1.GetDataRow(e.RowHandle)["CANCELLED"].ToString()))
                {
                    XtraMessageBox.Show("Material ləğv olunub!", "Xəta!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    gridView1.GetDataRow(e.RowHandle).CancelEdit();
                    return;
                }


                gridView1.GetDataRow(e.RowHandle)["APPROVEDAMOUNT"] = $"{e.Value:#####0.00}";
            }
        }

       
    }
}