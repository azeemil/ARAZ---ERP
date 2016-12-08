using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace ERP.Designs
{
    public partial class Reporting : XtraForm
    {
        public XtraReport Report;
        public Reporting(DataSet dataSet,XtraReport report)
        {
            InitializeComponent();
            this.Report = report;
            this.Report.DataSource = dataSet;
        }
        public Reporting( XtraReport report)
        {
            InitializeComponent();
            this.Report = report;
        }
        public Reporting()
        {
            InitializeComponent();
        }
        private void Reporting_Load(object sender, EventArgs e)
        {

            if (Report != null)
            {
                Report.CreateDocument();
                documentViewer1.DocumentSource = Report;
                documentViewer1.Refresh();
                Refresh();
                return;
            }
          
        }
    }
}