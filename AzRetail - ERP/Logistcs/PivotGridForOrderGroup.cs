using System.Windows.Forms;

namespace ERP.Logistcs
{
    public partial class PivotGridForOrderGroup : DevExpress.XtraEditors.XtraForm
    {
        public PivotGridForOrderGroup()
        {
            InitializeComponent();
        }

        private void PrintBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          pivotGrid.ShowPrintPreview();
        }

        private void ExcelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sv = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "Excel | *.xlsx",
                Filter = @"Excel | *.xlsx"
            };
            if (sv.ShowDialog() != DialogResult.OK) return;
            if (sv.FileName == string.Empty)
            {
                MessageBox.Show(@"Ad boşdur");
                return;
            }
            pivotGrid.ExportToXlsx(sv.FileName);
        }

        private void pivotGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
                popupMenu1.ShowPopup(MousePosition);
        }

        private void DesignBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}