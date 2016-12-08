using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ERP.Designs;

namespace ERP.Market.MQ
{
    public partial class Invoice : XtraForm
    {

        public DataSet ds;
        public XtraReport Report;
        public Invoice()
        {
           InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            try
            {
                ds.Tables[0].TableName = "MASTER";
                ds.Tables[1].TableName = "DETAIL";
                gridIrsaliyye.DataSource = ds.Tables[1];
                gridIrsaliyye.Refresh();
                fisno.Text = ds.Tables[0].Rows[0]["FICHENO"].ToString().Trim();
                docno.Text = ds.Tables[0].Rows[0]["DOCODE"].ToString().Trim();
                sourceindex.Text = ds.Tables[0].Rows[0]["SOURCEINDEX"].ToString().Trim();
                name.Text = ds.Tables[0].Rows[0]["NAME"].ToString().Trim();
                tip.Text = ds.Tables[0].Rows[0]["TIP"].ToString().Trim();
                definition.Text = ds.Tables[0].Rows[0]["DEFINITION_"].ToString().Trim();
                code.Text = ds.Tables[0].Rows[0]["CODE"].ToString().Trim();
                total.Text = ds.Tables[0].Rows[0]["NETTOTAL"].ToString().Trim();
                date.Text = ((DateTime)ds.Tables[0].Rows[0]["DATE_"]).ToString("dd.MM.yyyy");
              
            } 
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.ToString());
            }
        }

        private void capIrsaliyye_Click(object sender, EventArgs e)
        {
            if (Report==null)
            {
                XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Report.DataSource = ds;
            var report = new Reporting(Report);
            report.Show();
        }
    

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.Kind == IndicatorKind.Header)
            {
                e.Info.DisplayText = "№";
            }
            else if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}