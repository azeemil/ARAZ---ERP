using System;
using System.Windows.Forms;

namespace ERP.Market.BarcodePrint
{
    public partial class MobilePrintList : DevExpress.XtraEditors.XtraForm
    {
        public MobilePrintList()
        {
            InitializeComponent();
           
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if(gridView1.SelectedRowsCount>0)
                DialogResult=DialogResult.OK;
        }

        private void MobilePrintList_Load(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;}
    }
}