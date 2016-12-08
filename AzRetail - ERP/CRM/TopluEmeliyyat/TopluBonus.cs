using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using ERP.General;

namespace ERP.CRM.TopluEmeliyyat
{
    public partial class TopluBonus : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public TopluBonus()
        {
            InitializeComponent();
            dt.Columns.Add("KartNo", typeof(string));
            dt.Columns.Add("Bonus", typeof(string));
            dt.Columns.Add("Result", typeof(string));
            gridControl1.DataSource = dt;
        }

       

        private void PasteClipboard()
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    gridView1.AddNewRow();

                    int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
                    if (pastedRowCells.Length == 2)
                    {
                        if (gridView1.IsNewItemRow(rowHandle))
                        {
                            gridView1.SetRowCellValue(rowHandle, gridView1.Columns[0], pastedRowCells[0]);
                            gridView1.SetRowCellValue(rowHandle, gridView1.Columns[1], pastedRowCells[1]);
                        }
                    }
                    else XtraMessageBox.Show("Bir sütun seçmisiniz!!!", "Xəbərdarlıq",MessageBoxButtons.OK,MessageBoxIcon.Warning);              
                }
            }
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(MousePosition);
        }

        private void Copybtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PasteClipboard();
            gridView1.RefreshData();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {            
            if (memoEdit1.Text.Trim().Length !=0)
            {
                splashScreenManager1.ShowWaitForm();
                SqlConnection connection = new SqlConnection(Variables.TigerConnection);
                connection.Open();
                SqlTransaction tran = connection.BeginTransaction();
                foreach (DataRow dr in dt.Rows)
                {                   
                    SqlCommand cmd = new SqlCommand()
                    {
                        Transaction = tran,
                        Connection = connection,
                        CommandText = @"
                                    IF EXISTS(SELECT * FROM [inter_puan]..[INTERBONUS_PUAN] WHERE Cari_Kod=@CARTNO)
                                    BEGIN
                                    UPDATE [inter_puan]..[INTERBONUS_PUAN] SET Puan=ISNULL(Puan,0)+@BONUS WHERE Cari_Kod=@CARTNO
                                    END;
                                    ELSE
                                    BEGIN
                                    insert into [inter_puan]..INTERBONUS_PUAN (cari_koD,Puan)VALUES(@CARTNO,@BONUS)
                                    END;
                                    INSERT INTO [inter_puan]..INTERBONUS_PUANHAREKET(Cari_Kod,Puan,Aciklama,Kasa_No) 
                                    VALUES(@CARTNO,@BONUS,@EXPLANATION+'-'+@USERNAME,0)"
                    };
                    cmd.Parameters.AddWithValue("@CARTNO", dr["KartNo"]);
                    cmd.Parameters.AddWithValue("@BONUS", dr["Bonus"]);
                    cmd.Parameters.AddWithValue("@EXPLANATION", memoEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@USERNAME", User.UserName);
                    try
                    {
                           cmd.ExecuteNonQuery();                         
                    }
                    catch (Exception exception)
                    {
                        tran.Rollback();
                        splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show(exception.Message + "\n" + exception, "Xəta!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }
                splashScreenManager1.CloseWaitForm();
                tran.Commit();
                dt.Clear();
                XtraMessageBox.Show("Köçürülmə uğurla sonlandı", "Məlumat",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else XtraMessageBox.Show("Açıqlama yazın!!!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Cleanbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void Clearbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dt.Clear();
            gridView1.RefreshData();
        }
    }
}