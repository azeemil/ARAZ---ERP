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

        public XtraReport GetReport(string no, string type)
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

        public XtraReport GetReportForDetail(string no, string type)
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
                $@"SELECT  ID,TYPE,TEMPLATE,NAME,DESIGNEDFOR FROM ERP_REPORTTEMPLATES WHERE TYPE IN(2,3,4,5) AND FIRMNR={Variables.FirmNr}");

        }

        private void LoadPermissions()
        {
            // Pageler 
            tab.TabPages[0].Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.4.1'").Any();
            tab.TabPages[0].Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.4.2'").Any();

            //Page1
            // Lisbox
            for (var i = 0; i < invTypes.ItemCount; i++)
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
            ,CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,R.ID REQUESTID
            FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
            INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF
            INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
            INNER JOIN L_CAPIDIV CAP1 ON FIS.BRANCH=CAP1.NR AND CAP1.FIRMNR={1}
            LEFT JOIN ARAZERP..[ERP_DELETEREQUEST] R ON R.STF_ID=FIS.LOGICALREF AND R.FIRMNR={1}  AND R.REQUESTISCANCELLED=0 WHERE 1=1 
                
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
                invView.BestFitColumns();
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
            SELECT FIS.LOGICALREF,FIS.FICHENO,CAST(ISNULL(FIS.APPROVE,0) AS BIT) APPROVE,FIS.DOCODE ,FIS.DATE_ ,CAP.NAME NAME,FIS.NETTOTAL,
            FIS.SOURCEINDEX,
			(CASE FIS.TRCODE WHEN 25 THEN FIS.DESTINDEX	ELSE  NULL END)	DESTINDEX,	
			FIS.UGIRTRACKINGNO,CAP.NAME SOURCEWHOUSENAME,
			(CASE FIS.TRCODE WHEN 25 THEN CAP1.NAME	ELSE  NULL END)	DESTWHOUSENAME,
            CASE FIS.TRCODE 
            WHEN  15 THEN N'Mərkəzdən Gələn' 
            WHEN  20 THEN N'Mərkəzdən Çıxan' 
            WHEN  25 THEN 'Transfer' 
            WHEN  11 THEN N'Imha' 
            WHEN  12 THEN N'Sərf' 
            WHEN  13 THEN N'Ürətim'
            END 'TIP' ,FIS.TRCODE,
         CAST((CASE WHEN R.ID IS NULL THEN 0 ELSE 1 END) AS BIT) REQUEST,R.ID REQUESTID
         FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
         INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} 
         INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}         
         LEFT JOIN ARAZERP..[ERP_DELETEREQUEST] R ON R.STF_ID=FIS.LOGICALREF AND R.FIRMNR={1} AND R.REQUESTISCANCELLED=0
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
            query += $" AND (FIS.SOURCEINDEX IN ({temp}) OR FIS.DESTINDEX IN ({temp})) ";

            temp = Functions.GetCheckedComboboxValue(TransferDestWhouseCmbx, TransferDestWhouseChbx.Checked);
            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Anbar 2 seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            query += $" AND (FIS.DESTINDEX IN ({temp}) OR FIS.SOURCEINDEX IN ({temp})) ";

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
                mtView.BestFitColumns();
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
                    var row = view.GetDataRow(e.RowHandle);
                    if ((bool)row["BILLED"])
                    {
                        e.Appearance.BackColor = Color.Chartreuse;
                        e.Appearance.BackColor2 = Color.GreenYellow;

                    }
                    if ((bool)row["REQUEST"])
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
                    var row = view.GetDataRow(e.RowHandle);
                    if ((bool)row["APPROVE"])
                    {
                        e.Appearance.BackColor = Color.Chartreuse;
                        e.Appearance.BackColor2 = Color.GreenYellow;

                    }
                    if ((bool)row["REQUEST"])
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;

                    }
                }
            }
        }

        private void gridInvoice_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(MousePosition);
        }

        private void gridMaterial_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu2.ShowPopup(MousePosition);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            InvDetailsBtn_ItemClick(null, null);
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            mtDetails_ItemClick(null,null);
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
            var row = invView.GetFocusedDataRow();
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
                irsForm.Report = GetReportForDetail(row["TRCODE"].ToString(), "2");
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

            var row = invView.GetFocusedDataRow();
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
            var report = GetReport(row["TRCODE"].ToString(), "2");
            if (report == null) return;
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
            if (invView.GetSelectedRows().Count() <= 0) return;
            start:          
            if (_printDialog.ShowDialog() != DialogResult.OK) return;
            if (!_printDialog.PrinterSettings.IsValid)
            {
                if (
                    XtraMessageBox.Show("Printer Problemi!", "Diqqət!", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error) == DialogResult.Retry)
                    goto start;
                return;
            }


            string temp = Empty;
            int[] a = invView.GetSelectedRows();
            temp = a.Select(t => (DataRowView) invView.GetRow(t))
                .Aggregate(temp, (current, row) => current + ("," + row.Row["LOGICALREF"].ToString()));
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
                for (var i = 0; i < counter; i++)
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
                    var report = GetReport(type, "2");
                    if (report == null) continue;
                    report.DataSource = ds;
                    report.ShowPrintStatusDialog = false;
                    report.PrintingSystem.StartPrint += PrintingSystem_StartPrint;
                    report.Print();
                }


            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message + Environment.NewLine + exception, "Diqqət!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }

        }
        private void InvGridToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Functions.GridToExcel(invView);
        }
        private void InvNewRequestBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = invView.GetFocusedDataRow();
            if (row == null) return;

           if ((bool)row["BILLED"])
            {
                if (!(User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.4.1.4'").Any() || User.IsAdmin))
                {
                    XtraMessageBox.Show(@"Fakturalanmış irsaliyənin silinmə tələbi üçün səlahiyətiniz yoxdur!",
                        @"Ləğv edildi!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Request(invView.GetFocusedRowCellValue("LOGICALREF").ToString());

        }
        private void InvGridPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            var report = GetReport("0", "4");
            if (report == null) return;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("MASTER");
            dt.Columns.Add("DATE", typeof (string));
            dt.Columns.Add("USER", typeof (string));
            dt.Rows.Add(
                InvBegDate.DateTime.ToString("dd.MM.yyyy") + " - " + InvEndDate.DateTime.ToString("dd.MM.yyyy"),
                User.UserName);
            ds.Tables.Add(dt);
            ds.Tables.Add((DataTable) gridInvoice.DataSource);
            ds.Tables[0].TableName = "MASTER";
            ds.Tables[1].TableName = "DETAIL";
            report.DataSource = ds;
            report.CreateDocument();
            var reporting = new Reporting(report);
            splashScreenManager1.CloseWaitForm();
            reporting.ShowDialog();

        }

        #endregion

        #region mtPopup
        private void mtRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MtSearch(null, null);
        }
        private void mtDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = mtView.GetFocusedDataRow();
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
                        Report = GetReportForDetail(trcode, "3")
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
                splashScreenManager1.CloseWaitForm();
            }




        }
        private void mtPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = mtView.GetFocusedDataRow();
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
        private void mtPrintSelected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mtView.GetSelectedRows().Count() <= 0) return;

            start:           
            if (_printDialog.ShowDialog() != DialogResult.OK) return;
            if (!_printDialog.PrinterSettings.IsValid)
            {
                if (
                    XtraMessageBox.Show("Printer Problemi!", "Diqqət!", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error) == DialogResult.Retry)
                    goto start;
                return;
            }

       
            string temp = Empty;
            int[] a = mtView.GetSelectedRows();
            temp = a.Select(t => (DataRowView)mtView.GetRow(t))
                .Aggregate(temp, (current, row) => current + ("," + row.Row["LOGICALREF"].ToString()));
            temp = temp.Substring(1);
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
         INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}  AND FIS.LOGICALREF IN ({3})
         INNER JOIN L_CAPIWHOUSE CAP1 ON FIS.DESTINDEX=CAP1.NR AND CAP1.FIRMNR={1}         
         LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF ;
           ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, temp, User.UserName);


            query += Format(@"
SELECT STL.LOGICALREF,STL.STFICHEREF,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
(CASE WHEN ISNULL(STL.PRICE,0)>0 THEN ROUND(STL.PRICE,3) ELSE PRC.NETPURCHASE END) PRICE,
(CASE WHEN ISNULL(STL.PRICE,0)>0 THEN ROUND(STL.TOTAL,3) ELSE ROUND(STL.AMOUNT*PRC.NETPURCHASE,3) END) TOTAL,STL.IOCODE
FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK) 
INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF AND STL.STFICHEREF IN ({3}) 
LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
LEFT JOIN {0}LK_{1}_PRCLIST PRC ON PRC.OFFICECODE=0 AND PRC.STREF=STL.STOCKREF
ORDER BY STL.LOGICALREF ;

                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, temp);

            DataSet ds = new DataSet();
            try
            {
                splashScreenManager1.ShowWaitForm();
                var data = Functions.GetSqlServerDataset(Variables.TigerConnection, query);

                int counter = data.Tables[0].Rows.Count;
                for (var i = 0; i < counter; i++)
                {
                   
                    string id = data.Tables[0].Rows[i]["LOGICALREF"].ToString();
                    string type = data.Tables[0].Rows[i]["TRCODE"].ToString();
                    var add = (type.Trim() == "25") ? " AND IOCODE IN (1,2)": Empty;
                    ds.Tables.Clear();
                    ds.Tables.Add(
                        data.Tables[0].Select($"LOGICALREF={id}{add}").CopyToDataTable());
                    ds.Tables.Add(
                        data.Tables[1].Select($"STFICHEREF={id}", "LOGICALREF ASC").CopyToDataTable());
                    ds.Tables[0].TableName = "MASTER";
                    ds.Tables[1].TableName = "DETAIL";
                    var report = GetReport(type, "3");
                    if (report == null) continue;
                    report.DataSource = ds;
                    report.ShowPrintStatusDialog = false;
                    report.PrintingSystem.StartPrint += PrintingSystem_StartPrint;
                    report.Print();
                }


            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message + Environment.NewLine + exception, "Diqqət!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }


        }
        private void mtGeneralReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            var report = GetReport("0", "5");
            if (report == null) return;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("MASTER");
            dt.Columns.Add("DATE", typeof (string));
            dt.Columns.Add("USER", typeof (string));
            dt.Rows.Add(
                InvBegDate.DateTime.ToString("dd.MM.yyyy") + " - " + InvEndDate.DateTime.ToString("dd.MM.yyyy"),
                User.UserName);
            ds.Tables.Add(dt);
            ds.Tables.Add((DataTable) gridMaterial.DataSource);
            ds.Tables[0].TableName = "MASTER";
            ds.Tables[1].TableName = "DETAIL";
            report.DataSource = ds;
            report.CreateDocument();
            var reporting = new Reporting(report);
            splashScreenManager1.CloseWaitForm();
            reporting.ShowDialog();

        }
        private void mtNewRequestBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = mtView.GetFocusedDataRow();
            if (row==null) return;
            if ((bool)row["APPROVE"])

            {
                if (!(User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.4.2.4'").Any() || User.IsAdmin))
                {
                    XtraMessageBox.Show(@"Yoxlanılmış sənədləri silinmə tələbi üçün səlahiyətiniz yoxdur!",
                        @"Ləğv edildi!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Request(row["LOGICALREF"].ToString());
        }
        #endregion

        private readonly PrintDialog _printDialog = new PrintDialog();

        public void Request(string index){
            string command = Format(@"
        SELECT   FIS.LOGICALREF,FIS.TRCODE, FIS.FICHENO , FIS.DOCODE,FIS.SOURCEINDEX,FIS.DESTINDEX,FIS.UGIRTRACKINGNO,CLC.CODE , 
        CLC.DEFINITION_ , FIS.NETTOTAL,FIS.DATE_, 
        CAP.NAME,
         CASE FIS.TRCODE 
            WHEN  15 THEN N'Mərkəzdən Gələn' 
            WHEN  20 THEN N'Mərkəzdən Çıxan' 
            WHEN  25 THEN 'Transfer' 
            WHEN  11 THEN N'Imha' 
            WHEN  12 THEN N'Sərf' 
            WHEN  13 THEN N'Ürətim'
            WHEN 1 THEN N'Alış' 
			WHEN 6 THEN N'Iadə' 
			WHEN 2 THEN N'Satış İadə' 
		    WHEN 7 THEN N'Satış'
			WHEN 8 THEN N'Topdan Satış'
			WHEN 3 THEN N'Topdan Satış İadə'
            END 'TIP' 
        ,ISNULL(USERNAME,'') N'USERID',R.ID,R.APPROVED,R.CANCELLED,R.EXPLANATION,CAST(ISNULL(FIS.BILLED,0) AS BIT) BILLED
          ,CAST(ISNULL(FIS.APPROVE,0) AS BIT) APPROVE,CAST(ISNULL(R.SENDFORAPPROVE,0) AS BIT) SENDFORAPPROVE,
        CAST(ISNULL(R.ONLYVOUCHER,0) AS BIT) ONLYVOUCHER
        FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
        LEFT JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF = FIS.CLIENTREF 
        LEFT JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
        LEFT JOIN ARAZERP..[ERP_DELETEREQUEST] R ON R.STF_ID=FIS.LOGICALREF AND R.FIRMNR = {1} AND R.REQUESTISCANCELLED=0
        LEFT JOIN ARAZERP..ERP_USERS US ON US.ID = R.RECUSER
        WHERE FIS.LOGICALREF={3}
                
                             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index);
            RequestForm form = new RequestForm(command);
            form.ShowDialog();
        }

        private void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e)
        {
            e.PrintDocument.PrinterSettings = _printDialog.PrinterSettings;
        }



     

    }

}
