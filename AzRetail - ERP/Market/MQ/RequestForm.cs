using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Market.MQ
{
    public partial class RequestForm : XtraForm
    {
        private readonly string _command;
      
        private string _logicalref;
        private int trcode;
        public RequestForm(string command)
        {
            _command = command;
            InitializeComponent();
        }
        private void RequestForm_Load(object sender, EventArgs e)
        {
            OnLoad();
        }
        public  void OnLoad()
        {

            var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection, _command);
            trcode = int.Parse(dt.Rows[0]["TRCODE"].ToString());
            user.Text = dt.Rows[0]["USERID"].ToString();
            _logicalref = dt.Rows[0]["LOGICALREF"].ToString();
            fisno.Text = dt.Rows[0]["FICHENO"].ToString();
            docno.Text = dt.Rows[0]["DOCODE"].ToString();
            tip.Text = dt.Rows[0]["TIP"].ToString();
            code.Text = dt.Rows[0]["CODE"].ToString();
            definition.Text = dt.Rows[0]["DEFINITION_"].ToString();
            sourceindex_code.Text = dt.Rows[0]["SOURCEINDEX"].ToString();
            destindex_code.Text = dt.Rows[0]["DESTINDEX"].ToString();
            ugirtrackingno.Text = dt.Rows[0]["UGIRTRACKINGNO"].ToString();
            date.Text = dt.Rows[0]["DATE_"].ToString();
            user.Text = dt.Rows[0]["USERID"].ToString();
            billedChxb.Checked = (bool)dt.Rows[0]["BILLED"];
            RequestNo.Text = dt.Rows[0]["ID"].ToString();
            total.Text = dt.Rows[0]["NETTOTAL"].ToString();
            Explanation.Text = dt.Rows[0]["EXPLANATION"].ToString();
            billedChxb.Checked = (bool) dt.Rows[0]["BILLED"];
            OnlyVoucher.Visible = (bool)dt.Rows[0]["BILLED"];
            approveChbx.Checked = (bool)dt.Rows[0]["APPROVE"];
            OnlyVoucher.Checked = (bool)dt.Rows[0]["ONLYVOUCHER"];
            SendedToApprove.Checked = (bool)dt.Rows[0]["SENDFORAPPROVE"];
         
            if (!string.IsNullOrEmpty(dt.Rows[0]["ID"].ToString()))
            {
                OnlyVoucher.Enabled = false;
                
                if ((bool)dt.Rows[0]["SENDFORAPPROVE"])
                {
                    Explanation.Enabled = save.Enabled = cancel.Enabled =  false;

                }
                else
                {
                   
                    save.Enabled = Explanation.Enabled = false;
                    SendToApprove.Enabled = cancel.Enabled = true;
                }

            }
            else
            {
                OnlyVoucher.Enabled = true;
                cancel.Enabled = SendToApprove.Enabled = false;
                Explanation.Enabled = save.Enabled = true;
            }

        }
        private void SaveClick(object sender, EventArgs e)
        {
            if (Explanation.Text.Length > 20)
            {
                if (XtraMessageBox.Show(
                    "Seçdiyiniz qaimə təsdiqləndikdən sonra sistemnən çıxarılacaqdır. Müraciət təsdiqlənməsə\nqaimə sistemnən çıxarılmayacaq. Əgər müraciətiniz təsdiqlənərsə müraciəti ləğv etmək\nmümkün olmayacaqdir",
                    "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    string insert = string.Format(@"
                    BEGIN TRY
                    BEGIN TRANSACTION TR
                    INSERT INTO ARAZERP..ERP_DELETEREQUEST
                    ([FIRMNR],[STF_ID] ,[TRCODE],[FICHENO] ,[DOCODE] ,[SOURCEINDEX] ,[DESTINDEX] ,[UGIRTRACKINGNO],
                    [CODE],[DEFINITION_] ,[TOTAL] ,[DATE_] ,[BILLED] ,[ONLYVOUCHER] ,[RECUSER],[EXPLANATION])
                    SELECT 
                    {1},FIS.LOGICALREF,FIS.TRCODE, FIS.FICHENO , FIS.DOCODE,FIS.SOURCEINDEX,FIS.DESTINDEX,FIS.UGIRTRACKINGNO,
                    CLC.CODE , CLC.DEFINITION_ , FIS.NETTOTAL,FIS.DATE_,FIS.BILLED,{6},{4},N'{5}'
                    FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
                    LEFT JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
                    LEFT JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
                    LEFT JOIN ARAZERP..[ERP_DELETEREQUEST] R ON R.STF_ID=FIS.LOGICALREF AND R.FIRMNR={1}
                    WHERE FIS.LOGICALREF={3}
                    UPDATE  {0}LG_{1}_{2}_STFICHE  SET SPECODE='DELETE' WHERE LOGICALREF={3}
                    COMMIT TRANSACTION TR

                    END TRY
                    BEGIN CATCH
                    ROLLBACK TRANSACTION TR
                    END CATCH


", Variables.FirmDb, Variables.FirmNr,Variables.FirmPeriod, _logicalref, User.UserId, Explanation.Text,((OnlyVoucher.Checked) ? 1:0));
                    SqlConnection conn = new SqlConnection(Variables.TigerConnection);
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = insert;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    OnLoad();
                    XtraMessageBox.Show($@"Müraciətiniz {RequestNo.Text} nömrəsi ilə qeydə alındı!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
               
            }
            else
            {
                XtraMessageBox.Show("Səbəb 20 simvoldan az ola bilməz!");
            }
        }
        private void OnCancel(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(
                    RequestNo.Text + " nömrəli müraciətiniz ləğv ediləcəldir. \nDavam Edirsiz?",
                    "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(Variables.TigerConnection);
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format(@"
                BEGIN TRY
                BEGIN TRANSACTION TR
                UPDATE  {0}LG_{2}_{3}_STFICHE  SET SPECODE='ELTERMINAL' WHERE LOGICALREF=(SELECT STF_ID FROM {0}REQUEST WHERE ID={1})
                UPDATE ARAZERP..ERP_DELETEREQUEST SET REQUESTISCANCELLED=1 WHERE ID={1}
                COMMIT TRANSACTION TR
                END TRY
                BEGIN CATCH
                ROLLBACK TRANSACTION TR
                END CATCH
", Variables.FirmDb, RequestNo.Text, Variables.FirmNr,Variables.FirmPeriod);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                XtraMessageBox.Show("Müraciət ləğv olundu!");
                DialogResult = DialogResult.OK;
            }
        }

        private void SendToApprove_Click(object sender, EventArgs e)
        {
            int type = 1;
            if (billedChxb.Checked) type = 2;
            else if (trcode == 12 || trcode == 13 || trcode == 14 || trcode == 25 || trcode == 11) type = 3;
            if (ApproveSystem.AddRequest(int.Parse(RequestNo.Text), type, int.Parse(Variables.FirmNr),
                int.Parse(User.UserId), ""))
                Functions.ExecuteStatement(Variables.ConnectionString,
                    $"UPDATE ERP_DELETEREQUEST SET SENDFORAPPROVE=1 WHERE ID={RequestNo.Text}");
            else
            {
                XtraMessageBox.Show(ApproveSystem.LastError, "Xəta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}