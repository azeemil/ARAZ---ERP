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

namespace ERP.CRM
{
    public partial class CrmPositionNewEdit : DevExpress.XtraEditors.XtraForm
    {
        public CrmPositionNewEdit()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(NameTxt.Text.Trim().Length>0) DialogResult=DialogResult.OK;
        }
    }
}