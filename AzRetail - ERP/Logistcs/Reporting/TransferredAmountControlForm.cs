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
using ERP.General;

namespace ERP.Logistcs.Reporting
{
    public partial class TransferredAmountControlForm : DevExpress.XtraEditors.XtraForm
    {
        public TransferredAmountControlForm()
        {
            InitializeComponent();
            BegDate.DateTime=DateTime.Today.AddDays(-1);
            EndDate.DateTime=DateTime.Today;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection, string.Format(@"
                        SELECT FIC.LOGICALREF,FIC.ORDERREF, FIC.DESTINDEX,FIC.SOURCEINDEX,LINE.TRANSFER_AMOUNT-LINE.TRANSFERED_AMOUNT AMOUNT,
                            ITEM.NAME,BARCODE.BARCODE,ITEM.CODE
                            FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIC WITH(NOLOCK)   
                            INNER JOIN {0}LK_{1}_{2}_PURCHORDERDISTLINE LINE WITH(NOLOCK) ON LINE.ORDERREF=FIC.LOGICALREF AND FIC.LOGICALREF!=FIC.ORDERREF
                            AND (CAST(FIC.DATE_ AS DATE) BETWEEN '{3}' AND '{4}')   
                            INNER JOIN {0}LG_{1}_ITEMS ITEM ON ITEM.LOGICALREF=LINE.ITEMREF 
                            INNER JOIN {0}LG_{1}_UNITBARCODE BARCODE ON BARCODE.ITEMREF=LINE.ITEMREF AND BARCODE.LINENR=1
                       ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, BegDate.DateTime.ToString("yyyy-MM-dd"),EndDate.DateTime.ToString("yyyy-MM-dd")));
            gridControl1.DataSource = dt;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Functions.GridToExcel(gridView1);
        }
    }
}