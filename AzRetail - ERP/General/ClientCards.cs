using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP.General
{
    public partial class ClientCards : XtraForm
    {
        public ClientCards()
        {
            InitializeComponent();
        }
        public ClientCards(string rtcode)
        {
            InitializeComponent();
            radioButton2.Checked = true;
            textBox1.Text = rtcode;
            if (textBox1.Text.Trim().Length > 0)
            {
                simpleButton1.PerformClick();
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var filtr = string.Empty;
            if (textBox1.Text.Trim().Length > 0)
            {
                filtr = string.Format(" WHERE {1} LIKE '%{0}%'", textBox1.Text.Trim(), (radioButton1.Checked) ? "DEFINITION_" : "CODE");
            }
            var query = string.Format(@"SELECT CODE,DEFINITION_ N'DEFINITION_' FROM {1}LG_{2}_CLCARD {0}", filtr, Variables.FirmDb, Variables.FirmNr);


            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            if (gridView1.SelectedRowsCount > 0)
                DialogResult = DialogResult.OK;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            simpleButton3.PerformClick();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter) simpleButton1.PerformClick();
        }
    }
}