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

namespace ERP.General
{
    public partial class SetAmount : DevExpress.XtraEditors.XtraForm
    {
        public SetAmount()
        {
            InitializeComponent();
        }

        private void amount_EditValueChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = (amount.Text.Length > 0);
        }
    }
}