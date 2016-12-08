using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ERP.General;

namespace ERP
{
    public partial class LoginPanel : XtraForm
    {
        private readonly DataTable _periodsTable;

        public LoginPanel()
        {
            InitializeComponent();
            User.UserPermission = new DataTable();
            User.UserPermission.Columns.Add("LEVEL", typeof(string));
            User.UserPermission.Columns.Add("PERMISSION", typeof(string));
            labelControl6.Text = @"v" + Application.ProductVersion;
            domain.Text = DomainManager.DomainName;
            user.Text = DomainManager.UserName;
            const string query = @"
                           SELECT NR,NAME,TITLE,DBNAME FROM L_CAPIFIRM ; 
                           SELECT NR,FIRMNR FROM L_CAPIPERIOD;
                           ";
            DataSet ds = Functions.GetSqlServerDataset(Variables.TigerConnection, query);
            var firmsTable = ds.Tables[0];
            _periodsTable = ds.Tables[1];
            FirmLookUp.Properties.DataSource = firmsTable;
            FirmLookUp.Refresh();
            PeriodRefresh();
        }

        private void OK_Click(object sender, EventArgs e)

        {
             marqueeProgressBarControl1.Show();
            if (FirmLookUp.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Firma nömrəsi daxil edilməyib!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                marqueeProgressBarControl1.Hide();
                return;
            }

            Variables.FirmPeriod = Convert.ToInt32(PeriodCMB.Text).ToString("D2");

            User.UserPermission.Rows.Clear();
            if (ActiveDirectory.IsAuthenticated("", user.Text, password.Text))
            {
              
                Variables.WindowsUserName = User.UserName = user.Text;
                if (CheckPermissions())
                {
                    Variables.Branch = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                        "SELECT NR,NAME,CAST(NR AS VARCHAR(3))+' - '+NAME DISPLAYNAME FROM L_CAPIDIV WHERE FIRMNR=" +
                        Variables.FirmNr);
                    Variables.Whouse = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                        "SELECT NR,NAME,CAST(NR AS VARCHAR(3))+' - '+NAME DISPLAYNAME,DIVISNR FROM L_CAPIWHOUSE WHERE FIRMNR=" +
                        Variables.FirmNr);

                    LoadBWPermissions();

                    Registr.WriteToRegistry(Application.ProductName + @"\LoginFirmInfo", "FirmNumber",FirmLookUp.Text);
                    Registr.WriteToRegistry(Application.ProductName + @"\LoginFirmInfo", "PeriodNumber", PeriodCMB.Text);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    marqueeProgressBarControl1.Hide();
                }



            }
            else
            {
                marqueeProgressBarControl1.Hide();
                XtraMessageBox.Show("Istifadəçi adı və ya şifrə yalnışdır!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadBWPermissions()
        {
            Variables.BranchFiltrString = string.Empty;
            Variables.WhouseFiltrString = string.Empty;
            Variables.BranchFiltrStringIn = string.Empty;
            Variables.WhouseFiltrStringIn = string.Empty;
            Variables.BranchFiltrStringOut = string.Empty;
            Variables.WhouseFiltrStringOut = string.Empty;
            if (!User.IsAdmin)
            {

                User.Branch = Variables.Branch.Clone();
                User.Whouse = Variables.Whouse.Clone();
                User.BranchIn = Variables.Branch.Clone();
                User.BranchOut = Variables.Branch.Clone();
                User.WhouseIn = Variables.Whouse.Clone();
                User.WhouseOut = Variables.Whouse.Clone();

                foreach (DataRow row in Variables.Branch.Rows)
                {

                    if (
                        User.UserPermission.Select($"LEVEL=1 AND PERMISSION='{row["NR"].ToString().Trim()}'").Any())
                    {
                        User.Branch.ImportRow(row);
                        Variables.BranchFiltrString += row["NR"] + ",";
                    }
                }
               
                ////
                foreach (DataRow row in Variables.Whouse.Rows)
                {

                    if (
                        User.UserPermission.Select($"LEVEL=2 AND PERMISSION='{row["NR"].ToString().Trim()}'").Any())
                        User.Whouse.ImportRow(row);
                    Variables.WhouseFiltrString += row["NR"] + ",";
                }

               
                /////
                foreach (DataRow row in Variables.Branch.Rows)
                {
                    if (
                        User.UserPermission.Select($"LEVEL=3 AND PERMISSION='{row["NR"].ToString().Trim()}'").Any())
                        User.BranchIn.ImportRow(row);
                    Variables.BranchFiltrStringIn += row["NR"] + ",";
                }

                 
                ////


                foreach (DataRow row in Variables.Branch.Rows)
                {
                    if (
                        User.UserPermission.Select($"LEVEL=4 AND PERMISSION='{row["NR"].ToString().Trim()}'")
                            .Any())
                        User.BranchOut.ImportRow(row);
                    Variables.WhouseFiltrString += row["NR"] + ",";
                }

               

                ////
                foreach (DataRow row in Variables.Whouse.Rows)
                {
                    if (
                        User.UserPermission.Select($"LEVEL=5 AND PERMISSION='{row["NR"].ToString().Trim()}'")
                            .Any())
                        User.WhouseIn.ImportRow(row);
                    Variables.BranchFiltrStringOut += row["NR"] + ",";
                }

               
                ////


                ////
                foreach (DataRow row in Variables.Whouse.Rows)
                {
                    if (
                        User.UserPermission.Select($"LEVEL=6 AND PERMISSION='{row["NR"].ToString().Trim()}'")
                            .Any())
                        User.WhouseOut.ImportRow(row);
                    Variables.WhouseFiltrStringOut += row["NR"] + ",";
                }

                
                ////

            }
            else

            {
                User.Branch = Variables.Branch.Copy();
                User.Whouse = Variables.Whouse.Copy();
                User.BranchIn = Variables.Branch.Copy();
                User.BranchOut = Variables.Branch.Copy();
                User.WhouseIn = Variables.Whouse.Copy();
                User.WhouseOut = Variables.Whouse.Copy();
            }


        }

        bool CheckPermissions(){
            var dt = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                string.Format("SELECT * FROM ERP_USERS WHERE LTRIM(RTRIM(USERNAME))='{0}'", User.UserName.Trim()));
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Istifadəçi qeydiyyatı yoxdur! \nProqramlaşdırma şöbəsi ilə əlaqə saxlayın!", "Diqqət", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return false;
            }
            if (!bool.Parse(dt.Rows[0]["ACTIV"].ToString()))
            {
                XtraMessageBox.Show("Istifadəçi aktiv deyil! \nProqramlaşdırma şöbəsi ilə əlaqə saxlayın!", "Diqqət", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return false;
            }
            User.UserId = dt.Rows[0]["ID"].ToString();
            User.IsAdmin = bool.Parse(dt.Rows[0]["ISADMIN"].ToString());
            User.ApiUse = bool.Parse(dt.Rows[0]["LOBJECT"].ToString());
            if (User.IsAdmin) return true;
            User.IsAdmin = GroupIsAdmin();
            if (User.IsAdmin) return true;
            var ds = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                            string.Format(@"
                                SELECT LEVEL,PERMISSION FROM ERP_PERMISSIONS WHERE TYPE=1 AND MASTERID={0} AND FIRMNR={1}
                                UNION ALL
                                SELECT LEVEL,PERMISSION FROM ERP_PERMISSIONS WHERE TYPE=2 AND FIRMNR={1} AND MASTERID IN 
                                (SELECT GR.ID FROM ERP_GROUPS GR INNER JOIN ERP_GROUPMEMBERS MEMBER ON GR.ID=MEMBER.GROUPID AND USERID={0} AND GR.ACTIV=1)
                             ", User.UserId,Variables.FirmNr));

          if (ds.Rows.Count != 0)
                {
                   
                    foreach (DataRow row in ds.Rows)
                    {
                        var level = row["LEVEL"].ToString();
                        var str = GetLevelPermission(row["PERMISSION"]).Split(';');

                        for (int i = 0; i < str.Length; i++)
                        {
                            User.UserPermission.Rows.Add(level, str[i]);
                        }


                    }User.UserPermission = User.UserPermission.DefaultView.ToTable(true);

                   
                }

            return true;
        }


        bool GroupIsAdmin()
        {
            var ds = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                            string.Format(@"
                                SELECT GR.* FROM ERP_GROUPS GR INNER JOIN ERP_GROUPMEMBERS MB ON MB.GROUPID=GR.ID AND MB.USERID={0} AND GR.ACTIV=1
                             ", User.UserId));


          
            return ds.Select("ISADMIN=1").Any();
        }

        string GetLevelPermission(object ob)
        {
            MemoryStream ms = new MemoryStream((byte[])ob);

            StreamReader sr = new StreamReader(ms);
            string myStr = sr.ReadToEnd();
            return myStr;
        }
        private void CANCEL_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void password_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            password.Properties.PasswordChar = '\0';
        
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Properties.PasswordChar = '*';
        }

        private void password_DoubleClick(object sender, EventArgs e)
        {
            password.Properties.PasswordChar = '*';
        }
        private void LoginPanel_Load(object sender, EventArgs e)
        {
            marqueeProgressBarControl1.Hide();
            FirmLookUp.Properties.NullText = FirmLookUp.Text = Registr.ReadFromRegistry(Application.ProductName + @"\LoginFirmInfo",
                "FirmNumber");
            FirmLookUp.Properties.SearchMode = SearchMode.OnlyInPopup;

            PeriodCMB.Properties.NullText =PeriodCMB.Text= Registr.ReadFromRegistry(Application.ProductName + @"\LoginFirmInfo",
                "PeriodNumber");
            PeriodCMB.Properties.SearchMode = SearchMode.OnlyInPopup;
        }

       
        public void PeriodRefresh()
        {
            if (FirmLookUp.Text.Trim().Length > 0)
            {
                var datarow = (DataRowView) FirmLookUp.GetSelectedDataRow();
                Variables.FirmDb = (datarow["DBNAME"].ToString().Trim().Length!=0) ? datarow["DBNAME"].ToString().Trim()+".." :string.Empty;
                Variables.FirmName = datarow["NAME"].ToString();
                Variables.FirmNr = datarow["NR"].ToString();
                var dr = _periodsTable.Select("FIRMNR=" + Variables.FirmNr).CopyToDataTable();
                if (dr.Select().Any())
                {
                    PeriodCMB.Properties.DataSource = dr;
                    PeriodCMB.ItemIndex = 0;
                }
                else
                {
                    PeriodCMB.Properties.DataSource = null;

                }
            }
        }

        private void FirmLookUp_EditValueChanged(object sender, EventArgs e)
        {
            PeriodRefresh();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                OK_Click(null,null);
        }
    }
}