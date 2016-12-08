using System;
using System.Windows.Forms;

namespace ERP.General
{
    public partial class AcceptForm : Form
    {
        private readonly string _quetsion;
        public AcceptForm( string quetsion)
        {
            this._quetsion = quetsion;InitializeComponent();
        }

        private void AcceptForm_Load(object sender, EventArgs e)
        {
            label1.Text = _quetsion;
        }

        private void yes_Click(object sender, EventArgs e)
        {

        }

        private void no_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
