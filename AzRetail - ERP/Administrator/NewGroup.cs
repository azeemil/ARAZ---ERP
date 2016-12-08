using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Administrator
{
    public partial class NewGroup : XtraForm
    {
        public NewGroup()
        {InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var UName = groupName.Text.Trim();

            if (UName.Length==0)
            {
                XtraMessageBox.Show("Qrup adı daxil edilməyib!", "Diqqət",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Functions.GetSqlServerDataTable(Variables.ConnectionString,
                string.Format("SELECT TOP 1 * FROM ERP_GROUPS WHERE LTRIM(RTRIM(GROUPNAME))='{0}'", UName)).Rows.Count > 0)
            {
                XtraMessageBox.Show("Qrup artıq mövcuddur!", "Diqqət",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show(UName + " adlı qrup əlavə olunacaq.\nDavam etmək istəyirsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

           
            string command = string.Format(
                @"
                 INSERT INTO ERP_GROUPS (GROUPNAME,ACTIV,ISADMIN,RECUSER,RECDATE,LOBJECT) VALUES 
                  (N'{0}',0,0,1,GETDATE(),0)", UName);

            try
            {
                Functions.ExecuteStatement(Variables.ConnectionString, command);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Xəta!",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}