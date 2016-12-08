using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using ERP.Designs;
using ERP.General;
using static System.String;
using PrintDialog = System.Windows.Forms.PrintDialog;

namespace ERP.Market.MQ
{
    public partial class MqFrm : XtraForm
    {
        private DataTable _desginTable;
        public XtraReport GetReport(string no,string type)
        {
            XtraReport report;

            if (!_desginTable.Select($"TYPE={type} AND DESIGNEDFOR={no}").Any())
            {
                XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            using (var sw = new StreamWriter(new MemoryStream()))
            {
                sw.Write(_desginTable.Select($"TYPE={type} AND DESIGNEDFOR={no}")[0]["TEMPLATE"].ToString());
                sw.Flush();
                report = XtraReport.FromStream(sw.BaseStream, true);
            }

            return report;

        }
        public XtraReport GetReportForDetail(string no,string type)
        {
            XtraReport report;

            if (!_desginTable.Select($"TYPE={type} AND DESIGNEDFOR={no}").Any())
                return null;
            using (var sw = new StreamWriter(new MemoryStream()))
            {
                sw.Write(_desginTable.Select($"TYPE={type} AND DESIGNEDFOR={no}")[0]["TEMPLATE"].ToString());
                sw.Flush();
                report = XtraReport.FromStream(sw.BaseStream, true);
            }
            return report;

        }
        public MqFrm()
        {
            InitializeComponent();
             #region Invoice
            invBranchCmbx.Properties.DataSource = User.Branch;
            invWhouseCmbx.Properties.DataSource = User.Whouse;
            InvBegDate.DateTime = InvEndDate.DateTime = DateTime.Now;
            #endregion

             #region Transfer
            TransferSourceWhouseCmbx.Properties.DataSource = User.WhouseIn;
            TransferDestWhouseCmbx.Properties.DataSource = User.WhouseOut;
            TransferBegDate.DateTime = TransferEndDate.DateTime = DateTime.Now;
            #endregion

        }
        private void OnLoad(object sender, EventArgs e)
        {
            if (!User.IsAdmin) LoadPermissions();
            InvCheckEditCheckedChanged(null, null);
            MtCheckEditCheckedChanged(null, null);
            _desginTable = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                  @"SELECT  ID,TYPE,TEMPLATE,NAME,DESIGNEDFOR FROM ERP_REPORTTEMPLATES WHERE TYPE IN(2,3,4,5)");

        }
        private void LoadPermissions()
        {
           // Pageler 
            tab.TabPages[0].Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.4.1'").Any();
            tab.TabPages[0].Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.4.2'").Any();

            //Page1
            // Lisbox
            for(var i = 0 ; i<invTypes.ItemCount;i++)
            {
                var item = invTypes.Items[i];
                item.Enabled = User.UserPermission.Select($"LEVEL=0 AND PERMISSION = '{item.Tag}'").Any();
               invTypes.SetItemChecked(i, item.Enabled);
            }
            for (var i = 0; i < mtTypes.ItemCount; i++)
            {
                var item = mtTypes.Items[i];
                item.Enabled = User.UserPermission.Select($"LEVEL=0 AND PERMISSION = '{item.Tag}'").Any();
                mtTypes.SetItemChecked(i, item.Enabled);
            }

        }
        private void InvCheckEditCheckedChanged(object sender, EventArgs e)
        {
            invBranchCmbx.Enabled = invBranchChbx.Checked;
            invWhouseCmbx.Enabled = invWhouseChbx.Checked;
            InvBegDate.Enabled = InvEndDate.Enabled = invDateChbx.Checked;
            invInvnoTxbx.Enabled = invInvnoChbx.Checked;
            invDocnoTxbx.Enabled = invDocnoChbx.Checked;
        }
        private void MtCheckEditCheckedChanged(object sender, EventArgs e)
        {
            mtInvNoTxt.Enabled = TransferInvChbx.Checked;
            mtDocnoTxt.Enabled = TransferDocnoChbx.Checked;
            TransferBegDate.Enabled = TransferEndDate.Enabled = TransferDateChbx.Checked;
            TransferDestWhouseCmbx.Enabled = TransferDestWhouseChbx.Checked;
            TransferSourceWhouseCmbx.Enabled = TransferSourceWhouseChbx.Checked;

        }
        #region Searching
        private void InvSearch(object sender, EventArgs e)
        {
            string query = Format(@"
            SELECT  FIS.LOGICALREF,FIS.FICHENO ,FIS.DOCODE ,CAST(FIS.DATE_ AS DATE) DATE_ ,CLC.CODE, 
            CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,CAP.NAME,CAP1.NR BRANCHNO,CAP1.NAME BRANCH
            ,  CASE FIS.TRCODE 
			WHEN 1 THEN N'Alış' 
			WHEN 6 THEN N'Iadə' 
			WHEN 2 THEN N'Satış İadə' 
		    WHEN 7 THEN N'Satış'
			WHEN 8 THEN N'Topdan Satış'
			WHEN 3 THEN N'Topdan Satış İadə'
			  END 'TIP'
             ,FIS.TRCODE ,CAST(ISNULL(FIS.BILLED,0) AS BIT) BILLED
            ,CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST
            FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
            INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF
            INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
           INNER JOIN L_CAPIDIV CAP1 ON FIS.BRANCH=CAP1.NR AND CAP1.FIRMNR={1}
            LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF WHERE 1=1
                
                             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod);

            if (invDateChbx.Checked)
                query +=
         $" AND FIS.DATE_ BETWEEN '{InvBegDate.DateTime.ToString("yyyy-MM-dd")}' AND '{InvEndDate.DateTime.ToString("yyyy-MM-dd")}' ";

            var temp = Functions.GetCheckedComboboxValue(invBranchCmbx, invBranchChbx.Checked);
            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Iş yeri seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            query += $" AND FIS.BRANCH IN ({temp}) ";

            temp = Functions.GetCheckedComboboxValue(invWhouseCmbx, invWhouseChbx.Checked);
            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Anbar seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            query += $" AND FIS.SOURCEINDEX IN ({temp}) ";

            if (invTypes.Items.GetCheckedValues().Count == 0)
            {
                XtraMessageBox.Show("Sənəd növü seçilməyib!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            temp = invTypes.Items.GetCheckedValues().Aggregate(Empty, (current, item) => current + ("," + item));
          

            query += $" AND FIS.TRCODE IN  ({temp.Substring(1)}) ";
            if (invInvnoChbx.Checked)
                query += $" AND FIS.FICHENO LIKE '{invInvnoTxbx.Text}' ";
            if (invDocnoChbx.Checked)
                query += $" AND FIS.DOCODE LIKE '{invDocnoTxbx.Text}' ";
            try
            {
                splashScreenManager1.ShowWaitForm();
                gridInvoice.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
                gridInvoice.Refresh();
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + Environment.NewLine + ex, "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }
          
        }
        private void MtSearch(object sender, EventArgs e)
        {
            string query = Format(@"
           SELECT  FIS.LOGICALREF,FIS.FICHENO,FIS.APPROVE,FIS.DOCODE ,FIS.DATE_ ,CAP.NAME NAME,FIS.NETTOTAL,
            FIS.SOURCEINDEX,FIS.DESTINDEX,FIS.UGIRTRACKINGNO,CAP.NAME SOURCEWHOUSENAME,CAP1.NAME DESTWHOUSENAME,
            CASE FIS.TRCODE 
            WHEN  15 THEN N'Mərkəzdən Gələn' 
            WHEN  20 THEN N'Mərkəzdən Çıxan' 
            WHEN  25 THEN 'Transfer' 
            WHEN  11 THEN N'Imha' 
            WHEN  12 THEN N'Sərf' 
            WHEN  13 THEN N'Ürətim'
            END 'TIP' ,FIS.TRCODE,
         CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST
         FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
         INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
         INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}         
         LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
         WHERE 1=1     ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod);

            if (TransferDateChbx.Checked)
                query +=
         $" AND (FIS.DATE_ BETWEEN '{TransferBegDate.DateTime.ToString("yyyy-MM-dd")}' AND '{TransferEndDate.DateTime.ToString("yyyy-MM-dd")}') ";

            var temp = Functions.GetCheckedComboboxValue(TransferSourceWhouseCmbx, TransferSourceWhouseChbx.Checked);
            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Anbar 1 seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            query += $" AND FIS.SOURCEINDEX IN ({temp}) ";

            temp = Functions.GetCheckedComboboxValue(TransferDestWhouseCmbx, TransferDestWhouseChbx.Checked);
            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Anbar 2 seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            query += $" AND FIS.DESTINDEX IN ({temp}) ";

            if (mtTypes.Items.GetCheckedValues().Count == 0)
            {
                XtraMessageBox.Show("Sənəd növü seçilməyib!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            temp = mtTypes.Items.GetCheckedValues().Aggregate(Empty, (current, item) => current + ("," + item));


            query += $" AND FIS.TRCODE IN  ({temp.Substring(1)}) ";
            if (invInvnoChbx.Checked)
                query += $" AND FIS.FICHENO LIKE '{mtInvNoTxt.Text}' ";
            if (invDocnoChbx.Checked)
                query += $" AND FIS.DOCODE LIKE '{mtDocnoTxt.Text}' ";
            try
            {
                splashScreenManager1.ShowWaitForm();
                gridMaterial.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
                gridMaterial.Refresh();
                gridView2.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + Environment.NewLine + ex, "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }

        }
        #endregion

        #region GridOptions
        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (view != null)
                {
                    string billed = view.GetRowCellDisplayText(e.RowHandle, view.Columns["BILLED"]);
                    if (billed == "Checked")
                    {
                        e.Appearance.BackColor = Color.Chartreuse;
                        e.Appearance.BackColor2 = Color.GreenYellow;

                    }
                }
                if (view != null)
                {
                    string requested = view.GetRowCellDisplayText(e.RowHandle, view.Columns["REQUEST"]);
                    if (requested == "Checked")
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;

                    }
                }
            }
        }
        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (view != null)
                {
                    string requested = view.GetRowCellDisplayText(e.RowHandle, view.Columns["REQUEST"]);
                    if (requested == "Checked")
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;

                    }
                }
            }
        }
        private void gridInvoice_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
                popupMenu1.ShowPopup(MousePosition);
        }
        private void gridMaterial_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu2.ShowPopup(MousePosition);
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           InvDetailsBtn_ItemClick(null,null);
        }
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
           
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.Kind == IndicatorKind.Header)
            {
                e.Info.DisplayText = "№";
            }
            else if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.Kind == IndicatorKind.Header)
            {
                e.Info.DisplayText = "№";
            }
            else if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        #endregion
      
        #region invPopup
        private void InvRefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvSearch(null, null);
        }
        private void InvDetailsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;

            var index = row["LOGICALREF"];
            string query = Format(@"
SELECT  FIS.LOGICALREF,FIS.FICHENO ,FIS.DOCODE ,CAST(FIS.DATE_ AS DATE) DATE_ ,CLC.CODE, 
            CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,CAP.NAME,CAP1.NR BRANCHNO,CAP1.NAME BRANCH
            ,  CASE FIS.TRCODE 
			WHEN 1 THEN N'Alış' 
			WHEN 6 THEN N'Iadə' 
			WHEN 2 THEN N'Satış İadə' 
		    WHEN 7 THEN N'Satış'
			WHEN 8 THEN N'Topdan Satış'
			WHEN 3 THEN N'Topdan Satış İadə'
			  END 'TIP'
             ,FIS.TRCODE ,CAST(ISNULL(FIS.BILLED,0) AS BIT) BILLED
            ,CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,USER_ = N'{4}'
            FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
            INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF AND FIS.LOGICALREF={3}
            INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
           INNER JOIN L_CAPIDIV CAP1 ON FIS.BRANCH=CAP1.NR AND CAP1.FIRMNR={1}
            LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF                                 
                             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index, User.UserName);


            query += Format(@"
SELECT ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
ROUND(STL.PRICE,3) PRICE,STL.TOTAL,ROUND(STL.PRICE/1.18,3) PRICE_EDVSIZ,ROUND(STL.TOTAL/1.18,2) TOTAL_EDVSIZ,
[QIYMET_KOLI_EDVLI]=ROUND(STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2),2),
[MEBLEG_KOLI_EDVLI]=ROUND(STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2),2),
[QIYMET_KOLI_EDVSIZ]=ROUND((STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
[MEBLEG_KOLI_EDVSIZ]=ROUND((STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
[KOLI_MIQDAR]=ROUND((STL.AMOUNT/ITM.CONVFACT2),3)
FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK) 
INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
LEFT JOIN {0}LG_{1}_ITMUNITA ITM WITH (NOLOCK) ON ITM.ITEMREF=ITEM.LOGICALREF AND ITM.LINENR=3
WHERE STL.STFICHEREF ={3} ORDER BY STL.LOGICALREF

                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index);




            Invoice irsForm = new Invoice();
            try
            {
                splashScreenManager1.ShowWaitForm();
                irsForm.ds = Functions.GetSqlServerDataset(Variables.TigerConnection, query);
                irsForm.Report = GetReportForDetail(row["TRCODE"].ToString(),"2");
                irsForm.Show();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.ToString());
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }


        }
        private void InvPrintBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            splashScreenManager1.ShowWaitForm();
            var index = row["LOGICALREF"];
            var query = Format(@"
            SELECT  FIS.LOGICALREF,FIS.FICHENO ,FIS.DOCODE ,CAST(FIS.DATE_ AS DATE) DATE_ ,CLC.CODE, 
            CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,CAP.NAME,CAP1.NR BRANCHNO,CAP1.NAME BRANCH
            ,  CASE FIS.TRCODE 
			WHEN 1 THEN N'Alış' 
			WHEN 6 THEN N'Iadə' 
			WHEN 2 THEN N'Satış İadə' 
		    WHEN 7 THEN N'Satış'
			WHEN 8 THEN N'Topdan Satış'
			WHEN 3 THEN N'Topdan Satış İadə'
			  END 'TIP'
             ,FIS.TRCODE ,CAST(ISNULL(FIS.BILLED,0) AS BIT) BILLED
            ,CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,USER_ = N'{4}'
            FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
            INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF AND FIS.LOGICALREF={3}
            INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
           INNER JOIN L_CAPIDIV CAP1 ON FIS.BRANCH=CAP1.NR AND CAP1.FIRMNR={1}
            LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF                                 
                             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index, User.UserName);


            query += Format(@"
            SELECT ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
            ROUND(STL.PRICE,3) PRICE,STL.TOTAL,ROUND(STL.PRICE/1.18,3) PRICE_EDVSIZ,ROUND(STL.TOTAL/1.18,2) TOTAL_EDVSIZ,
            [QIYMET_KOLI_EDVLI]=ROUND(STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2),2),
            [MEBLEG_KOLI_EDVLI]=ROUND(STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2),2),
            [QIYMET_KOLI_EDVSIZ]=ROUND((STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
            [MEBLEG_KOLI_EDVSIZ]=ROUND((STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
            [KOLI_MIQDAR]=ROUND((STL.AMOUNT/ITM.CONVFACT2),3)
            FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK) 
            INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
            LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
            LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
            LEFT JOIN {0}LG_{1}_ITMUNITA ITM WITH (NOLOCK) ON ITM.ITEMREF=ITEM.LOGICALREF AND ITM.LINENR=3
            WHERE STL.STFICHEREF ={3} ORDER BY STL.LOGICALREF

                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index);
            var ds = Functions.GetSqlServerDataset(Variables.TigerConnection, query);
            var report = GetReport(row["TRCODE"].ToString(),"2");
            if(report==null) return;
            ds.Tables[0].TableName = "MASTER";
            ds.Tables[1].TableName = "DETAIL";
            report.DataSource = ds;
            report.CreateDocument();
            var reporting = new Reporting(report);
            splashScreenManager1.CloseWaitForm();
            reporting.ShowDialog();
          
           
        }
        private void InvPrintSelectedBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.GetSelectedRows().Count() <= 0) return;        
          
            start:
            _printDialog.ShowDialog();
            if (_printDialog.ShowDialog() != DialogResult.OK) return;
            if (!_printDialog.PrinterSettings.IsValid)
            {
                if (XtraMessageBox.Show("Printer Problemi!", "Diqqət!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    goto start;
                return;
            }


            string temp =Empty;
                    int[] a = gridView1.GetSelectedRows();
                    temp = a.Select(t => (DataRowView) gridView1.GetRow(t)).Aggregate(temp, (current, row) => current + ("," + row.Row["LOGICALREF"].ToString()));
                    temp = temp.Substring(1);
                    string query = Format(@"
            SELECT  FIS.LOGICALREF,FIS.FICHENO ,FIS.DOCODE ,CAST(FIS.DATE_ AS DATE) DATE_ ,CLC.CODE, 
            CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,CAP.NAME,CAP1.NR BRANCHNO,CAP1.NAME BRANCH
            ,  CASE FIS.TRCODE 
			WHEN 1 THEN N'Alış' 
			WHEN 6 THEN N'Iadə' 
			WHEN 2 THEN N'Satış İadə' 
		    WHEN 7 THEN N'Satış'
			WHEN 8 THEN N'Topdan Satış'
			WHEN 3 THEN N'Topdan Satış İadə'
			END 'TIP'
            ,FIS.TRCODE ,CAST(ISNULL(FIS.BILLED,0) AS BIT) BILLED
            ,CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,USER_ = N'{4}'
            FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
            INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF AND FIS.LOGICALREF IN ({3})
            INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
            INNER JOIN L_CAPIDIV CAP1 ON FIS.BRANCH=CAP1.NR AND CAP1.FIRMNR={1}
            LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF   ;                              
                             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, temp, User.UserName);


                    query += Format(@"
            SELECT STL.LOGICALREF,STL.STFICHEREF,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
            ROUND(STL.PRICE,3) PRICE,STL.TOTAL,ROUND(STL.PRICE/1.18,3) PRICE_EDVSIZ,ROUND(STL.TOTAL/1.18,2) TOTAL_EDVSIZ,
            [QIYMET_KOLI_EDVLI]=ROUND(STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2),2),
            [MEBLEG_KOLI_EDVLI]=ROUND(STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2),2),
            [QIYMET_KOLI_EDVSIZ]=ROUND((STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
            [MEBLEG_KOLI_EDVSIZ]=ROUND((STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
            [KOLI_MIQDAR]=ROUND((STL.AMOUNT/ITM.CONVFACT2),3)
            FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK) 
            INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
            LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
            LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
            LEFT JOIN {0}LG_{1}_ITMUNITA ITM WITH (NOLOCK) ON ITM.ITEMREF=ITEM.LOGICALREF AND ITM.LINENR=3
            WHERE STL.STFICHEREF IN ({3}) ORDER BY STL.LOGICALREF  ;

                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, temp);
            DataSet ds = new DataSet();
            try
            {
                splashScreenManager1.ShowWaitForm();
                var data = Functions.GetSqlServerDataset(Variables.TigerConnection, query);

                int counter = data.Tables[0].Rows.Count;
                for (var i = 0;i<counter;i++)
                {
                    string id = data.Tables[0].Rows[i]["LOGICALREF"].ToString();
                    string type = data.Tables[0].Rows[i]["TRCODE"].ToString();
                    ds.Tables.Clear();
                    ds.Tables.Add(
                        data.Tables[0].Select($"LOGICALREF={id}").CopyToDataTable());
                    ds.Tables.Add(
                       data.Tables[1].Select($"STFICHEREF={id}", "LOGICALREF ASC").CopyToDataTable());
                    ds.Tables[0].TableName = "MASTER";
                    ds.Tables[1].TableName = "DETAIL";
                    var report = GetReport(type,"2");
                    if(report==null) continue;
                    report.DataSource = ds;
                    report.ShowPrintStatusDialog = false;
                    report.PrintingSystem.StartPrint +=PrintingSystem_StartPrint;
                    report.Print();
                }
                
               
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message + Environment.NewLine + exception, "Diqqət!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            finally { splashScreenManager1.CloseWaitForm(); }
            
        }
        private void InvGridToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Functions.GridToExcel(gridView1);
        }
        private void InvNewRequestBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.GetSelectedRows().Count() <= 0) return;
            if (bool.Parse(gridView1.GetFocusedRowCellValue("BILLED").ToString()))

            {
                XtraMessageBox.Show(@"Fakturalanmış irsaliyənin silinmə muraciətini Mühasibatlıq şöbəsinə edin!", @"Ləğv edildi!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Request(gridView1.GetFocusedRowCellValue("LOGICALREF").ToString());
           
        }
        private void InvGridPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          // DataTable dt = (DataTable)gridInvoice.DataSource;
            //Reporting re = new Reporting(command1, command2, conString, trcode.ToString());
            //          re.Show();
        }
        #endregion

        #region mtPopup
        private void mtRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MtSearch(null,null);
        }
        private void mtDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView2.GetFocusedDataRow();
            if (row == null) return;
            var index = row["LOGICALREF"];
            var trcode = row["TRCODE"].ToString();
            var add = (trcode.Trim() == "25")
                ? " AND STL.IOCODE IN (1,2)"
                : Empty;
            string query = Format(@"
           SELECT  FIS.LOGICALREF,FIS.FICHENO,FIS.APPROVE,FIS.DOCODE ,FIS.DATE_ ,CAP.NAME NAME,FIS.NETTOTAL,
            FIS.SOURCEINDEX,FIS.DESTINDEX,FIS.UGIRTRACKINGNO,CAP.NAME SOURCEWHOUSENAME,CAP1.NAME DESTWHOUSENAME,
            CASE FIS.TRCODE 
            WHEN  15 THEN N'Mərkəzdən Gələn' 
            WHEN  20 THEN N'Mərkəzdən Çıxan' 
            WHEN  25 THEN 'Transfer' 
            WHEN  11 THEN N'Imha' 
            WHEN  12 THEN N'Sərf' 
            WHEN  13 THEN N'Ürətim'
            END 'TIP' ,FIS.TRCODE,
         CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,N'{4}' USERNAME
         FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
         INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}  AND FIS.LOGICALREF={3}
         INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}         
         LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF ;
           ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index, User.UserName);


            query += Format(@"
SELECT STL.LOGICALREF,STL.STFICHEREF,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
(CASE WHEN STL.PRICE>0 THEN ROUND(STL.PRICE,3) ELSE PRC.NETPURCHASE END) PRICE,
(CASE WHEN STL.PRICE>0 THEN ROUND(STL.TOTAL,3) ELSE ROUND(STL.AMOUNT*PRC.NETPURCHASE,3) END) TOTAL,STL.IOCODE
FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK) 
INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF AND STL.STFICHEREF ={3}  {4}
LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
LEFT JOIN {0}LK_{1}_PRCLIST PRC ON PRC.OFFICECODE=0 AND PRC.STREF=STL.STOCKREF
ORDER BY STL.LOGICALREF

                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index, add);

           
            try
            {
                splashScreenManager1.ShowWaitForm();
                if (trcode == "25")
                {
                    MaterialTransfer materialTransactionsForm = new MaterialTransfer
                    {
                        ds = Functions.GetSqlServerDataset(Variables.TigerConnection, query),
                        Report = GetReportForDetail(trcode, "25")
                    };
                    materialTransactionsForm.ShowDialog();
                }
                else
                {
                    MaterialTransact materialTransactionsForm = new MaterialTransact
                    {
                        ds = Functions.GetSqlServerDataset(Variables.TigerConnection, query),
                        Report = GetReportForDetail(trcode, "3")
                    };
                    materialTransactionsForm.ShowDialog();
                }
                
              
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.ToString());
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();}

         
         

        }
        private void mtPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView2.GetFocusedDataRow();
            if (row == null) return;
            splashScreenManager1.ShowWaitForm();
            var index = row["LOGICALREF"];
            var trcode = row["TRCODE"].ToString();
            var add = (trcode.Trim() == "25")
                ? " AND STL.IOCODE IN (1,2)"
                : Empty;
            string query = Format(@"
           SELECT  FIS.LOGICALREF,FIS.FICHENO,FIS.APPROVE,FIS.DOCODE ,FIS.DATE_ ,CAP.NAME NAME,FIS.NETTOTAL,
            FIS.SOURCEINDEX,FIS.DESTINDEX,FIS.UGIRTRACKINGNO,CAP.NAME SOURCEWHOUSENAME,CAP1.NAME DESTWHOUSENAME,
            CASE FIS.TRCODE 
            WHEN  15 THEN N'Mərkəzdən Gələn' 
            WHEN  20 THEN N'Mərkəzdən Çıxan' 
            WHEN  25 THEN 'Transfer' 
            WHEN  11 THEN N'Imha' 
            WHEN  12 THEN N'Sərf' 
            WHEN  13 THEN N'Ürətim'
            END 'TIP' ,FIS.TRCODE,
         CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,USER_ = N'{4}'
         FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
         INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}  AND FIS.LOGICALREF={3}
         INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}         
         LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF ;
           ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index, User.UserName);


            query += Format(@"
SELECT STL.LOGICALREF,STL.STFICHEREF,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
(CASE WHEN ISNULL(STL.PRICE,0)>0 THEN ROUND(STL.PRICE,3) ELSE PRC.NETPURCHASE END) PRICE,
(CASE WHEN ISNULL(STL.PRICE,0)>0 THEN ROUND(STL.TOTAL,3) ELSE ROUND(STL.AMOUNT*PRC.NETPURCHASE,3) END) TOTAL,STL.IOCODE
FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK) 
INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF AND STL.STFICHEREF ={3}  {4}
LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
LEFT JOIN {0}LK_{1}_PRCLIST PRC ON PRC.OFFICECODE=0 AND PRC.STREF=STL.STOCKREF
ORDER BY STL.LOGICALREF

                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index, add);

            var ds = Functions.GetSqlServerDataset(Variables.TigerConnection, query);
            var report = GetReport(trcode, "3");
            if (report == null) return;
            ds.Tables[0].TableName = "MASTER";
            ds.Tables[1].TableName = "DETAIL";
            report.DataSource = ds;
            report.CreateDocument();
            var reporting = new Reporting(report);
            splashScreenManager1.CloseWaitForm();
            reporting.ShowDialog();

        }
        #endregion

        private readonly PrintDialog _printDialog = new PrintDialog();
        public void Request(string index)
        {
            string command = Format(@"
        SELECT   FIS.LOGICALREF,FIS.TRCODE, FIS.FICHENO , FIS.DOCODE,FIS.SOURCEINDEX,FIS.DESTINDEX,FIS.UGIRTRACKINGNO,CLC.CODE , 
        CLC.DEFINITION_ , FIS.NETTOTAL,FIS.DATE_,
        CAP.NAME,CASE WHEN FIS.TRCODE =1 THEN N'Alış' WHEN FIS.TRCODE = 6 THEN N'Iadə' WHEN FIS.TRCODE =11 THEN N'Imha' WHEN FIS.TRCODE = 25 THEN N'Transfer' 
        WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN FIS.TRCODE = 20 THEN N'Mərkəzdən Çıxan'
        END 'TIP',N'{4}' USERID,R.ID,R.APPROVED,R.CANCELLED,R.EXPLANATION
        FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
        LEFT JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
        LEFT JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
        LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
        WHERE FIS.LOGICALREF={3}
                
                             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index, User.UserName);
            RequestForm form = new RequestForm(command);
            form.ShowDialog();
        }
        private void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e)
        {
            e.PrintDocument.PrinterSettings = _printDialog.PrinterSettings;
        }

       






        public void MtDetails()
        {
            

        }

        








        #region archive



        //        private void simpleButton1_Click(object sender, EventArgs e)
        //        {
        //            try
        //            {
        //                string dbn = string.Empty;
        //                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";
        //                // tprogress1.Visible = true;
        //                string command = string.Format(@"
        //SELECT  FIS.LOGICALREF, ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, 
        //FIS.FICHENO  ,FIS.DOCODE ,FIS.DATE_ ,CAP.NAME NAME,
        // FIS.NETTOTAL , FIS.SOURCEINDEX,CASE WHEN FIS.TRCODE=25 THEN FIS.DESTINDEX ELSE  FIS.UGIRTRACKINGNO END DESTINDEX
        //,CASE WHEN FIS.TRCODE=25 THEN CAP1.NAME ELSE CAP2.NAME END NAME1,
        //CASE WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN FIS.TRCODE=20 THEN N'Mərkəzdən Çıxan' ELSE 'Anbar Fişi' END 'TIP' ,FIS.TRCODE,
        //CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,FIS.UGIRTRACKINGNO
        //FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
        //INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
        //INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
        //INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
        //LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
        //WHERE FIS.TRCODE IN (15,20,25) 


        //                             ", dbn, Variables.FirmNr);
        //                string command1 = string.Format(@"
        //SELECT  FIS.LOGICALREF, ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, 
        //FIS.FICHENO  ,FIS.DOCODE ,FIS.DATE_ ,CAP.NAME NAME,
        // FIS.NETTOTAL , FIS.SOURCEINDEX,CASE WHEN FIS.TRCODE=25 THEN FIS.DESTINDEX ELSE  FIS.UGIRTRACKINGNO END DESTINDEX
        //,CASE WHEN FIS.TRCODE=25 THEN CAP1.NAME ELSE CAP2.NAME END NAME1,
        //CASE WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN FIS.TRCODE=20 THEN N'Mərkəzdən Çıxan' ELSE 'Anbar Fişi' END 'TIP' ,FIS.TRCODE,
        //CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,FIS.UGIRTRACKINGNO
        //FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
        //INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
        //INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
        //INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
        //LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
        //WHERE FIS.TRCODE IN (15,20,25) 


        //                             ", dbn, Variables.FirmNr);

        //                #region chekbox

        //                string add = string.Empty;
        //                string add1 = string.Empty;
        //                //----------------------------------------------------------

        //                #region index

        //                //---------------------------------------sourceindex-------------------
        //                if (combo_sourceindex.Properties.GetItems().Count > 0)
        //                {
        //                    string anbarlar = ",";
        //                    if (s_anbar.Checked && (combo_sourceindex.Properties.GetItems().GetCheckedValues().Count > 0))
        //                    {

        //                        foreach (string items in combo_sourceindex.Properties.Items.GetCheckedValues())
        //                        {

        //                            anbarlar += items + ",";

        //                        }
        //                        add += string.Format(" AND FIS.SOURCEINDEX IN ({0})", anbarlar.Substring(1, anbarlar.Length - 2));
        //                        add1 += string.Format(" AND FIS.DESTINDEX IN ({0})", anbarlar.Substring(1, anbarlar.Length - 2));
        //                    }
        //                    else if (s_anbar.Checked && (combo_sourceindex.Properties.GetItems().GetCheckedValues().Count == 0))
        //                    {
        //                        MessageBox.Show(@"Anbar seçilməyib!");
        //                        return;
        //                    }
        //                    else if (s_anbar.Checked == false)
        //                    {
        //                        combo_sourceindex.CheckAll();
        //                        foreach (string items in combo_sourceindex.Properties.Items.GetCheckedValues())
        //                        {
        //                            anbarlar += items + ",";
        //                        }
        //                        add += string.Format(" AND FIS.SOURCEINDEX IN ({0})", anbarlar.Substring(1, anbarlar.Length - 2));
        //                        add1 += string.Format(" AND FIS.DESTINDEX IN ({0})", anbarlar.Substring(1, anbarlar.Length - 2));
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show(@"Anbar seçimi yoxdur! Programlasdirma söbəsi ilə əlaqə saxlayin");
        //                    return;
        //                }

        //                //--------------------------destindex--------------------------------
        //                if (combo_destindex.Properties.GetItems().Count > 0)
        //                {
        //                    string anbarlar1 = ",";
        //                    if (s_anbar2.Checked && (combo_destindex.Properties.GetItems().GetCheckedValues().Count > 0))
        //                    {

        //                        foreach (string items in combo_destindex.Properties.Items.GetCheckedValues())
        //                        {

        //                            anbarlar1 += items + ",";

        //                        }
        //                        add += string.Format(" AND (FIS.DESTINDEX IN ({0}) OR FIS.UGIRTRACKINGNO IN ({0}) )",//OR FIS.UGIRTRACKINGNO IN ({0})
        //                            anbarlar1.Substring(1, anbarlar1.Length - 2));
        //                        add1 += string.Format(" AND (FIS.SOURCEINDEX IN ({0}) OR FIS.UGIRTRACKINGNO IN ({0}) )",//OR FIS.UGIRTRACKINGNO IN ({0})
        //                            anbarlar1.Substring(1, anbarlar1.Length - 2));
        //                    }

        //                    else if (s_anbar2.Checked && (combo_destindex.Properties.GetItems().GetCheckedValues().Count == 0))
        //                    {
        //                        MessageBox.Show(@"Anbar seçilməyib!");
        //                        return;
        //                    }
        //                    else if (s_anbar2.Checked == false)
        //                    {
        //                        combo_destindex.CheckAll();
        //                        foreach (string items in combo_destindex.Properties.Items.GetCheckedValues())
        //                        {
        //                            anbarlar1 += items + ",";
        //                        }
        //                        add += string.Format(" AND (FIS.DESTINDEX IN ({0}) OR FIS.UGIRTRACKINGNO IN ({0}))",//OR FIS.UGIRTRACKINGNO IN ({0})
        //                            anbarlar1.Substring(1, anbarlar1.Length - 2));
        //                        add1 += string.Format(" AND (FIS.SOURCEINDEX IN ({0}) OR FIS.UGIRTRACKINGNO IN ({0}))",//OR FIS.UGIRTRACKINGNO IN ({0})
        //                            anbarlar1.Substring(1, anbarlar1.Length - 2));
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show(@"Anbar seçimi yoxdur! Programlasdirma söbəsi ilə əlaqə saxlayin");
        //                    return;
        //                }
        //                //-------------------------------------------------------------------

        //                #endregion

        //                if (s_tarix.Checked)
        //                {
        //                    if (sdt1.DateTime <= sdt2.DateTime)
        //                    {
        //                        add += string.Format(" AND FIS.DATE_ BETWEEN CAST('{0}' AS DATE) AND CAST('{1}' AS DATE)",
        //                            sdt1.DateTime.ToString(CultureInfo.InvariantCulture),
        //                            sdt2.DateTime.ToString(CultureInfo.InvariantCulture));
        //                        add1 += string.Format(" AND FIS.DATE_ BETWEEN CAST('{0}' AS DATE) AND CAST('{1}' AS DATE)",
        //                            sdt1.DateTime.ToString(CultureInfo.InvariantCulture),
        //                            sdt2.DateTime.ToString(CultureInfo.InvariantCulture));
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show(@"Tarix araligi düzgün seçilməyib!");
        //                        return;
        //                    }
        //                }




        //                if (s_faktura.Checked)
        //                {
        //                    if (s_faktura_text.Text.Length != 0)
        //                    {
        //                        add += string.Format(" AND FIS.FICHENO='{0}'", s_faktura_text.Text);
        //                        add1 += string.Format(" AND FIS.FICHENO='{0}'", s_faktura_text.Text);
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show(@"Qaimə nömrəsi daxil edilməyib!");
        //                        return;
        //                    }
        //                }

        //                #endregion

        //                command += add;
        //                command1 += add1;
        //                string command2 = string.Format("SELECT * FROM ( {0} UNION {1} ) AS FIS ORDER BY FIS.LOGICALREF",
        //                    command, command1);


        //                gridMaterial.Refresh();
        //            }
        //            catch (Exception exception)
        //            {
        //                MessageBox.Show(exception.ToString());
        //            }


        //        }



        //        #endregion





        //        private void alis_cap_context_Click(object sender, EventArgs e)
        //        {
        //            if (gridView1.GetSelectedRows().Count() > 0)
        //            {
        //                var index = gridView1.GetFocusedRowCellValue("LOGICALREF");
        //                string dbn = string.Empty;
        //                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";

        //                string command1 = string.Format(@"
        //SELECT    FIS.FICHENO  , FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CLC.CODE  , 
        //CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,
        //CAP.NAME,CASE WHEN FIS.TRCODE =1 THEN N'Alış' ELSE N'Iadə' END 'TIP',N'{3}' USER_,LEFT(CLC.DEFINITION_,1) B,FIS.TRCODE,FIS.LOGICALREF 
        //FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
        //INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
        //INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} WHERE FIS.LOGICALREF={2}

        //                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());


        //                string command2 = string.Format(@"
        //SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
        //ROUND(STL.PRICE,3) PRICE,STL.TOTAL,ROUND(STL.PRICE/1.18,3) PRICE_EDVSIZ,ROUND(STL.TOTAL/1.18,2) TOTAL_EDVSIZ,
        //[QIYMET_KOLI_EDVLI]=ROUND(STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2),2),
        //[MEBLEG_KOLI_EDVLI]=ROUND(STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2),2),
        //[QIYMET_KOLI_EDVSIZ]=ROUND((STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
        //[MEBLEG_KOLI_EDVSIZ]=ROUND((STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
        //[KOLI_MIQDAR]=ROUND((STL.AMOUNT/ITM.CONVFACT2),3)
        //FROM  {0}LG_{1}_01_STLINE STL WITH (NOLOCK) 
        //INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
        //LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
        //LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
        //LEFT JOIN {0}LG_{1}_ITMUNITA ITM WITH (NOLOCK) ON ITM.ITEMREF=ITEM.LOGICALREF AND ITM.LINENR=3
        //WHERE STL.STFICHEREF ={2} ORDER BY STL.LOGICALREF

        //                                                ", dbn, Variables.FirmNr, index);
        //                string trcode = gridView1.GetFocusedRowCellValue("TRCODE").ToString().Trim();
        //                Reporting re = new Reporting(command1, command2, conString, trcode.ToString());
        //                re.Show();


        //            }


        //        }



        //        private void sevk_cap_context_Click(object sender, EventArgs e)

        //        {
        //            if (gridView2.GetSelectedRows().Count() > 0)
        //            {
        //                var index = gridView2.GetFocusedRowCellValue("LOGICALREF");
        //                string trcode = gridView2.GetFocusedRowCellValue("TRCODE").ToString();
        //                // string add = string.Empty;
        //                string add = (trcode == "25") ? @" AND STL.IOCODE=3 " : string.Empty;
        //                string dbn = string.Empty;
        //                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";

        //                string command1 = string.Format(@"
        //SELECT  FIS.LOGICALREF, ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, 
        //FIS.FICHENO  ,FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CAP.NAME NAME,
        // FIS.NETTOTAL , FIS.SOURCEINDEX,CASE WHEN TRCODE=25 THEN FIS.DESTINDEX ELSE  FIS.UGIRTRACKINGNO END DESTINDEX
        //,CASE WHEN TRCODE=25 THEN CAP1.NAME ELSE CAP2.NAME END NAME1,
        //CASE WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN TRCODE=20 THEN N'Mərkəzdən Çıxan' ELSE 'Anbar Fişi' END 'TIP', 
        //N'{3}' USER_ , FIS.TRCODE,FIS.UGIRTRACKINGNO
        //FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
        //INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
        //INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
        //INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
        //WHERE FIS.LOGICALREF={2}
        //                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());


        //                string command2 = string.Format(@"
        //SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], ROUND(STL.PRICE,3) PRICE,STL.TOTAL  
        //FROM  {0}LG_{1}_01_STLINE STL WITH (NOLOCK) 
        //INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF  {3}
        //LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
        //LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
        //WHERE STL.STFICHEREF ={2} ORDER BY STL.LOGICALREF

        //                                                ", dbn, Variables.FirmNr, index, add);
        //                Reporting Report = new Reporting(command1, command2, conString, trcode);

        //                Report.Show();

        //            }
        //        }

        //        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        //        {
        //            if (gridView3.GetSelectedRows().Count() > 0)
        //            {
        //                var index = gridView3.GetFocusedRowCellValue("LOGICALREF");
        //                string trcode = gridView3.GetFocusedRowCellValue("TRCODE").ToString();
        //                string dbn = string.Empty;
        //                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";

        //                string command1 = string.Format(@"
        //SELECT  FIS.LOGICALREF, ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, FIS.FICHENO  ,
        //FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ , FIS.NETTOTAL , FIS.SOURCEINDEX,
        //CAP.NAME,CASE WHEN FIS.TRCODE =11 THEN N'Imha'  END 'TIP',N'{3}' USER_  FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK)  
        //INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
        //INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
        //INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
        //WHERE FIS.LOGICALREF={2}
        //                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());


        //                string command2 = string.Format(@"
        //SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], ROUND(STL.PRICE,3) PRICE,ROUND(STL.TOTAL,3) TOTAL  
        //FROM  {0}LG_{1}_01_STLINE STL WITH (NOLOCK) 
        //INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
        //LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
        //LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
        //WHERE STL.STFICHEREF ={2} ORDER BY STL.LOGICALREF

        //                                                ", dbn, Variables.FirmNr, index);
        //                Reporting Report = new Reporting(command1, command2, conString, trcode);
        //                Report.Show();
        //                //Report_imha repor = new Report_imha(conString, command1, command2);
        //                //repor.Show();
        //            }
        //        }

        //        private void sifaris_incele_context_Click(object sender, EventArgs e)
        //        {
        //            if (gridView4.GetSelectedRows().Count() > 0)
        //            {
        //                var index = gridView4.GetFocusedRowCellValue("LOGICALREF");
        //                string dbn = string.Empty;
        //                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";

        //                string command1 = string.Format(@"
        //SELECT    FIS.FICHENO  , FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CLC.CODE  , 
        //CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,
        //CAP.NAME,N'Sifariş' 'TIP','{3}' USER_  FROM {0}LG_{1}_01_ORFICHE FIS WITH(NOLOCK) 
        //INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
        //INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} WHERE FIS.LOGICALREF={2}

        //                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());


        //                string command2 = string.Format(@"
        //SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME]  
        //FROM  {0}LG_{1}_01_ORFLINE STL WITH (NOLOCK) 
        //INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
        //LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
        //LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
        //WHERE STL.ORDFICHEREF ={2} ORDER BY STL.LOGICALREF

        //                                                ", dbn, Variables.FirmNr, index);

        //                sip_form irsForm = new sip_form(conString, command1, command2);
        //                irsForm.Show();

        //            }
        //        }

        //        private void sifaris_cap_context_Click(object sender, EventArgs e)
        //        {
        //            if (gridView4.GetSelectedRows().Count() > 0)
        //            {
        //                var index = gridView4.GetFocusedRowCellValue("LOGICALREF");
        //                string dbn = string.Empty;
        //                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";

        //                string command1 = string.Format(@"
        //SELECT    FIS.FICHENO  , FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CLC.CODE  , 
        //CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,
        //CAP.NAME,N'Sifariş' 'TIP',N'{3}' USER_  FROM {0}LG_{1}_01_ORFICHE FIS WITH(NOLOCK) 
        //INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
        //INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} WHERE FIS.LOGICALREF={2}

        //                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());


        //                string command2 = string.Format(@"
        //SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME]  
        //FROM  {0}LG_{1}_01_ORFLINE STL WITH (NOLOCK) 
        //INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
        //LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
        //LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
        //WHERE STL.ORDFICHEREF ={2} ORDER BY STL.LOGICALREF

        //                                                ", dbn, Variables.FirmNr, index);

        //                //sip_report Report = new sip_report(conString, command1, command2);
        //                //Report.Show();
        //                Reporting Report = new Reporting(command1, command2, conString, "102");
        //                Report.Show();
        //            }

        //        }

      

       
      

      

//        private void alis_secili_cap_Click(object sender, EventArgs e)
//        {
//            if (gridView1.GetSelectedRows().Count() <= 0) return;
//            string dbn = string.Empty;
//            if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";



//            if (_printDialog.ShowDialog() == DialogResult.OK)
//            {
//                if (_printDialog.PrinterSettings.IsValid)
//                {


//                    int[] a = gridView1.GetSelectedRows();
//                    for (int i = 0; i < a.Length; i++)
//                    {
//                        DataRowView row = (DataRowView) gridView1.GetRow(a[i]);
//                        string index = row.Row["LOGICALREF"].ToString();

//                        string command1 = string.Format(@"
//SELECT    FIS.FICHENO  , FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_,CLC.CODE  , 
//CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,
//CAP.NAME,CASE WHEN FIS.TRCODE =1 THEN N'Alış' ELSE N'Iadə' END 'TIP',N'{3}' USER_,LEFT(CLC.DEFINITION_,1) B,FIS.TRCODE,FIS.LOGICALREF 
//FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
//INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
//INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} WHERE FIS.LOGICALREF={2}
                
//                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());


//                        string command2 = string.Format(@"
//SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
//ROUND(STL.PRICE,3) PRICE,STL.TOTAL,ROUND(STL.PRICE/1.18,3) PRICE_EDVSIZ,ROUND(STL.TOTAL/1.18,2) TOTAL_EDVSIZ,
//[QIYMET_KOLI_EDVLI]=ROUND(STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2),2),
//[MEBLEG_KOLI_EDVLI]=ROUND(STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2),2),
//[QIYMET_KOLI_EDVSIZ]=ROUND((STL.PRICE/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
//[MEBLEG_KOLI_EDVSIZ]=ROUND((STL.TOTAL/(STL.AMOUNT/ITM.CONVFACT2))/1.18,2),
//[KOLI_MIQDAR]=ROUND((STL.AMOUNT/ITM.CONVFACT2),3)
//FROM  {0}LG_{1}_01_STLINE STL WITH (NOLOCK) 
//INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
//LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
//LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
//LEFT JOIN {0}LG_{1}_ITMUNITA ITM WITH (NOLOCK) ON ITM.ITEMREF=ITEM.LOGICALREF AND ITM.LINENR=3
//WHERE STL.STFICHEREF ={2} ORDER BY STL.LOGICALREF

//                                                ", dbn, Variables.FirmNr, index);



//                        try
//                        {
//                            var conn = new SqlConnection(conString);
//                            var da1 = new SqlDataAdapter(command1, conn);
//                            var da2 = new SqlDataAdapter(command2, conn);
//                            ds.reportstfiche.Clear();
//                            ds.reporstline.Clear();
//                            da1.Fill(ds.reportstfiche);
//                            da2.Fill(ds.reporstline);
//                        }
//                        catch (Exception exception)
//                        {
//                            MessageBox.Show(@"Bağlantı Yoxdur! " + exception.ToString());
//                            return;

//                        }

//                        IadeReport Report = new IadeReport
//                        {
//                            DataSource = ds
//                        };

//                        Report.PrintingSystem.StartPrint +=
//                            new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
//                        Report.Print();
//                        // e.PrintDocument.PrinterSettings = _printDialog.PrinterSettings;
//                        // = _printDialog.PrinterSettings;

//                    }


//                }

//            }

//        }


//       

//        private void sevk_secilmis_cap_Click(object sender, EventArgs e)
//        {
//            if (gridView2.GetSelectedRows().Count() <= 0) return;
//            string dbn = string.Empty;
//            if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";
//            if (_printDialog.ShowDialog() == DialogResult.OK)
//            {
//                if (_printDialog.PrinterSettings.IsValid)
//                {

//                    int[] a = gridView2.GetSelectedRows();
//                    for (int i = 0; i < a.Length; i++)
//                    {
//                        DataRowView row = (DataRowView) gridView2.GetRow(a[i]);
//                        string index = row.Row["LOGICALREF"].ToString();
//                        string trcode = row.Row["TRCODE"].ToString();
//                        string add = string.Empty;
//                        if (trcode == "25") add = @" AND STL.IOCODE=3 ";

//                        string command1 = string.Format(@"
//SELECT  FIS.LOGICALREF, ROW_NUMBER() OVER (ORDER BY FIS.LOGICALREF) ROWNR, 
//FIS.FICHENO  ,FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CAP.NAME NAME,
// FIS.NETTOTAL , FIS.SOURCEINDEX,CASE WHEN TRCODE=25 THEN FIS.DESTINDEX ELSE  FIS.UGIRTRACKINGNO END DESTINDEX
//,CASE WHEN TRCODE=25 THEN CAP1.NAME ELSE CAP2.NAME END NAME1,
//CASE WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN TRCODE=20 THEN N'Mərkəzdən Çıxan' ELSE 'Anbar Fişi' END 'TIP', 
//N'{3}' USER_ , FIS.TRCODE,FIS.UGIRTRACKINGNO
//FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
//INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
//INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
//INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
//WHERE FIS.LOGICALREF={2}
//                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());

//                        string command2 = string.Format(@"
//SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], ROUND(STL.PRICE,3) PRICE,STL.TOTAL  
//FROM  {0}LG_{1}_01_STLINE STL WITH (NOLOCK) 
//INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF {3}
//LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
//LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
//WHERE STL.STFICHEREF ={2} ORDER BY STL.LOGICALREF

//                                                ", dbn, Variables.FirmNr, index, add);



//                        try
//                        {
//                            var conn = new SqlConnection(conString);
//                            var da1 = new SqlDataAdapter(command1, conn);
//                            var da2 = new SqlDataAdapter(command2, conn);
//                            ds.reportsevk_stfiche.Clear();
//                            ds.reporstline.Clear();
//                            da1.Fill(ds.reportsevk_stfiche);
//                            da2.Fill(ds.reporstline);
//                        }
//                        catch (Exception exception)
//                        {
//                            MessageBox.Show(@"Bağlantı Yoxdur! " + exception.ToString());
//                            return;

//                        }

//                        TransferReport Report = new TransferReport();
//                        Report.DataSource = ds;
//                        Report.BeginInit();
//                        Report.EndInit();
//                        Report.PrintingSystem.StartPrint +=
//                            new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
//                        Report.Print();

//                    }
//                }


//            }
//        }

//        private void fakturalanmamışİrsaliyyıələrToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                string dbn = string.Empty;
//                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";
//                //  tprogress1.Visible = true;
//                string command = string.Format(@"
//SELECT  ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, FIS.FICHENO  ,
//FIS.DOCODE ,CONVERT(VARCHAR(10),FIS.DATE_,104)  DATE_ ,CLC.CODE  , 
//CLC.DEFINITION_ ,  FIS.NETTOTAL ,CAST(FIS.SOURCEINDEX AS VARCHAR(5)) +' - '+CAP.NAME AS NAME, 
//CASE WHEN FIS.TRCODE =1 THEN N'Alış' ELSE N'Iadə' END 'TIP',(CASE WHEN R.STF_ID IS NOT NULL THEN N'Silinəcək' END) QEYD  FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
//INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
//INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
//LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
//WHERE
                
//                             ", dbn, Variables.FirmNr);

//                #region chekbox

//                string add = string.Empty;
//                //----------------------------------------------------------
//                if (tip_.Checked)
//                {
//                    switch (tip.SelectedIndex)
//                    {
//                        case 0:
//                            add += string.Format(" FIS.TRCODE=1");
//                            break;
//                        case 1:
//                            add += string.Format(" FIS.TRCODE=6");
//                            break;
//                    }

//                }
//                else
//                {
//                    add += string.Format(" FIS.TRCODE IN (1,6)");
//                }
//                //----------------------------------------------------------
//                if (combo_a.Properties.GetItems().Count > 0)
//                {
//                    string anbarlar = ",";
//                    if (anbar.Checked && (combo_a.Properties.GetItems().GetCheckedValues().Count > 0))
//                    {

//                        foreach (string items in combo_a.Properties.Items.GetCheckedValues())
//                        {

//                            anbarlar += items + ",";

//                        }
//                        add += string.Format(" AND FIS.SOURCEINDEX IN ({0})", anbarlar.Substring(1, anbarlar.Length - 2));
//                    }
//                    else if (anbar.Checked && (combo_a.Properties.GetItems().GetCheckedValues().Count == 0))
//                    {
//                        MessageBox.Show(@"Anbar seçilməyib!");
//                        return;
//                    }
//                    else if (anbar.Checked == false)
//                    {
//                        combo_a.CheckAll();
//                        foreach (string items in combo_a.Properties.Items.GetCheckedValues())
//                        {
//                            anbarlar += items + ",";
//                        }
//                        add += string.Format(" AND FIS.SOURCEINDEX IN ({0})", anbarlar.Substring(1, anbarlar.Length - 2));

//                    }
//                }
//                else
//                {
//                    MessageBox.Show("Anbar seçimi yoxdur! Programlasdirma söbəsi ilə əlaqə saxlayin");
//                    return;
//                }
//                //----------------------------------------------------------
//                if (tarix.Checked)
//                {
//                    if (dt1.DateTime <= dt2.DateTime)
//                    {
//                        add += string.Format(" AND FIS.DATE_ BETWEEN CAST('{0}' AS DATE) AND CAST('{1}' AS DATE)",
//                            dt1.DateTime.ToString(CultureInfo.InvariantCulture),
//                            dt2.DateTime.ToString(CultureInfo.InvariantCulture));
//                    }
//                    else
//                    {
//                        MessageBox.Show(@"Tarix araligi düzgün seçilməyib!");
//                        return;
//                    }
//                }


//                if (invDocnoChbx.Checked)
//                {
//                    if (invDocnoTxbx.Text.Length != 0)
//                    {
//                        add += string.Format("  AND FIS.DOCODE='{0}'", invDocnoTxbx.Text);
//                    }
//                    else
//                    {
//                        MessageBox.Show("Sənəd nömrəsi daxil edilməyib!");
//                        return;
//                    }

//                }

//                if (invInvnoChbx.Checked)
//                {
//                    if (invInvnoTxbx.Text.Length != 0)
//                    {
//                        add += string.Format(" AND FIS.FICHENO='{0}'", invInvnoTxbx.Text);
//                    }
//                    else
//                    {
//                        MessageBox.Show("Qaimə nömrəsi daxil edilməyib!");
//                        return;
//                    }
//                }

//                #endregion

//                command += add;
//                string command2 =
//                    string.Format(
//                        @"SELECT (CONVERT(VARCHAR(10),'{0}',104) +' - '+CONVERT(VARCHAR(10),'{1}',104)) DATE_,N'{2}' USER_ ",
//                        dt1.DateTime, dt2.DateTime, statuslable.ToString().Trim());

//                Reporting Report = new Reporting(command, command2, conString, "100");
//                Report.Show();



//            }
//            catch (Exception exception)
//            {
//                MessageBox.Show(exception.ToString());
//            }

//        }

      
     

    

    

//        private void gridView5_DoubleClick(object sender, EventArgs e)
//        {
//            if (gridView5.GetSelectedRows().Count() > 0)
//            {
//                var l = gridView5.GetFocusedRowCellValue("TRCODE");

//                var index = gridView5.GetFocusedRowCellValue("LOGICALREF");
//                var add = (gridView5.GetFocusedRowCellValue("TRCODE").ToString().Trim() == "25")
//                    ? " AND STL.IOCODE IN (1,2)"
//                    : String.Empty;
//                string dbn = string.Empty;
//                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";

//                string command1 = string.Format(@"
//SELECT  FIS.LOGICALREF, ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, 
//FIS.FICHENO  ,FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CAP.NAME NAME,
// FIS.NETTOTAL , FIS.SOURCEINDEX,CASE WHEN TRCODE=25 THEN FIS.DESTINDEX ELSE  FIS.UGIRTRACKINGNO END DESTINDEX
//,CASE WHEN TRCODE=25 THEN CAP1.NAME ELSE CAP2.NAME END NAME1,
//CASE WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN TRCODE=20 THEN N'Mərkəzdən Çıxan' ELSE 'Anbar Fişi' END 'TIP', 
//N'{3}' USER_ , FIS.TRCODE
//FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
//INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
//INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
//INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
//WHERE FIS.LOGICALREF={2}
//                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());


//                string command2 = string.Format(@"
//SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], ROUND(STL.PRICE,3) PRICE,STL.TOTAL  
//FROM  {0}LG_{1}_01_STLINE STL WITH (NOLOCK) 
//INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF {3}
//LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
//LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
//WHERE STL.STFICHEREF ={2} ORDER BY STL.LOGICALREF

//                                                ", dbn, Variables.FirmNr, index, add);

//                MaterialTransactions sevkForm = new MaterialTransactions(conString, command1, command2);
//                sevkForm.Show();

//            }
//        }

//        private void toolStripMenuItem1_Click(object sender, EventArgs e)
//        {
//            if (gridView5.GetSelectedRows().Count() > 0)
//            {
//                var l = gridView5.GetFocusedRowCellValue("TRCODE");

//                var index = gridView5.GetFocusedRowCellValue("LOGICALREF");
//                var add = (gridView5.GetFocusedRowCellValue("TRCODE").ToString().Trim() == "25")
//                    ? " AND STL.IOCODE IN (1,2)"
//                    : String.Empty;
//                string dbn = string.Empty;
//                if (dbname.TextLength > 0) dbn = dbname.Text.Trim() + "..";

//                string command1 = string.Format(@"
//SELECT  FIS.LOGICALREF, ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, 
//FIS.FICHENO  ,FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CAP.NAME NAME,
// FIS.NETTOTAL , FIS.SOURCEINDEX,CASE WHEN TRCODE=25 THEN FIS.DESTINDEX ELSE  FIS.UGIRTRACKINGNO END DESTINDEX
//,CASE WHEN TRCODE=25 THEN CAP1.NAME ELSE CAP2.NAME END NAME1,
//CASE WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN TRCODE=20 THEN N'Mərkəzdən Çıxan' ELSE 'Anbar Fişi' END 'TIP', 
//N'{3}' USER_ , FIS.TRCODE
//FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
//INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
//INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
//INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
//WHERE FIS.LOGICALREF={2}
//                             ", dbn, Variables.FirmNr, index, statuslable.ToString().Trim());


//                string command2 = string.Format(@"
//SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], ROUND(STL.PRICE,3) PRICE,STL.TOTAL  
//FROM  {0}LG_{1}_01_STLINE STL WITH (NOLOCK) 
//INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF {3}
//LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
//LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
//WHERE STL.STFICHEREF ={2} ORDER BY STL.LOGICALREF

//                                                ", dbn, Variables.FirmNr, index, add);

//                MaterialTransactions sevkForm = new MaterialTransactions(conString, command1, command2);
//                sevkForm.Show();

//            }
//        }

//        private void toolStripMenuItem2_Click(object sender, EventArgs e)
//        {
//            SaveFileDialog sv = new SaveFileDialog();
//            sv.AddExtension = true;
//            sv.DefaultExt = "Excel | *.xlsx";
//            sv.Filter = @"Excel | *.xlsx";
//            if (sv.ShowDialog() == DialogResult.OK)
//            {
//                if (sv.FileName == string.Empty)
//                {
//                    MessageBox.Show(@"Ad boşdur");
//                    return;
//                }
//                gridView5.ExportToXlsx(sv.FileName);
//            }
//        }

      

        private void transferHesabat_Click(object sender, EventArgs e)
        {
            try
            {
             
                string command = Format(@"
SELECT  FIS.LOGICALREF,-- ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, 
FIS.FICHENO  ,FIS.DOCODE ,FIS.DATE_ ,CAP.NAME NAME,
 FIS.NETTOTAL , FIS.SOURCEINDEX,CASE WHEN FIS.TRCODE=25 THEN FIS.DESTINDEX ELSE  FIS.UGIRTRACKINGNO END DESTINDEX
,CASE WHEN FIS.TRCODE=25 THEN CAP1.NAME ELSE CAP2.NAME END NAME1,
CASE WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN FIS.TRCODE=20 THEN N'Mərkəzdən Çıxan' ELSE 'Anbar Fişi' END 'TIP' ,FIS.TRCODE,
CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,FIS.UGIRTRACKINGNO
FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
WHERE FIS.TRCODE IN (15,20,25) 

                
                             ", Variables.FirmDb, Variables.FirmNr);
                string command1 = Format(@"
SELECT  FIS.LOGICALREF, --ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, 
FIS.FICHENO  ,FIS.DOCODE ,FIS.DATE_ ,CAP.NAME NAME,
 FIS.NETTOTAL , FIS.SOURCEINDEX,CASE WHEN FIS.TRCODE=25 THEN FIS.DESTINDEX ELSE  FIS.UGIRTRACKINGNO END DESTINDEX
,CASE WHEN FIS.TRCODE=25 THEN CAP1.NAME ELSE CAP2.NAME END NAME1,
CASE WHEN FIS.TRCODE =15 THEN N'Mərkəzdən Gələn' WHEN FIS.TRCODE=20 THEN N'Mərkəzdən Çıxan' ELSE 'Anbar Fişi' END 'TIP' ,FIS.TRCODE,
CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,FIS.UGIRTRACKINGNO
FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}
INNER JOIN L_CAPIWHOUSE CAP2 ON FIS.UGIRTRACKINGNO=CAP2.NR AND CAP2.FIRMNR={1}
LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
WHERE FIS.TRCODE IN (15,20,25) 

                
                             ", Variables.FirmDb, Variables.FirmNr);

                #region chekbox

                string add = Empty;
                string add1 = Empty;
                //----------------------------------------------------------

                #region index

           

                //--------------------------destindex--------------------------------
              //-------------------------------------------------------------------

                #endregion

              

                #endregion

                //command += add;
                //command1 += add1;
                //string command2 = string.Format("SELECT DISTINCT ROW_NUMBER() OVER(ORDER BY FIS.LOGICALREF) ROWNR, * FROM ( {0} UNION {1} ) AS FIS ORDER BY FIS.LOGICALREF",
                //    command, command1);

                //string command3 =
                //  string.Format(
                //      @"SELECT (CONVERT(VARCHAR(10),'{0}',104) +' - '+CONVERT(VARCHAR(10),'{1}',104)) DATE_,N'{2}' USER_ ",
                   //   dt1.DateTime, dt2.DateTime, statuslable.ToString().Trim());

                //Reporting Report = new Reporting(command2, command3, conString, "101");
               // Report.Show();
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }














        #endregion

      
    }

}
