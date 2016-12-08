using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP.General
{
    public partial class ProjAndCost : XtraForm
    {
        private readonly int _type;
        public ProjAndCost(int type)
        {
            _type = type;
            InitializeComponent();
            radioButton2.Checked = true;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(_type==0) SearchCostCentre();
            else if (_type == 1) SearchProject();
            else if (_type == 2) SearchTradingGroup();
        }

        void SearchCostCentre()
        {
            var filtr = string.Empty;

            if (textBox1.Text.Trim().Length > 0)
            {
                filtr = string.Format(" WHERE {1} LIKE '%{0}%'", textBox1.Text.Trim(), (radioButton1.Checked) ? "DEFINITION_" : "CODE");
            }
            var query = string.Format(@"SELECT CODE,DEFINITION_ N'DEFINITION_' FROM {1}LG_{2}_EMCENTER {0}", filtr, Variables.FirmDb, Variables.FirmNr);

            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
        }
        void SearchProject()
        {
            var filtr = string.Empty;

            if (textBox1.Text.Trim().Length > 0)
            {
                filtr = string.Format(" WHERE {1} LIKE '%{0}%'", textBox1.Text.Trim(), (radioButton1.Checked) ? "NAME" : "CODE");
            }
            var query = string.Format(@"SELECT CODE,NAME N'DEFINITION_' FROM {1}LG_{2}_PROJECT {0}", filtr, Variables.FirmDb, Variables.FirmNr);


            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
        }
        void SearchTradingGroup()
        {
            var filtr = string.Empty;

            if (textBox1.Text.Trim().Length > 0)
            {
                filtr = string.Format(" AND  {1} LIKE '%{0}%'", textBox1.Text.Trim(), (radioButton1.Checked) ? "GDEF" : "GCODE");
            }
            var query = $@"SELECT GCODE N'CODE',GDEF N'DEFINITION_' FROM L_TRADGRP WHERE ACTIVE=0 {filtr}";

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