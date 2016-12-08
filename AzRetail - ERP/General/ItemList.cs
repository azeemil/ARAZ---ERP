using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP.General
{
    public partial class ItemList : XtraForm
    {
        public ItemList()
        {
            InitializeComponent();
           
        }

        public int Type;
      
        private void SearchBtn_Click(object sender, System.EventArgs e)
        {
          
            string query;
            if (Type == 4)
            {
                var filtr = (CodeRd.Checked) ? $" CODE LIKE '%{filtrTxbx.Text.Trim()}%'" : $" DEFINITION_ LIKE '%{filtrTxbx.Text.Trim()}%'";
                query =
                    $@" SELECT LOGICALREF,'' BARCODE ,CODE,DEFINITION_ NAME,UNITSETREF FROM {Variables.FirmDb}LG_{Variables.FirmNr}_SRVCARD WHERE  CARDTYPE=1 AND
                   {filtr} ";
            }
            else if (Type == 9)
            {
                var filtr = (CodeRd.Checked) ? $" CODE LIKE '%{filtrTxbx.Text.Trim()}%'" : $" DEFINITION_ LIKE '%{filtrTxbx.Text.Trim()}%'";
                query =
                    $@" SELECT LOGICALREF,'' BARCODE ,CODE,DEFINITION_ NAME,UNITSETREF FROM {Variables.FirmDb}LG_{Variables.FirmNr}_SRVCARD WHERE  CARDTYPE=2 AND
                   {filtr} ";
            }
            else
            {
                var filtr = (CodeRd.Checked) ? $" CODE LIKE '%{filtrTxbx.Text.Trim()}%'" : $" NAME LIKE '%{filtrTxbx.Text.Trim()}%'";
                query = string.Format(@"
             SELECT ITEM.LOGICALREF ,
             (SELECT TOP 1 BARCODE FROM {0}LG_{1}_UNITBARCODE BARCODE WHERE BARCODE.ITEMREF=ITEM.LOGICALREF) BARCODE
            ,ITEM.CODE, ITEM.NAME,ITEM.UNITSETREF  FROM  {0}LG_{1}_ITEMS ITEM  WHERE {2}        
			 ", Variables.FirmDb, Variables.FirmNr,filtr);
               
            }
            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
        }

        private void view_DoubleClick(object sender, System.EventArgs e)
        {
            if (!view.GetFocusedDataRow().IsNull(0))
            {
                DialogResult=DialogResult.OK;
            }
        }
    }
}