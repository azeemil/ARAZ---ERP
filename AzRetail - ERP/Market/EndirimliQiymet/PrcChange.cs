using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Market.EndirimliQiymet
{
    public partial class PrcChange : XtraForm
    {
        public PrcChange()
        {
            InitializeComponent();
            branchCmbx.Properties.DataSource = User.Branch;
            BegDate.DateTime = EndDate.DateTime = DateTime.Today;
            CheckedChanged(null, null);
            branchCmbx.CheckAll();

        }
      
        private void CheckedChanged(object sender, EventArgs e)
        {
            BegDate.Enabled = EndDate.Enabled = dateChbx.Checked;
            branchCmbx.Enabled = branchChbx.Checked;
           
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string date = string.Empty;
            if (dateChbx.Checked)
                date =
                    $" AND CAST(CREATEDDATE AS DATE) BETWEEN '{BegDate.DateTime.ToString("yyyy-MM-dd")}' AND '{EndDate.DateTime.ToString("yyyy-MM-dd")}' ";

            var temp = Functions.GetCheckedComboboxValue(branchCmbx, branchChbx.Checked);
            if (temp.Length == 0)
            {
                XtraMessageBox.Show("Iş yeri seçimi yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            temp = $" AND PRC.BRANCH IN ({temp})";
            var query =
                $@"
                        SELECT PRC.ID,PRC.APPROVED,PRC.BRANCH,DIV.NAME BRANCHNAME,USERS.USERNAME CREATEDUSER,
                        PRC.CREATEDDATE,PRC.COMMENT,PRC.CANCELLED 
                        FROM ARAZERP..ERP_PRCCHANGE PRC
                        INNER JOIN L_CAPIDIV DIV ON DIV.NR=PRC.BRANCH AND DIV.FIRMNR=PRC.FIRMNR AND DIV.FIRMNR={Variables.FirmNr}  {date} {temp}
                        INNER JOIN ARAZERP..ERP_USERS USERS ON USERS.ID=PRC.CREATEDUSERID
                                       ";
                       gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
        }

        private void ReadBtn_Click(object sender, EventArgs e){
            var row = gridView1.GetFocusedDataRow();
            if(row==null) return;
            var detail = new PrcDetail(0) {Text = $"Qiymət dəyişim sənədi - {row["ID"]}",Id = row["ID"].ToString()};
            detail.Name += $"_{row["ID"].ToString().Trim()}";
            detail.Officecode = row["BRANCH"].ToString().Trim();
            detail.BranchLookUp.SelectedText = row["BRANCH"].ToString().Trim();
            detail.BranchLookUp.Text = row["BRANCH"].ToString().Trim();
            detail.BranchLookUp.ReadOnly = true;
            detail.CommentMemo.Text = row["COMMENT"].ToString().Trim();
            Variables.MForm.OpenOrBringToFront(detail);
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            var detail = new PrcDetail(1) { Text = $"Qiymət dəyişim sənədi"};
            detail.Name += $"_New";
            Variables.MForm.OpenOrBringToFront(detail);
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            if(bool.Parse(row["APPROVED"].ToString()) || bool.Parse(row["CANCELLED"].ToString()))
            {
                XtraMessageBox.Show("Təsdiqlənmiş və ya ləğv olunmuş sənədlər üzərində dəyişiklik etmək olmaz!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var detail = new PrcDetail(2) { Text = $"Qiymət dəyişim sənədi - {row["ID"]}", Id = row["ID"].ToString() };
            detail.Name += $"_{row["ID"].ToString().Trim()}";
            detail.Officecode = row["BRANCH"].ToString().Trim();
            detail.BranchLookUp.SelectedText = row["BRANCH"].ToString().Trim();
            detail.BranchLookUp.Text = row["BRANCH"].ToString().Trim();
            detail.CommentMemo.Text = row["COMMENT"].ToString().Trim();
            Variables.MForm.OpenOrBringToFront(detail);
        }
        private void ShowPopUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReadBtn_Click(null,null);
        }

        private void NewPopUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewBtn_Click(null,null);
        }

        private void EditPopUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           EditBtn_Click(null,null);
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            if (bool.Parse(row["APPROVED"].ToString()) || bool.Parse(row["CANCELLED"].ToString()))
            {
                XtraMessageBox.Show("Təsdiqlənmiş və ya ləğv olunmuş sənədlər üzərində dəyişiklik etmək olmaz!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (XtraMessageBox.Show("Sənəd ləğv olunacaq.\nDavam edirsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            var connection = new SqlConnection(Variables.ConnectionString);
            connection.Open();
            var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "QIYMET DEYISIMI");
            var command = connection.CreateCommand();
            command.CommandTimeout = 0;
            command.Transaction = transaction;
            command.CommandText = "UPDATE ERP_PRCCHANGE SET CANCELLED = 1,MODIFIEDUSER=@MODIFIEDUSER,MODIFIEDDATE=GETDATE() WHERE ID=@ID ";
            command.Parameters.AddWithValue("@ID", row["ID"]);
            command.Parameters.AddWithValue("@MODIFIEDUSER", User.UserId);
            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction?.Rollback();
                XtraMessageBox.Show(exception.Message + "\n" + exception.ToString(), "Xəta!", MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }


            SearchBtn_Click(null, null);
        }

        private void CancelPopUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteBtn_Click(null,null);
        }

        private void PrcChange_Load(object sender, EventArgs e)
        {
            if (!User.IsAdmin)
            {
                ReadBtn.Enabled =
                    ShowPopUp.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.2.0'").Any();
                NewBtn.Enabled =
                    NewPopUp.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.2.1'").Any();
                ReadBtn.Enabled =
                    ShowPopUp.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.2.2'").Any();
                CancelPopUp.Enabled =
                    DeleteBtn.Enabled = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.2.3'").Any();
            }
        }

        private void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchBtn_Click(null, null);
        }
    }
}