using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Logistcs
{
    public partial class GroupOrderMembers : XtraForm
    {
        public GroupOrderMembers()
        {
            InitializeComponent();

        }

        public DataRowView Dr;
        public int Id { get; set; }

        private void GroupOrderMembers_Load(object sender, EventArgs e)
        {
            string query = string.Format(@"               
                    SELECT FIS.LOGICALREF,FIS.STATUS,CAST(FIS.DATE_ AS DATE) DATE_,FIS.ORDERREF,
                    CAST((CASE ISNULL(FIS.ORDERREF,0) WHEN 0 THEN 0 ELSE 1 END) AS BIT) GROUPPED,
                    FIS.SOURCEBRANCH,DIV1.NAME DIVNAME1,FIS.SOURCEINDEX,WHOUSE1.NAME WHOUSENAME1,
                    FIS.DESTBRANCH,DIV2.NAME DIVNAME2,FIS.DESTINDEX,WHOUSE2.NAME WHOUSENAME2 
                    FROM {0}LK_{1}_{2}_PURCHORDERDISTFICHE FIS 
                    INNER JOIN L_CAPIDIV DIV1 ON DIV1.NR=FIS.SOURCEBRANCH AND DIV1.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE1 ON WHOUSE1.NR=FIS.SOURCEINDEX AND WHOUSE1.FIRMNR={1}
                    INNER JOIN L_CAPIDIV DIV2 ON DIV2.NR=FIS.DESTBRANCH AND DIV2.FIRMNR={1}
                    INNER JOIN L_CAPIWHOUSE WHOUSE2 ON WHOUSE2.NR=FIS.DESTINDEX AND WHOUSE2.FIRMNR={1} WHERE FIS.ORDERREF={3} AND FIS.FICHETYPE=1 
                     AND FIS.ORDERREF!=FIS.LOGICALREF
                        ", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod, Id);
            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
        }

        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {

            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                var row = gridView2.GetFocusedRow();
                if (row == null) return;
                DataRowView dr = (DataRowView) row;
                if (XtraMessageBox.Show("Sətir silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                Functions.ExecuteStatement(Variables.TigerConnection,
                    string.Format("UPDATE {0}LK_{1}_{2}_PURCHORDERDISTFICHE SET ORDERREF=NULL WHERE LOGICALREF={3}",
                        Variables.FirmDb,
                        Variables.FirmNr,
                        Variables.FirmPeriod, dr["LOGICALREF"]));
                e.Handled = false;
                return;
            }
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                OrderList list = new OrderList
                {
                    sourceBranch = Dr["SOURCEBRANCH"].ToString(),
                    sourceIndex = Dr["SOURCEINDEX"].ToString()
                };
                if (list.ShowDialog() == DialogResult.OK)
                {

                    if (list.view.GetSelectedRows().Count() <= 0) return;

                    int[] a = list.view.GetSelectedRows();
                    string values = a.Select(t => (DataRowView) list.view.GetRow(t)).Aggregate(string.Empty,
                        (current, row) => current + (row.Row["LOGICALREF"] + ","));
                    values = values.Remove(values.Length - 1, 1);
                    Functions.ExecuteStatement(Variables.TigerConnection,
                        string.Format(
                            "UPDATE {0}LK_{1}_{2}_PURCHORDERDISTFICHE SET ORDERREF={4} WHERE LOGICALREF IN ({3})",
                            Variables.FirmDb,
                            Variables.FirmNr,
                            Variables.FirmPeriod, values, Dr["LOGICALREF"]));


                    GroupOrderMembers_Load(null, null);
                }

            }
        }
    }

}