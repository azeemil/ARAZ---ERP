using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ERP.General;

namespace ERP.Administrator
{
    public partial class NewUser : XtraForm
    {
        public NewUser()
        {
            InitializeComponent();
            gridControl1.DataSource = ActiveDirectory.GetAdUsers();
            gridControl1.Refresh();
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (view != null)
                {
                    string requested = view.GetRowCellDisplayText(e.RowHandle, view.Columns["AccountController"]);
                    if (requested != "Checked")
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;

                    }
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            if (gridView1.GetSelectedRows().Count() <= 0)
            {
                XtraMessageBox.Show("Seçim etməmisiniz!", "Diqqət",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!bool.Parse(gridView1.GetFocusedRowCellValue("AccountController").ToString()))
            {
                XtraMessageBox.Show("Yalnız aktiv statuslu istifadəçilər əlavə oluna bilər!", "Diqqət",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var UName = gridView1.GetFocusedRowCellValue("UserName").ToString().Trim();

            if (Functions.GetSqlServerDataTable(Variables.ConnectionString,
                string.Format("SELECT TOP 1 * FROM ERP_USERS WHERE LTRIM(RTRIM(USERNAME))='{0}'", UName)).Rows.Count > 0)
            {
                XtraMessageBox.Show("Istifadəçi artıq mövcuddur!", "Diqqət",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show(UName + " adlı istifadəçi əlavə olunacaq.\nDavam etmək istəyirsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var FName = gridView1.GetFocusedRowCellValue("FirstName");
            var LName = gridView1.GetFocusedRowCellValue("LastName");
            var DName = gridView1.GetFocusedRowCellValue("DisplayName");
            var Email = gridView1.GetFocusedRowCellValue("Email");
            string command = string.Format(
                @"
                 INSERT INTO ERP_USERS (USERNAME,DISPLAYNAME,FIRSTNAME,LASTNAME,EMAIL,ACTIV,ISADMIN,RECUSER,RECDATE,LOBJECT) VALUES 
                  ('{0}','{1}','{2}','{3}','{4}',0,0,{5},GETDATE(),0)

                ", UName, DName, FName, LName, Email, User.UserId);

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