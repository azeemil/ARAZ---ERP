using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ERP.General;

namespace ERP.Logistcs
{
    public partial class NewWhouseOrder : XtraForm
    {
        public NewWhouseOrder()
        {
            InitializeComponent();
            DestBranchLookUp.Properties.DataSource = User.BranchOut;
            SourceBranchCmbx.Properties.DataSource = User.BranchIn;
            grid.DataSource = _orderTable;
            progress.Hide();
        }

        private Thread _thread;
        private DataTable _orderTable = new DataTable();



        private void BranchLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (DestBranchLookUp.Text.Trim().Length > 0)
            {
                var datarow = (DataRowView) DestBranchLookUp.GetSelectedDataRow();
                if (User.WhouseOut.Select("DIVISNR=" + datarow["NR"]).Any())
                {
                    var dr = User.WhouseOut.Select("DIVISNR=" + datarow["NR"]).CopyToDataTable();

                    DestWhouseLookUp.Properties.DataSource = dr;
                    DestWhouseLookUp.ItemIndex = 0;
                }
                else
                {
                    DestWhouseLookUp.Properties.DataSource = null;
                }
            }
        }

        private void SourceWhouseCmbx_EditValueChanged(object sender, EventArgs e)
        {
            if (SourceBranchCmbx.Text.Trim().Length > 0)
            {
                var datarow = (DataRowView) SourceBranchCmbx.GetSelectedDataRow();
                if (User.WhouseIn.Select("DIVISNR=" + datarow["NR"]).Any())
                {
                    var dr = User.WhouseIn.Select("DIVISNR=" + datarow["NR"]).CopyToDataTable();

                    SourceWhouseCmbx.Properties.DataSource = dr;
                    SourceWhouseCmbx.ItemIndex = 0;
                }
                else
                {
                    SourceWhouseCmbx.Properties.DataSource = null;
                }
            }
        }

        private bool _closeMode;

        #region query

        private string GetQuery()
        {
            return string.Format(
                @"
    SET ROWCOUNT 0
DECLARE 
        @GERIYE_GUN INT,
		@SIFARIS_GUN INT,
		@DATE DATE,
		@DATE_B DATE,
		@DATE_S DATE,
		@D DATE,
		@COUNTER INT,
		@MARKET SMALLINT,
		@AMBAR SMALLINT		
		SET @MARKET = {6}
		SET @AMBAR = {7}
		SET @GERIYE_GUN={4}
		SET @SIFARIS_GUN={5}
		SET @COUNTER=0		
		SET @DATE=CAST(GETDATE() AS DATE)
		SET @DATE_B=DATEADD(DAY,-(@GERIYE_GUN),GETDATE())
		SET @DATE_S=DATEADD(DAY,-(1),GETDATE())	  
  IF OBJECT_ID ('TEMPDB..#T_{3}SATIS') IS NOT NULL DROP TABLE #T_{3}SATIS
  IF OBJECT_ID ('TEMPDB..#T_{3}STOK') IS NOT NULL DROP TABLE #T_{3}STOK
  IF OBJECT_ID ('TEMPDB..#T_{3}STOK_AMBAR') IS NOT NULL DROP TABLE #T_{3}STOK_AMBAR
  IF OBJECT_ID ('TEMPDB..#T_{3}AMBAR_REZERV') IS NOT NULL DROP TABLE #T_{3}AMBAR_REZERV
  IF OBJECT_ID ('TEMPDB..#T_{3}BAGLANMAMIS_SIFARIS') IS NOT NULL DROP TABLE #T_{3}BAGLANMAMIS_SIFARIS
  IF OBJECT_ID ('TEMPDB..#T_{3}ITEMS') IS NOT NULL DROP TABLE #T_{3}ITEMS 
 
 --- AMBAR STOKU
 SELECT  INVENNO SOURCEINDEX,STOCKREF,ROUND(SUM(ONHAND),2) STOK  INTO #T_{3}STOK_AMBAR  FROM {0}LV_{1}_{2}_STINVTOT  
 WHERE INVENNO=@AMBAR
 GROUP BY STOCKREF,INVENNO
 HAVING ROUND(SUM(ONHAND),2)>0
 --- AMBAR REZERV
 SELECT DTL.ITEMREF,SUM(DTL.AMOUNT) REZERV INTO #T_{3}AMBAR_REZERV FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE MST WITH(NOLOCK) 
 INNER JOIN {0}LK_{1}_{2}_PURCHORDERDISTLINE DTL WITH(NOLOCK) ON DTL.ORDERREF=MST.LOGICALREF 
 WHERE MST.SOURCEINDEX=@AMBAR AND MST.FICHETYPE=1 AND DTL.ITEMREF IN (SELECT STOCKREF FROM #T_{3}STOK_AMBAR) AND MST.STATUS in (0,1)
 GROUP BY DTL.ITEMREF
 --- BAGLANMAMIS SIFARIS
 SELECT DTL.ITEMREF,SUM(DTL.AMOUNT) SIFARIS INTO #T_{3}BAGLANMAMIS_SIFARIS FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE MST WITH(NOLOCK) 
 INNER JOIN {0}LK_{1}_{2}_PURCHORDERDISTLINE DTL WITH(NOLOCK) ON DTL.ORDERREF=MST.LOGICALREF 
 WHERE MST.DESTBRANCH=@MARKET AND MST.STATUS IN (0,1) AND DTL.ITEMREF IN (SELECT STOCKREF FROM #T_{3}STOK_AMBAR) AND MST.FICHETYPE=1
 GROUP BY DTL.ITEMREF
-------------------------------------------------
 CREATE TABLE #T_{3}STOK
  (
  SOURCEINDEX SMALLINT,
  STOCKREF INT,
  AMOUNT FLOAT 
  )  
INSERT INTO #T_{3}STOK
SELECT  INVENNO ,STOCKREF,ROUND(SUM(ONHAND),2) FROM {0}LV_{1}_{2}_STINVTOT
WHERE STOCKREF IN (SELECT STOCKREF FROM #T_{3}STOK_AMBAR) AND INVENNO = @MARKET
GROUP BY INVENNO,STOCKREF
ORDER BY INVENNO,STOCKREF		
 CREATE TABLE #T_{3}SATIS
  (
  SOURCEINDEX SMALLINT,
  STOCKREF INT,
  AMOUNT FLOAT DEFAULT 0, 
  DATE_  DATE
  )
INSERT INTO #T_{3}SATIS
SELECT SOURCEINDEX,STOCKREF,SUM(AMOUNT) AMOUNT,CAST(DATE_ AS DATE) DATE_ 
FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK)
WHERE (DATE_ BETWEEN @DATE_B AND @DATE_S) AND TRCODE=7 AND STOCKREF IN (SELECT STOCKREF FROM #T_{3}STOK_AMBAR) AND STL.SOURCEINDEX = @MARKET
GROUP BY SOURCEINDEX,STOCKREF,CAST(DATE_ AS DATE)
---------------------------------
IF OBJECT_ID ('TEMPDB..#T_{3}TEMP') IS NOT NULL DROP TABLE #T_{3}TEMP
CREATE TABLE #T_{3}TEMP
 (
 SOURCEINDEX SMALLINT,
 STOCKREF INT,
 AMOUNT FLOAT,
 DATE_ DATE 
 )

   
IF OBJECT_ID ('TEMPDB..#T_{3}TEMP2') IS NOT NULL DROP TABLE #T_{3}TEMP2
 CREATE TABLE #T_{3}TEMP2
 (
 SOURCEINDEX SMALLINT,
 STOCKREF INT,
 AMOUNT FLOAT
 )

    INSERT INTO #T_{3}TEMP2
    SELECT SOURCEINDEX,STOCKREF,SUM(AMOUNT) FROM #T_{3}SATIS 
	GROUP BY SOURCEINDEX,STOCKREF
	SET @COUNTER=0    
         WHILE (@COUNTER<@GERIYE_GUN)
		 BEGIN		  
		 SET @D=(CAST(DATEADD(DAY,@COUNTER,@DATE_B) AS DATE))		
		 INSERT INTO #T_{3}TEMP		
		 SELECT *,@D FROM #T_{3}TEMP2  
		 SET @COUNTER=@COUNTER+1
		 END;	 	  												  
                
		IF OBJECT_ID ('TEMPDB..#T_{3}NETICE') IS NOT NULL DROP TABLE #T_{3}NETICE
		IF OBJECT_ID ('TEMPDB..#T_{3}SON') IS NOT NULL DROP TABLE #T_{3}SON
		SELECT T.SOURCEINDEX,T.STOCKREF,AVG(T.AMOUNT) ORTALAMA_SATIS ,SUM(ABS(ISNULL(S.AMOUNT,0)-(T.AMOUNT/@GERIYE_GUN))) KENARLASMA
	    INTO #T_{3}NETICE FROM #T_{3}SATIS S FULL JOIN  #T_{3}TEMP T ON S.SOURCEINDEX=T.SOURCEINDEX AND S.STOCKREF=T.STOCKREF AND T.DATE_=S.DATE_        			
		GROUP BY T.SOURCEINDEX,T.STOCKREF	
			
		
        SELECT  ITEM.CODE ITEMCODE, BARCOD.BARCODE,ITEM.NAME ITEMNAME,CAT.DESCR CATEGORY,SETL.NAME UNITNAME,    
        ISNULL(STOK.AMOUNT,0) STOK,
        ISNULL(A_S.ORTALAMA_SATIS,0) SALE,
        ROUND(ISNULL(KENARLASMA,0),2) KENARLASMA, 
        ROUND((ISNULL(A_S.ORTALAMA_SATIS,0)/@GERIYE_GUN),2) PROGNOZ,  
        FLOOR(ISNULL((CASE WHEN STOK.AMOUNT<0 THEN 0 ELSE STOK.AMOUNT END)/NULLIF(((ROUND((ISNULL(A_S.ORTALAMA_SATIS,0)/@GERIYE_GUN),2))),0),0) ) STOKGUN,  
        ISNULL(A.STOK,0) ANBARSTOKU,
        (CASE WHEN (ISNULL(A.STOK,0)-ISNULL(A_R.REZERV,0))>0 THEN (ISNULL(A.STOK,0)-ISNULL(A_R.REZERV,0)) ELSE 0 END)  SERBESTSTOK,
        ISNULL(B_S.SIFARIS,0) ACIQSIFARIS,         
        FLOOR( ROUND((CASE WHEN ((@SIFARIS_GUN*(ROUND((ISNULL(A_S.ORTALAMA_SATIS,0)/@GERIYE_GUN),2))-
        ROUND((CASE WHEN ISNULL(STOK.AMOUNT,0)<=0 THEN 0 ELSE ISNULL(STOK.AMOUNT,0) END),2)))>0   
        THEN ((@SIFARIS_GUN*(ROUND((ISNULL(A_S.ORTALAMA_SATIS,0)/@GERIYE_GUN),2))-ROUND((CASE WHEN ISNULL(STOK.AMOUNT,0)<=0 THEN 0 ELSE ISNULL(STOK.AMOUNT,0) END),2))) 
        ELSE 0 END),2))  AMOUNT,
        A.STOCKREF ITEMID,SETL.UNITSETREF,SETL.LOGICALREF UNITID,CAT1.DESCR D1,CAT2.DESCR D2,CAT3.DESCR D3 ,
        (CASE  PRC.STATUS WHEN 0 THEN 'Aktiv' ELSE 'Passiv' END) STATUS --,ISNULL(NULLIF(ITMUNITA3.CONVFACT2,0),1)/ISNULL(NULLIF(ITMUNITA3.CONVFACT1,0),1) ICSAYI
		INTO #T_{3}SON
	  
	                       FROM #T_{3}STOK_AMBAR AS A 
                           FULL JOIN #T_{3}NETICE A_S ON A_S.STOCKREF=A.STOCKREF
                           LEFT JOIN #T_{3}STOK STOK ON STOK.SOURCEINDEX=@MARKET AND STOK.STOCKREF=A.STOCKREF					     
						   LEFT JOIN  L_CAPIDIV CAP (NOLOCK) ON CAP.NR=A.SOURCEINDEX AND CAP.FIRMNR={1}
				           INNER JOIN {0}LG_{1}_ITEMS ITEM (NOLOCK) ON ITEM.LOGICALREF=A.STOCKREF AND LEN(ISNULL(ITEM.CODE,0))=6 AND ITEM.CARDTYPE=1
						   LEFT JOIN {0}LG_{1}_UNITSETL SETL (NOLOCK) ON SETL.UNITSETREF=ITEM.UNITSETREF AND SETL.LINENR=1
						   LEFT JOIN {0}LK_{1}_PRCLIST PRC (NOLOCK) ON PRC.STREF=A.STOCKREF AND PRC.OFFICECODE=@MARKET
				           LEFT JOIN {0}LG_{1}_UNITBARCODE BARCOD (NOLOCK) ON BARCOD.ITEMREF=A.STOCKREF AND BARCOD.LINENR=1 AND BARCOD.UNITLINEREF=SETL.LOGICALREF 
						   LEFT JOIN {0}LG_{1}_ITMUNITA ITMUNITA (NOLOCK) ON A.STOCKREF=ITMUNITA.ITEMREF AND ITMUNITA.LINENR=1						   				   
						   LEFT JOIN {0}LK_{1}_{2}_PURCHCATEGORY CAT (NOLOCK) ON CAT.CODE=LEFT(ITEM.STGRPCODE,2)
                           LEFT JOIN {0}LK_{1}_{2}_PURCHCATEGORY CAT1 (NOLOCK) ON CAT1.CODE=LEFT(ITEM.STGRPCODE,7)
                           LEFT JOIN {0}LK_{1}_{2}_PURCHCATEGORY CAT2 (NOLOCK) ON CAT2.CODE=LEFT(ITEM.STGRPCODE,11)
                           LEFT JOIN {0}LK_{1}_{2}_PURCHCATEGORY CAT3 (NOLOCK) ON CAT3.CODE=LEFT(ITEM.STGRPCODE,15)						   
						   LEFT JOIN #T_{3}AMBAR_REZERV A_R ON A_R.ITEMREF=A.STOCKREF
						   LEFT JOIN #T_{3}BAGLANMAMIS_SIFARIS B_S ON B_S.ITEMREF=A.STOCKREF
                           --LEFT JOIN {0}LG_{1}_ITMUNITA ITMUNITA3 (NOLOCK)  ON ITEM.LOGICALREF=ITMUNITA3.ITEMREF  AND ITMUNITA3.LINENR=3
				SELECT T.*,ISNULL(NULLIF(ITMUNITA.CONVFACT2,0),1)/ISNULL(NULLIF(ITMUNITA.CONVFACT1,0),1) ICSAYI, CAST(0 AS FLOAT) RESULT FROM #T_{3}SON T
                LEFT JOIN {0}LG_{1}_UNITSETL SETL2 (NOLOCK) ON SETL2.UNITSETREF=T.UNITSETREF  AND SETL2.CODE='SB'
                LEFT JOIN {0}LG_{1}_ITMUNITA ITMUNITA (NOLOCK)  ON ITEMID=ITMUNITA.ITEMREF  AND ITMUNITA.UNITLINEREF=SETL2.LOGICALREF  
              ORDER BY CATEGORY,ITEMNAME	   

             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserId,
                Convert.ToInt16(calcDayCount.Text), Convert.ToInt16(orderDayCount.Text)
                , SourceWhouseCmbx.Text.Trim(), DestWhouseLookUp.Text.Trim());
        }

        #endregion

        private void Calculate(object sender, EventArgs e)
        {
            if (SourceWhouseCmbx.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Giriş anbar məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (DestWhouseLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Çıxış anbar məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            _thread = new Thread(CalculateOrder) {IsBackground = true};
            _thread.Start();

        }

        private void CalculateOrder()
        {
            Invoke(new Action(() =>
            {
                groupControl3.Enabled = false;
                progress.Show();
            }));
            try
            {
                using (SqlConnection con = new SqlConnection(Variables.TigerConnection))
                {
                    con.Open();
                    SqlCommand com = con.CreateCommand();
                    com.CommandTimeout = 0;
                    com.CommandText = GetQuery();
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    _orderTable = new DataTable();
                    da.Fill(_orderTable);

                    Invoke(new Action(() => { grid.DataSource = _orderTable; }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {

                    XtraMessageBox.Show(string.Format("{0}\n{1}", ex.Message, ex), "Xəta!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }));
            }
            finally
            {
                Invoke(new Action(() =>
                {
                    progress.Hide();
                    gridView1.BestFitColumns();
                    groupControl3.Enabled = true;
                }));
            }

        }

        private void gridView1_CustomDrawRowIndicator(object sender,
            RowIndicatorCustomDrawEventArgs e)
        {

            if (e.Info.Kind == IndicatorKind.Header)
            {
                e.Info.DisplayText = "№";
            }
            else if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();

        }

        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                e.Handled = XtraMessageBox.Show("Seçilmiş sətirlər silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;


            }
            if (e.Button.ButtonType == NavigatorButtonType.Custom)
            {
                if (e.Button.Tag.Equals("1"))
                {

                    SaveFileDialog sv = new SaveFileDialog();
                    sv.AddExtension = true;
                    sv.DefaultExt = "Excel | *.xlsx";
                    sv.Filter = @"Excel | *.xlsx";
                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        if (sv.FileName == string.Empty)
                        {
                            MessageBox.Show(@"Ad boşdur");
                            return;
                        }
                        gridView1.ExportToXlsx(sv.FileName);
                    }
                }
                if (e.Button.Tag.Equals("2"))
                {
                    SetAmount amount = new SetAmount();
                    if (amount.ShowDialog() == DialogResult.OK)
                    {
                        if (XtraMessageBox.Show(
                            string.Format("Seçilmiş sətirlərdə sifariş miqdarı {0} bərabər olacaq\nDavam edirsiz?",
                                amount.amount.Text.Trim()), "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                            DialogResult.Yes) return;

                        if (gridView1.GetSelectedRows().Count() <= 0) return;
                        int[] a = gridView1.GetSelectedRows();
                        for (int i = 0; i < a.Length; i++)
                        {
                            DataRowView row = (DataRowView) gridView1.GetRow(a[i]);
                            row.Row["RESULT"] = amount.amount.Text.Trim();
                            gridView1.RefreshRow(a[i]);
                            gridView1.UnselectRow(a[i]);

                        }


                    }
                    e.Handled = false;
                }
            }
        }



        private void NewPurchOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_closeMode)
                e.Cancel = XtraMessageBox.Show("Etdiyiniz dəyişiklər yadda saxlanılmayıb! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void gridView1_EditFormPrepared(object sender, EditFormPreparedEventArgs e)
        {
            Control ctrl = FindControl(e.Panel, "Update");
            if (ctrl != null)
                ctrl.Text = @"Dəyiş";
            ctrl = FindControl(e.Panel, "Cancel");
            if (ctrl != null)
                ctrl.Text = @"Ləğv Et";



        }

        public Control FindControl(Control root, string text)
        {
            if (root == null) throw new ArgumentNullException("root");
            foreach (Control child in root.Controls)
            {
                if (child.Text == text) return child;
                Control found = FindControl(child, text);
                if (found != null) return found;
            }
            return null;
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (view != null)
                {
                    string requested = view.GetRowCellDisplayText(e.RowHandle, view.Columns["RESULT"]).Trim();
                    if (requested=="0" || requested=="")
                    {e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            if (DestBranchLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Iş Yeri məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (DestWhouseLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Anbar məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!_orderTable.Select("RESULT>0").Any())
            {
                XtraMessageBox.Show("Uyğun material yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            splashScreenManager1.ShowWaitForm();
            SqlConnection conn = new SqlConnection(Variables.ConnectionString);
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            SqlCommand command = new SqlCommand
            {
                Connection = conn,
                Transaction = tran,
                CommandText = string.Format(@"INSERT INTO {0}LK_{1}_{2}_PURCHORDERDISTFICHE  
    (ORDERREF,STATUS,TRANSFER_TYPE,FICHETYPE,EXPLANATION,DATE_,SOURCEBRANCH,DESTBRANCH,SOURCEINDEX,DESTINDEX,RECDATE,RECUSER) 
   VALUES (NULL,0,1,1,0,GETDATE(),{5},{4},{7},{6},GETDATE(),{3}) 
          SELECT SCOPE_IDENTITY()", Variables.FirmDb,
                    Variables.FirmNr, Variables.FirmPeriod, User.UserId, SourceBranchCmbx.Text.Trim(),
                    DestBranchLookUp.Text.Trim()
                    , SourceWhouseCmbx.Text.Trim(), DestWhouseLookUp.Text.Trim()
                    )
            };
            try
            {
                var id = command.ExecuteScalar();
                command.CommandText = string.Format(@"INSERT INTO {0}LK_{1}_{2}_PURCHORDERDISTLINE 
             (ORDERREF,ITEMREF,DIVREF,GENERAL_REMAINDER,TRANSFERED_AMOUNT,TRANSFER_AMOUNT,UNIT_CODE,UNITLINEREF,UNITSETREF,CONVFACT1,CONVFACT2,AMOUNT,SPECODE5)
                 VALUES (@ID,@ITEMREF,@DIVREF,0,0,@AMOUNT,@UNITCODE,@UNITLINEREF,@UNITSETREF,1,1,@AMOUNT,'')",
                    Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod);
                foreach (DataRow row in _orderTable.Select("RESULT>0").CopyToDataTable().Rows)
                {command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@ITEMREF", row["ITEMID"]);
                    command.Parameters.AddWithValue("@DIVREF", SourceBranchCmbx.Text.Trim());
                    command.Parameters.AddWithValue("@AMOUNT", row["RESULT"]);

                    command.Parameters.AddWithValue("@UNITCODE", "");
                    command.Parameters.AddWithValue("@UNITLINEREF", row["UNITID"]);
                    command.Parameters.AddWithValue("@UNITSETREF", row["UNITSETREF"]);
                    command.ExecuteNonQuery();
                }


                tran.Commit();
                XtraMessageBox.Show(string.Format("Sifarişiniz {0} nömrəsi ilə qeydə alındı!", id), "Məlumat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                tran.Rollback();
                XtraMessageBox.Show(ex.Message, "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
                _closeMode = true;
                Close();

            }
        
        }



        private void gridView1_CellValueChanged(object sender,
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRowView row = (DataRowView) gridView1.GetFocusedRow();
            if (row != null)
            {
                if (string.IsNullOrEmpty(e.Value.ToString().Trim()))
                {
                    row.Row["RESULT"] = 0;
                    gridView1.RefreshRow(e.RowHandle);
                    return;
                }
                var value = float.Parse(e.Value.ToString());
                if (value < 0)
                {
                    gridView1.CancelUpdateCurrentRow();
                    alertControl1.Show(this, "Səhf", "Mənfi miqdar daxil etmək olmaz!");
                    return;
                }
                if (value > float.Parse(row.Row["SERBESTSTOK"].ToString()))
                {
                    gridView1.CancelUpdateCurrentRow();
                    alertControl1.Show(this, "Səhf", "Sərbəst stokdan artıq miqdar daxil etmisiniz!");
                    return;

                }

                value = value / float.Parse(row.Row["ICSAYI"].ToString());

                if ((value - Math.Truncate(value)) > 0)
                {
                    gridView1.CancelUpdateCurrentRow();
                    alertControl1.Show(this, "Səhf", "Sifariş miqdarı iç sayına uyğun olmalıdır!");
                }
              
            }

        }

        private void SaveGridViewCustomization_Click(object sender, EventArgs e)
        {
            gridView1.SaveLayoutToRegistry(@"HKEY_CURRENT_USER\Software\AzRetail - ERP\Layouts\WhouseOrders");
            XtraMessageBox.Show("Dizayn yadda saxlanıldı!", "Məlumat!",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NewWhouseOrder_Load(object sender, EventArgs e)
        {
            try
            {
                gridView1.SaveLayoutToStream(str);
                str.Seek(0, System.IO.SeekOrigin.Begin);
                gridView1.RestoreLayoutFromRegistry(@"HKEY_CURRENT_USER\Software\AzRetail - ERP\Layouts\WhouseOrders");
            }
            catch
            {
              
            }
           
        }

        System.IO.Stream str = new System.IO.MemoryStream();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.RestoreLayoutFromStream(str);
            str.Seek(0, System.IO.SeekOrigin.Begin);
        }

        private void LoadLayout_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.RestoreLayoutFromRegistry(@"HKEY_CURRENT_USER\Software\AzRetail - ERP\Layouts\WhouseOrders");
            }
            catch
            {

            }
        }
       

      
    }
}
