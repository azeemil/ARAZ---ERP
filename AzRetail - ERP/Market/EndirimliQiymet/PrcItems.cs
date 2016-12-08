using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Market.EndirimliQiymet
{
    public partial class PrcItems : XtraForm
    {
        public PrcItems(string officecode)
        {
            InitializeComponent();
            var query = string.Format(@"
             SELECT ITEM.LOGICALREF ITEMID,
            (SELECT TOP 1 BARCODE FROM {0}LG_{1}_UNITBARCODE BARCODE WHERE BARCODE.ITEMREF=ITEM2.LOGICALREF) BARCODE
            ,ITEM2.CODE,
            ITEM2.NAME,         
            BUYPRICE 
            FROM {0}LK_{1}_ITEMSDIVERTMST MST WITH (NOLOCK)
            INNER JOIN {0}LG_{1}_ITEMS ITEM ON ITEM.LOGICALREF=ITEMREF  AND NAME LIKE '%ENDIRIMLI%'
            INNER JOIN {0}LK_{1}_ITEMSDIVERTDTL DTL WITH (NOLOCK)ON DTL.MASTERREF=MST.LOGICALREF
            INNER JOIN {0}LG_{1}_ITEMS ITEM2 ON ITEM2.LOGICALREF=DTL.ITEMREF  
            INNER JOIN {0}LK_{1}_PRCLIST PRC ON PRC.STREF=ITEM2.LOGICALREF  AND OFFICECODE={2}
                                       ",Variables.FirmDb,Variables.FirmNr,officecode);
            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
        }

        private void OK_Click(object sender, System.EventArgs e)
        {
            if(view.SelectedRowsCount>0) DialogResult=DialogResult.OK;}
    }
}