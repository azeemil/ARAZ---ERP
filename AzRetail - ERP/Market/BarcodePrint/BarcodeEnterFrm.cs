using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Market.BarcodePrint
{
    public partial class BarcodeEnterFrm : XtraForm
    {
        public BarcodeEnterFrm()
        {
            InitializeComponent();
        }

        public ERP.Market.BarcodePrint.PriceEtiketPrint PrcEtiketPrint { get; set; }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var query = string.Format(@"
            SELECT ITEM.CODE,ITEM.NAME,BARCODE.BARCODE,UNIT.NAME UNITNAME,
            COALESCE(
            PRCUNIT.SELLPRICE,
            ACT.SELLPRICE,
            PRC.BUYPRICE
            ) PRICE
            FROM {0}LG_{1}_UNITBARCODE BARCODE WITH (NOLOCK)
            INNER JOIN {0}LG_{1}_UNITSETL UNIT WITH (NOLOCK) ON UNIT.LOGICALREF=BARCODE.UNITLINEREF 
            AND BARCODE.BARCODE='{4}'
            INNER JOIN {0}LG_{1}_ITEMS ITEM WITH (NOLOCK) ON BARCODE.ITEMREF=ITEM.LOGICALREF
            LEFT JOIN {0}LK_{1}_PRCLISTOTHPRC PRCUNIT  WITH (NOLOCK) ON PRCUNIT.ITEMREF=ITEM.LOGICALREF AND PRCUNIT.DIVNR={3} 
            AND PRCUNIT.UNITLINEREF=BARCODE.UNITLINEREF
            LEFT JOIN {0}LK_{1}_PRCLIST PRC WITH (NOLOCK) ON PRC.STREF=ITEM.LOGICALREF AND PRC.OFFICECODE={3}
            LEFT JOIN {0}LK_{1}_{2}_ACTIVATIONLINES ACT WITH (NOLOCK) ON ACT.STREF=ITEM.LOGICALREF AND ACT.OFFICECODE={3} 
            AND CAST(GETDATE() AS DATE)>=CAST(START_DATE AS DATE) AND CAST(GETDATE() AS DATE)<=CAST(FINISH_DATE AS DATE)
                                      ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod,BranchNoTxt.Text,
                BarcodeTxt.Text.Trim());
              DataTable dt = General.Functions.GetSqlServerDataTable(Variables.TigerConnection,query);
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Material tapılmadı!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            PrcEtiketPrint.AddRow(
                int.Parse(BranchNoTxt.Text),
                dt.Rows[0]["CODE"].ToString(),
                dt.Rows[0]["NAME"].ToString(), 
                dt.Rows[0]["BARCODE"].ToString(), 
                dt.Rows[0]["UNITNAME"].ToString(),
                float.Parse(dt.Rows[0]["PRICE"].ToString()),
                int.Parse(CountTxt.Text)
                );
            BarcodeTxt.Text = String.Empty;

        }

        private void BarcodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                SearchBtn.PerformClick();
        }
    }
}