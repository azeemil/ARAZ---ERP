using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using ERP.General;


namespace ERP.Market
{
    public partial class MobileNumbers : XtraForm
    {

        private bool m = false;
        private string _logicalref;

        public MobileNumbers()
        {
            InitializeComponent();
        }



        private void MainMenu_Load(object sender, EventArgs e)
        {
            filial.Properties.DataSource = User.Branch;
            select();
        }


        private void select()
        {

            var dttable = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                $@"SELECT NUM.ID, LTRIM(RTRIM(CAST(NUM.BRANCH AS VARCHAR(5)) +' - '+CAP.NAME)) DIVREF,
                        NUM.OPERATOR,NUM.NUMBER,NUM.PURCHASEDATE,NUM.REFRESHDATE,NUM.ISACTIV,NUM.COMMENT 
                        FROM ARAZERP..ERP_DATACARTNUMBERS NUM
                        INNER JOIN L_CAPIDIV CAP ON CAP.NR=NUM.BRANCH AND CAP.FIRMNR={
                    Variables.FirmNr} AND NUM.FIRM={Variables.FirmNr}");
            grid.DataSource = dttable;
            grid.Refresh();
        }



        public void SelectGridRow()
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                DataRow row = gridView1.GetFocusedDataRow();
                CommentMemo.Text = row["COMMENT"].ToString();
                filial.Text = filial.Properties.NullText = row["DIVREF"].ToString().Split('-')[0].Trim();
                NumberEdit.Text = row["NUMBER"].ToString();
                OperatorCmbx.Text = row["OPERATOR"].ToString();
                RefreshDt.DateTime = (DateTime) row["REFRESHDATE"];
                PurchaseDateEdit.DateTime = (DateTime) row["PURCHASEDATE"];
                IsActiveChbx.Checked = (bool) row["ISACTIV"];
                _logicalref = row["ID"].ToString();

            }
        }

        private void grid_Click(object sender, EventArgs e)
        {
            SelectGridRow();
        }

        private void yeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select();
        }

        private void dəyişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show(@"Seçim yoxdur!");
                return;
            }
            SelectGridRow();
            m = false;
            grid.Enabled = false;
            gb1.Enabled = true;
        }

        private void əlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = true;
            NumberEdit.Text = string.Empty;
            filial.ItemIndex = 0;
            NumberEdit.Text = string.Empty;
            OperatorCmbx.SelectedIndex = 0;
            RefreshDt.DateTime = PurchaseDateEdit.DateTime = DateTime.Today;
            IsActiveChbx.Checked = true;
            grid.Enabled = false;
            gb1.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            grid.Enabled = true;
            gb1.Enabled = false;
            SelectGridRow();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((NumberEdit.Text.Length == 0))
            {
                XtraMessageBox.Show(@"Nömrə girilməyib!");
                return;
            }
            string query;
            SqlCommand command = new SqlCommand();
            if (m)
            {
                query = @" 
INSERT INTO ERP_DATACARTNUMBERS (FIRM,BRANCH,OPERATOR,NUMBER,PURCHASEDATE,REFRESHDATE,ISACTIV,COMMENT)	
VALUES (@FIRM,@BRANCH,@OPERATOR,@NUMBER,@PURCHASEDATE,@REFRESHDATE,@ISACTIV,@COMMENT)		
";
                command.CommandText = query;
                command.Parameters.AddWithValue("@FIRM", Variables.FirmNr);
                command.Parameters.AddWithValue("@BRANCH", filial.Text);
                command.Parameters.AddWithValue("@OPERATOR", OperatorCmbx.Text);
                command.Parameters.AddWithValue("@NUMBER", NumberEdit.Text);
                command.Parameters.AddWithValue("@PURCHASEDATE", PurchaseDateEdit.DateTime);
                command.Parameters.AddWithValue("@REFRESHDATE", RefreshDt.DateTime);
                command.Parameters.AddWithValue("@ISACTIV", IsActiveChbx.Checked);
                command.Parameters.AddWithValue("@COMMENT", CommentMemo.Text);
                if (Functions.ExecuteStatement(Variables.ConnectionString, command))
                    XtraMessageBox.Show("Yadda Saxlanıldı");
                grid.Enabled = true;
                gb1.Enabled = false;
                @select();
                SelectGridRow();
            }
            else
            {
                if (gridView1.SelectedRowsCount == 0) return;
                query = @"
UPDATE ERP_DATACARTNUMBERS
SET BRANCH=@BRANCH,OPERATOR=@OPERATOR,NUMBER=@NUMBER,PURCHASEDATE=@PURCHASEDATE,REFRESHDATE=@REFRESHDATE,ISACTIV=@ISACTIV,COMMENT=@COMMENT 
WHERE ID=@ID";
                command.CommandText = query;
                command.Parameters.AddWithValue("@ID", _logicalref);
                command.Parameters.AddWithValue("@BRANCH", filial.Text);
                command.Parameters.AddWithValue("@OPERATOR", OperatorCmbx.Text);
                command.Parameters.AddWithValue("@NUMBER", NumberEdit.Text);
                command.Parameters.AddWithValue("@PURCHASEDATE", PurchaseDateEdit.DateTime);
                command.Parameters.AddWithValue("@REFRESHDATE", RefreshDt.DateTime);
                command.Parameters.AddWithValue("@ISACTIV", IsActiveChbx.Checked);
                command.Parameters.AddWithValue("@COMMENT", CommentMemo.Text);
                if (Functions.ExecuteStatement(Variables.ConnectionString, command))
                    XtraMessageBox.Show("Yadda Saxlanıldı");

                grid.Enabled = true;
                gb1.Enabled = false;
                @select();
                SelectGridRow();

            }
        }

     

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Functions.GridToExcel(gridView1);
        }
    }
}
