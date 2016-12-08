using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ERP.Designs;

namespace ERP.Market.MQ
{
    public partial class MaterialTransfer : XtraForm
    {


        public DataSet ds;
        public XtraReport Report;
        public MaterialTransfer()
        {
          InitializeComponent();
           
        }
        private void Sevk_Load(object sender, EventArgs e)
        {
                ds.Tables[0].TableName = "MASTER";
                ds.Tables[1].TableName = "DETAIL";
                MainGrid.DataSource = ds.Tables[1];
                MainGrid.Refresh();
                fisno.Text = ds.Tables["MASTER"].Rows[0]["FICHENO"].ToString();
                sourceindex_code.Text = ds.Tables["MASTER"].Rows[0]["SOURCEINDEX"].ToString();
                sourceindex.Text = ds.Tables["MASTER"].Rows[0]["SOURCEWHOUSENAME"].ToString();
                destindex_code.Text = ds.Tables["MASTER"].Rows[0]["DESTINDEX"].ToString();
                destindex.Text = ds.Tables["MASTER"].Rows[0]["DESTWHOUSENAME"].ToString();
                date.Text = ds.Tables["MASTER"].Rows[0]["DATE_"].ToString();
                total.Text = ds.Tables["MASTER"].Rows[0]["NETTOTAL"].ToString();
                tip.Text = ds.Tables["MASTER"].Rows[0]["TIP"].ToString();
                //_trcode = ds.Tables["MASTER"].Rows[0]["TRCODE"].ToString();
           
        }

        private void capIrsaliyye_Click(object sender, EventArgs e)
        {
            if (Report == null)
            {
                XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Report.DataSource = ds;
            var report = new Reporting(Report);
            report.Show();
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