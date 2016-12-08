using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ERP.Designs;
using ERP.General;

namespace ERP.Logistcs
{
    public partial class WhouseOrders : XtraForm
    {
        private readonly MainForm _mainForm = Variables.MForm;
        private DataTable _desginTable;
        public WhouseOrders()
        {
            InitializeComponent();
        }
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
        public WhouseOrders(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = Variables.MForm;
            branchCmbx.Properties.DataSource = User.BranchIn;
            SourceBranchCmbx.Properties.DataSource = User.BranchOut;
            whouseCmbx.Properties.DataSource = User.WhouseIn;
            SourceIndexCmbx.Properties.DataSource = User.WhouseOut;
            BegDate.DateTime = EndDate.DateTime = DateTime.Now;
        }

        public void LoadPermissions()
        {
            if (User.IsAdmin) return;
            NewBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.1.1'").Any();
            ModifyBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.1.2'").Any();
            DeleteBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.1.3'").Any();
        }

        readonly string _query = string.Format(@"               
                    SELECT FIS.LOGICALREF,FIS.STATUS,FIS.DATE_ ,FIS.ORDERREF,
                    CAST((CASE ISNULL(FIS.ORDERREF,0) WHEN 0 THEN 0 ELSE 1 END) AS BIT) GROUPPED,
                    FIS.SOURCEBRANCH,DIV1.NAME DIVNAME1,FIS.SOURCEINDEX,WHOUSE1.NAME WHOUSENAME1,
                    FIS.DESTBRANCH,DIV2.NAME DIVNAME2,FIS.DESTINDEX,WHOUSE2.NAME WHOUSENAME2 
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} WHERE FIS.FICHETYPE=1 AND LTRIM(RTRIM(FIS.EXPLANATION))='0'
                        ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod);
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            if (dateChbx.Checked)
                query +=
                    $" AND CAST(FIS.DATE_ AS DATE) BETWEEN '{BegDate.DateTime.ToString("yyyy-MM-dd")}' AND '{EndDate.DateTime.ToString("yyyy-MM-dd")}' ";

            var temp = Functions.GetCheckedComboboxValue(branchCmbx, branchChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Iş yeri seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += $" AND FIS.DESTBRANCH IN ({temp})";

            temp = Functions.GetCheckedComboboxValue(whouseCmbx, WhouseChbx.Checked);

            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Anbar seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            query += $" AND FIS.DESTINDEX IN ({temp}) ";


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

            query += string.Format(" AND FIS.SOURCEINDEX IN ({0}) ", temp);

            DataSet ds = Functions.GetSqlServerDataset(Variables.TigerConnection, _query + query);
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
            _mainForm.OpenOrBringToFront( new NewWhouseOrder());
        }
        private void view_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (view != null)
                {
                    string requested = view.GetRowCellDisplayText(e.RowHandle, view.Columns["GROUPPED"]);
                    if (requested.Trim() == "Checked")
                    {
                        e.Appearance.BackColor = Color.CadetBlue;
                       
                    }
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var row = view.GetFocusedRow();
            if (row != null)
            {
                DataRowView dr = (DataRowView)row;
                if (bool.Parse(dr["GROUPPED"].ToString()))
                {
                    XtraMessageBox.Show("Qruplanmış sifarış üzərində əməliyyat etmək olmaz!", "Diqqət", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }
              
                var id = dr["LOGICALREF"];

                if (XtraMessageBox.Show(id + " Nömrəli sifariş ləğv olunacaq. Davam edirsiz?", "Diqqət",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Functions.ExecuteStatement(Variables.TigerConnection,
                        string.Format("UPDATE {0}LK_{1}_{2}_PURCHORDERDISTFICHE SET FICHETYPE=10,CHANGEUSER={3},CHANGEDATE=GETDATE() WHERE LOGICALREF={4}", Variables.FirmDb,
                            Variables.FirmNr, Variables.FirmPeriod, User.UserId,id));
                }
                SearchBtn.PerformClick();}
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {

            var row = view.GetFocusedRow();
            if (row == null)return;
           
                DataRowView dr = (DataRowView) row;
                var id = dr["LOGICALREF"];
                string command1 = string.Format(@" SELECT FIS.LOGICALREF,FIS.STATUS,CAST(FIS.DATE_ AS DATE) DATE_,FIS.ORDERREF,
                    CAST((CASE ISNULL(FIS.ORDERREF,0) WHEN 0 THEN 0 ELSE 1 END) AS BIT) GROUPPED,
                    FIS.SOURCEBRANCH,DIV1.NAME SOURCEBRANCHNAME,FIS.SOURCEINDEX,WHOUSE1.NAME SOURCEINDEXNAME,
                    FIS.DESTBRANCH,DIV2.NAME DESTBRANCHNAME,FIS.DESTINDEX,WHOUSE2.NAME DESTINDEXNAME ,USERNAME='{3}'
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} WHERE FIS.LOGICALREF={4}",
                    Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, User.UserName, id);
                string command2 = string.Format(@" SELECT ROW_NUMBER() OVER(ORDER BY STL.LOGICALREF) ROWNR ,
                                ITEM.CODE ,UNIT.BARCODE,LEFT(ITEM.NAME,45) NAME, ROUND(STL.TRANSFER_AMOUNT-STL.TRANSFERED_AMOUNT,4) AMOUNT,SELT.NAME UNITCODE  
                                FROM  {0}LK_{1}_{2}_PURCHORDERDISTLINE STL WITH (NOLOCK) 
                                INNER JOIN {0}LG_{1}_ITEMS ITEM ON STL.ITEMREF=ITEM.LOGICALREF 
                                LEFT JOIN {0}LG_{1}_UNITSETL SELT ON  STL.UNITSETREF=SELT.UNITSETREF AND SELT.LINENR=1    
                                LEFT JOIN {0}LG_{1}_UNITBARCODE UNIT ON  ITEM.LOGICALREF=UNIT.ITEMREF AND UNIT.UNITLINEREF=SELT.LOGICALREF AND UNIT.LINENR=1   
                                WHERE STL.ORDERREF={3}",
                   Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, id);
            try
            {
             
                var report = GetReport("0", "7");
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
          
           
        }

        private void WhouseOrders_Load(object sender, EventArgs e)
        {
            _desginTable = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                 @"SELECT  ID,TYPE,TEMPLATE,NAME,DESIGNEDFOR FROM ERP_REPORTTEMPLATES WHERE TYPE IN(7)");
        }
    }
}