using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using ERP.Designs;
using ERP.General;
using ERP.Market;

namespace ERP.Administrator.ReportDesigns
{
    public partial class ReportDesigns : XtraForm
    {
        public ReportDesigns()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ExecuteQuery =$@"INSERT INTO ERP_REPORTTEMPLATES(NAME,[TYPE],TEMPLATE,STATUS,FIRMNR)
                                              VALUES      (@NAME,{typeCmbx.SelectedIndex},@TEMPLATE,1,{Variables.FirmNr})
                                            ";
            Form = new XRDesignForm();
            MdiController = Form.DesignMdiController;

            Form.DesignMdiController.DesignPanelLoaded +=
                DesignMdiController_DesignPanelLoaded;
            Form.OpenReport(new XtraReport {Name = "NewReport",ShowPrintMarginsWarning = false});

            Form.ActiveDesignPanel.SetCommandVisibility(ReportCommand.SaveAll,
              CommandVisibility.None);
            Form.ActiveDesignPanel.SetCommandVisibility(ReportCommand.NewReport,
                CommandVisibility.None);
            Form.ActiveDesignPanel.SetCommandVisibility(ReportCommand.VerbReportWizard,
                CommandVisibility.None);

            MdiController.ActiveDesignPanel.SetCommandVisibility(ReportCommand.Close, CommandVisibility.None);
            splashScreenManager1.CloseWaitForm();
            if (Form.ShowDialog(this) == DialogResult.OK) RefreshGrid();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;

            splashScreenManager1.ShowWaitForm();

            XtraReport newReport;
            string s = row["TEMPLATE"].ToString();


            using (var sw = new StreamWriter(new MemoryStream()))
            {
                sw.Write(s);
                sw.Flush();
                newReport = XtraReport.FromStream(sw.BaseStream, true);
            }
           
            ExecuteQuery = $@"UPDATE ERP_REPORTTEMPLATES
                SET NAME=@NAME,TEMPLATE=@TEMPLATE WHERE ID={row["ID"]}
                                            ";
            Form = new XRDesignForm();
            MdiController = Form.DesignMdiController;


            Form.DesignMdiController.DesignPanelLoaded +=
                DesignMdiController_DesignPanelLoaded;
            Form.OpenReport(newReport);

            Form.ActiveDesignPanel.SetCommandVisibility(ReportCommand.SaveAll,
              CommandVisibility.None);
            Form.ActiveDesignPanel.SetCommandVisibility(ReportCommand.NewReport,
                CommandVisibility.None);
            Form.ActiveDesignPanel.SetCommandVisibility(ReportCommand.VerbReportWizard,
                CommandVisibility.None);
            MdiController.ActiveDesignPanel.SetCommandVisibility(ReportCommand.Close, CommandVisibility.None);
            splashScreenManager1.CloseWaitForm();
            if (Form.ShowDialog(this) == DialogResult.OK) RefreshGrid();
           
           
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            if (XtraMessageBox.Show("Silməyə əminsiz?", "Diqqət",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Functions.ExecuteStatement(Variables.ConnectionString,
                    $"DELETE FROM ERP_REPORTTEMPLATES WHERE ID={row["ID"]} " +
                    $"DELETE FROM ERP_RT_USERPERMISSON WHERE TEMPLATEID={row["ID"]}");
            }
            RefreshGrid();
        }
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            Functions.GetSqlServerDataTable(Variables.ConnectionString, $@"
     INSERT INTO ERP_REPORTTEMPLATES (FIRMNR,NAME,TEMPLATE,TYPE,STATUS)
     SELECT FIRMNR,SUBSTRING(NAME+'_Kopya',0,20),TEMPLATE,TYPE,STATUS FROM ERP_REPORTTEMPLATES WHERE FIRMNR={Variables.FirmNr} AND ID={row["ID"]}");
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            gridControl1.DataSource =
                Functions.GetSqlServerDataTable(connectionString: Variables.ConnectionString,
                    sqlStatement: $"SELECT ID,NAME,TEMPLATE,TYPE,STATUS,DESIGNEDFOR FROM ERP_REPORTTEMPLATES WHERE FIRMNR={Variables.FirmNr} AND TYPE={typeCmbx.SelectedIndex}");
        }


        public static XRDesignForm Form;
        public XRDesignMdiController MdiController;
        public static string ExecuteQuery;
        #region

        public DataSet GetDataSource()
        {
            DataSet ds = new DataSet();
            switch (typeCmbx.SelectedIndex)
            {
                #region Etiket dizayni
                case 0:
                {
                        var dt = new DataTable("ItemList");
                        dt.Columns.Add("BRANCH", typeof(int));
                        dt.Columns.Add("CODE", typeof(string));
                        dt.Columns.Add("NAME", typeof(string));
                        dt.Columns.Add("BARCODE", typeof(string));
                        dt.Columns.Add("UNITNAME", typeof(string));
                        dt.Columns.Add("PRICE", typeof(float));
                        dt.Columns.Add("PRICE_TAM", typeof(string));
                        dt.Columns.Add("PRICE_KESIR", typeof(string));
                        dt.Rows.Add(0, "555555", "TEST UCUN HAZIRLANMIS METN", "27000001"
                            , "EDED", 325.45f, "325", "45");
                        ds.Tables.Add(dt);
                    }
                    break;
                #endregion
                #region Hediyye dizayni
                case 1:
                {
                    var dt = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                        string.Format(@"
                        SELECT TOP 1 GIFT.ID,GIFT.CREATEDDATE,GIFT.BRANCH, CART.CARTNO,US.USERNAME,GIFT.APPROVED,GIFT.CANCELLED,
                        (CASE GIFT.[TYPE] WHEN 0 THEN N'Verilmə' ELSE N'Qaytarma' END) TYPE,'{2}' NTUSERNAME
                        FROM   {0}LK_{1}_CRMCART CART (NOLOCK)
                        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF 
                        INNER JOIN ERP_CRM_GIFT GIFT ON GIFT.CUSTOMERCARDNO=CART.CARTNO     
                        INNER JOIN ERP_USERS US ON US.ID=GIFT.CREATEDUSER     
                                             ", Variables.FirmDb, Variables.FirmNr,User.UserName));
                   
                      var dtDetail = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                          string.Format(@"
             SELECT CUSTOMER.LOGICALREF,CUSTOMER.NAME,CUSTOMER.SURNAME,IDENT.FATHERNAME,
        IDENT.BIRTHDATE,CARTNO,IDENT.TCNUMBER,
        (CASE IDENT.MARRIED WHEN '0' THEN 'Evli' WHEN '1' THEN 'Subay' ELSE '' END ) MARRIED,
        ADDRES.[ADDRESS],ADDRES.MOBILTEL,
         (CASE PERSONAL.SEX WHEN '0' THEN N'Kişi' WHEN '1' THEN N'Qadın' ELSE '' END) SEX,
         (CASE CUSTOMER.STATUS WHEN 0 THEN 'Aktiv' ELSE 'Passiv' END ) STATUS,PERSONAL.COMPANYDEF,CAST(ISNULL(P.Puan,0) AS INT) PUAN
        FROM       {0}LK_{1}_CRMCART CART (NOLOCK)
        INNER JOIN  {0}LK_{1}_CRMCUSTOMER CUSTOMER (NOLOCK) ON CART.CARTREF=CUSTOMER.LOGICALREF  AND  CART.CARTNO='201401'
        INNER JOIN  {0}LK_{1}_CRMIDENTITY IDENT (NOLOCK) ON IDENT.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN  {0}LK_{1}_CRMADDRESS ADDRES (NOLOCK) ON ADDRES.CARTREF=CUSTOMER.LOGICALREF
        LEFT JOIN  {0}LK_{1}_CRMPERSONAL PERSONAL (NOLOCK) ON PERSONAL.CARTREF=CUSTOMER.LOGICALREF 
        LEFT JOIN inter_puan..INTERBONUS_PUAN P ON P.Cari_kod COLLATE DATABASE_DEFAULT=CARTNO
                                             ", Variables.FirmDb, Variables.FirmNr));

                      var  ItemsTable = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                          string.Format(@"
                 SELECT DTL.ID , ITEM.LOGICALREF ITEMID,
           (SELECT TOP 1 BARCODE FROM {0}LG_{1}_UNITBARCODE BARCODE WHERE BARCODE.ITEMREF=ITEM.LOGICALREF) BARCODE
            ,ITEM.CODE,
            ITEM.NAME, DTL.AMOUNT,DTL.BONUS,DTL.TOTALBONUS         
            FROM             {0}LG_{1}_ITEMS ITEM 
            INNER JOIN  ERP_CRM_GIFTLINES DTL ON ITEM.LOGICALREF=DTL.ITEMID AND DTL.MASTERID={2} 
			ORDER BY DTL.ID
                                      ", Variables.FirmDb, Variables.FirmNr, 0));

                        dt.TableName = "MASTER";
                        dtDetail.TableName = "CUSTOMER";
                        ItemsTable.TableName = "ITEMS";
                        ds.Tables.Add(dt);
                        ds.Tables.Add(dtDetail);
                        ds.Tables.Add(ItemsTable);
                    }
                    break;
                #endregion
                #region Satinalma ve Satis
                case 2:
                    {
                        string command1 = string.Format(@"
SET FMTONLY ON
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
                            ; ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, 0, User.UserName);


                        string command2 = string.Format(@"

SELECT  ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
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
 ORDER BY STL.LOGICALREF ;
SET FMTONLY OFF
                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod);

                        ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2);
                        ds.Tables[0].TableName = "MASTER";
                        ds.Tables[1].TableName = "DETAIL";
                       
                    }
                    break;
                #endregion
                #region Material Hereketleri
                case 3:
                    {
                        string command1 = string.Format(@"
SET FMTONLY ON
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
         LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF                    
                            ; ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, 0, User.UserName);


                        string command2 = string.Format(@"

SELECT STL.LOGICALREF,STL.STFICHEREF,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME], 
ROUND(STL.PRICE,3) PRICE,STL.TOTAL,STL.IOCODE
FROM  {0}LG_{1}_{2}_STLINE STL WITH (NOLOCK) 
INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF AND STL.STFICHEREF=0
LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1 
ORDER BY STL.LOGICALREF;
SET FMTONLY OFF
                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod);

                        ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2);
                        ds.Tables[0].TableName = "MASTER";
                        ds.Tables[1].TableName = "DETAIL";

                    }
                    break;
                #endregion
                #region Alis Satis Sifarisi
                case 6:
                    {

                        string command1 = string.Format(@"
SET FMTONLY ON
SELECT    FIS.FICHENO  , FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CLC.CODE  , 
CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,
CAP.NAME,N'Sifariş' 'TIP',N'{4}' USER_  FROM {0}LG_{1}_{2}_ORFICHE FIS WITH(NOLOCK) 
INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} WHERE FIS.LOGICALREF={3}
                
                             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, 0, User.UserName);


                        string command2 = string.Format(@"
SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,35) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME]  
FROM  {0}LG_{1}_{2}_ORFLINE STL WITH (NOLOCK) 
INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
WHERE STL.ORDFICHEREF ={3} ORDER BY STL.LOGICALREF
SET FMTONLY OFF

                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, 0);

                        ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2);
                        ds.Tables[0].TableName = "MASTER";
                        ds.Tables[1].TableName = "DETAIL";

                    }
                    break;
                #endregion
                #region Anbara Sifaris
                case 7:
                    {

                        string command1 = string.Format(@" SELECT FIS.LOGICALREF,FIS.STATUS,CAST(FIS.DATE_ AS DATE) DATE_,FIS.ORDERREF,
                    CAST((CASE ISNULL(FIS.ORDERREF,0) WHEN 0 THEN 0 ELSE 1 END) AS BIT) GROUPPED,
                    FIS.SOURCEBRANCH,DIV1.NAME SOURCEBRANCHNAME,FIS.SOURCEINDEX,WHOUSE1.NAME SOURCEINDEXNAME,
                    FIS.DESTBRANCH,DIV2.NAME DESTBRANCHNAME,FIS.DESTINDEX,WHOUSE2.NAME DESTINDEXNAME ,USERNAME='{3}'
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} WHERE FIS.LOGICALREF={4}",
                   Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, 0);
                        string command2 = string.Format(@" SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,
                                ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,45) NAME, ROUND(STL.TRANSFER_AMOUNT-STL.TRANSFERED_AMOUNT,4) AMOUNT,SELT.NAME UNITCODE  
                                FROM  {0}LK_{1}_{2}_PURCHORDERDISTLINE STL WITH (NOLOCK) 
                                INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.ITEMREF=ITEM.LOGICALREF 
                                LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UNITSETREF=SELT.UNITSETREF AND SELT.LINENR=1    
                                LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
                                WHERE STL.ORDERREF={3}",
                           Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, 0);

                        ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2);
                        ds.Tables[0].TableName = "MASTER";
                        ds.Tables[1].TableName = "DETAIL";

                    }
                    break;
                #endregion
                #region Anbar Qrupu
                case 8:
                    {

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
                    WHERE FIS.LOGICALREF={4}  ;",
                      Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, 0);
                        string command2 = string.Format(@"SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,
                    ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,45) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME UNITCODE  
                    FROM  {0}LK_{1}_{2}_PURCHORDERDISTLINE STL WITH (NOLOCK) 
                    INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.ITEMREF=ITEM.LOGICALREF 
                    LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UNITSETREF=SELT.UNITSETREF AND SELT.LINENR=1    
                    LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
                    WHERE STL.ORDERREF={3} ;",
                            Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, 0);
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
                            Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, 0);

                        ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2+command3);
                        ds.Tables[0].TableName = "MASTER";
                        ds.Tables[1].TableName = "DETAIL";
                        ds.Tables[2].TableName = "DETAIL_OFF";
                       
                    }
                    break;
                #endregion
                #region Anbar Qrupu Pivotda
                case 9:
                    {

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
                    WHERE FIS.LOGICALREF={4}  ;",
                      Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, 0);
                        string command2 = string.Format(@"SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,
                    ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,45) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME UNITCODE  
                    FROM  {0}LK_{1}_{2}_PURCHORDERDISTLINE STL WITH (NOLOCK) 
                    INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.ITEMREF=ITEM.LOGICALREF 
                    LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UNITSETREF=SELT.UNITSETREF AND SELT.LINENR=1    
                    LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
                    WHERE STL.ORDERREF={3} ;",
                            Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, 0);
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
                            Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, 0);

                        ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2 + command3);
                        ds.Tables[0].TableName = "MASTER";
                        ds.Tables[1].TableName = "DETAIL";
                        ds.Tables[2].TableName = "DETAIL_OFF";

                    }
                    break;
                    #endregion
            }



            return ds;
        }

        private  void DesignMdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
        {

            XRDesignPanel panel = (XRDesignPanel)sender;
            
            var ds = GetDataSource();
            var report = (panel).Report;
            panel.AddCommandHandler(new SaveCommandHandler(panel));
            report.DataSource = ds;
            panel.SetCommandVisibility(ReportCommand.SaveAll,
              CommandVisibility.None);
            panel.SetCommandVisibility(ReportCommand.NewReport,
              CommandVisibility.None);
            var pd = TypeDescriptor.GetProperties(report)["DataSource"];
            pd.SetValue(report, ds);
           
        }
        public class SaveCommandHandler : ICommandHandler
        {
            readonly XRDesignPanel _panel;
            
            public SaveCommandHandler(XRDesignPanel panel)
            {
                _panel = panel;
            }

            public void HandleCommand(ReportCommand command,
            object[] args)
            {
                
                Save();
            }

            // ReSharper disable once RedundantAssignment
            public bool CanHandleCommand(ReportCommand command,ref bool useNextHandler)
            {
                useNextHandler = !(command == ReportCommand.SaveFile ||
                    command == ReportCommand.SaveFileAs);
                return !useNextHandler;
            }

            void Save()
            {
                if (XtraMessageBox.Show("Dəyişikliklər yadda saxlanılacaq.\nDavam edirsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
               
                MemoryStream stream =  new MemoryStream();
               
                _panel.Report.SaveLayout(stream);
                stream.Position = 0;
                using (StreamReader sr = new StreamReader(stream))
                {
                    using (var sqlCommand = new SqlCommand())
                    {
                        string s = sr.ReadToEnd();
                        sqlCommand.CommandText = ExecuteQuery;sqlCommand.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = _panel.Report.DisplayName;
                        sqlCommand.Parameters.Add("@TEMPLATE", SqlDbType.NVarChar).Value = s;
                        Functions.ExecuteStatement(Variables.ConnectionString, sqlCommand);
                    }

                    Form.DialogResult=DialogResult.OK;
                }

                // Commit changes.
               
                _panel.ReportState = ReportState.Saved;
            }

        }

        #endregion

  

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
            }
        }
        private void UserPermissionBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            ReportTamplateUserPermissions userPermissions = new ReportTamplateUserPermissions
            {
                ReportId = int.Parse(row["ID"].ToString())
            };
            userPermissions.RefreshGrid();
            userPermissions.Text = row["NAME"] + @"-Istifadəçi hüquqları";
            userPermissions.Name = "TEMPLATE_" + row["ID"];
            Variables.MForm.OpenOrBringToFront(userPermissions);
        }

        private void typeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void SetDefaultBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            var result = Microsoft.VisualBasic.Interaction.InputBox("Yalnız tam ədəd olmalıdır!", "Daxil Edin", row["DESIGNEDFOR"].ToString());
           
            try
            {
                if (string.IsNullOrEmpty(result)) return;
                var query =
                    $@"UPDATE ERP_REPORTTEMPLATES
                SET DESIGNEDFOR={result} WHERE ID={row["ID"]}";
                Functions.ExecuteStatement(Variables.ConnectionString, query);
                RefreshGrid();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

    
    }
}