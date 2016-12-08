using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP
{
    public partial class FirmList : XtraForm
    {
        public FirmList()
        {
            InitializeComponent();
            string query = @"
                           SELECT NR,NAME,TITLE FROM L_CAPIFIRM ;                           
                           ";
            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
               DialogResult = DialogResult.OK;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
                DialogResult = DialogResult.OK;
        }
    }
}