using System;
using System.Data;
using DevExpress.XtraEditors;
using ERP.General;


namespace ERP.Market
{
    public partial class Cashiers : XtraForm
    {
    
        private bool m = false;
        private string logicalref;
        public Cashiers()
        {
            InitializeComponent();
        }

        private void sifre_ver_Click(object sender, EventArgs e)
        {
           
           sifre.Text = new Random().Next(100001, 999999).ToString();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           filial.Properties.DataSource = User.Branch;
           select();
        }


        private void select()
        {
          
            var dttable = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                string.Format(@"SELECT POS.LOGICALREF, LTRIM(RTRIM(CAST(POS.DIVREF AS VARCHAR(5)) +' - '+CAP.NAME)) DIVREF,POS.CASHIERCODE,POS.CASHIERNAME,POS.CASHIERPASS,POS.CASHIERAXX,POS.EXPLANATION 
                                        FROM {0}LK_{1}_POSCASHIER POS
                                                INNER JOIN L_CAPIDIV CAP ON CAP.NR=POS.DIVREF AND CAP.FIRMNR={1} AND POS.KSTYPE=5
                                                ORDER BY POS.DIVREF,POS.CASHIERCODE", Variables.FirmDb, Variables.FirmNr));
            grid.DataSource = dttable;
            grid.Refresh();
        }

      

        public void SelectGridRow()
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                DataRow row = gridView1.GetFocusedDataRow();
                kod.Text = row["CASHIERCODE"].ToString();
                filial.Text = filial.Properties.NullText = row["DIVREF"].ToString().Split('-')[0].Trim();
                kassir.Text = row["CASHIERNAME"].ToString();
                sifre.Text = row["CASHIERPASS"].ToString();
                huquq.Text = row["CASHIERAXX"].ToString();
                rt.Text = row["EXPLANATION"].ToString();
                logicalref = row["LOGICALREF"].ToString();
                
            }
        }

        private void grid_Click(object sender, EventArgs e)
        {
            SelectGridRow();
        }

        private void yeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select();
        }

        private void dəyişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show(@"Seçim yoxdur!"); return;
            }
            SelectGridRow();
            m = false;
            grid.Enabled = false;
            gb1.Enabled = true;
        }

        private void əlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = true;
            kod.Text = string.Empty;
            filial.ItemIndex = 0;
            kassir.Text = string.Empty;
            huquq.SelectedIndex = 0;
            rt.Text = string.Empty;
            grid.Enabled = false;
            gb1.Enabled = true;
            sifre.Text = new Random().Next(100001, 999999).ToString();}

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            grid.Enabled = true;
            gb1.Enabled = false;
            SelectGridRow();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if((kassir.Text.Length==0)||(sifre.Text.Length!=6))
            {
                XtraMessageBox.Show(@"Kassir adı və ya Şifresi girilməyib!");
                return;
            }
            string query=string.Empty;
          
            if (m)
            {
                query = string.Format(@"BEGIN TRY     
BEGIN TRANSACTION    
DECLARE @CODE VARCHAR (10)
SET @CODE=(SELECT REPLICATE('0',4-LEN(CAST(MAX(CASHIERCODE) AS INT)+1))+LTRIM(RTRIM(CAST(MAX(CASHIERCODE) AS INT)+1))  FROM {0}LK_{1}_POSCASHIER)
INSERT INTO {0}LK_{1}_POSCASHIER (FIRMREF,DIVREF,CASHIERCODE,CASHIERNAME,CASHIERPASS,CASHIERAXX,EXPLANATION,KSTYPE,DISCRATE,DISCTOTAL,MASTERREF)
VALUES ({1},{2},LTRIM(RTRIM(@CODE)),'{3}','{4}','{5}','{6}',5,0,0,(SELECT TOP 1 LOGICALREF FROM {0}LK_{1}_FOODMST WHERE DIVNR={2}))
COMMIT TRAN                                   
SELECT VALUE=1 
END TRY 
BEGIN CATCH     
IF @@TRANCOUNT > 0   ROLLBACK TRAN
SELECT VALUE=0  
END CATCH", Variables.FirmDb,Variables.FirmNr,filial.Text,kassir.Text.Trim(),sifre.Text.Trim(),huquq.Text.Trim(),rt.Text.Trim());

            }
            else
            {
                if(gridView1.SelectedRowsCount==0) return;
                query = string.Format(@"
BEGIN TRY      
BEGIN TRANSACTION     
UPDATE {0}LK_{1}_POSCASHIER
SET DIVREF={2} , CASHIERNAME = '{3}',CASHIERPASS='{4}',CASHIERAXX='{5}',EXPLANATION='{7}',MASTERREF=(SELECT TOP 1 LOGICALREF FROM {0}LK_{1}_FOODMST WHERE DIVNR={2}) 
WHERE LOGICALREF={6}
COMMIT TRAN                                    
SELECT VALUE=1  
END TRY  
BEGIN CATCH      
IF @@TRANCOUNT > 0   
ROLLBACK TRAN 
SELECT VALUE=0   
END CATCH
", Variables.FirmDb, Variables.FirmNr, filial.Text, kassir.Text.Trim(),sifre.Text.Trim(),huquq.Text.Trim(),logicalref, rt.Text.Trim());
            }
          
            var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
            if(dt.Rows[0][0].ToString().Trim()=="1")
            {
                XtraMessageBox.Show("Yadda Saxlanıldı");
            }
            else
            {
                XtraMessageBox.Show("Yadda Saxlanılmadı");   
            }
            grid.Enabled = true;
            gb1.Enabled = false;
            @select();SelectGridRow();
        
        }
    }
}
