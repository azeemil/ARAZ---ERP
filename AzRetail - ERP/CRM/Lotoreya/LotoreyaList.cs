using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.CRM.Lotoreya
{
    public partial class LotoreyaList : XtraForm
    {
        public LotoreyaList()
        {
            InitializeComponent();
        }

        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonNew_Click(object sender, EventArgs e)
        {
            Lotoreya l = new Lotoreya();
            if(l.ShowDialog()!=DialogResult.OK) return;
            RefreshTable();
        }

        private void LotoreyaList_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        public void RefreshTable()
        {
            SqlConnection conn = Lotoreya.ReturnConnection();

            var cmd = new SqlCommand(string.Format(@"Select * from ARAZERP..ERP_LOTOREYA where [STATUS]=1 {0}",
                User.IsAdmin ? string.Empty : $"And Upper(MODIFIEDBY)='{User.UserName.ToUpper()}'"), conn);


         
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControlList.DataSource = dt;
        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Functions.GridToExcel(gridView1);
        }
    }
}
