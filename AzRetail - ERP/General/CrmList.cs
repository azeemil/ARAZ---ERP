using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace ERP.General
{
    public partial class CrmList : XtraForm
    {
        public CrmList()
        {
            InitializeComponent();
            progress.Hide();
            SetPermissions();
        }

        private void SetPermissions()
        {
            if (!User.IsAdmin)
            {
                EditBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1'").Any();
                TransactionBtn.Enabled =
                    User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.2'").Any();
                Bonus.Enabled =
                    User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.3'").Any();
                BonusArtir.Enabled =
                   User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.3.1'").Any();
                BonusAzalt.Enabled =
                  User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.3.2'").Any();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            progress.Show();
            Thread thread = new Thread(Search);
            thread.Start();
            
        }

        private void Search(){
            
            string mainQuery = string.Format(@"
        SELECT CUSTOMER.LOGICALREF,CUSTOMER.NAME,CUSTOMER.SURNAME,IDENT.FATHERNAME,
        IDENT.BIRTHDATE,CARTNO,IDENT.TCNUMBER,
        (CASE IDENT.MARRIED WHEN '0' THEN 'Evli' WHEN '1' THEN 'Subay' ELSE '' END ) MARRIED,
        ADDRES.[ADDRESS],ADDRES.MOBILTEL,
         (CASE PERSONAL.SEX WHEN '0' THEN N'Kişi' WHEN '1' THEN N'Qadın' ELSE '' END) SEX,
         (CASE CUSTOMER.STATUS WHEN 0 THEN 'Aktiv' ELSE 'Passiv' END ) STATUS,PERSONAL.COMPANYDEF,CAST(ISNULL(P.Puan,0) AS INT) PUAN
        FROM       {0}LK_{1}_CRMCART CART (NOLOCK)
        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF        {2} 
        INNER JOIN  {0}LK_{1}_CRMIDENTITY IDENT (NOLOCK) ON IDENT.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN  {0}LK_{1}_CRMADDRESS ADDRES (NOLOCK) ON ADDRES.CARTREF=CUSTOMER.LOGICALREF
        LEFT JOIN  {0}LK_{1}_CRMPERSONAL PERSONAL (NOLOCK) ON PERSONAL.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN inter_puan..INTERBONUS_PUAN P ON P.Cari_kod COLLATE DATABASE_DEFAULT=CARTNO
                                             ", Variables.FirmDb, Variables.FirmNr,
              $" AND CART.CARTNO LIKE '{CardNoTxbx.Text}'"
    
                );

            try
            {
                using (var conn = new SqlConnection(Variables.TigerConnection))
                {
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    command.CommandText = mainQuery;
                    command.CommandTimeout = 0;
                    DataTable dt = new DataTable();
                    SqlDataReader da = command.ExecuteReader();
                    dt.Load(da);
                    Invoke(new Action(() =>
                    {
                        gridControl1.DataSource = dt;
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {

                    XtraMessageBox.Show($"{ex.Message}\n{ex}", "Xəta!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }));
            }
            finally
            {
                Invoke(new Action(() =>
                {
                    progress.Hide();
                }));
               
            }
        }
       

      
        public static string ToInvarianTitleCase(string self)
        {
            if (string.IsNullOrWhiteSpace(self))
            {
                return self;
            }

            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(self.ToLower());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();

            if (row == null) return;
            DialogResult=DialogResult.OK;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();

            if (row == null) return;
            DialogResult = DialogResult.OK;
        }
    }
}