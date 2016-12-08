using System;
using System.Data;
using DevExpress.XtraReports.UI;

namespace ERP.Market.MQ
{

    public partial class MaterialTransact : DevExpress.XtraEditors.XtraForm
    {
        public DataSet ds;
        public XtraReport Report;

        public MaterialTransact()
        {
           InitializeComponent();
        }

        private void cap_Click(object sender, EventArgs e)
        {
          

        }

        private void OnLoad(object sender, EventArgs e)
        {
            ds.Tables[0].TableName = "MASTER";
            ds.Tables[1].TableName = "DETAIL";
            MainGrid.DataSource = ds.Tables[1];
            MainGrid.Refresh();
            fisno.Text = ds.Tables["MASTER"].Rows[0]["FICHENO"].ToString();
            sourceindex.Text = ds.Tables["MASTER"].Rows[0]["SOURCEINDEX"].ToString();
            name.Text = ds.Tables["MASTER"].Rows[0]["SOURCEWHOUSENAME"].ToString();
            date.Text = ds.Tables["MASTER"].Rows[0]["DATE_"].ToString();
            total.Text = ds.Tables["MASTER"].Rows[0]["NETTOTAL"].ToString();
            tip.Text = ds.Tables["MASTER"].Rows[0]["TIP"].ToString();
            
        }
    }
}