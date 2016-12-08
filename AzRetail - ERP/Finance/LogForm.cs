using System;
using DevExpress.XtraEditors;

namespace ERP.Finance
{
    public partial class LogForm : DevExpress.XtraEditors.XtraForm
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void docnoLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = ((ListBoxControl) sender);
           int r = a.SelectedIndex;

            docnoLst.SelectedIndex = r;
            type.SelectedIndex = r;
            clcard.SelectedIndex = r;
            total.SelectedIndex = r;
            errorstring.SelectedIndex = r;
           
        }
    }
}