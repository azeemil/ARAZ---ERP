using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.CRM
{
    public partial class BonusTransaction : XtraForm
    {
        private readonly string _cardNo;
        private readonly bool _transaction;
        public int Bonus;
        public BonusTransaction(string cardNo,bool transaction)
        {
            _cardNo = cardNo;
            _transaction = transaction;
            InitializeComponent();
            SaveBtn.Enabled = (BonusAmount.Text.Length > 0);
            CartNo.Text = cardNo;
            GetCustomer();
        }

     
        private void BonusAmount_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public bool CheckForValidation()
        {
           
            int errorCount = 0;
            if (NameTxbx.Text.Trim().Length < 3)
            {
                alertControl1.Show(this, "Səhv", "Ad ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }
            if (SNameTxbx.Text.Trim().Length < 3)
            {
                alertControl1.Show(this, "Səhv", "Soyad ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }
            if (FNameTxbx.Text.Trim().Length < 3)
            {
                alertControl1.Show(this, "Səhv", "Ata adı ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }

            if (BDayText.Text.Length == 0)
            {
                alertControl1.Show(this, "Səhv", "Doğum tarixi daxil edilməyib!");
                errorCount++;
            }
            if ((DateTime.Now.Year - BDayText.DateTime.Year) < 16 || (DateTime.Now.Year - BDayText.DateTime.Year) > 80)
            {
                alertControl1.Show(this, "Səhv", "Doğum tarixi 16 - 80 yaş aralığında olmalıdır!");
                errorCount++;
            }

            if (MaritialRadio.SelectedIndex == -1)
            {
                alertControl1.Show(this, "Səhv", "Aile vəziyyəti seçilməyib!");
                errorCount++;
            }

            if (SexRadio.SelectedIndex == -1)
            {
                alertControl1.Show(this, "Səhv", "Cins seçilməyib!");
                errorCount++;
            }

            if (ContactCode.Text.Trim().Length < 3 || ContactTxbx.Text.Trim().Length < 7)
            {
                alertControl1.Show(this, "Səhv", "Əlaqə nömrəsi qeyd edilməyib!");
                errorCount++;
            }

            if (Position.Text.Trim().Length < 3 || ContactTxbx.Text.Trim().Length < 7)
            {
                alertControl1.Show(this, "Səhv", "Vəzifə qeyd edilməyib!");
                errorCount++;
            }
            if (errorCount > 0)
            {
                XtraMessageBox.Show("Bütün məlumatlar doldurulmalıdır!",
                    @"Səhv!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
           
            return true;
        }
        public string ToInvarianTitleCase(string self)
        {
            if (string.IsNullOrWhiteSpace(self))
            {
                return self;
            }

            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(self.ToLower());
        }
        public void GetCustomer()
        {
            string mainQuery = string.Format(@"
        SELECT CUSTOMER.LOGICALREF,CUSTOMER.NAME,CUSTOMER.SURNAME,IDENT.FATHERNAME,
        IDENT.BIRTHDATE,CARTNO,IDENT.TCNUMBER,
        (CASE IDENT.MARRIED WHEN '0' THEN 'Evli' WHEN '1' THEN 'Subay' ELSE '' END ) MARRIED,
        ADDRES.[ADDRESS],ADDRES.MOBILTEL,
         (CASE PERSONAL.SEX WHEN '0' THEN N'Kişi' WHEN '1' THEN N'Qadın' ELSE '' END) SEX,
         (CASE CUSTOMER.STATUS WHEN 0 THEN 'Aktiv' ELSE 'Passiv' END ) STATUS,PERSONAL.COMPANYDEF
        FROM       {0}LK_{1}_CRMCART CART (NOLOCK)
        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF  AND  CART.CARTNO='{2}'
        INNER JOIN  {0}LK_{1}_CRMIDENTITY IDENT (NOLOCK) ON IDENT.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN  {0}LK_{1}_CRMADDRESS ADDRES (NOLOCK) ON ADDRES.CARTREF=CUSTOMER.LOGICALREF
        LEFT JOIN  {0}LK_{1}_CRMPERSONAL PERSONAL (NOLOCK) ON PERSONAL.CARTREF=CUSTOMER.LOGICALREF        
                                             ", Variables.FirmDb, Variables.FirmNr, CartNo.Text);
            var customerTable = Functions.GetSqlServerDataTable(Variables.TigerConnection, mainQuery);

            if (customerTable.Rows.Count > 0)
            {
                DataRow row = customerTable.Rows[0];
                CartNo.Text = row["CARTNO"].ToString();
                NameTxbx.Text = ToInvarianTitleCase(row["NAME"].ToString());
                SNameTxbx.Text = ToInvarianTitleCase(row["SURNAME"].ToString());
                FNameTxbx.Text = ToInvarianTitleCase(row["FATHERNAME"].ToString());
                ContactTxbx.Text = row["MOBILTEL"].ToString();
                Position.SelectedText = row["COMPANYDEF"].ToString();
                Position.Properties.NullText = row["COMPANYDEF"].ToString();
                if (row["MOBILTEL"].ToString().Length > 3)
                {
                    ContactCode.Text = row["MOBILTEL"].ToString().Substring(0, 3);
                    ContactTxbx.Text = row["MOBILTEL"].ToString().Substring(3);
                }
                if (!string.IsNullOrEmpty(row["BIRTHDATE"].ToString().Trim()))
                {
                    DateTime dt; DateTime.TryParse(row["BIRTHDATE"].ToString(), out dt);
                    BDayText.DateTime = dt;
                }


                if (row["MARRIED"].ToString().Trim() == "Evli")
                    MaritialRadio.SelectedIndex = 0;

                else if (row["MARRIED"].ToString().Trim() == "Subay")
                    MaritialRadio.SelectedIndex = 1;


                if (row["SEX"].ToString().Trim() == "Kişi")
                    SexRadio.SelectedIndex = 0;
                else if (row["SEX"].ToString().Trim() == "Qadın")
                    SexRadio.SelectedIndex = 1;

                Logicalref.Text = row["LOGICALREF"].ToString();
            }
        }
        private void SaveBtn_Click(object sender, System.EventArgs e)
        {
            if(int.Parse(BonusAmount.Text)==0)
            {
                XtraMessageBox.Show("Bonus miqdarı daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }

            if(!_transaction&&int.Parse(BonusAmount.Text)>Bonus)
            {
                XtraMessageBox.Show("Daxil edilmiş miqdar hazıki miqdardan böyükdür!", "Xəta!", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }

            if (ExplanationTxt.Text.Length<5)
            {
                XtraMessageBox.Show("Açıqlama xanası minimum 5 simvoldan ibaret olmalıdır!", "Xəta!", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }
            if(CheckForValidation())
            DialogResult =DialogResult.OK;
            
        }

        private void BonusAmount_TextChanged(object sender, System.EventArgs e)
        {
            SaveBtn.Enabled = (BonusAmount.Text.Length > 0);
        }
    }
}