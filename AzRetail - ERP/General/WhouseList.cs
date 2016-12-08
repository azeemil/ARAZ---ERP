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
    public partial class WhouseList : DevExpress.XtraEditors.XtraForm
    {
        public WhouseList()
        {
            InitializeComponent();
           gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                $@" SELECT DIV.NR BRANCH,DIV.NAME BRANCHNAME,WH.NR,WH.NAME FROM L_CAPIDIV DIV
                    INNER JOIN L_CAPIWHOUSE WH ON WH.DIVISNR = DIV.NR 
                    AND WH.FIRMNR = DIV.FIRMNR AND DIV.FIRMNR = { Variables.FirmNr}");
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult =DialogResult.OK;
        }
    }
}