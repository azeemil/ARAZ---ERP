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
using DevExpress.XtraGrid.Views.Grid;
using ERP.General;

namespace ERP.Logistcs
{
    public partial class OrderList : DevExpress.XtraEditors.XtraForm
    {
    
        public OrderList()
        {
            InitializeComponent();
        }


        public string sourceIndex;
        public string sourceBranch;
      

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void OrderList_Load(object sender, EventArgs e)
        {
               string _query = string.Format(@"               
                    SELECT FIS.LOGICALREF,FIS.STATUS,CAST(FIS.DATE_ AS DATE) DATE_,                  
                    FIS.SOURCEBRANCH,DIV1.NAME DIVNAME1,FIS.SOURCEINDEX,WHOUSE1.NAME WHOUSENAME1,
                    FIS.DESTBRANCH,DIV2.NAME DIVNAME2,FIS.DESTINDEX,WHOUSE2.NAME WHOUSENAME2 
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND FIS.SOURCEBRANCH={3} AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND FIS.SOURCEINDEX={4} AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} 
                    WHERE FIS.FICHETYPE=1 AND LTRIM(RTRIM(FIS.EXPLANATION))='0' AND FIS.ORDERREF IS NULL
                        ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod,sourceBranch,sourceIndex);
            grid.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, _query);
        }

    }
}