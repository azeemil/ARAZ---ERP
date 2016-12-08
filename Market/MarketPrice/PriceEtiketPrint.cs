using System.Data;


namespace ERP.MarketPrice
{

    public partial class PriceEtiketPrint : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _prcTable;
        public PriceEtiketPrint()
        {
            InitializeComponent();
            //BranchLookUp.Properties.DataSource = User.Branch;
            _prcTable =new DataTable("ItemList");
            _prcTable.Columns.Add("CODE",typeof(string));
            _prcTable.Columns.Add("NAME", typeof(string));
            _prcTable.Columns.Add("BARCODE", typeof(string));
            _prcTable.Columns.Add("UNIT", typeof(string));
            _prcTable.Columns.Add("PRICE", typeof(float));_prcTable.Columns.Add("COUNT", typeof(int));
        }
    }
}
