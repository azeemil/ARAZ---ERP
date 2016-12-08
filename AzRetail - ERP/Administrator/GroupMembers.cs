using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Administrator
{
    public partial class GroupMembers : XtraForm
    {

        public string UserId;
        public GroupMembers()
        {
            InitializeComponent();
        }

        void RefreshData()
        {
            grid.DataSource = Functions.GetSqlServerDataTable(Variables.ConnectionString,
               "SELECT GR.* FROM ERP_GROUPS GR INNER JOIN ERP_GROUPMEMBERS MEMBER ON GR.ID=MEMBER.GROUPID AND USERID=" +
               UserId);
            }

        private void GroupMembers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Groups gr = new Groups();
            if (gr.ShowDialog() == DialogResult.OK)
            {
                var command = String.Format("IF NOT EXISTS (SELECT * FROM ERP_GROUPMEMBERS WHERE GROUPID={1} AND USERID={0})" +
                                            "INSERT INTO ERP_GROUPMEMBERS (GROUPID,USERID) VALUES ({1},{0})", UserId, gr.gridView1.GetFocusedRowCellValue("ID"));
                Functions.ExecuteStatement(Variables.ConnectionString, command);
                RefreshData();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show("Istifadəçi qrupdan cıxarılacaq.\nDavam etmək istəyirsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                var command = String.Format("DELETE FROM ERP_GROUPMEMBERS WHERE GROUPID={1} AND USERID={0}"
                                           , UserId,gridView1.GetFocusedRowCellValue("ID"));
                Functions.ExecuteStatement(Variables.ConnectionString, command);
                RefreshData();
            }
        }
    }
}