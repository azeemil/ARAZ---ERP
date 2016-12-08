using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.Designs;

namespace ERP.Purchase
{
    public partial class PurchaseDetails : XtraForm
    {
        private readonly string _command1;
        private readonly string _conString;
        private readonly string _command2;
        public int Trcode;
      
        public PurchaseDetails(string conString, string command1, string command2)
        {
            _conString = conString;
            _command2 = command2;
            _command1 = command1;
            InitializeComponent();
        }

        private void Irsaliyye_Load(object sender, EventArgs e){
            //try
            //{
            //    var conn = new SqlConnection(_conString);
            //    var da1 = new SqlDataAdapter(_command1, conn);
            //    var da2 = new SqlDataAdapter(_command2, conn);
            //    ds.reportstfiche.Clear();
            //    ds.reporstline.Clear();
            //    da1.Fill(ds.reportstfiche);
            //    da2.Fill(ds.reporstline);

            //    //_stfich = ds.Tables["reportstfiche"];
            //    //_stline = ds.reporstline;
            //    gridIrsaliyye.Refresh();
            //    fisno.Text = ds.Tables["reportstfiche"].Rows[0]["FICHENO"].ToString().Trim();
            //    docno.Text = ds.Tables["reportstfiche"].Rows[0]["DOCODE"].ToString().Trim();
            //    sourceindex.Text = ds.Tables["reportstfiche"].Rows[0]["SOURCEINDEX"].ToString().Trim();
            //    name.Text = ds.Tables["reportstfiche"].Rows[0]["NAME"].ToString().Trim();
            //    tip.Text = ds.Tables["reportstfiche"].Rows[0]["TIP"].ToString().Trim();
            //    definition.Text = ds.Tables["reportstfiche"].Rows[0]["DEFINITION_"].ToString().Trim();
            //    code.Text = ds.Tables["reportstfiche"].Rows[0]["CODE"].ToString().Trim();
            //    total.Text = ds.Tables["reportstfiche"].Rows[0]["NETTOTAL"].ToString().Trim();
            //    date.Text = ds.Tables["reportstfiche"].Rows[0]["DATE_"].ToString().Trim();
            //    Trcode = int.Parse(ds.Tables["reportstfiche"].Rows[0]["TRCODE"].ToString().Trim());
            //} 
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.ToString());
            //}
        }

        private void capIrsaliyye_Click(object sender, EventArgs e)
        {
            Reporting report = new Reporting(_command1, _command2, _conString, Trcode.ToString());
                report.ShowDialog();
        }
    

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}