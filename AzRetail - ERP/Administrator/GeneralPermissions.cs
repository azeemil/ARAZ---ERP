using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Administrator
{
    public partial class GeneralPermissions : XtraForm
    {
        public GeneralPermissions()
        {
            InitializeComponent();
        }
        public int MasterId { get; set; }
        public int PermissionType { get; set; }
        private void Save_Click(object sender, EventArgs e)
        {
            var command = (PermissionType == 1)
                ? string.Format("UPDATE ERP_USERS SET ACTIV={1},LOBJECT={2},ISADMIN={3}  WHERE ID = {0}",
                    MasterId, userStatus.Checked ? 1 : 0, ApiUse.Checked ? 1 : 0, isAdmin.Checked ? 1 : 0)
                : string.Format("UPDATE ERP_GROUPS SET ACTIV={1},LOBJECT={2},ISADMIN={3}  WHERE ID = {0}",
                    MasterId, userStatus.Checked ? 1 : 0, ApiUse.Checked ? 1 : 0, isAdmin.Checked ? 1 : 0);
            Functions.ExecuteStatement(Variables.ConnectionString, command);
            DialogResult = DialogResult.OK;
        }

        private void GeneralPermissions_Load(object sender, EventArgs e)
        {

            var command = (PermissionType == 1)
                ? string.Format("SELECT * FROM ERP_USERS WHERE ID = {0} ;", MasterId)
                : string.Format("SELECT * FROM ERP_GROUPS WHERE ID = {0} ;", MasterId);
            var dt = Functions.GetSqlServerDataTable(Variables.ConnectionString, command);
            userStatus.Checked = bool.Parse(dt.Rows[0]["ACTIV"].ToString());
            ApiUse.Checked = bool.Parse(dt.Rows[0]["LOBJECT"].ToString());
            isAdmin.Checked = bool.Parse(dt.Rows[0]["ISADMIN"].ToString());
        }
    }
}