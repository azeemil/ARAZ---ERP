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

namespace ERP.Market
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