using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Linq;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using ERP.General;
using DevExpress.XtraReports.UI;

namespace ERP.Market
{

    public partial class PriceEtiketPrint : XtraForm
    {
        private readonly DataTable _prcTable;
        public readonly DataTable PrintTable;
        private XtraReport _report;
        private readonly string _decimalChar;
        public PriceEtiketPrint()
        {
            InitializeComponent();
             _decimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            BranchLookUp.Properties.DataSource = User.Branch;
            _prcTable =new DataTable("ItemList");

            _prcTable.Columns.Add("BRANCH", typeof (int));
            _prcTable.Columns.Add("CODE",typeof(string));
            _prcTable.Columns.Add("NAME", typeof(string));
            _prcTable.Columns.Add("BARCODE", typeof(string));
            _prcTable.Columns.Add("UNITNAME", typeof(string));
            _prcTable.Columns.Add("PRICE", typeof(float));
            _prcTable.Columns.Add("COUNT", typeof(int));
            _prcTable.Columns.Add("PRICE_TAM", typeof(string));
            _prcTable.Columns.Add("PRICE_KESIR", typeof(string));
            gridControl1.DataSource = _prcTable;
            var designs = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                $@"SELECT REPORT.ID,REPORT.TEMPLATE,REPORT.NAME FROM ERP_REPORTTEMPLATES REPORT 
                INNER JOIN ERP_RT_USERPERMISSON UP ON UP.TEMPLATEID=REPORT.ID AND USERID={User.UserId} 
                AND UP.FIRMNR=REPORT.FIRMNR  AND TYPE=0
                           ");

            PrintTable = new DataTable("ItemList");
            PrintTable.Columns.Add("BRANCH", typeof(int));
            PrintTable.Columns.Add("CODE", typeof(string));
            PrintTable.Columns.Add("NAME", typeof(string));
            PrintTable.Columns.Add("BARCODE", typeof(string));
            PrintTable.Columns.Add("UNITNAME", typeof(string));
            PrintTable.Columns.Add("PRICE", typeof(float));
            PrintTable.Columns.Add("COUNT", typeof(int));
            PrintTable.Columns.Add("PRICE_TAM", typeof(string));
            PrintTable.Columns.Add("PRICE_KESIR", typeof(string));

            DesignLookUp.Properties.DataSource = designs;
            PrinterName.Text = Registr.ReadFromRegistry(Application.ProductName + @"\Market\BarcodePrint\PrinterName","PrinterName");
        }

      
        private void BarkodEnter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BranchLookUp.Text.Length == 0)
            {
                XtraMessageBox.Show("Filial seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var barcodeEnterFrm = new BarcodeEnterFrm
            {
                PrcEtiketPrint = this,
                BranchNoTxt = { Text = BranchLookUp.Text }
            };
            barcodeEnterFrm.ShowDialog();
        }
        public void AddRow(int branch,string code,string name,string barcode,string unit,float price, int count)
        {
            var s = price.ToString("F2").Split(char.Parse(_decimalChar));
            _prcTable.Rows.Add(branch, code, name, barcode, unit, price, count,s[0],s[1]);
           
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
          
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
            }
        }

        private void PrinterName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            PrintDialog p =  new PrintDialog();
            if (p.ShowDialog() == DialogResult.OK)
            {
                PrinterName.Text = p.PrinterSettings.PrinterName;
                Registr.WriteToRegistry(Application.ProductName + @"\Market\BarcodePrint\PrinterName", "PrinterName",
                    p.PrinterSettings.PrinterName);
            }
        }

        private void PrintBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if(row==null) return;
            if (!CheckDesignStatus()) return;
            if (!CheckPrinter()) return;
            PrintRow(row);
        }
        private void PrintSelected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int[] a = gridView1.GetSelectedRows();
            if (a.Length <= 0) return;
            
            if (!CheckDesignStatus()) return;
            if (!CheckPrinter()) return;

            progressBarControl1.Position = 0;
            progressBarControl1.Properties.Minimum = 0;progressBarControl1.Properties.Maximum = a.Length;
            progressBarControl1.Visible = true;

            try
            {
                foreach (var t in a)
                {
                    PrintRow(gridView1.GetDataRow(t));
                    progressBarControl1.PerformStep();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Xəta!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                progressBarControl1.Visible = false;
            }

        }

        private bool CheckPrinter()
        {
            if (PrinterName.Text.Length == 0)
            {
                XtraMessageBox.Show("Printer seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            PrinterSettings p = new PrinterSettings {PrinterName = PrinterName.Text};
            if (!p.IsValid)
            {
                XtraMessageBox.Show("Printer xetası!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _report.PrinterName = PrinterName.Text;
            return true;
        }

        private bool CheckDesignStatus()
        {
            if (DesignLookUp.Text.Length == 0)
            {
                XtraMessageBox.Show("Dizayn forması seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DataRowView row = (DataRowView)DesignLookUp.GetSelectedDataRow();
            if (row != null)
            {
                using (var sw = new StreamWriter(new MemoryStream()))
                {
                    sw.Write(row["TEMPLATE"].ToString());
                    sw.Flush();
                    _report = XtraReport.FromStream(sw.BaseStream, true);
                }
            }
            _report.DataSource = PrintTable;
            return true;
        }

        private void ClearBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _prcTable.Clear();
            gridView1.RefreshData();
        }

        private void DeleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          gridView1.GetFocusedDataRow()?.Delete();
        }

        private void DeleteSelectedBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] a;
            if ((a = gridView1.GetSelectedRows()).Length <= 0) return;

            try
            {
                foreach (var t in a)
                {
                    gridView1.GetDataRow(t).Delete();
                }
            }
            catch
            {
                // ignored
            }
        }

        private void PrintRow(DataRow row)
        {
            PrintTable.Clear();
            PrintTable.ImportRow(row);
            _report.CreateDocument();
            _report.Print();
        }


        private void MobilePrintBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BranchLookUp.Text.Length == 0)
            {
                XtraMessageBox.Show("Filial seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MobilePrintList mp = new MobilePrintList
            {
                gridControl1 =
                {
                    DataSource =
                        Functions.GetSqlServerDataTable(Variables.TigerConnection,
                            $@"
                                            SELECT MST.LOGICALREF,NR,DIV.NAME,EXPLANATION,DATE_ FROM L_CAPIDIV DIV INNER JOIN  
                                            {Variables.FirmDb}LK_{Variables.FirmNr}_MOBILELABELPRINTMST MST ON MST.DIVNR=DIV.NR 
                                             AND FIRMNR={Variables.FirmNr}    AND FICHETYPE=1 AND DIVNR ={BranchLookUp.Text} ")
                }
            };

            mp.gridView1.Columns["LOGICALREF"].Visible = false;

            mp.gridView1.Columns["NR"].Caption = @"Filial №";
            mp.gridView1.Columns["NAME"].Caption = @"Filial";
            mp.gridView1.Columns["EXPLANATION"].Caption = @"Açıqlama №";
            mp.gridView1.Columns["DATE_"].Caption = @"Tarix";
            mp.gridView1.Columns["DATE_"].DisplayFormat.FormatType = FormatType.DateTime;
            mp.gridView1.Columns["DATE_"].DisplayFormat.FormatString = "dd-MM-yyyy";
            

            foreach (GridColumn c in mp.gridView1.Columns)
            {
                c.OptionsColumn.AllowEdit = false;
                c.OptionsColumn.AllowFocus = false;
                c.OptionsColumn.AllowSort = DefaultBoolean.False;
            }
            mp.gridView1.BestFitColumns();
            if(mp.ShowDialog()!=DialogResult.OK) return;
            string filterString = mp.gridView1.GetSelectedRows().Aggregate(string.Empty, (current, a) => current + "," + 
             (((DataRowView)mp.gridView1.GetRow(a))["LOGICALREF"].ToString()));


            var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                string.Format(@"SELECT MST.DIVNR,DTL.LOGICALREF,DTL.MASTERREF, ITEM.CODE,ITEM.NAME,BARCODE.BARCODE,UNIT.NAME UNITNAME,
            COALESCE(
            PRCUNIT.SELLPRICE,
            ACT.SELLPRICE,
            PRC.BUYPRICE
            ) PRICE,DTL.LABELAMOUNT [COUNT]
            FROM {0}LG_{1}_UNITBARCODE BARCODE WITH (NOLOCK)
			INNER JOIN {0}LK_{1}_MOBILELABELPRINTDTL DTL ON DTL.BARCODE=BARCODE.BARCODE
			INNER JOIN {0}LK_{1}_MOBILELABELPRINTMST MST ON DTL.MASTERREF=MST.LOGICALREF  AND MST.LOGICALREF IN ({3})
            INNER JOIN {0}LG_{1}_UNITSETL UNIT WITH (NOLOCK) ON UNIT.LOGICALREF=BARCODE.UNITLINEREF             
            INNER JOIN {0}LG_{1}_ITEMS ITEM WITH (NOLOCK) ON BARCODE.ITEMREF=ITEM.LOGICALREF
            LEFT JOIN {0}LK_{1}_PRCLISTOTHPRC PRCUNIT  WITH (NOLOCK) ON PRCUNIT.ITEMREF=ITEM.LOGICALREF AND PRCUNIT.DIVNR=MST.DIVNR
            AND PRCUNIT.UNITLINEREF=BARCODE.UNITLINEREF
            LEFT JOIN {0}LK_{1}_PRCLIST PRC WITH (NOLOCK) ON PRC.STREF=ITEM.LOGICALREF AND PRC.OFFICECODE=MST.DIVNR
            LEFT JOIN {0}LK_{1}_{2}_ACTIVATIONLINES ACT WITH (NOLOCK) ON ACT.STREF=ITEM.LOGICALREF AND ACT.OFFICECODE=MST.DIVNR
            AND CAST(GETDATE() AS DATE)>=CAST(START_DATE AS DATE) AND CAST(GETDATE() AS DATE)<=CAST(FINISH_DATE AS DATE)          

              ",
            Variables.FirmDb,Variables.FirmNr,Variables.FirmPeriod,filterString.Substring(1)));

            foreach(DataRow row in dt.Rows)
                AddRow(
                int.Parse(row["DIVNR"].ToString()),
                row["CODE"].ToString(),
                row["NAME"].ToString(),
                row["BARCODE"].ToString(),
                row["UNITNAME"].ToString(),
                float.Parse(row["PRICE"].ToString()),
                int.Parse(row["COUNT"].ToString())
                );

        }
        private void PrcChangeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BranchLookUp.Text.Length == 0)
            {
                XtraMessageBox.Show("Filial seçilməyib!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var mp = new MobilePrintList
            {
                gridControl1 =
                {
                    DataSource =
                        Functions.GetSqlServerDataTable(Variables.TigerConnection,
                            string.Format(@"
                                         SELECT MST.LOGICALREF, DIV.DIVNR,CAP.NAME,MST.EXPLANATION,AP.RECDATE
                 FROM {0}LK_{1}_{2}_PRCCHANGEMST MST WITH (NOLOCK)
                INNER JOIN {0}LK_{1}_{2}_PRCCHANGEDIVISIONS DIV WITH (NOLOCK) ON DIV.MASTERREF=MST.LOGICALREF AND DIV.DIVNR={3} AND DOCTYPE IN (0,14) AND MST.FIRMNR={1}
                INNER JOIN {0}LK_{1}_{2}_PRCCHANGEAPPROVS AP WITH (NOLOCK) ON AP.CARDREF=MST.LOGICALREF AND AP.APPROVED=1 AND AP.OFFICECODE=DIVNR
                INNER JOIN ARAZ..L_CAPIDIV CAP ON CAP.NR=DIV.DIVNR AND CAP.FIRMNR={1}
                ORDER BY MST.LOGICALREF", Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod,BranchLookUp.Text))
                }
            };
            
        

            mp.gridView1.Columns["LOGICALREF"].Caption = @"Sənəd №";
            mp.gridView1.Columns["DIVNR"].Caption = @"Filial №";
            mp.gridView1.Columns["NAME"].Caption = @"Filial";
            mp.gridView1.Columns["EXPLANATION"].Caption = @"Açıqlama №";
            mp.gridView1.Columns["RECDATE"].Caption = @"Tarix";
            mp.gridView1.Columns["RECDATE"].DisplayFormat.FormatType = FormatType.DateTime;
            mp.gridView1.Columns["RECDATE"].DisplayFormat.FormatString = "dd-MM-yyyy";


            foreach (GridColumn c in mp.gridView1.Columns)
            {
                c.OptionsColumn.AllowEdit = false;
                c.OptionsColumn.AllowFocus = false;
                c.OptionsColumn.AllowSort = DefaultBoolean.False;
            }
            mp.gridView1.BestFitColumns();
            if (mp.ShowDialog() != DialogResult.OK) return;

           

            string filterString = mp.gridView1.GetSelectedRows().Aggregate(string.Empty, (current, a) => current + "," +
             (((DataRowView)mp.gridView1.GetRow(a))["LOGICALREF"].ToString()));


            var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                string.Format(@"SELECT  ITEM.CODE,ITEM.NAME,BARCODE.BARCODE,UNIT.NAME UNITNAME,
            COALESCE(
            PRCUNIT.SELLPRICE,
            ACT.SELLPRICE,
            PRC.BUYPRICE
            ) PRICE
            FROM {0}LK_{1}_{2}_PRCCHANGEDTL DTL
			INNER JOIN {0}LG_{1}_UNITBARCODE BARCODE WITH (NOLOCK) ON DTL.STREF=BARCODE.ITEMREF 
			AND BARCODE.LINENR=1 AND DTL.MASTERID IN ({4})	
            INNER JOIN {0}LG_{1}_UNITSETL UNIT WITH (NOLOCK) ON UNIT.LOGICALREF=BARCODE.UNITLINEREF             
            INNER JOIN {0}LG_{1}_ITEMS ITEM WITH (NOLOCK) ON BARCODE.ITEMREF=ITEM.LOGICALREF
            LEFT JOIN {0}LK_{1}_PRCLISTOTHPRC PRCUNIT  WITH (NOLOCK) ON PRCUNIT.ITEMREF=ITEM.LOGICALREF AND PRCUNIT.DIVNR={3}
            AND PRCUNIT.UNITLINEREF=BARCODE.UNITLINEREF
            LEFT JOIN {0}LK_{1}_PRCLIST PRC WITH (NOLOCK) ON PRC.STREF=ITEM.LOGICALREF AND PRC.OFFICECODE={3}
            LEFT JOIN {0}LK_{1}_{2}_ACTIVATIONLINES ACT WITH (NOLOCK) ON ACT.STREF=ITEM.LOGICALREF AND ACT.OFFICECODE={3}
            AND CAST(GETDATE() AS DATE)>=CAST(START_DATE AS DATE) AND CAST(GETDATE() AS DATE)<=CAST(FINISH_DATE AS DATE)          

              ",
            Variables.FirmDb, Variables.FirmNr, Variables.FirmPeriod,BranchLookUp.Text, filterString.Substring(1)));


         


            foreach (DataRow row in dt.Rows)
                AddRow(
                int.Parse(BranchLookUp.Text),
                row["CODE"].ToString(),
                row["NAME"].ToString(),
                row["BARCODE"].ToString(),
                row["UNITNAME"].ToString(),
                float.Parse(row["PRICE"].ToString()),
                1
                );

        }
    };



}
    

