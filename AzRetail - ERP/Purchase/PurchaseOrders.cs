using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ERP.Designs;
using ERP.General;

namespace ERP.Purchase
{
    public partial class PurchaseOrders : XtraForm
    {
        public PurchaseOrders()
        {
            InitializeComponent();
        }


        private MainForm _mainForm;
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
        public PurchaseOrders(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
            branchCmbx.Properties.DataSource = User.Branch;
            whouseCmbx.Properties.DataSource = User.Whouse;
            BegDate.DateTime = EndDate.DateTime = DateTime.Now;
            CheckedChanged(null, null);
            _desginTable = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                 @"SELECT  ID,TYPE,TEMPLATE,NAME,DESIGNEDFOR FROM ERP_REPORTTEMPLATES WHERE TYPE IN(6)");
        }

        private readonly string _query = string.Format(@"
                            IF OBJECT_ID ('TEMPDB..#TEMP_{2}') IS NOT NULL DROP TABLE #TEMP_{2}
                            SELECT  FIS.LOGICALREF, FIS.FICHENO  ,
                            FIS.DOCODE ,FIS.DATE_ ,CLC.CODE  , 
                            CLC.DEFINITION_ ,  FIS.SOURCEINDEX,CAPWH.NAME WHNAME,FIS.BRANCH,CAP.NAME INTO #TEMP_{2} FROM {0}LG_{1}_{3}_ORFICHE FIS WITH(NOLOCK) 
                            INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF AND TRCODE=2
                            INNER JOIN L_CAPIWHOUSE CAPWH ON FIS.SOURCEINDEX=CAPWH.NR AND CAPWH.FIRMNR={1} 
                            INNER JOIN L_CAPIDIV CAP ON FIS.BRANCH=CAP.NR AND CAP.FIRMNR={1} WHERE 1=1 
                        ", Variables.FirmDb, Variables.FirmNr, User.UserId, Variables.FirmPeriod);

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = string.Empty;

            if (dateChbx.Checked)
                query += string.Format(" AND FIS.DATE_ BETWEEN '{0}' AND '{1}' ",
                    BegDate.DateTime.ToString("yyyy-MM-dd"),
                    EndDate.DateTime.ToString("yyyy-MM-dd"));

            var temp = Functions.GetCheckedComboboxValue(branchCmbx, branchChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Iş yeri seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += string.Format(" AND FIS.BRANCH IN ({0})", temp);

            temp = Functions.GetCheckedComboboxValue(whouseCmbx, WhouseChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Anbar seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += string.Format(" AND FIS.SOURCEINDEX IN ({0}) ", temp);
            query += string.Format(@"
                SELECT * FROM  #TEMP_{2} ;               
        --SELECT STL.ORDFICHEREF,STL.LOGICALREF,ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,25) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME]  
       -- FROM  {0}LG_{1}_{3}_ORFLINE STL WITH (NOLOCK) 
        --INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
       -- LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
       -- LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
       -- WHERE STL.ORDFICHEREF IN (SELECT LOGICALREF FROM #TEMP_{2}) ", Variables.FirmDb, Variables.FirmNr, User.UserId,
                Variables.FirmPeriod);

            DataSet ds = Functions.GetSqlServerDataset(Variables.TigerConnection, _query + query);
            //DataColumn keyColumn = ds.Tables[0].Columns["LOGICALREF"];
            //DataColumn foreignKeyColumn = ds.Tables[1].Columns["ORDFICHEREF"];
            //ds.Relations.Add(keyColumn, foreignKeyColumn);
            grid.DataSource = ds.Tables[0];

        }



        private void CheckedChanged(object sender, EventArgs e)
        {
            BegDate.Enabled = EndDate.Enabled = dateChbx.Checked;
            branchCmbx.Enabled = branchChbx.Checked;
            whouseCmbx.Enabled = WhouseChbx.Checked;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenOrBringToFront(new NewPurchOrder());
        }

        private void DetailsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var type = int.Parse(e.Item.Tag.ToString()); 
            if (view.SelectedRowsCount > 0)
            {
                var index = view.GetFocusedRowCellValue("LOGICALREF");
                var text = view.GetFocusedRowCellValue("FICHENO");

                string command1 = string.Format(@"
SELECT    FIS.FICHENO  , FIS.DOCODE ,CONVERT(VARCHAR(12),FIS.DATE_,104) DATE_ ,CLC.CODE  , 
CLC.DEFINITION_ ,  FIS.NETTOTAL , FIS.SOURCEINDEX,
CAP.NAME,N'Sifariş' 'TIP',N'{4}' USER_  FROM {0}LG_{1}_{2}_ORFICHE FIS WITH(NOLOCK) 
INNER JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
INNER JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1} WHERE FIS.LOGICALREF={3} ;
                
                             ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index, User.UserName);


                string command2 = string.Format(@"
SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,35) NAME, ROUND(STL.AMOUNT,4) AMOUNT,SELT.NAME [SELT_NAME]  
FROM  {0}LG_{1}_{2}_ORFLINE STL WITH (NOLOCK) 
INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.STOCKREF=ITEM.LOGICALREF 
LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UOMREF=SELT.LOGICALREF  
LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
WHERE STL.ORDFICHEREF ={3} ORDER BY STL.LOGICALREF

                                                ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, index);

               
              
                if (type == 1)
                {
                    try
                    {
                        splashScreenManager1.ShowWaitForm();
                        OrderDetails detail = new OrderDetails()
                        {
                            Text = @"Sifariş № " + text
                        };
                        detail.Name = $"{detail.Name}_{text}";
                        var ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2);
                        ds.Tables[0].TableName = "MASTER";
                        ds.Tables[1].TableName = "DETAIL";
                        detail.ds = ds;
                        detail.Report = GetReportForDetail("0", "6");
                        Variables.MForm.OpenOrBringToFront(detail);
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
                if (type == 2)
                {
                    try
                    {
                        splashScreenManager1.ShowWaitForm();
                        var report = GetReport("0", "6");
                        if (report == null)
                        {
                            XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var ds = Functions.GetSqlServerDataset(Variables.TigerConnection, command1 + command2);
                        ds.Tables[0].TableName = "MASTER";
                        ds.Tables[1].TableName = "DETAIL";
                        report.DataSource = ds;
                        report.CreateDocument();
                        var reporting = new Reporting(report)
                        {
                            Text = @"Çap Forması - Sifariş № " + text,
                            Name = $"{report.Name}_{text}"
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
            }

        }

        private void grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
            }
        }
    }
}