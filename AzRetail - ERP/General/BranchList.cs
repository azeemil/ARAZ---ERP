using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP.General
{
    public partial class BranchList : DevExpress.XtraEditors.XtraForm
    {
        public BranchList()
        {
            InitializeComponent();
           gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                $"SELECT NR,NAME FROM L_CAPIDIV WHERE FIRMNR={Variables.FirmNr}");
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult =DialogResult.OK;
        }
    }
}