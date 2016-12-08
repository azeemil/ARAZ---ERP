using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ERP.Designs;
using ERP.General;


namespace ERP.CRM
{
    public partial class CrmGift : XtraForm
    {
        public CrmGift()
        {
            InitializeComponent();
            branchCmbx.Properties.DataSource = User.Branch;
        
            BegDate.DateTime = EndDate.DateTime = DateTime.Now;
            CheckedChanged(null, null);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            BegDate.Enabled = EndDate.Enabled = dateChbx.Checked;
            branchCmbx.Enabled = branchChbx.Checked;
            CardNo.Enabled = CartnoChbx.Checked;
        }
        private void NewBtn_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(MousePosition);
        }
        private readonly string _query = string.Format(@"
                        SELECT GIFT.ID,GIFT.CREATEDDATE,GIFT.BRANCH, CART.CARTNO,US.USERNAME,GIFT.APPROVED,GIFT.CANCELLED,
                        (CASE GIFT.[TYPE] WHEN 0 THEN N'Verilmə' ELSE N'Qaytarma' END) TYPE
                        FROM   {0}LK_{1}_CRMCART CART (NOLOCK)
                        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF 
                        INNER JOIN ERP_CRM_GIFT GIFT ON GIFT.CUSTOMERCARDNO=CART.CARTNO     
                        INNER JOIN ERP_USERS US ON US.ID=GIFT.CREATEDUSER  WHERE 1=1    
                                             ", Variables.FirmDb, Variables.FirmNr);
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = string.Empty;

            if (dateChbx.Checked)
                query +=
                    $" AND CAST(GIFT.CREATEDDATE AS DATE) BETWEEN '{BegDate.DateTime.ToString("yyyy-MM-dd")}' AND '{EndDate.DateTime.ToString("yyyy-MM-dd")}' ";

            var temp = Functions.GetCheckedComboboxValue(branchCmbx, branchChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Iş yeri seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += $" AND GIFT.BRANCH IN ({temp})";

            temp = CardNo.Text;

            if(CartnoChbx.Checked)
            {
                if (temp.Length == 0)
                    {
                        XtraMessageBox.Show("Kart nömrəsi daxil edilməyib!", "Diqqət", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    
                    }
                        query += $" AND GIFT.CUSTOMERCARDNO LIKE '{temp}' ";
                    }

            grid.DataSource = Functions.GetSqlServerDataTable(Variables.ConnectionString, _query + query);
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CrmGiftDocumentDetail frm = new CrmGiftDocumentDetail(1) {DocType = 0};
            if(frm.ShowDialog()==DialogResult.OK) RefreshBtn_ItemClick(null,null);
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CrmGiftDocumentDetail frm = new CrmGiftDocumentDetail(1) { DocType = 1 };
            if (frm.ShowDialog() == DialogResult.OK) SearchBtn_Click(null, null);
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CrmGiftDocumentDetail frm = new CrmGiftDocumentDetail(1) { DocType = 0 };
            if (frm.ShowDialog() == DialogResult.OK) SearchBtn_Click(null, null);

        }

        private void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchBtn_Click(null, null);
        }

        private void grid_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            popupMenu2.ShowPopup(MousePosition);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var row = view.GetFocusedDataRow();
            if (row == null) return;
            if (bool.Parse(row["APPROVED"].ToString()) || bool.Parse(row["CANCELLED"].ToString()))
            {
                XtraMessageBox.Show("Təsdiqlənmiş və ya ləğv olunmuş sənədlər üzərində dəyişiklik etmək olmaz!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var detail = new CrmGiftDocumentDetail(2)
            {
                Id = row["ID"].ToString().Trim(),
                CartNo = {Text = row["CARTNO"].ToString().Trim()},
                Officecode = row["BRANCH"].ToString().Trim(),
                BranchLookUp =
                {
                    SelectedText = row["BRANCH"].ToString().Trim(),
                    Text = row["BRANCH"].ToString().Trim()
                },
                DocType = string.Equals(row["TYPE"].ToString().Trim(), "Qaytarma") ? 1 : 0
            };
            if (detail.ShowDialog()==DialogResult.OK) SearchBtn_Click(null,null);
        }

        private void EditPopUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditBtn_Click(null, null);
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            var row = view.GetFocusedDataRow();
            if (row == null) return;
            var detail = new CrmGiftDocumentDetail(0)
            {
                Officecode = row["BRANCH"].ToString().Trim(),
                BranchLookUp =
                {
                    SelectedText = row["BRANCH"].ToString().Trim(),
                    Text = row["BRANCH"].ToString().Trim(),
                    ReadOnly = true
                },

                CartNo = { Text = row["CARTNO"].ToString().Trim()}
                ,
                Id = row["ID"].ToString().Trim()
            };
            detail.ShowDialog();
        }
        private void ShowPopUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReadBtn_Click(null, null);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var row = view.GetFocusedDataRow();
            if (row == null) return;
            if (bool.Parse(row["APPROVED"].ToString()) || bool.Parse(row["CANCELLED"].ToString()))
            {
                XtraMessageBox.Show("Təsdiqlənmiş və ya ləğv olunmuş sənədlər üzərində dəyişiklik etmək olmaz!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (XtraMessageBox.Show("Sənəd ləğv olunacaq.\nDavam edirsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            var connection = new SqlConnection(Variables.ConnectionString);
            connection.Open();
            var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "QIYMET DEYISIMI");
            var command = connection.CreateCommand();
            command.CommandTimeout = 0;
            command.Transaction = transaction;
            command.CommandText = "UPDATE ERP_CRM_GIFT SET CANCELLED = 1,MODIFIEDUSER=@MODIFIEDUSER,MODIFIEDDATE=GETDATE() WHERE ID=@ID ";
            command.Parameters.AddWithValue("@ID", row["ID"]);
            command.Parameters.AddWithValue("@MODIFIEDUSER", User.UserId);
            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction?.Rollback();
                XtraMessageBox.Show(exception.Message + "\n" + exception, "Xəta!", MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }


            SearchBtn_Click(null, null);
        }

        private void CancelPopUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteBtn_Click(null, null);
        }

      

        private void PrintDocument_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = view.GetFocusedDataRow();
            if (row == null) return;
            if (!bool.Parse(row["APPROVED"].ToString()))
            {
                XtraMessageBox.Show("Yalnız təsdiqlənmiş sənədlər çap oluna bilər!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            splashScreenManager1.ShowWaitForm();
            var report = GetReport();
            var ds = new DataSet();
            try
            {

         
            var dt = Functions.GetSqlServerDataTable(Variables.ConnectionString,
              string.Format(@"
                        SELECT GIFT.ID,GIFT.CREATEDDATE,GIFT.BRANCH, CART.CARTNO,US.USERNAME,GIFT.APPROVED,GIFT.CANCELLED,
                        (CASE GIFT.[TYPE] WHEN 0 THEN N'Verilmə' ELSE N'Qaytarma' END) TYPE,'{2}' NTUSERNAME
                        FROM   {0}LK_{1}_CRMCART CART (NOLOCK)
                        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF 
                        INNER JOIN ERP_CRM_GIFT GIFT ON GIFT.CUSTOMERCARDNO=CART.CARTNO  AND GIFT.ID={3}   
                        INNER JOIN ERP_USERS US ON US.ID=GIFT.CREATEDUSER     
                                             ", Variables.FirmDb, Variables.FirmNr, User.UserName, row["ID"]));

            var dtDetail = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                string.Format(@"
             SELECT CUSTOMER.LOGICALREF,CUSTOMER.NAME,CUSTOMER.SURNAME,IDENT.FATHERNAME,
        IDENT.BIRTHDATE,CARTNO,IDENT.TCNUMBER,
        (CASE IDENT.MARRIED WHEN '0' THEN 'Evli' WHEN '1' THEN 'Subay' ELSE '' END ) MARRIED,
        ADDRES.[ADDRESS],ADDRES.MOBILTEL,
         (CASE PERSONAL.SEX WHEN '0' THEN N'Kişi' WHEN '1' THEN N'Qadın' ELSE '' END) SEX,
         (CASE CUSTOMER.STATUS WHEN 0 THEN 'Aktiv' ELSE 'Passiv' END ) STATUS,PERSONAL.COMPANYDEF,CAST(ISNULL(P.Puan,0) AS INT) PUAN
        FROM       {0}LK_{1}_CRMCART CART (NOLOCK)
        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF  AND  CART.CARTNO='{2}'
        INNER JOIN  {0}LK_{1}_CRMIDENTITY IDENT (NOLOCK) ON IDENT.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN  {0}LK_{1}_CRMADDRESS ADDRES (NOLOCK) ON ADDRES.CARTREF=CUSTOMER.LOGICALREF
        LEFT JOIN  {0}LK_{1}_CRMPERSONAL PERSONAL (NOLOCK) ON PERSONAL.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN inter_puan..INTERBONUS_PUAN P ON P.Cari_kod COLLATE DATABASE_DEFAULT=CARTNO
                                             ", Variables.FirmDb, Variables.FirmNr, row["CARTNO"]));

            var itemsTable = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                string.Format(@"
                 SELECT DTL.ID , ITEM.LOGICALREF ITEMID,
           (SELECT TOP 1 BARCODE FROM {0}LG_{1}_UNITBARCODE BARCODE WHERE BARCODE.ITEMREF=ITEM.LOGICALREF) BARCODE
            ,ITEM.CODE,
            ITEM.NAME, DTL.AMOUNT,DTL.BONUS,DTL.TOTALBONUS         
            FROM             {0}LG_{1}_ITEMS ITEM 
            INNER JOIN  ERP_CRM_GIFTLINES DTL ON ITEM.LOGICALREF=DTL.ITEMID AND DTL.MASTERID={2} 
			ORDER BY DTL.ID
                                      ", Variables.FirmDb, Variables.FirmNr, row["ID"]));

                dt.TableName = "MASTER";
                dtDetail.TableName = "CUSTOMER";
                itemsTable.TableName = "ITEMS";
                ds.Tables.Add(dt);
                ds.Tables.Add(dtDetail);
                ds.Tables.Add(itemsTable);

                if (report == null) return;
                report.DataSource = ds;
                report.CreateDocument();
                var reporting = new Reporting(report);
                splashScreenManager1.CloseWaitForm();
                reporting.WindowState = FormWindowState.Maximized;
                reporting.ShowDialog();

               
            }
            catch (Exception)
            {

                splashScreenManager1.CloseWaitForm();
            }
          
        }

        public XtraReport GetReport()
        {
              XtraReport _report = new XtraReport();
        var designs = Functions.GetSqlServerDataTable(Variables.ConnectionString,
              $@"SELECT TOP 1 ID,TEMPLATE,NAME FROM ERP_REPORTTEMPLATES WHERE TYPE=1 AND FIRMNR={Variables.FirmNr}");
            if (designs.Rows.Count == 0)
            {
                XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null ;
            }
            DataRow row =  designs.Rows[0];
            if (row != null)
            {
                using (var sw = new StreamWriter(new MemoryStream()))
                {
                    sw.Write(row["TEMPLATE"].ToString());
                    sw.Flush();
                    _report = XtraReport.FromStream(sw.BaseStream, true);
                }
            }
            return _report;

        }
    }
}