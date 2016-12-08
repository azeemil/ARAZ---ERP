using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.CRM
{
    public partial class CrmGiftItems : XtraForm
    {
        public CrmGiftItems()
        {
            InitializeComponent();
            var query = string.Format(@"
             SELECT ITEM.LOGICALREF ITEMID,
             (SELECT TOP 1 BARCODE FROM {0}LG_{1}_UNITBARCODE BARCODE WHERE BARCODE.ITEMREF=ITEM.LOGICALREF) BARCODE
            ,ITEM.CODE,
            ITEM.NAME, DTL.AMOUNT BONUS           
            FROM             {0}LG_{1}_ITEMS ITEM 
            INNER JOIN  {0}LK_{1}_ITEMSDIVERTDTL DTL ON ITEM.LOGICALREF=DTL.ITEMREF AND MASTERREF=39--AND ITEM.SPECODE2 LIKE 'HEDIYYE'
			ORDER BY ITEMID
                                       ", Variables.FirmDb,Variables.FirmNr);
            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
        }

        private void OK_Click(object sender, System.EventArgs e)
        {
            if(view.SelectedRowsCount>0) DialogResult=DialogResult.OK;
        }
    }
}