using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ERP.General;

namespace ERP.Administrator
{
    public partial class GroupUsers : XtraForm
    {
        public GroupUsers()
        {
            InitializeComponent();
           
        }

        public int GroupId { get; set; }

        public void RefreshGrid()
        {
           gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.ConnectionString, $@"                
                  SELECT USERS.ID,USERS.USERNAME,MEMBERS.ID MEMBERID FROM ERP_GROUPS GR 
                      INNER JOIN ERP_GROUPMEMBERS MEMBERS ON GR.ID=MEMBERS.GROUPID AND GR.ID={GroupId}
                      INNER JOIN ERP_USERS USERS ON USERS.ID=MEMBERS.USERID
                                                                          ");
        }
        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
               
                if (XtraMessageBox.Show("Sətir silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int[] a = gridView1.GetSelectedRows();
                    if (a.Length > 0)
                    {
                        string values = a.Select(t => (DataRowView) gridView1.GetRow(t)).Aggregate(string.Empty,
                            (current, row) => current + (row.Row["MEMBERID"] + ","));
                        values = values.Remove(values.Length - 1, 1);
                        Functions.ExecuteStatement(Variables.ConnectionString,
                            $@"DELETE FROM ERP_GROUPMEMBERS WHERE ID IN ({values})");
                    }

                }
                
                
            }
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                 var users = new Users();
                 users.gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                 users.gridView1.OptionsSelection.MultiSelect = true;
                users.EditUserBtn.Visible = users.newUserBtn.Visible = false;
                users.StartPosition = FormStartPosition.CenterScreen;
                users.SelectBtn.Visible = true;
                if (users.ShowDialog() == DialogResult.OK)
                {

                    if (users.gridView1.GetSelectedRows().Count() <= 0) return;

                    int[] a = users.gridView1.GetSelectedRows();
                    if(a.Length==0)return;
                    string values = a.Select(t => (DataRowView)users.gridView1.GetRow(t)).Aggregate(string.Empty,
                        (current, row) => current + (row.Row["ID"] + ","));

                    values = values.Remove(values.Length - 1, 1);

                    var query =
                        $@"
                     INSERT INTO  ERP_GROUPMEMBERS (USERID,GROUPID) 
                      SELECT ID,{GroupId} AS GROUPID FROM ERP_USERS WHERE ID IN ({values}) AND 
                     ID NOT IN (SELECT USERID FROM ERP_GROUPMEMBERS WHERE GROUPID={GroupId})";
                    Functions.ExecuteStatement(Variables.ConnectionString, query);
                   
                }
             

            }
            RefreshGrid();
            e.Handled = false;
        }

        
    }
}