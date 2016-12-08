using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.CRM
{
    public partial class CrmPosition : XtraForm
    {
        public CrmPosition()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            gridControl1.DataSource =
                General.Functions.GetSqlServerDataTable(connectionString: Variables.ConnectionString,
                    sqlStatement: "SELECT ID,NAME FROM ERP_CRMPOSITIONS");
        }


        private void NewBtn_Click(object sender, EventArgs e)
        {
            CrmPositionNewEdit crmPosition = new CrmPositionNewEdit();
            if (crmPosition.ShowDialog() == DialogResult.OK)
            {
                General.Functions.ExecuteStatement(Variables.ConnectionString,
                    $"INSERT INTO ERP_CRMPOSITIONS (NAME,CREATEDBY) VALUES (N'{crmPosition.NameTxt.Text}',{General.User.UserId}) ");
                RefreshGrid();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            CrmPositionNewEdit crmPosition = new CrmPositionNewEdit {NameTxt = {Text = row["NAME"].ToString()}};
            if (crmPosition.ShowDialog() == DialogResult.OK)
            {
                General.Functions.ExecuteStatement(Variables.ConnectionString,
                    $"UPDATE ERP_CRMPOSITIONS SET NAME=N'{crmPosition.NameTxt.Text}' WHERE ID = {row["ID"]} ");
                RefreshGrid();}
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            if (XtraMessageBox.Show("Silməyə əminsiz?", "Diqqət",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.Functions.ExecuteStatement(Variables.ConnectionString,
                    $"DELETE ERP_CRMPOSITIONS  WHERE ID = {row["ID"]} ");
                RefreshGrid();
            }
        }
    }
}