using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ERP.Designs;

namespace ERP.Purchase
{
    public partial class OrderDetails : XtraForm
    {
      
        public DataSet ds;
        public XtraReport Report;
        public OrderDetails()
        {
            
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {


            gridIrsaliyye.DataSource = ds.Tables["DETAIL"];
            gridIrsaliyye.Refresh();
            fisno.Text = ds.Tables["MASTER"].Rows[0]["FICHENO"].ToString().Trim();
            docno.Text = ds.Tables["MASTER"].Rows[0]["DOCODE"].ToString().Trim();
            sourceindex.Text = ds.Tables["MASTER"].Rows[0]["SOURCEINDEX"].ToString().Trim();
            name.Text = ds.Tables["MASTER"].Rows[0]["NAME"].ToString().Trim();
            tip.Text = ds.Tables["MASTER"].Rows[0]["TIP"].ToString().Trim();
            definition.Text = ds.Tables["MASTER"].Rows[0]["DEFINITION_"].ToString().Trim();
            code.Text = ds.Tables["MASTER"].Rows[0]["CODE"].ToString().Trim();
            date.Text = ds.Tables["MASTER"].Rows[0]["DATE_"].ToString().Trim();
           
        }

        private void capIrsaliyye_Click(object sender, EventArgs e)
        {
           splashScreenManager1.ShowWaitForm();
            if (Report == null)
            {
                XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Report.DataSource = ds;
            var report = new Reporting(Report);
            report.Show();
            splashScreenManager1.CloseWaitForm();
        }
    }
}