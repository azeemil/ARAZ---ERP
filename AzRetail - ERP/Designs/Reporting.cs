using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace ERP.Designs
{
    public partial class Reporting : XtraForm
    {

    
    private string trcode, command1, command2,command3, conString;
        public XtraReport Report;
      
        public Reporting( string command1, string command2,string conString,string trcode)
        {
            InitializeComponent();
            this.command1 = command1;
            this.command2 = command2;
            this.conString = conString;
            this.trcode = trcode;
        }
        public Reporting(string command1, string command2, string conString, string trcode,string command3)
        {
            InitializeComponent();
            this.command1 = command1;
            this.command2 = command2;
            this.command3 = command3;
            this.conString = conString;
            this.trcode = trcode;
        }

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

            var conn = new SqlConnection(conString);
            var da1 = new SqlDataAdapter(command1, conn);
            var da2 = new SqlDataAdapter(command2, conn);
            var da3 = new SqlDataAdapter(command3, conn);

            switch (trcode)
            {
               

              

            
                   
                   
                
            }

            documentViewer1.Refresh();
            Refresh();

        }
    }
}