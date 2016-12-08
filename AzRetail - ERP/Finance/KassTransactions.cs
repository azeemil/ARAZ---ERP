using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using ERP.General;
using UnityObjects;
using User = ERP.General.User;

namespace ERP.Finance
{
    public partial class KassTransactions : XtraForm
    {
        public readonly UnityApplicationClass Application;
        private DataTable PropertyTable;
        private XDocument xml;
        public KassTransactions()
        {
            InitializeComponent();
            Application = Variables.UnityApplication;
            PropertyTable = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                $"SELECT * FROM ERP_PROPERTIES WHERE TYPE = 0 AND FIRMNR={Variables.FirmNr}");
            if (PropertyTable.Rows.Count > 0)
                xml = XDocument.Parse(PropertyTable.Rows[0]["PROPERITY"].ToString());

              
            
                begDate.DateTime = endDate.DateTime = DateTime.Today;
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
          officecodesCbx.DataSource = User.Branch;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount <= 0) return;
            ProcForm pf = new ProcForm(this);

            if (xml != null)
            {
                pf.satisKodeBtnEdt.Text = xml.Element("Property").Element("SatisKod").Value;
                pf.satisNameBtnEdt.Text = xml.Element("Property").Element("SatisAd").Value;
                pf.iadeKodeBtnEdt.Text = xml.Element("Property").Element("IadeKod").Value;
                pf.iadeNameBtnEdt.Text = xml.Element("Property").Element("IadeAd").Value;
                pf.kartigKodeBtnEdt.Text = xml.Element("Property").Element("KassaQaliqKod").Value;
                pf.kartigNameBtnEdt.Text = xml.Element("Property").Element("KassaQaliqAd").Value;
            }



            if (pf.ShowDialog() == DialogResult.OK)
            {
                var dr =gridView1.GetFocusedDataRow();
                gridView1.SetFocusedRowCellValue("STATUS",true);
                gridView1.SetFocusedRowCellValue("APPROVED", true);
                gridView1.RefreshData();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            officecodesCbx.CheckAll();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           officecodesCbx.UnCheckAll();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (officecodesCbx.CheckedItemsCount == 0)
            {
                XtraMessageBox.Show(@"İş yeri seçimi yoxdur!");
                return;
            }
             var officecodes = (from object item in officecodesCbx.CheckedItems select item as DataRowView)
                .Aggregate(string.Empty, (current, row) => current + ("," + row["NR"]));

            officecodes=officecodes.Remove(0, 1);

             var filtr =
                 $@" WHERE CAST(PAYMENT.DATE_ AS DATE)  BETWEEN CAST('{begDate.DateTime.Date.ToString("yyyy-MM-dd")}' AS DATE) 
                   AND CAST('{endDate.DateTime.Date.ToString("yyyy-MM-dd")}' AS DATE) AND
                                    PAYMENT.OFFICECODE IN ({officecodes})
                                        ";
            gridCotrol.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, string.Format(@"

                                SELECT  PAYMENT.LOGICALREF,CAST(PAYMENT.DATE_ AS DATE) DATE_,PAYMENT.OFFICECODE,
                                CAP.NAME,CASHIER.EXPLANATION,CASHIERCODE,CASHIER.CASHIERNAME N'CASHIERNAME',POSKS.KSCODE,PAYMENT.ZNO,
                                PAYMENT.ZREPORTTOTAL,RTFICHETOTAL ,PAYMENT.CARDTOTAL,PAYMENT.CUFFTOTAL, 
                                ROUND(DIFFTOTAL,2) FERQ,KSCARD.CODE BKOD,KSCARD.NAME BAD,PAYMENT.COMMENT EXPLAN_,
                                CAST(PAYMENT.APPROVED AS BIT) APPROVED,CAST(PAYMENT.STATUS AS BIT) STATUS
                                FROM {0}LK_{1}_{2}_CASHIERPAYMENT PAYMENT
                                INNER JOIN {0}LK_{1}_POSCASHIER CASHIER ON CASHIER.LOGICALREF=PAYMENT.CASHIERREF
                                INNER JOIN  L_CAPIDIV CAP ON CAP.NR=PAYMENT.OFFICECODE AND CAP.FIRMNR={1}
                                INNER JOIN  {0}LK_{1}_POSKS POSKS ON POSKS.LOGICALREF=PAYMENT.POSKSREF
                                INNER JOIN {0}LK_{1}_DIVDEFAULTS DIV ON DIV.OFFICECODE=CAP.NR
                                INNER JOIN {0}LG_{1}_KSCARD KSCARD ON KSCARD.LOGICALREF=DIV.KSCARDREF
                                {3}
                                

                    ", Variables.FirmDb, Variables.FirmNr,Variables.FirmPeriod,filtr));
        }

     

        private void NewBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Functions.GridToExcel(gridView1);
        }
    }
}
