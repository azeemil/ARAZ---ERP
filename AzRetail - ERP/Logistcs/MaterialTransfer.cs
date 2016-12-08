using System;
using System.Data;
using DevExpress.XtraReports.UI;

namespace ERP.Logistcs
{
    public partial class MaterialTransfer : DevExpress.XtraEditors.XtraForm
    {


        public DataSet ds;
        public XtraReport Report;
        private string _trcode ;
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
                _trcode = ds.Tables["MASTER"].Rows[0]["TRCODE"].ToString();
           
        }

        private void capIrsaliyye_Click(object sender, EventArgs e)
        {
           
        }
    }
}