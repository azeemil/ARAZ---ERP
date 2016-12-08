using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP.General
{
    public partial class RequestForm : DevExpress.XtraEditors.XtraForm
    {
        private string command;
        private string dbname;
        private string conString;
        private string firmnr;
        private string fis_logicalref;

        public RequestForm(string command, string dbname, string connstring,string firmnr)
        {
            this.firmnr = firmnr;
            this.command = command;
            this.dbname = dbname;
            if (dbname.Length != 0)
            {
                dbname = dbname + "..";
            }
           conString = connstring;
            InitializeComponent();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {

            DataTable firmds = new DataTable();
            var conn = new SqlConnection(conString);
            var da = new SqlDataAdapter(command, conn);
            da.Fill(firmds);
            fis_logicalref = firmds.Rows[0]["LOGICALREF"].ToString();
            fisno.Text = firmds.Rows[0]["FICHENO"].ToString();
            docno.Text = firmds.Rows[0]["DOCODE"].ToString();
            tip.Text = firmds.Rows[0]["TIP"].ToString();
            code.Text = firmds.Rows[0]["CODE"].ToString();
            definition.Text = firmds.Rows[0]["DEFINITION_"].ToString();
            sourceindex_code.Text = firmds.Rows[0]["SOURCEINDEX"].ToString();
            destindex_code.Text = firmds.Rows[0]["DESTINDEX"].ToString();
            ugirtrackingno.Text = firmds.Rows[0]["UGIRTRACKINGNO"].ToString();
            date.Text = firmds.Rows[0]["DATE_"].ToString();
            user.Text = firmds.Rows[0]["USERID"].ToString();
            request_no.Text = firmds.Rows[0]["ID"].ToString();
            total.Text = firmds.Rows[0]["NETTOTAL"].ToString();
            user_explanation.Text = firmds.Rows[0]["EXPLANATION"].ToString();

            if (!string.IsNullOrEmpty(firmds.Rows[0]["ID"].ToString()))
            {
                
                if (!bool.Parse(firmds.Rows[0]["APPROVED"].ToString()))
                {

                    user_explanation.Enabled = approv.Checked = save.Enabled = false;
                    cancel.Enabled = true;

                }
                else
                {
                    approv.Checked =  true;
                    cancel.Enabled = save.Enabled = user_explanation.Enabled = false;
                }

            }
            else
            {
                approv.Checked = cancel.Enabled = false;
                user_explanation.Enabled = save.Enabled = true;
            }

        }

        private
            void user_explanation_TextChanged(object sender, EventArgs e)
        {
            label12.Text = (user_explanation.MaxLength - user_explanation.Text.Length).ToString();
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (user_explanation.TextLength>20)
            {
                AcceptForm frm =
                    new AcceptForm(
                        "Seçdiyiniz qaimə təsdiqləndikdən sonra sistemnən çıxarılacaqdır. Müraciət təsdiqlənməsə\nqaimə sistemnən çıxarılmayacaq. Əgər müraciətiniz təsdiqlənərsə müraciəti ləğv etmək\nmümkün olmayacaqdir");
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Yes)
                {
                    string insert = string.Format(@" INSERT INTO {0}REQUEST 
 ( STF_ID,TRCODE ,FICHENO, DOCODE, SOURCEINDEX,DESTINDEX,UGIRTRACKINGNO,
 CODE,DEFINITION_ ,TOTAL,DATE_,EMAIL,[BACKUP],CANCELLED,DELETED, APPROVED,EXPLANATION,[RECUSER],RECDATE )
 SELECT   FIS.LOGICALREF,FIS.TRCODE, FIS.FICHENO , FIS.DOCODE,FIS.SOURCEINDEX,FIS.DESTINDEX,FIS.UGIRTRACKINGNO,
          CLC.CODE , CLC.DEFINITION_ , FIS.NETTOTAL,FIS.DATE_,0,0,0,0,0,N'{4}',N'{3}' ,GETDATE()
FROM {0}LG_{1}_01_STFICHE FIS WITH(NOLOCK) 
LEFT JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
LEFT JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
WHERE FIS.LOGICALREF={2}
UPDATE  {0}LG_{1}_01_STFICHE  SET SPECODE='DELETE' WHERE LOGICALREF={2}


", dbname, firmnr, fis_logicalref, user.Text, user_explanation.Text);
                    //  user_explanation.Text = insert;
                    SqlConnection conn = new SqlConnection(conString);
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = insert;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    load();
                    MessageBox.Show("Müraciətiniz " + request_no.Text + @" nömrəsi ilə qeydə alındı!");
                }
                else if (frm.DialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Səbəb 20 simvoldan az ola bilməz!");}
        }

        private void cancel_Click(object sender, EventArgs e)
        {
             AcceptForm frm = new AcceptForm(request_no.Text + " nömrəli müraciətiniz ləğv ediləcəldir.");
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(conString);
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format(@"

UPDATE  {0}LG_{2}_01_STFICHE  SET SPECODE='ELTERMINAL' WHERE LOGICALREF=(SELECT STF_ID FROM {0}REQUEST WHERE ID={1})
DELETE {0}REQUEST WHERE ID={1}", dbname, request_no.Text,firmnr);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Müraciət ləğv olundu!");
                this.Close();
                }
        }

        private void user_explanation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        
        }
    }
}