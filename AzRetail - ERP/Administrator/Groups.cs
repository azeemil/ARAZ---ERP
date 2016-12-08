using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Administrator
{
    public partial class Groups : XtraForm
    {
        private MainForm mainForm;
        private bool _mode;
        public Groups(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            SelectBtn.Visible = false;
            RefreshData();
            _mode = true;
        }
        public Groups()
        {
           InitializeComponent();
           newGroupBtn.Visible = false;
           EditGroupBtn.Visible = false;
           RefreshData();
            _mode = false;
        }

        void RefreshData()
        {
            grid.DataSource = Functions.GetSqlServerDataTable(Variables.ConnectionString, "SELECT * FROM ERP_GROUPS");
        }
        private void newGroupBtn_Click(object sender, EventArgs e)
        {
            NewGroup grp = new NewGroup();
            if (grp.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void EditGroupBtn_Click(object sender, EventArgs e)
        {
            barButtonItem4_ItemClick(null, null);
        }
        private void grid_MouseDown(object sender, MouseEventArgs e)
        {
            if(_mode)
            if (e.Button == MouseButtons.Right)
            {
                contextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            GeneralPermissions per = new GeneralPermissions();
            per.PermissionType = 2;
            per.MasterId = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString().Trim());
            if(per.ShowDialog()==DialogResult.OK)
                RefreshData();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FirmList firm = new FirmList();
            if (firm.ShowDialog() != DialogResult.OK) return;

            Permissions per = new Permissions();
            per.FirmNr = Convert.ToInt16(firm.gridView1.GetFocusedRowCellValue("NR").ToString().Trim());
            per.Text = string.Format("{0} - {1} (Qrup) - Firma - {2}", per.Text, gridView1.GetFocusedRowCellValue("GROUPNAME").ToString().Trim(), per.FirmNr);
            per.PermissionType = 2;
            per.MasterId = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString().Trim());
            if (per.ShowDialog() == DialogResult.OK) RefreshData();
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            newGroupBtn.PerformClick();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
            {
                if (!bool.Parse(gridView1.GetFocusedRowCellValue("ACTIV").ToString()))
                {
                    XtraMessageBox.Show("Yalnız aktiv statuslu qruplar əlavə oluna bilər!", "Diqqət",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult = DialogResult.OK;

            }

        }

        private void UsersBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;

            if (!bool.Parse(row["ACTIV"].ToString()))
            {
                XtraMessageBox.Show("Qrup aktiv deyil!", "Diqqət", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            GroupUsers groupUsers = new GroupUsers {GroupId = (int) row["ID"]};
            groupUsers.RefreshGrid();
            groupUsers.ShowDialog();

        }
    }
}