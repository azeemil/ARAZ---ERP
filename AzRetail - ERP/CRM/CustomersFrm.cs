using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.CRM
{
    public partial class CustomersFrm : XtraForm
    {
        public CustomersFrm()
        {
            InitializeComponent();
            BDayText.Value = DateTime.Now;
            CheckedChanged(null, null);
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
                TransferBtn.Enabled =
                  User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.4'").Any();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBtn.Enabled = false;
            progress.Show();
            Thread thread = new Thread(Search) {IsBackground = true};
            thread.Start();
           
        }

        private void Search(){
            
            string mainQuery = string.Format(@"
        SELECT CUSTOMER.LOGICALREF,CUSTOMER.NAME,CUSTOMER.SURNAME,IDENT.FATHERNAME,
        IDENT.BIRTHDATE,CARTNO,IDENT.TCNUMBER,
        (CASE IDENT.MARRIED WHEN '0' THEN 'Evli' WHEN '1' THEN 'Subay' ELSE '' END ) MARRIED,
        ADDRES.[ADDRESS],ADDRES.MOBILTEL,
         (CASE PERSONAL.SEX WHEN '0' THEN N'Kişi' WHEN '1' THEN N'Qadın' ELSE '' END) SEX,
         (CASE CUSTOMER.STATUS WHEN 0 THEN 'Aktiv' ELSE 'Passiv' END ) STATUS,PERSONAL.COMPANYDEF N'COMPANYDEF',CAST(ISNULL(P.Puan,0) AS INT) PUAN,PERSONAL.EMAIL
        FROM       {0}LK_{1}_CRMCART CART (NOLOCK)
        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF
        {2} {3} {4}
        LEFT JOIN  {0}LK_{1}_CRMIDENTITY IDENT (NOLOCK) ON IDENT.CARTREF=CUSTOMER.LOGICALREF {5} {6}
        LEFT JOIN  {0}LK_{1}_CRMADDRESS ADDRES (NOLOCK) ON ADDRES.CARTREF=CUSTOMER.LOGICALREF
        LEFT JOIN  {0}LK_{1}_CRMPERSONAL PERSONAL (NOLOCK) ON PERSONAL.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN inter_puan..INTERBONUS_PUAN P ON P.Cari_kod COLLATE DATABASE_DEFAULT=CARTNO
                                             ", Variables.FirmDb, Variables.FirmNr,
    (!CardNoChbx.Checked) ? "" : $" AND CART.CARTNO LIKE '{CardNoTxbx.Text}'",
    (!NameChbx.Checked) ? "" : $" AND CUSTOMER.NAME LIKE '{NameTxbx.Text}'",
    (!SNameChbx.Checked) ? "" : $" AND CUSTOMER.SURNAME LIKE '{SNameTxbx.Text}'",
    (!FNameChbx.Checked) ? "" : $" AND IDENT.FATHERNAME LIKE '{FNameTxbx.Text}'",
    (!BDayChbx.Checked) ? "" : $" AND CAST(IDENT.BIRTHDATE AS DATE)='{BDayText.Value.ToString("yyyy-MM-dd")}'"
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
                    dt.Columns["STATUS"].ReadOnly = false;
                    dt.Columns["SEX"].ReadOnly = false;
                    dt.Columns["MARRIED"].ReadOnly = false;
                    dt.Columns["PUAN"].ReadOnly = false;
                    Invoke(new Action(() =>
                    {
                        gridControl1.DataSource = dt;
                        SearchBtn.Enabled = true;
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
        private void CheckedChanged(object sender, EventArgs e)
        {
            CardNoTxbx.Enabled = CardNoChbx.Checked;
            NameTxbx.Enabled = NameChbx.Checked;
            SNameTxbx.Enabled = SNameChbx.Checked;
            FNameTxbx.Enabled = FNameChbx.Checked;
            BDayText.Enabled = BDayChbx.Checked;
           
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
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
        private void EditBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            
            if (row == null) return;
            #region
            CrmEditForm crmedit = new CrmEditForm(row)
            {
                Text = row["CARTNO"].ToString(),
                NameTxbx =
                {
                    Text = ToInvarianTitleCase(row["NAME"].ToString()),
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.2'").Any()
                },
                SNameTxbx =
                {
                    Text = ToInvarianTitleCase(row["SURNAME"].ToString()),
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.3'").Any()
                },
                FNameTxbx =
                {
                    Text = ToInvarianTitleCase(row["FATHERNAME"].ToString()),
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.4'").Any()
                },
                ContactTxbx =
                {
                    Text = row["MOBILTEL"].ToString(),
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.6'").Any()
                },
                DocumentNoTxbx =
                {
                    Text = row["TCNUMBER"].ToString(),
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.9'").Any()
                },
                AddressTxbx = {Text = row["ADDRESS"].ToString()},
                StatusChbx =
                {
                    Checked = row["STATUS"].ToString().Trim() == "Aktiv",
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.1'").Any()
                },
                BDayText =
                {
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.5'").Any()
                },
                SexRadio =
                {
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.7'").Any()
                },
                MaritialRadio =
                {
                    Enabled = User.IsAdmin ||
                              User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.1.8'").Any()
                },
                CrmMail = { Text = row["EMAIL"].ToString().Trim()},
                Position = {SelectedText = row["COMPANYDEF"].ToString()}
            };
            
            crmedit.Position.Properties.NullText = row["COMPANYDEF"].ToString();
           
            if (row["MOBILTEL"].ToString().Length > 3)
            {
                crmedit.ContactCode.Text = row["MOBILTEL"].ToString().Substring(0, 3);
                crmedit.ContactTxbx.Text = row["MOBILTEL"].ToString().Substring(3);
            }

            if (!string.IsNullOrEmpty(row["BIRTHDATE"].ToString().Trim()))
            {
                DateTime dt;
                DateTime.TryParse(row["BIRTHDATE"].ToString(), out dt);
                crmedit.BDayText.DateTime = dt;
            }

            if (row["MARRIED"].ToString().Trim() == "Evli")
                crmedit.MaritialRadio.SelectedIndex = 0;

            else if (row["MARRIED"].ToString().Trim() == "Subay")
                crmedit.MaritialRadio.SelectedIndex = 1;
          

            if (row["SEX"].ToString().Trim() == "Kişi")
                crmedit.SexRadio.SelectedIndex = 0;
            else if (row["SEX"].ToString().Trim() == "Qadın")
                crmedit.SexRadio.SelectedIndex =1;
#endregion
            if (crmedit.ShowDialog() == DialogResult.OK)
            {
                string updateQuery =$@"
           
BEGIN TRY
BEGIN TRANSACTION TR

UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMCUSTOMER SET NAME=N'{crmedit.NameTxbx.Text.Trim()}',
                                                        SURNAME=N'{crmedit.SNameTxbx.Text.Trim()}',
                                                        STATUS ={(crmedit.StatusChbx.Checked ? '0' : '1')},
                                                        CHANGEDATE=GETDATE()
                                                            WHERE LOGICALREF ={row["LOGICALREF"]} 
----CRMIDENTITY

IF EXISTS (SELECT * FROM {Variables.FirmDb}LK_{Variables.FirmNr}_CRMIDENTITY WHERE CARTREF ={row["LOGICALREF"]})

BEGIN 
UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMIDENTITY SET FATHERNAME=N'{crmedit.FNameTxbx.Text.Trim()}',
                                                            BIRTHDATE = '{crmedit.BDayText.DateTime.ToString("yyyy-MM-dd")}',
                                                            TCNUMBER = '{crmedit.DocumentNoTxbx.Text.Trim()}',
                                                            MARRIED = '{crmedit.MaritialRadio.SelectedIndex}'                                                                             
                                                            WHERE CARTREF ={row["LOGICALREF"]} 
END
ELSE
BEGIN
 
INSERT INTO {Variables.FirmDb}LK_{Variables.FirmNr}_CRMIDENTITY (CARTREF,FATHERNAME,BIRTHDATE,TCNUMBER,MARRIED) 
VALUES({row["LOGICALREF"]},N'{crmedit.FNameTxbx.Text.Trim()}','{crmedit.BDayText.DateTime.ToString("yyyy-MM-dd")}',
'{crmedit.DocumentNoTxbx.Text.Trim()}','{crmedit.MaritialRadio.SelectedIndex}')


END
----CRMIDENTITY

----CRMADDRESS
IF EXISTS (SELECT * FROM {Variables.FirmDb}LK_{Variables.FirmNr}_CRMADDRESS WHERE CARTREF ={row["LOGICALREF"]})
BEGIN 
UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMADDRESS SET [ADDRESS]=N'{crmedit.AddressTxbx.Text.Trim()}',
                                                        MOBILTEL='{crmedit.ContactCode.Text.Trim()+ crmedit.ContactTxbx.Text.Trim()}' 
                                                            WHERE CARTREF ={row["LOGICALREF"]}  
END
ELSE
BEGIN 
INSERT INTO {Variables.FirmDb}LK_{Variables.FirmNr}_CRMADDRESS(CARTREF,[ADDRESS],MOBILTEL) 
VALUES({row["LOGICALREF"]},N'{crmedit.AddressTxbx.Text.Trim()}','{crmedit.ContactCode.Text.Trim() + crmedit.ContactTxbx.Text.Trim()}')
END
----CRMADDRESS

----CRMPERSONAL

IF EXISTS (SELECT * FROM {Variables.FirmDb}LK_{Variables.FirmNr}_CRMPERSONAL WHERE CARTREF ={row["LOGICALREF"]})

BEGIN 
UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMPERSONAL SET SEX={crmedit.SexRadio.SelectedIndex},
                                                                COMPANYDEF=N'{crmedit.Position.Text}',
                                                                EMAIL = N'{crmedit.CrmMail.Text}'  
                                                            WHERE CARTREF ={row["LOGICALREF"]} 
END
ELSE
BEGIN 
INSERT INTO {Variables.FirmDb}LK_{Variables.FirmNr}_CRMPERSONAL(CARTREF,SEX,COMPANYDEF,EMAIL) 
VALUES({row["LOGICALREF"]},{crmedit.SexRadio.SelectedIndex},N'{crmedit.Position.Text}',N'{crmedit.CrmMail.Text}')
END


----CRMPERSONAL



INSERT INTO ARAZERP..ERP_CRMLOGS (USERID,CRMCARD,[TYPE],[DESCRIPTION])
        VALUES ({User.UserId},'{row["CARTNO"].ToString().Trim()}',0,N'{User.UserName}: Müştəri qeydiyyatı')
                            
                    
SELECT 1 AS RESULT

COMMIT TRANSACTION TR

END TRY

BEGIN CATCH
    ROLLBACK TRANSACTION TR
SELECT 0 AS RESULT
END CATCH
     

                            ";
                try
                {
                    var conn = new SqlConnection(Variables.TigerConnection);
                    string result;
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = updateQuery;
                        conn.Open();
                        result = cmd.ExecuteScalar().ToString();
                    }
                    conn.Close();

                    XtraMessageBox.Show(
                        result.Trim() == "1" ? "Məlumatlar yadda saxlanıldı!" : "Məlumatlar yadda saxlanılmadı!",
                        @"Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var foucesdRow  = gridView1.GetFocusedDataRow();
                    foucesdRow["NAME"] = crmedit.NameTxbx.Text.Trim();
                    foucesdRow["SURNAME"] = crmedit.SNameTxbx.Text.Trim();
                    foucesdRow["FATHERNAME"] = crmedit.FNameTxbx.Text.Trim();
                    foucesdRow["BIRTHDATE"] = crmedit.BDayText.DateTime.Date;
                    foucesdRow["MOBILTEL"] = crmedit.ContactCode.Text.Trim() + crmedit.ContactTxbx.Text.Trim();
                    foucesdRow["TCNUMBER"] = crmedit.DocumentNoTxbx.Text.Trim();
                    foucesdRow["ADDRESS"] = crmedit.AddressTxbx.Text.Trim();
                    foucesdRow["STATUS"] = (crmedit.StatusChbx.Checked ? "Aktiv" : "Passiv");
                    foucesdRow["SEX"] = crmedit.SexRadio.SelectedIndex==0 ? "Kişi" : "Qadın";
                    foucesdRow["MARRIED"] = crmedit.MaritialRadio.SelectedIndex==0 ? "Evli" : "Subay";
                    foucesdRow["COMPANYDEF"] = crmedit.Position.Text.Trim();
                    foucesdRow["EMAIL"] = crmedit.CrmMail.Text.Trim();
                    gridView1.UpdateCurrentRow();
                  



                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, @"Səhf!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
        }

        private void TransactionBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();

            if (row == null) return;
            CrmTransactions transactions = new CrmTransactions(row["CARTNO"].ToString().Trim());
            transactions.Text = @"Əməliyyatlar - " + row["CARTNO"].ToString().Trim();
            transactions.Name = "transactions_" + row["CARTNO"].ToString().Trim();
            Variables.MForm.OpenOrBringToFront(transactions);
            
        }

        private void BonusArtir_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;

            var btran = new BonusTransaction(row["CARTNO"].ToString().Trim(), true)
            {
                Text = row["CARTNO"].ToString().Trim() + @" - Bonus artırma"
            };
            btran.labelControl3.Text += $" {row["PUAN"].ToString().Trim()}";btran.Bonus = int.Parse(row["PUAN"].ToString().Trim());
            if (btran.ShowDialog() == DialogResult.OK)
            {
                var query = $@"
                        BEGIN TRY
                        BEGIN TRAN BONUSTRANSACTION
                           
                        IF EXISTS(SELECT * FROM inter_puan..INTERBONUS_PUAN WHERE Cari_Kod='{row["CARTNO"].ToString().Trim()}')
		                BEGIN 

                        UPDATE inter_puan..INTERBONUS_PUAN SET PUAN=PUAN+{btran.BonusAmount.Text.Trim()} WHERE Cari_Kod='{row["CARTNO"].ToString().Trim()}'
                       
                        END 
                        ELSE

		                BEGIN
 
		                INSERT INTO inter_puan..INTERBONUS_PUAN (Cari_Kod,Puan,ToplamTutar,DATECREATED) 
		                                       VALUES('{row["CARTNO"].ToString().Trim()}',{btran.BonusAmount.Text.Trim()},0,GETDATE())
		                END 



                        INSERT INTO inter_puan..INTERBONUS_PUANHAREKET
                              (Tarih,Belge_No,Belge_Tipi,Cari_Kod,Puan,ToplamTutar,Kasa_No,Offline,DATECREATED,Aciklama)
                        VALUES(GETDATE(),0,0,'{row["CARTNO"].ToString().Trim()}',{btran.BonusAmount.Text.Trim()},0,0,0,GETDATE(),
                       N'{User.UserName}:{btran.ExplanationTxt.Text.Trim()}')
                        DECLARE @ID INT;
                        SET @ID = (SELECT SCOPE_IDENTITY())
                        INSERT INTO ARAZERP..ERP_CRMLOGS(TRANID,TYPE,DESCRIPTION,EXPLANATION,CRMCARD,USERID)
               VALUES(@ID,1,N'{User.UserName}: Bonus atrırma (-{btran.BonusAmount.Text.Trim()})',N'{btran.ExplanationTxt.Text.Trim()}',
              '{row["CARTNO"].ToString().Trim()}',{User.UserId})
                        COMMIT TRAN BONUSTRANSACTION
                        END TRY
                        BEGIN CATCH
                        ROLLBACK TRAN BONUSTRANSACTION
                        END CATCH
                              ";
                try
                {
                    Functions.ExecuteStatement(Variables.ConnectionString, query);
                    row["PUAN"] = (btran.Bonus + int.Parse(btran.BonusAmount.Text.Trim()));
                    gridView1.UpdateCurrentRow();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, @"Səhf!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BonusAzalt_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;

            var btran = new BonusTransaction(row["CARTNO"].ToString().Trim(), false)
            {
                Text = row["CARTNO"].ToString().Trim() + @" - Bonus azaltma"
            };
            btran.labelControl3.Text += $" {row["PUAN"].ToString().Trim()}";
            btran.Bonus = int.Parse(row["PUAN"].ToString().Trim());
            if (btran.ShowDialog() == DialogResult.OK)
            {
                var query = $@"
                        BEGIN TRY
                        BEGIN TRAN BONUSTRANSACTION
                            IF EXISTS(SELECT * FROM inter_puan..INTERBONUS_PUAN WHERE Cari_Kod='{row["CARTNO"].ToString().Trim()}')
		                BEGIN 

                        UPDATE inter_puan..INTERBONUS_PUAN SET PUAN=PUAN-{btran.BonusAmount.Text.Trim()} WHERE Cari_Kod='{row["CARTNO"].ToString().Trim()}'
                       
                         END 
                        ELSE

		                BEGIN
 
		           INSERT INTO inter_puan..INTERBONUS_PUAN (Cari_Kod,Puan,ToplamTutar,DATECREATED) 
		                                       VALUES('{row["CARTNO"].ToString().Trim()}',-{btran.BonusAmount.Text.Trim()},0,GETDATE())
		                END 



                         INSERT INTO inter_puan..INTERBONUS_PUANHAREKET
                              (Tarih,Belge_No,Belge_Tipi,Cari_Kod,Puan,ToplamTutar,Kasa_No,Offline,DATECREATED,Aciklama)
                        VALUES(GETDATE(),0,0,'{row["CARTNO"].ToString().Trim()}',-{btran.BonusAmount.Text.Trim()},0,0,0,GETDATE(),
                       N'{User.UserName}:{btran.ExplanationTxt.Text.Trim()}')
                        DECLARE @ID INT;
                        SET @ID = (SELECT SCOPE_IDENTITY())
                        INSERT INTO ARAZERP..ERP_CRMLOGS(TRANID,TYPE,DESCRIPTION,EXPLANATION,CRMCARD,USERID)
               VALUES(@ID,2,N'{User.UserName}: Bonus azaltma(-{btran.BonusAmount.Text.Trim()})',N'{btran.ExplanationTxt.Text.Trim()}',
              '{row["CARTNO"].ToString().Trim()}',{User.UserId})
                        COMMIT TRAN BONUSTRANSACTION
                        END TRY
                        BEGIN CATCH
                        ROLLBACK TRAN BONUSTRANSACTION
                        END CATCH
                              ";

                try
                {
                    Functions.ExecuteStatement(Variables.ConnectionString, query);
                    row["PUAN"] = (btran.Bonus - int.Parse(btran.BonusAmount.Text.Trim()));
                    gridView1.UpdateCurrentRow();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, @"Səhf!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }}

        }

        private void TransferBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();

            if (row == null) return;
            var crmedit = new CrmCartTransfer
            {
                
                CartNo = 
                {
                    Text = row["CARTNO"].ToString()
                },
                NameTxbx =
                {
                    Text = ToInvarianTitleCase(row["NAME"].ToString())
                },
                SNameTxbx =
                {
                    Text = ToInvarianTitleCase(row["SURNAME"].ToString())
                },
                FNameTxbx =
                {
                    Text = ToInvarianTitleCase(row["FATHERNAME"].ToString())
                },
                ContactTxbx =
                {
                    Text = row["MOBILTEL"].ToString()
                },
                Position = { SelectedText = row["COMPANYDEF"].ToString() },
                AddressTxbx = {Text = row["ADDRESS"].ToString()},
                DocumentNoTxbx = { Text = row["TCNUMBER"].ToString()},
                LogicalrefFrom = {Text = row["LOGICALREF"].ToString().Trim()}};

            crmedit.Position.Properties.NullText = row["COMPANYDEF"].ToString();

            if (row["MOBILTEL"].ToString().Length > 3)
            {
                crmedit.ContactCode.Text = row["MOBILTEL"].ToString().Substring(0, 3);
                crmedit.ContactTxbx.Text = row["MOBILTEL"].ToString().Substring(3);
            }

            if (!string.IsNullOrEmpty(row["BIRTHDATE"].ToString().Trim()))
            {
                DateTime dt;
                DateTime.TryParse(row["BIRTHDATE"].ToString(), out dt);
                crmedit.BDayText.DateTime = dt;
            }

            if (row["MARRIED"].ToString().Trim() == "Evli")
                crmedit.MaritialRadio.SelectedIndex = 0;

            else if (row["MARRIED"].ToString().Trim() == "Subay")
                crmedit.MaritialRadio.SelectedIndex = 1;


            if (row["SEX"].ToString().Trim() == "Kişi")
                crmedit.SexRadio.SelectedIndex = 0;
            else if (row["SEX"].ToString().Trim() == "Qadın")
                crmedit.SexRadio.SelectedIndex = 1;
            crmedit.bonusTxt.Text = row["PUAN"].ToString().Trim();
            if(crmedit.ShowDialog()==DialogResult.OK)
                if (crmedit.SetStatus.Checked)
                {
                    row["STATUS"] = "Passiv";
                    row["PUAN"] = "0";
                    gridView1.UpdateCurrentRow();
                }

        }

        private void SendToExcelBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Functions.GridToExcel(gridView1);
        }
    }
}