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
    public partial class Units : DevExpress.XtraEditors.XtraForm
    {
        public Units()
        {
            InitializeComponent();
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if(list.SelectedIndex>=0)
                DialogResult=DialogResult.OK;
        }
    }
}