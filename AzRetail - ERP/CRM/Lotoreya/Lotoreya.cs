using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.CRM.Lotoreya
{
    public partial class Lotoreya : XtraForm
    {
        
        public bool contr = false;


        public Lotoreya()
        {
            InitializeComponent();
            BranchLookUp.Properties.DataSource = General.User.Branch;
        }
                       
        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ReturnConnection())
            {
                if (BranchLookUp.Text.Trim().Length == 0)
                {
                    XtraMessageBox.Show("Filial seçilməyib!!!");
                    return;
                }                
                if (contr)
                {
                    Fill(textBoxCartNo.Text);
                    if (XtraMessageBox.Show(string.Format("{0} nömrəli karta {1} hədiyyə veriləcək. \n Davam edilsinmi?",
                        textBoxCartNo.Text, comboBoxPresent.SelectedItem.ToString()), "Təsdiq", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand(string.Format(
                        @"Update ARAZERP..ERP_LOTOREYA set CUSTOMERCARD='{0}',
                    MODIFIEDBY='{1}',MODDIFYDATE=GETDATE(),[STATUS]=1, BRANCH={2} where BILETNO='{3}' And NAME='{4}'",
                        textBoxCustCartNo.Text, User.UserName,BranchLookUp.Text, textBoxCartNo.Text, comboBoxPresent.SelectedItem.ToString()), con);
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            MessageBox.Show(string.Format("{0} nömrəli karta {1} hədiyyə verildi", textBoxCartNo.Text, comboBoxPresent.SelectedItem.ToString()));
                           DialogResult = DialogResult.OK;
                        }
                        else
                            MessageBox.Show("Xəta baş verdi!!!");
                    }
                }
                else
                    MessageBox.Show("Müştəri və lotoreya kart No. yoxlamamışsınız!!!");
            }


        }

        private void simpleButtonCheck_Click(object sender, EventArgs e)
        {
            Fill(textBoxCartNo.Text);
        }

        public void Fill(string cardno)
        {
            string s = Check(textBoxCustCartNo.Text, textBoxCartNo.Text);
            if (s == "1")
            {
                Clear();
                MessageBox.Show("Məlumatları daxil edin!!!");
            }
            else if (s == "4")
            {
                Clear();
                MessageBox.Show("Bu lotoreya kartı ilə hədiyyə artıq alınmışdır!!!");
            }
            else if (s == "2")
            {
                Clear();
                MessageBox.Show("Müştəri kart nömrəsi yanlışdır!!!");
            }
            else if (s == "3")
            {
                Clear();
                MessageBox.Show("Lotoreya kart nömrəsi yanlışdır!!!");
            }
            else
            {
                SqlConnection con = ReturnConnection();
                SqlCommand cmd = new SqlCommand(string.Format(@"
            Select * from ARAZERP..ERP_LOTOREYA where BILETNO='{0}'",
                            cardno), con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (!contr)
                        {
                            comboBoxPresent.Properties.Items.Add(dr["NAME"]);
                            comboBoxPresent.Text = dr["NAME"].ToString();
                        }
                    }
                    contr = true;
                }
            }

        }

        public string Check(string custcardno,string cardno)
        {
            if (textBoxCartNo.Text.Length != 0 && textBoxCustCartNo.Text.Length != 0)
            {
                using (SqlConnection con = ReturnConnection())
                {
                    SqlCommand cmd = new SqlCommand(String.Format(@"Select Count(CARTNO) From
        ARAZ2017..LK_103_CRMCART Where CartNo='{0}'", custcardno), con);
                    if ((int)cmd.ExecuteScalar() != 0)
                    {
                        SqlCommand cmd1 = new SqlCommand(string.Format(@"
            Select * from ARAZERP..ERP_LOTOREYA where BILETNO='{0}'",
                            cardno), con);
                        if (cmd1.ExecuteScalar() != null)
                        {
                            using (SqlDataReader dr = cmd1.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    if ((bool)dr["STATUS"])
                                    {
                                        return "4";    
                                    }
                                }
                            }
                        }
                        else
                        {
                            return "3";
                        }
                        return "0";
                    }
                    else
                    {
                        return "2";
                    }
                }
            }
            else
            {
                return "1";
            }
        }

        public static SqlConnection ReturnConnection()
        {
            SqlConnection con = new SqlConnection(string.Format(@"Data Source='LSTARAZ01.retail.local';
                Application Name='ARAZ ERP';
                Initial Catalog='ARAZERP';User ID='terminal';Password='texnologiya252'"));
            con.Open();
            return con;
        }

        public void Clear()
        {
            contr = false;
            comboBoxPresent.Properties.Items.Clear();
            comboBoxPresent.Text = string.Empty;
        }

        
    }
}
