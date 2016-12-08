using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Administrator
{
    public partial class Users : XtraForm
    {


       
        public Users()
        {
            
            InitializeComponent();
            RefreshData();
        }

        private MainForm _main;
        public Users(MainForm main)
        {
            this._main = main;
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            grid.DataSource = Functions.GetSqlServerDataTable(Variables.ConnectionString, "SELECT * FROM ERP_USERS");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           NewUser newUser = new NewUser();
            if (newUser.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
                gridView1.SelectRow(gridView1.RowCount - 1);

            }

        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            
            FirmList firm = new FirmList();
            if(firm.ShowDialog()!=DialogResult.OK) return;
            
            Permissions per = new Permissions();
            per.FirmNr =Convert.ToInt16(firm.gridView1.GetFocusedRowCellValue("NR").ToString().Trim());
            per.Text = string.Format("{0} - {1} (Istifadəçi) - Firma - {2}", per.Text, gridView1.GetFocusedRowCellValue("USERNAME").ToString().Trim(), per.FirmNr);
            per.PermissionType = 1;
            per.MasterId = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString().Trim());
            if(per.ShowDialog()==DialogResult.OK)RefreshData();
        }

        private void grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            GeneralPermissions per = new GeneralPermissions();
            per.PermissionType = 1;
            per.MasterId = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID").ToString().Trim());
            if (per.ShowDialog() == DialogResult.OK)
                RefreshData();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditUserBtn.PerformClick();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            newUserBtn.PerformClick();
        }

        private void AddToGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                GroupMembers gr = new GroupMembers();
                gr.UserId = gridView1.GetFocusedRowCellValue("ID").ToString();
                gr.Text = gridView1.GetFocusedRowCellValue("USERNAME").ToString();
                gr.ShowDialog();
            }

        }
    }
}