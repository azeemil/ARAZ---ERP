using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using ERP.General;
using UnityObjects;

namespace ERP.Purchase
{
    public partial class NewPurchOrder : XtraForm
    {
        public NewPurchOrder()
        {
            InitializeComponent();
            BranchLookUp.Properties.DataSource = General.User.Branch;
           
            grid.DataSource = _orderTable;
            progress.Hide();
        }
        
        private Thread _thread;
        private DataTable _orderTable = new DataTable();

        private void clientNameBtnEdit_ButtonClick(object sender,
            ButtonPressedEventArgs e)
        {
            ClientCards clcard = new ClientCards();if (clcard.ShowDialog() == DialogResult.OK)
            {
                var dr = clcard.gridView1.GetFocusedDataRow();
                clientNameBtnEdit.Text = dr["DEFINITION_"].ToString();
                clientCodeBtnEdit.Text = dr["CODE"].ToString();
            }
        }

        private void BranchLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (BranchLookUp.Text.Trim().Length > 0)
            {
                var datarow = (DataRowView) BranchLookUp.GetSelectedDataRow();
                var dr = General.User.Whouse.Select("DIVISNR=" + datarow["NR"]).CopyToDataTable();
                if (dr.Select().Any())
                {
                    WhouseLookUp.Properties.DataSource = dr;
                    WhouseLookUp.ItemIndex = 0;
                }
                else
                {
                    WhouseLookUp.Properties.DataSource = null;

                }
            }
        }

        private  bool _closeMode = false;
        #region query

        private string GetQuery()
        {
            return string.Format(
                @"
    DECLARE      
        @GERIYE_GUN INT,
		@SIFARIS_GUN INT,
		@DATE DATE,
		@DATE_B DATE,
		@DATE_S DATE,
		@D DATE,
		@COUNTER INT,
		@MARKET SMALLINT,
		@CARI_KODU VARCHAR(20),
		@CL_LOGICALREG INT
		SET @MARKET = {4}
		SET @CARI_KODU='{5}'
		SET @GERIYE_GUN={6}
		SET @SIFARIS_GUN={7}					
		SET @COUNTER=0		
		SET @DATE=CAST(GETDATE() AS DATE)
		SET @DATE_B=DATEADD(DAY,-(@GERIYE_GUN),GETDATE())
		SET @DATE_S=DATEADD(DAY,-(1),GETDATE())	  
  IF OBJECT_ID ('TEMPDB..#SATIS_{3}') IS NOT NULL DROP TABLE #SATIS_{3}
  IF OBJECT_ID ('TEMPDB..#STOK_{3}') IS NOT NULL DROP TABLE #STOK_{3}
  IF OBJECT_ID ('TEMPDB..#ITEMS_{3}') IS NOT NULL DROP TABLE #ITEMS_{3} 
 SET @CL_LOGICALREG=(SELECT LOGICALREF FROM {0}LG_{1}_CLCARD WHERE CODE LIKE @CARI_KODU)
 SELECT LOGICALREF INTO #ITEMS_{3} FROM {0}LG_{1}_ITEMS WHERE LOGICALREF IN 
 (SELECT ITEMREF FROM {0}LG_{1}_SUPPASGN WHERE CLIENTREF=@CL_LOGICALREG)

-------------------------------------------------
 CREATE TABLE #STOK_{3}
  (
  SOURCEINDEX SMALLINT,
  STOCKREF INT,
  AMOUNT FLOAT 
  )  
INSERT INTO #STOK_{3}
SELECT SOURCEINDEX,STOCKREF,ROUND(ISNULL(SUM(CASE WHEN STL.IOCODE IN (1,2) THEN STL.AMOUNT WHEN STL.IOCODE IN (3,4) THEN STL.AMOUNT*(-1) END),0),3) 
FROM {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK) INNER JOIN {0}LG_{1}_ITEMS ITEM ON ITEM.LOGICALREF=STL.STOCKREF 
WHERE STL.STFICHEREF !=0 AND STL.LINETYPE=0 AND ITEM.LOGICALREF IN (SELECT * FROM #ITEMS_{3}) AND STL.SOURCEINDEX = @MARKET
GROUP BY STL.STOCKREF,STL.SOURCEINDEX
ORDER BY SOURCEINDEX,STOCKREF		
 CREATE TABLE #SATIS_{3}  (  SOURCEINDEX SMALLINT,  STOCKREF INT,  AMOUNT FLOAT DEFAULT 0,   DATE_  DATE)
INSERT INTO #SATIS_{3}
SELECT SOURCEINDEX,STOCKREF,SUM(AMOUNT) AMOUNT,CAST(DATE_ AS DATE) DATE_ FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK)
WHERE (DATE_ BETWEEN @DATE_B AND @DATE_S) AND TRCODE=7 AND STOCKREF IN (SELECT * FROM #ITEMS_{3}) AND STL.SOURCEINDEX = @MARKET
GROUP BY SOURCEINDEX,STOCKREF,CAST(DATE_ AS DATE)
---------------------------------
    IF OBJECT_ID ('TEMPDB..#TEMP_{3}') IS NOT NULL DROP TABLE #TEMP_{3}

    CREATE TABLE #TEMP_{3} ( SOURCEINDEX SMALLINT, STOCKREF INT, AMOUNT FLOAT, DATE_ DATE  )   

    IF OBJECT_ID ('TEMPDB..#TEMP_{3}2') IS NOT NULL DROP TABLE #TEMP_{3}2
  
    CREATE TABLE #TEMP_{3}2 ( SOURCEINDEX SMALLINT, STOCKREF INT, AMOUNT FLOAT )
    INSERT INTO #TEMP_{3}2
    SELECT SOURCEINDEX,STOCKREF,SUM(AMOUNT) FROM #SATIS_{3} 	GROUP BY SOURCEINDEX,STOCKREF
	SET @COUNTER=0  WHILE (@COUNTER<@GERIYE_GUN)
	BEGIN		  
	 SET @D=(CAST(DATEADD(DAY,@COUNTER,@DATE_B) AS DATE))		
	 INSERT INTO #TEMP_{3}		
	  SELECT *,@D FROM #TEMP_{3}2  
		 SET @COUNTER=@COUNTER+1
     END;         
		IF OBJECT_ID ('TEMPDB..#NETICE_{3}') IS NOT NULL DROP TABLE #NETICE_{3}
		SELECT T.SOURCEINDEX,T.STOCKREF,AVG(T.AMOUNT) ORTALAMA_SATIS ,SUM(ABS(ISNULL(S.AMOUNT,0)-(T.AMOUNT/@GERIYE_GUN))) KENARLASMA
	    INTO #NETICE_{3} FROM #SATIS_{3} S FULL JOIN  #TEMP_{3} T ON S.SOURCEINDEX=T.SOURCEINDEX AND S.STOCKREF=T.STOCKREF AND T.DATE_=S.DATE_        			
		GROUP BY T.SOURCEINDEX,T.STOCKREF		
		
        SELECT
        ITEM.CODE ITEMCODE,	BARCOD.BARCODE ,
        ITEM.NAME ITEMNAME,CAT.DESCR CATEGORY,	CAT.CODE CATCODE,SETL.NAME UNITNAME,SETL.CODE UNITCODE,
        ISNULL(STOK.AMOUNT,0) STOK,ISNULL(A.ORTALAMA_SATIS,0) SALE
		,
		ROUND((ISNULL(A.ORTALAMA_SATIS,0)/@GERIYE_GUN),2) TOTALSALE, ROUND((ISNULL(A.KENARLASMA,0)/@GERIYE_GUN),2) Kenarlasma
		,
		ROUND((ISNULL(A.ORTALAMA_SATIS,0)/@GERIYE_GUN),2) PROGNOZ 
		,
		FLOOR(ISNULL(STOK.AMOUNT/NULLIF(((ROUND((ISNULL(A.ORTALAMA_SATIS,0)/@GERIYE_GUN),2))),0),0)) STOKGUN 
		,
		ROUND((CASE WHEN ((@SIFARIS_GUN*(ROUND((ISNULL(A.ORTALAMA_SATIS,0)/@GERIYE_GUN),2))-ROUND((case when STOK.AMOUNT<0 then 0 else STOK.AMOUNT end),2)))>0	

		THEN ((@SIFARIS_GUN*(ROUND((ISNULL(A.ORTALAMA_SATIS,0)/@GERIYE_GUN),2))-ROUND((case when STOK.AMOUNT<0 then 0 else STOK.AMOUNT end),2))) ELSE 0 END),2) AMOUNT       		
		,ROUND((CASE WHEN ((@SIFARIS_GUN*(ROUND((ISNULL(A.ORTALAMA_SATIS,0)/@GERIYE_GUN),2))-ROUND((case when STOK.AMOUNT<0 then 0 else STOK.AMOUNT end),2)))>0	
		THEN ((@SIFARIS_GUN*(ROUND((ISNULL(A.ORTALAMA_SATIS,0)/@GERIYE_GUN),2))-ROUND((case when STOK.AMOUNT<0 then 0 else STOK.AMOUNT end),2))) ELSE 0 END),2) RESULT 
	    
		FROM #NETICE_{3}  AS A RIGHT JOIN #STOK_{3} STOK ON STOK.SOURCEINDEX=A.SOURCEINDEX AND STOK.STOCKREF=A.STOCKREF					     
		LEFT JOIN    L_CAPIDIV CAP (NOLOCK) ON CAP.NR=STOK.SOURCEINDEX AND CAP.FIRMNR={1}
		INNER  JOIN {0}LG_{1}_ITEMS ITEM (NOLOCK) ON ITEM.LOGICALREF=ISNULL(STOK.STOCKREF ,A.STOCKREF) AND ITEM.ACTIVE=0 
        LEFT JOIN {0}LG_{1}_UNITSETL SETL (NOLOCK) ON SETL.UNITSETREF=ITEM.UNITSETREF AND SETL.LINENR=1
		INNER  JOIN {0}LK_{1}_PRCLIST PRC (NOLOCK) ON PRC.STREF=STOK.STOCKREF AND PRC.OFFICECODE=STOK.SOURCEINDEX AND PRC.PURCHASABLE=0
		LEFT JOIN {0}LG_{1}_UNITBARCODE BARCOD (NOLOCK) ON BARCOD.ITEMREF=STOK.STOCKREF AND BARCOD.LINENR=1 AND BARCOD.UNITLINEREF=SETL.LOGICALREF      
        LEFT JOIN {0}LG_{1}_ITMUNITA ITMUNITA ON ITMUNITA.ITEMREF=ITEM.LOGICALREF AND ITMUNITA.LINENR=1  AND ITMUNITA.LOGICALREF=BARCOD.ITMUNITAREF		
	    LEFT JOIN {0}LK_{1}_{2}_PURCHCATEGORY CAT (NOLOCK) ON CAT.CODE=LEFT(ITEM.STGRPCODE,2)

             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, General.User.UserId, BranchLookUp.Text,
                clientCodeBtnEdit.Text.Trim(), Convert.ToInt16(calcDayCount.Text), Convert.ToInt16(orderDayCount.Text));
        }

        #endregion

        private void Calculate(object sender, EventArgs e)
        {
            if (clientCodeBtnEdit.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Cari hesab məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (BranchLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Iş Yeri məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (WhouseLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Anbar məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }_thread = new Thread(CalculateOrder) { IsBackground = true };
            _thread.Start();

        }

        private void CalculateOrder()
        {
            Invoke(new Action(() =>
            {
                groupControl3.Enabled = false; progress.Show(); }));
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
                Invoke(new Action(() => { progress.Hide(); gridView1.BestFitColumns(); groupControl3.Enabled = true; }));
            }

        }

        private void gridView1_CustomDrawRowIndicator(object sender,
            RowIndicatorCustomDrawEventArgs e)
        {
            
            if (e.Info.Kind == IndicatorKind.Header)
            {
                e.Info.DisplayText = "№";
            }
            else if (e.RowHandle>=0)
                e.Info.DisplayText = (e.RowHandle+1).ToString();

        }

        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
              e.Handled = XtraMessageBox.Show("Seçilmiş sətirlər silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes ;

              
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
                        if (XtraMessageBox.Show(string.Format("Seçilmiş sətirlərdə sifariş miqdarı {0} bərabər olacaq\nDavam edirsiz?",
                            amount.amount.Text.Trim()), "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                            DialogResult.Yes)return;
                        
                            if (gridView1.GetSelectedRows().Count() <= 0) return;
                            int[] a = gridView1.GetSelectedRows();
                            for (int i = 0; i < a.Length; i++)
                            {
                                DataRowView row = (DataRowView) gridView1.GetRow(a[i]);
                                row.Row["AMOUNT"] = amount.amount.Text.Trim();
                                gridView1.RefreshRow(a[i]);
                                gridView1.UnselectRow(a[i]);
                                
                            }
                      
                      
                    }
                }
            }

        }

        private void NewPurchOrder_Resize(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
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
        public  Control FindControl( Control root, string text)
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

        private void gridView1_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
          
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
                    string requested = view.GetRowCellDisplayText(e.RowHandle, view.Columns["AMOUNT"]);
                    if (requested.Trim() == "0")
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;

                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e){

            if (clientCodeBtnEdit.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Cari hesab məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (BranchLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Iş Yeri məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (WhouseLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Anbar məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!_orderTable.Select("AMOUNT>0").Any())
            {
                XtraMessageBox.Show("Uyğun material yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var app = Variables.UnityApplication;
            if (!app.LoggedIn)
              if (!app.Login("ERP","ERPUSER",int.Parse(Variables.FirmNr),int.Parse(Variables.FirmPeriod)))
            {
                XtraMessageBox.Show(app.GetLastErrorString(), "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            progress.Show();
            Data order = app.NewDataObject(DataObjectType.doPurchOrderSlip);
            order.New();
            order.DataFields.FieldByName("NUMBER").Value = "~";
            order.DataFields.FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            order.DataFields.FieldByName("DATE").Value = DateTime.Now.Date;
            order.DataFields.FieldByName("AUXIL_CODE").Value = "SISTEM";
            order.DataFields.FieldByName("DOC_NUMBER").Value = BranchLookUp.Text +  General.User.UserId + DateTime.Now.ToString("ddMMyyyy") + DateTime.Now.ToString("HHmmss");
            order.DataFields.FieldByName("ARP_CODE").Value = clientCodeBtnEdit.Text;
            order.DataFields.FieldByName("AUXIL_CODE").Value = "SISTEM";
            order.DataFields.FieldByName("DIVISION").Value = BranchLookUp.Text.Trim();
            order.DataFields.FieldByName("SOURCE_WH").Value = WhouseLookUp.Text.Trim();
            order.DataFields.FieldByName("ORDER_STATUS").Value = 4;
            order.DataFields.FieldByName("NOTES1").Value = General.User.UserName;
            order.DataFields.FieldByName("NOTES2").Value = "PROGRAMLASDIRMA";
            order.DataFields.FieldByName("NOTES3").Value = Environment.MachineName;
            order.DataFields.FieldByName("NOTES4").Value = General.User.UserId;
            Lines transaction = order.DataFields.FieldByName("TRANSACTIONS").Lines;
           
            foreach (DataRow row in _orderTable.Select("AMOUNT>0").CopyToDataTable().Rows)
            {
                transaction.AppendLine();
                transaction[(transaction.Count - 1)].FieldByName("TYPE").Value = 0;
                transaction[(transaction.Count - 1)].FieldByName("MASTER_CODE").Value = row["ITEMCODE"].ToString().Trim();
                transaction[(transaction.Count - 1)].FieldByName("QUANTITY").Value = row["AMOUNT"].ToString().Replace(",", ".")
                                  .Trim(); transaction[(transaction.Count - 1)].FieldByName("UNIT_CODE").Value = row["UNITCODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("DIVISION").Value = BranchLookUp.Text.Trim();
                transaction[(transaction.Count - 1)].FieldByName("SOURCE_WH").Value = WhouseLookUp.Text.Trim();
            }
                  string errorMessage = null;
                      if (!order.Post())
                      {

                          if (order.ErrorCode != 0)
                          {

                              errorMessage += string.Format(@" DB Error : ( {0}) - {1}", (order.ErrorCode), order.ErrorDesc);
                          }
                          else if (order.ValidateErrors.Count > 0)
                          {
                              for (int t = 0; t < order.ValidateErrors.Count;t++)
                                  errorMessage += @"XML Error : (" + (order.ValidateErrors[t].ID) + ") - " +
                                                  order.ValidateErrors[t].Error;

                          }

                           XtraMessageBox.Show( (string.IsNullOrEmpty(errorMessage)) ? order.ErrorDesc : errorMessage, "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                           progress.Hide();
                      }
                      else
                      {
                          XtraMessageBox.Show(
                              string.Format("Sifariş sənədi {0} nömrəsi ilə qeydə alındı!",
                                  order.DataFields.FieldByName("NUMBER").Value), "Diqqət", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                           _closeMode = true;
                            Close();

                      }
              
            
        }

        private void SaveGridViewCustomization_Click(object sender, EventArgs e)
        {
            gridView1.SaveLayoutToRegistry(@"HKEY_CURRENT_USER\Software\AzRetail - ERP\Layouts\PurchOrders");
            XtraMessageBox.Show("Dizayn yadda saxlanıldı!", "Məlumat!",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);}

        private void LoadLayout_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.RestoreLayoutFromRegistry(@"HKEY_CURRENT_USER\Software\AzRetail - ERP\Layouts\PurchOrders");
            }
            catch
            {

            }
        }

        private void DefaultLayout_Click(object sender, EventArgs e)
        {
            gridView1.RestoreLayoutFromStream(str);
            str.Seek(0, System.IO.SeekOrigin.Begin);
        }
        System.IO.Stream str = new System.IO.MemoryStream();

        private void NewPurchOrder_Load(object sender, EventArgs e)
        {
            try
            {
                gridView1.SaveLayoutToStream(str);
                str.Seek(0, System.IO.SeekOrigin.Begin);
                gridView1.RestoreLayoutFromRegistry(@"HKEY_CURRENT_USER\Software\AzRetail - ERP\Layouts\PurchOrders");
            }
            catch
            {
            }
        }

       
    }
    
}
