using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.CRM
{
    public partial class CrmCartTransfer : XtraForm
    {
        public CrmCartTransfer()
        {
            InitializeComponent();
            SetPermissions();
        }

        public static string ToInvarianTitleCase(string self)
        {
            if (string.IsNullOrWhiteSpace(self))
            {
                return self;
            }

            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(self.ToLower());
        }
        private void Cartnobtnedit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var crmForm = new General.CrmList {CardNoTxbx = {Text = Cartnobtnedit.Text}};
            if (crmForm.ShowDialog() == DialogResult.OK)
            {
                var row = crmForm.gridView1.GetFocusedDataRow();

                if (row["CARTNO"].ToString().Trim() == CartNo.Text.Trim())
                {
                    XtraMessageBox.Show("Eyni kart nömrəsi seçilib!", @"Səhv!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Cartnobtnedit.Text = row["CARTNO"].ToString();
                NameTo.Text = ToInvarianTitleCase(row["NAME"].ToString());
                SNameTo.Text = ToInvarianTitleCase(row["SURNAME"].ToString());
                FNameTo.Text = ToInvarianTitleCase(row["FATHERNAME"].ToString());
                ContactTo.Text = row["MOBILTEL"].ToString();
                PositionTo.SelectedText = row["COMPANYDEF"].ToString();
                PositionTo.Properties.NullText = row["COMPANYDEF"].ToString();
                if (row["MOBILTEL"].ToString().Length > 3)
                {
                    ContactCodeTo.Text = row["MOBILTEL"].ToString().Substring(0, 3);
                    ContactTo.Text = row["MOBILTEL"].ToString().Substring(3);
                }
                if (!string.IsNullOrEmpty(row["BIRTHDATE"].ToString().Trim()))
                {
                    DateTime dt;DateTime.TryParse(row["BIRTHDATE"].ToString(), out dt);
                    BDayTo.DateTime = dt;
                }


                if (row["MARRIED"].ToString().Trim() == "Evli")
                    MaritialTo.SelectedIndex = 0;

                else if (row["MARRIED"].ToString().Trim() == "Subay")
                    MaritialTo.SelectedIndex = 1;


                if (row["SEX"].ToString().Trim() == "Kişi")
                    SexTo.SelectedIndex = 0;
                else if (row["SEX"].ToString().Trim() == "Qadın")
                    SexTo.SelectedIndex = 1;

                bonusToTxt.Text = row["PUAN"].ToString().Trim();
                Logicalref.Text = row["LOGICALREF"].ToString();

            }
            
        }
        private void SetPermissions()
        {
            if (!General.User.IsAdmin)
            {
                SaveBtn.Enabled = 
                    General.User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.4.1'").Any();
                SetStatus.Enabled =
                    General.User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.4.2'").Any();
                TransferAllData.Enabled =
                    General.User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1.4.3'").Any();
                

            }
        }

        public string Result;

        private void SaveBtn_Click(object sender, EventArgs e)
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

            NameTxbx.Text = ToInvarianTitleCase(NameTxbx.Text);
            SNameTxbx.Text = ToInvarianTitleCase(SNameTxbx.Text);
            FNameTxbx.Text = ToInvarianTitleCase(FNameTxbx.Text);
           string reasonText = ReasonMemo.Text + ":" + NameTo.Text + "-" + SNameTo.Text + "-" + FNameTo.Text;
            if (errorCount > 0)
            {
                XtraMessageBox.Show("Transfer olunacaq Kartda bütün məlumatlar doldurulmalıdır!",
                    @"Səhv!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var setStatusPassiv =
                $@" UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMCUSTOMER SET STATUS = 1
                                                                                 WHERE LOGICALREF ={
                    LogicalrefFrom.Text.Trim()} ";


            var cardTransfer =
                string.Format(
                    $@"
                      UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMCUSTOMER 
                        SET NAME=N'{NameTxbx.Text.Trim()}',
                            SURNAME=N'{SNameTxbx.Text.Trim()}'                           
                            WHERE LOGICALREF ={Logicalref.Text.Trim()} 


                     UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMIDENTITY 
                     SET FATHERNAME = N'{FNameTxbx.Text.Trim()}',
                        BIRTHDATE = '{BDayText.DateTime.ToString("yyyy-MM-dd")}',
                        TCNUMBER = '{DocumentNoTxbx.Text.Trim()}',
                        MARRIED = '{MaritialRadio.SelectedIndex}'
                        WHERE CARTREF = {Logicalref.Text.Trim()}

IF EXISTS (SELECT * FROM {Variables.FirmDb}LK_{Variables.FirmNr}_CRMADDRESS WHERE CARTREF ={Logicalref.Text.Trim()})
BEGIN 
UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMADDRESS SET [ADDRESS]=N'{AddressTxbx.Text.Trim()}',
                                                        MOBILTEL='{ContactCode.Text.Trim() + ContactTxbx.Text.Trim()}' 
                                                            WHERE CARTREF ={Logicalref.Text.Trim()}  
END
ELSE
BEGIN 
INSERT INTO {Variables.FirmDb}LK_{Variables.FirmNr}_CRMADDRESS(CARTREF,[ADDRESS],MOBILTEL) 
VALUES({Logicalref.Text.Trim()},N'{AddressTxbx.Text.Trim()}','{ContactCode.Text.Trim() + ContactTxbx.Text.Trim()}')
END
UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMPERSONAL SET SEX={SexRadio.SelectedIndex},
                                                                COMPANYDEF=N'{Position.Text}'   
                                                            WHERE CARTREF ={Logicalref.Text.Trim()} 

                     UPDATE  {Variables.FirmDb}LK_{Variables.FirmNr}_CRMPERSONAL 
                        SET SEX ={SexRadio.SelectedIndex},
                        COMPANYDEF = N'{Position.Text}'
                        WHERE CARTREF = {Logicalref.Text.Trim()}
                                             ");

            string query =
                string.Format(
                    $@"
                BEGIN TRY
                    BEGIN TRANSACTION CARDTRANSFER

	                -- Bonuslarin kocurulmesi

                        IF EXISTS(SELECT * FROM inter_puan..INTERBONUS_PUAN WHERE Cari_Kod='{Cartnobtnedit.Text}')
		                BEGIN 

		           UPDATE inter_puan..INTERBONUS_PUAN SET PUAN+={bonusTxt.Text} WHERE Cari_Kod='{Cartnobtnedit.Text}'

		                END 
                        ELSE

		                BEGIN
 
		           INSERT INTO inter_puan..INTERBONUS_PUAN (Cari_Kod,Puan,ToplamTutar,DATECREATED) 
		                                       VALUES('{Cartnobtnedit.Text}',{bonusTxt.Text},0,GETDATE())
		                END 


                    INSERT INTO inter_puan..INTERBONUS_PUANHAREKET(Tarih,Belge_No,Belge_Tipi,Cari_Kod,Puan,ToplamTutar,
                    Kasa_No,Offline,DATECREATED,Aciklama)
          VALUES(GETDATE(),0,0,'{Cartnobtnedit.Text.Trim()}',{bonusTxt.Text},0,0,0,GETDATE(),'{CartNo.Text} Kartdan transfer') 

                    -- Sifirlanma   
                    UPDATE inter_puan..INTERBONUS_PUAN SET PUAN=0 WHERE Cari_Kod='{CartNo.Text.Trim()}'

                    INSERT INTO inter_puan..INTERBONUS_PUANHAREKET(Tarih,Belge_No,Belge_Tipi,Cari_Kod,Puan,ToplamTutar,
                    Kasa_No,Offline,DATECREATED,Aciklama)
                    VALUES(GETDATE(),0,0,'{CartNo.Text.Trim()}'
                 ,-{bonusTxt.Text},0,0,0,GETDATE(),'{Cartnobtnedit.Text} Karta transfer')     

                   {(TransferAllData.Checked ? cardTransfer : string.Empty)}
                      
                   {(SetStatus.Checked ? setStatusPassiv : string.Empty)}

                    INSERT INTO ERP_CRMLOGS (USERID,CRMCARD,TYPE,DESCRIPTION,EXPLANATION) VALUES
                      ({General.User.UserId},'{CartNo.Text.Trim()}',3
                    ,N'Karta transfer:{reasonCmbx.Text}:{Cartnobtnedit.Text.Trim()}',
                       N'{reasonText.Substring(0,51-(0<(51-reasonText.Length)? (51 - reasonText.Length):0))}')
                    COMMIT TRANSACTION CARDTRANSFER

                END TRY
                BEGIN CATCH
                ROLLBACK TRANSACTION CARDTRANSFER


                END CATCH
                                         ",
                    TransferAllData.Checked ? cardTransfer : string.Empty,
                    SetStatus.Checked ? setStatusPassiv : string.Empty);
            if (General.Functions.ExecuteStatement(Variables.ConnectionString, query))
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}