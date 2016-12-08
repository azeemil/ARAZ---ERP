using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ERP.General;

namespace ERP.Logistcs
{
    public partial class OrderGroups : XtraForm
    {
        internal readonly MainForm MainForm;
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
        public OrderGroups()
        {
            InitializeComponent();
            LoadPermissions();
        }

        public OrderGroups(MainForm mainForm)

        {
            InitializeComponent();
            MainForm = mainForm;
            branchCmbx.Properties.DataSource = User.BranchIn;
            SourceBranchCmbx.Properties.DataSource = User.BranchOut;
            whouseCmbx.Properties.DataSource = User.WhouseIn;
            SourceIndexCmbx.Properties.DataSource = User.WhouseOut;
            BegDate.DateTime = EndDate.DateTime = DateTime.Now;

            LoadPermissions();
        }

        public void LoadPermissions()
        {
            if (User.IsAdmin) return;
            NewBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.2.1'").Any();
            ModifyBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.2.2'").Any();
            DeleteBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.2.3'").Any();
            ApproveBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.2.4'").Any();
            PaylasdirBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.2.5'").Any();
        }

        private DataSet _ds;
        private readonly string _query = string.Format(@"               
                    SELECT FIS.LOGICALREF,FIS.STATUS,CAST(FIS.DATE_ AS DATE) DATE_,FIS.ORDERREF,
                    CAST((CASE ISNULL(FIS.ORDERREF,0) WHEN 0 THEN 0 ELSE 1 END) AS BIT) GROUPPED,
                    FIS.SOURCEBRANCH,DIV1.NAME DIVNAME1,FIS.SOURCEINDEX,WHOUSE1.NAME WHOUSENAME1,
                    FIS.DESTBRANCH,DIV2.NAME DIVNAME2,FIS.DESTINDEX,WHOUSE2.NAME WHOUSENAME2 
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} WHERE FIS.FICHETYPE IN(1,2) 
                    AND LTRIM(RTRIM(FIS.EXPLANATION))='1'
                        ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod);

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            if (dateChbx.Checked)
                query += string.Format(" AND CAST(FIS.DATE_ AS DATE) BETWEEN '{0}' AND '{1}' ",
                    BegDate.DateTime.ToString("yyyy-MM-dd"),
                    EndDate.DateTime.ToString("yyyy-MM-dd"));

            var temp = Functions.GetCheckedComboboxValue(branchCmbx, branchChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Iş yeri seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += string.Format(" AND FIS.DESTBRANCH IN ({0})", temp);

            temp = Functions.GetCheckedComboboxValue(whouseCmbx, WhouseChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Anbar seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += string.Format(" AND FIS.DESTINDEX IN ({0}) ", temp);


            /////
            temp = Functions.GetCheckedComboboxValue(SourceBranchCmbx, SourceBranchChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Iş yeri seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += $" AND FIS.SOURCEBRANCH IN ({temp})";

            temp = Functions.GetCheckedComboboxValue(SourceIndexCmbx, SourcheIndexChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Anbar seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += $" AND FIS.SOURCEINDEX IN ({temp}) ";

           
            _ds = Functions.GetSqlServerDataset(Variables.TigerConnection, _query + query);
            grid.DataSource = _ds.Tables[0];

        }


        private void CheckedChanged(object sender, EventArgs e)
        {
            BegDate.Enabled = EndDate.Enabled = dateChbx.Checked;
            branchCmbx.Enabled = branchChbx.Checked;
            whouseCmbx.Enabled = WhouseChbx.Checked;

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            NewOrderGroup newgGroup = new NewOrderGroup(true);
            if (newgGroup.ShowDialog() == DialogResult.OK)
                SearchBtn.PerformClick();
        }

        private void view_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (gridView != null)
                {
                    string requested = gridView.GetRowCellValue(e.RowHandle, gridView.Columns["GROUPPED"]).ToString();
                    if (bool.Parse(requested.Trim()))
                    {
                        e.Appearance.BackColor = Color.Gray;

                    }
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var row = view.GetFocusedRow();
            if (row != null)
            {
                DataRowView dr = (DataRowView) row;
                if (bool.Parse(dr["GROUPPED"].ToString()))
                {
                    XtraMessageBox.Show("Qrup artıq təsdiqlənib!", "Diqqət", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }
                var id = dr["LOGICALREF"];

                if (XtraMessageBox.Show(id + " Nömrəli qrup ləğv olunacaq. Davam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Functions.ExecuteStatement(Variables.TigerConnection,
                        string.Format(
                            "UPDATE {0}LK_{1}_{2}_PURCHORDERDISTFICHE SET FICHETYPE=10,CHANGEUSER={3},CHANGEDATE=GETDATE() WHERE LOGICALREF={4} " +
                            "UPDATE {0}LK_{1}_{2}_PURCHORDERDISTFICHE SET ORDERREF=NULL WHERE ORDERREF={4}",
                            Variables.FirmDb,
                            Variables.FirmNr, Variables.FirmPeriod, User.UserId, id));
                }
                SearchBtn.PerformClick();
            }
        }

        private void grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PopUp.ShowPopup(Cursor.Position);
            }
        }

        private void OrderList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = view.GetFocusedRow();
            if (row == null) return;
            DataRowView dr = (DataRowView) row;
            GroupOrderMembers grp = new GroupOrderMembers {Id = int.Parse(dr["LOGICALREF"].ToString())};
            grp.Text = string.Format("{0} - {1}", grp.Text, dr["LOGICALREF"]);
            grp.Name = string.Format("{0}_{1}", grp.Name, dr["LOGICALREF"]);
            grp.Dr = dr;
            grp.gridControl1.EmbeddedNavigator.Buttons.Append.Visible =
                grp.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = !bool.Parse(dr["GROUPPED"].ToString());
            Variables.MForm.OpenOrBringToFront(grp);

        }

        
        private void ApproveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = view.GetFocusedRow();
            if (row != null)
            {

                DataRowView dr = (DataRowView) row;
                if (bool.Parse(dr["GROUPPED"].ToString()))
                {
                    XtraMessageBox.Show("Qrup artıq təsdiqlənib!", "Diqqət", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }
                var id = dr["LOGICALREF"];
                if (XtraMessageBox.Show(
                    id +
                    " Nömrəli qrup təsdiqlənəcək və üzərində heç bir dəyişiklik etmək mümkün olmayacaq!. \nDavam edirsiz?",
                    "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  
                    if (Functions.ExecuteStatement(Variables.TigerConnection,
                        string.Format(
                            @"
                           BEGIN TRANSACTION 
			               BEGIN TRY 
                            INSERT INTO {0}LK_{1}_{2}_PURCHORDERDISTLINE
                            (ORDERREF,ITEMREF,TRANSFERED_AMOUNT,TRANSFER_AMOUNT,UNITLINEREF,UNITSETREF,CONVFACT1,CONVFACT2,AMOUNT)	
                            SELECT FIS.ORDERREF,ITEMREF,SUM(TRANSFERED_AMOUNT),SUM(TRANSFER_AMOUNT),
                            UNITLINEREF,STL.UNITSETREF,CONVFACT1,CONVFACT2,SUM(AMOUNT) 
                            FROM  {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS    
                            INNER JOIN   {0}LK_{1}_{2}_PURCHORDERDISTLINE  STL ON FIS.LOGICALREF=STL.ORDERREF AND 
                            FIS.FICHETYPE=1 AND LTRIM(RTRIM(FIS.EXPLANATION))='0' AND FIS.ORDERREF={3}
                            LEFT JOIN {0}LG_{1}_ITEMS ITEM (NOLOCK) ON ITEM.LOGICALREF=STL.ITEMREF
                            LEFT JOIN {0}LK_{1}_{2}_PURCHCATEGORY CAT (NOLOCK) ON CAT.CODE=LEFT(ITEM.STGRPCODE,2)
                            GROUP BY  FIS.ORDERREF,ITEMREF,UNITLINEREF,STL.UNITSETREF,CONVFACT1,CONVFACT2,CAT.DESCR,ITEM.NAME
                            ORDER BY CAT.DESCR,ITEM.NAME
 
                            UPDATE {0}LK_{1}_{2}_PURCHORDERDISTFICHE  SET FICHETYPE=1,ORDERREF={3} WHERE LOGICALREF={3}
                            UPDATE  {0}LK_{1}_{2}_PURCHORDERDISTFICHE SET SOURCEINDEX={4},SOURCEBRANCH={5} 
                            WHERE ORDERREF={3} AND LOGICALREF !={3}
                            COMMIT TRANSACTION
				            END TRY
				            BEGIN CATCH				
				            ROLLBACK TRANSACTION
				            END CATCH
                            ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, id, dr["DESTINDEX"],
                            dr["DESTBRANCH"])))
                    {
                        
                        dr.Row["GROUPPED"] = true;
                        view.RefreshData();
                        XtraMessageBox.Show("Sifariş qrupu təsdiqləndi!", "Diqqət", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
              
                }

              

            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {

            var row = view.GetFocusedRow();
            if (row == null) return;
            
            DataRowView dr = (DataRowView) row;
            var id = dr["LOGICALREF"];
            string command1 =
                string.Format(@" SELECT FIS.LOGICALREF,FIS.STATUS,CAST(FIS.DATE_ AS DATE) DATE_,FIS.ORDERREF,
                    CAST((CASE ISNULL(FIS.ORDERREF,0) WHEN 0 THEN 0 ELSE 1 END) AS BIT) GROUPPED,
                    FIS.SOURCEBRANCH,DIV1.NAME SOURCEBRANCHNAME,FIS.SOURCEINDEX,WHOUSE1.NAME SOURCEINDEXNAME,
                    FIS.DESTBRANCH,DIV2.NAME DESTBRANCHNAME,FIS.DESTINDEX,WHOUSE2.NAME DESTINDEXNAME ,USERNAME='{3}'
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} AND
                    LTRIM(RTRIM(FIS.EXPLANATION))='1'
                    WHERE FIS.LOGICALREF={4}",
                    Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, id);
            string command2 = string.Format(@"SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,
                    ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,45) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME UNITCODE  
                    FROM  {0}LK_{1}_{2}_PURCHORDERDISTLINE STL WITH (NOLOCK) 
                    INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.ITEMREF=ITEM.LOGICALREF --AND STL.TRANSFERED_AMOUNT>0 -- Deyisdirildi
                    LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UNITSETREF=SELT.UNITSETREF AND SELT.LINENR=1    
                    LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
                    WHERE STL.ORDERREF={3} ",
                Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, id);
            string command3 = string.Format(@" SELECT FIS.LOGICALREF,CAST(FIS.DATE_ AS DATE) DATE_,FIS.ORDERREF,
                    FIS.SOURCEBRANCH,DIV1.NAME SOURCEBRANCHNAME,FIS.SOURCEINDEX,WHOUSE1.NAME SOURCEINDEXNAME,
                    FIS.DESTBRANCH,DIV2.NAME DESTBRANCHNAME,FIS.DESTINDEX,WHOUSE2.NAME DESTINDEXNAME ,USERNAME='{3}'
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} AND
                    LTRIM(RTRIM(FIS.EXPLANATION))='0'
                    WHERE FIS.ORDERREF={4}",
                Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, id);
            try
            {
                splashScreenManager1.ShowWaitForm();
                var report = GetReport("0", "8");
                if (report == null)
                {
                    XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2 + command3);
                ds.Tables[0].TableName = "MASTER";
                ds.Tables[1].TableName = "DETAIL";
                ds.Tables[2].TableName = "DETAIL_OFF";
                report.DataSource = ds;
                report.CreateDocument();
                var reporting = new Designs.Reporting(report)
                {
                    Text = @"Çap Forması - Anbar Sifariş № " + id,
                    Name = $"{report.Name}_{id}"
                };
                Variables.MForm.OpenOrBringToFront(reporting);


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

        private void PaylasdirBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = view.GetFocusedDataRow();
            if (row == null) return;

            if (!bool.Parse(row["GROUPPED"].ToString()))
            {
                XtraMessageBox.Show("Qrup təsdiqlənməyib!", "Diqqət", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Davam edirsiz?",
                    "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                var query = string.Format(@"
IF OBJECT_ID('TEMPDB..#{3}_TEMP') IS NOT NULL DROP TABLE #{3}_TEMP
IF OBJECT_ID('TEMPDB..#{3}_TEMPLINES') IS NOT NULL DROP TABLE #{3}_TEMPLINES
IF OBJECT_ID('TEMPDB..#{3}_TRANSFERRED') IS NOT NULL DROP TABLE #{3}_TRANSFERRED
IF OBJECT_ID('TEMPDB..#{3}_CONVERTED') IS NOT NULL DROP TABLE #{3}_CONVERTED
IF OBJECT_ID('TEMPDB..#{3}_TEMPQALIQ') IS NOT NULL DROP TABLE #{3}_TEMPQALIQ

DECLARE @ID INT
SET @ID={4}



-------------------------------------------------IS SAYI-------------------

SELECT LINE.ITEMREF,ISNULL(ISNULL(NULLIF(ITMUNITA.CONVFACT2,0),1)/ISNULL(NULLIF(ITMUNITA.CONVFACT1,0),1),1) ICSAYI,LINE.TRANSFER_AMOUNT,SETL.CODE
INTO #{3}_CONVERTED
FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIC WITH(NOLOCK)
INNER JOIN {0}LK_{1}_{2}_PURCHORDERDISTLINE LINE WITH(NOLOCK) ON LINE.ORDERREF=FIC.LOGICALREF AND FIC.LOGICALREF=@ID AND TRANSFERED_AMOUNT<>0
LEFT JOIN {0}LG_{1}_ITMUNITA ITMUNITA (NOLOCK)  ON LINE.ITEMREF=ITMUNITA.ITEMREF
INNER JOIN {0}LG_{1}_UNITSETL SETL (NOLOCK) ON SETL.LOGICALREF=ITMUNITA.UNITLINEREF  AND SETL.CODE='SB'


--------------------------------------------------SIFARISLER-----------------------------
SELECT LINE.LOGICALREF,LINE.ITEMREF,LINE.TRANSFER_AMOUNT,LINE.TRANSFERED_AMOUNT,LINE.TRANSFERED_AMOUNT AMOUNT, 
LINE.TRANSFER_AMOUNT/ISNULL(ICSAYI,1) CONVERTED_AMOUNT,ISNULL(ICSAYI,1) ICSAYI
INTO #{3}_TEMPLINES
FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIC WITH(NOLOCK)   
INNER JOIN {0}LK_{1}_{2}_PURCHORDERDISTLINE LINE WITH(NOLOCK) ON LINE.ORDERREF=FIC.LOGICALREF AND 
FIC.ORDERREF=@ID AND FIC.LOGICALREF!=@ID  
LEFT JOIN #{3}_CONVERTED CON ON CON.ITEMREF=LINE.ITEMREF

--------------------------------------------------QEBUL_OLUNANLAR------------------------

SELECT LINE.ITEMREF,LINE.TRANSFER_AMOUNT,LINE.TRANSFERED_AMOUNT,
ROUND(ISNULL( (LINE.TRANSFERED_AMOUNT / (CASE ISNULL(CON.ICSAYI,0) WHEN 0 THEN 1 ELSE CON.ICSAYI END) *100 ) / 
(LINE.TRANSFER_AMOUNT/(CASE ISNULL(CON.ICSAYI,0) WHEN 0 THEN 1 ELSE CON.ICSAYI END)),0),2) PERCENT_,ISNULL(ICSAYI,1) ICSAYI, 
ISNULL(CAST((LINE.TRANSFERED_AMOUNT / ISNULL(CON.ICSAYI,1)) AS INT),0) TOPLANAN_TAM,
ISNULL(CAST(LINE.TRANSFERED_AMOUNT AS INT) % CAST(ISNULL(CON.ICSAYI,1) AS INT),0) TOPLANAN_QALIQ,0 ARTIQLAR
INTO #{3}_TRANSFERRED 
FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIC WITH(NOLOCK)
INNER JOIN {0}LK_{1}_{2}_PURCHORDERDISTLINE LINE WITH(NOLOCK) ON LINE.ORDERREF=FIC.LOGICALREF AND 
FIC.LOGICALREF=@ID 
AND TRANSFERED_AMOUNT<>0
LEFT JOIN #{3}_CONVERTED CON ON CON.ITEMREF=LINE.ITEMREF
------------------------------------------------------------------------------------------

-------------------------------------------------FAIZ CIXILIR-----------------------------

UPDATE #{3}_TEMPLINES SET CONVERTED_AMOUNT=FLOOR(((LINE.CONVERTED_AMOUNT) *
(CASE WHEN ISNULL(PERCENT_,0)>100 THEN 100 WHEN ISNULL(PERCENT_,0)<0 THEN 0 ELSE ISNULL(PERCENT_,0) END))/100)  
FROM #{3}_TEMPLINES LINE 
LEFT JOIN #{3}_TRANSFERRED TRANSFERRED ON LINE.ITEMREF=TRANSFERRED.ITEMREF AND LINE.ITEMREF=TRANSFERRED.ITEMREF



---------------------------------UMUMI TOPLANAN-----------------------------------------
SELECT ITEMREF,SUM(CONVERTED_AMOUNT) TOPLAM INTO #{3}_TEMPQALIQ FROM #{3}_TEMPLINES GROUP BY ITEMREF

---------------------------------ARTIQLAR SUTUNUNU DUZELDIRIK
UPDATE #{3}_TRANSFERRED SET ARTIQLAR=TOPLANAN_TAM - ISNULL(LINE.TOPLAM,0)
FROM #{3}_TRANSFERRED TRANSFERRED LEFT JOIN #{3}_TEMPQALIQ LINE ON LINE.ITEMREF=TRANSFERRED.ITEMREF AND LINE.ITEMREF=TRANSFERRED.ITEMREF   
   
-------------------------------------------------------------------------------------------
-----------------------------------------------------QEBUL OLUNMAMISLARI SIFIRLAYIR----------------------------------

UPDATE #{3}_TEMPLINES SET AMOUNT=TRANSFER_AMOUNT WHERE ITEMREF NOT IN (SELECT ITEMREF FROM #{3}_TRANSFERRED)

-----------------------------------------------------MIQDAR GERIYE CONVERT OLUNUR----------------------------------

UPDATE #{3}_TEMPLINES SET AMOUNT=ISNULL(LINE.CONVERTED_AMOUNT*TRANSFERRED.ICSAYI,0)
			FROM #{3}_TEMPLINES LINE 
			LEFT JOIN #{3}_TRANSFERRED TRANSFERRED ON LINE.ITEMREF=TRANSFERRED.ITEMREF AND LINE.ITEMREF=TRANSFERRED.ITEMREF 

---------------------------------------------------ESKIKLER DUZELDILIR------------------------------------------

DECLARE @ITEMREF INT,
        @DECLARED FLOAT,
		@TRANSFERRED FLOAT,
		@TRANSFERRED_TOTAL FLOAT,
		@ICSAYI FLOAT,
		@ARTIQ FLOAT;
DECLARE UPDATER CURSOR 

    FOR SELECT ITEMREF,ARTIQLAR,TOPLANAN_QALIQ,ICSAYI FROM #{3}_TRANSFERRED WHERE (ARTIQLAR>0) OR (TOPLANAN_QALIQ>0)
	OPEN UPDATER
	FETCH NEXT FROM UPDATER INTO @ITEMREF,@TRANSFERRED,@ARTIQ,@ICSAYI
	WHILE @@FETCH_STATUS = 0
		                                                   BEGIN

IF(@TRANSFERRED>0)
  BEGIN
		SET @TRANSFERRED_TOTAL=0;
		WHILE(@TRANSFERRED>@TRANSFERRED_TOTAL)
			BEGIN
			UPDATE #{3}_TEMPLINES SET AMOUNT+=@ICSAYI WHERE LOGICALREF IN 
			(SELECT TOP 1 LOGICALREF FROM #{3}_TEMPLINES WHERE ITEMREF=@ITEMREF AND (TRANSFER_AMOUNT/ICSAYI)>AMOUNT/ICSAYI ORDER BY LOGICALREF)
			SET @TRANSFERRED_TOTAL+=1;
			END
			PRINT @TRANSFERRED
						
  END

IF(@ARTIQ>0)
BEGIN
		
	UPDATE #{3}_TEMPLINES SET AMOUNT+=@ARTIQ WHERE LOGICALREF IN 
	(SELECT TOP 1 LOGICALREF FROM #{3}_TEMPLINES WHERE ITEMREF=@ITEMREF AND (TRANSFER_AMOUNT/ICSAYI)>AMOUNT/ICSAYI ORDER BY LOGICALREF)			
	--PRINT @ARTIQ		
END

													 FETCH NEXT FROM UPDATER INTO @ITEMREF,@TRANSFERRED,@ARTIQ,@ICSAYI
															 END 
CLOSE UPDATER
DEALLOCATE UPDATER


UPDATE {0}LK_{1}_{2}_PURCHORDERDISTLINE SET TRANSFERED_AMOUNT=ROUND(LINE.TRANSFER_AMOUNT-TEMP.AMOUNT,0) FROM
{0}LK_{1}_{2}_PURCHORDERDISTLINE LINE INNER JOIN #{3}_TEMPLINES TEMP ON TEMP.LOGICALREF=LINE.LOGICALREF





                            ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserId, row["LOGICALREF"]);

            splashScreenManager1.ShowWaitForm();
            try
            {
                var conn = new SqlConnection(Variables.TigerConnection);
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, @"Səhf!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            splashScreenManager1.CloseWaitForm();

        }

        private void showOnPivot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            var row = view.GetFocusedDataRow();
            if (row == null) return;
            PivotGridForOrderGroup pv = new PivotGridForOrderGroup
            {
                pivotGrid =
                {
                    DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection,string.Format(@"
                            SELECT FIC.DESTINDEX WHOUSE,LINE.TRANSFER_AMOUNT-LINE.TRANSFERED_AMOUNT AMOUNT,ITEM.NAME,BARCODE.BARCODE BARCODE
                            FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIC WITH(NOLOCK)   
                            INNER JOIN {0}LK_{1}_{2}_PURCHORDERDISTLINE LINE WITH(NOLOCK) ON LINE.ORDERREF=FIC.LOGICALREF AND 
                            FIC.ORDERREF={3} AND FIC.LOGICALREF!={3}
                            INNER JOIN {0}LG_{1}_ITEMS ITEM ON ITEM.LOGICALREF=LINE.ITEMREF 
                            INNER JOIN {0}LG_{1}_UNITBARCODE BARCODE ON BARCODE.ITEMREF=LINE.ITEMREF AND BARCODE.LINENR=1
                       ",Variables.FirmDb,Variables.FirmNr,Variables.FirmPeriod,row["LOGICALREF"]))
                }
               ,
                Text = @"Qrup № "+ row["LOGICALREF"]
            };
            pv.pivotGrid.BestFit();
            pv.ShowDialog();
        }

        private void OrderGroups_Load(object sender, EventArgs e)
        {
            _desginTable = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                 @"SELECT  ID,TYPE,TEMPLATE,NAME,DESIGNEDFOR FROM ERP_REPORTTEMPLATES WHERE TYPE IN(8,9)");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = view.GetFocusedRow();
            if (row == null) return;

            DataRowView dr = (DataRowView)row;
            var id = dr["LOGICALREF"];
            string command1 =
                string.Format(@" SELECT FIS.LOGICALREF,FIS.STATUS,CAST(FIS.DATE_ AS DATE) DATE_,FIS.ORDERREF,
                    CAST((CASE ISNULL(FIS.ORDERREF,0) WHEN 0 THEN 0 ELSE 1 END) AS BIT) GROUPPED,
                    FIS.SOURCEBRANCH,DIV1.NAME SOURCEBRANCHNAME,FIS.SOURCEINDEX,WHOUSE1.NAME SOURCEINDEXNAME,
                    FIS.DESTBRANCH,DIV2.NAME DESTBRANCHNAME,FIS.DESTINDEX,WHOUSE2.NAME DESTINDEXNAME ,USERNAME='{3}'
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} AND
                    LTRIM(RTRIM(FIS.EXPLANATION))='1'
                    WHERE FIS.LOGICALREF={4}",
                    Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, id);
            string command2 = string.Format(@"SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,
                    ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,45) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME UNITCODE  
                    FROM  {0}LK_{1}_{2}_PURCHORDERDISTLINE STL WITH (NOLOCK) 
                    INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.ITEMREF=ITEM.LOGICALREF 
                    LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UNITSETREF=SELT.UNITSETREF AND SELT.LINENR=1    
                    LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
                    WHERE STL.ORDERREF={3} ",
                Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, id);
            string command3 = string.Format(@" SELECT FIS.LOGICALREF,CAST(FIS.DATE_ AS DATE) DATE_,FIS.ORDERREF,
                    FIS.SOURCEBRANCH,DIV1.NAME SOURCEBRANCHNAME,FIS.SOURCEINDEX,WHOUSE1.NAME SOURCEINDEXNAME,
                    FIS.DESTBRANCH,DIV2.NAME DESTBRANCHNAME,FIS.DESTINDEX,WHOUSE2.NAME DESTINDEXNAME ,USERNAME='{3}'
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} AND
                    LTRIM(RTRIM(FIS.EXPLANATION))='0'
                    WHERE FIS.ORDERREF={4} ;",
                Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, id);
            string command4 = string.Format(@"
                            SELECT FIC.DESTINDEX WHOUSE,LINE.TRANSFER_AMOUNT-LINE.TRANSFERED_AMOUNT AMOUNT,ITEM.NAME,BARCODE.BARCODE BARCODE
                            FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIC WITH(NOLOCK)   
                            INNER JOIN {0}LK_{1}_{2}_PURCHORDERDISTLINE LINE WITH(NOLOCK) ON LINE.ORDERREF=FIC.LOGICALREF AND 
                            FIC.ORDERREF={3} AND FIC.LOGICALREF!={3}
                            INNER JOIN {0}LG_{1}_ITEMS ITEM ON ITEM.LOGICALREF=LINE.ITEMREF 
                            INNER JOIN {0}LG_{1}_UNITBARCODE BARCODE ON BARCODE.ITEMREF=LINE.ITEMREF AND BARCODE.LINENR=1 ;
                       ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, id);
            try
            {
                splashScreenManager1.ShowWaitForm();
                var report = GetReport("0", "9");
                if (report == null)
                {
                    XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2 + command3 + command4);
                ds.Tables[0].TableName = "MASTER";
                ds.Tables[1].TableName = "DETAIL";
                ds.Tables[2].TableName = "DETAIL_OFF";
                report.DataSource = ds;
                report.CreateDocument();
                var reporting = new Designs.Reporting(report)
                {
                    Text = @"Çap Forması - Anbar Sifariş № " + id,
                    Name = $"{report.Name}_{id}"
                };
                Variables.MForm.OpenOrBringToFront(reporting);


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

        private void EditPopUpBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e){
            var row = view.GetFocusedDataRow();
            if (row == null) return;

            if (bool.Parse(row["GROUPPED"].ToString()))
            {
                XtraMessageBox.Show("Qrup artıq təsdiqlənib!", "Diqqət", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            NewOrderGroup newgGroup = new NewOrderGroup(false);


            //CIXIS
            newgGroup.DestBranchLookUp.Properties.NullText = newgGroup.DestBranchLookUp.Text = row["SOURCEBRANCH"].ToString();
           

            if (User.WhouseIn.Select("DIVISNR=" + row["SOURCEBRANCH"]).Any())
            {
                var dr = User.WhouseIn.Select("DIVISNR=" + row["SOURCEBRANCH"]).CopyToDataTable();

                newgGroup.DestWhouseLookUp.Properties.DataSource = dr;
                newgGroup.DestWhouseLookUp.Refresh();
                newgGroup.DestWhouseLookUp.Properties.NullText = 
                    newgGroup.DestWhouseLookUp.Text = row["SOURCEINDEX"].ToString();
                newgGroup.DestWhouseLookUp.Refresh();
             
            }
            else
            {
                newgGroup.DestBranchLookUp.Properties.DataSource = null;
            }

            newgGroup.DestBranchLookUp.SelectionLength = newgGroup.DestWhouseLookUp.SelectionLength = 0;

            /////////////GIRIS//////////////
            newgGroup.SourceBranchCmbx.Properties.NullText = newgGroup.SourceBranchCmbx.Text = row["DESTBRANCH"].ToString();

            if (User.WhouseOut.Select("DIVISNR=" + row["DESTBRANCH"]).Any())
            {
                var dr = User.WhouseOut.Select("DIVISNR=" + row["DESTBRANCH"]).CopyToDataTable();

                newgGroup.SourceWhouseCmbx.Properties.DataSource = dr;
                newgGroup.SourceWhouseCmbx.Refresh();
                newgGroup.SourceWhouseCmbx.Properties.NullText =
                    newgGroup.SourceWhouseCmbx.Text = row["DESTINDEX"].ToString();
                newgGroup.SourceWhouseCmbx.Refresh();
            }
            else
            {
                newgGroup.SourceWhouseCmbx.Properties.DataSource = null;
            }

            newgGroup.SourceBranchCmbx.SelectionLength = newgGroup.SourceWhouseCmbx.SelectionLength = 0;


            newgGroup.Id = row["LOGICALREF"].ToString();
            if (newgGroup.ShowDialog() == DialogResult.OK)
                SearchBtn.PerformClick();

        }
    }
}

    
