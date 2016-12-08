using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ERP.General;
using ERP.ErpWebService;



namespace ERP.Logistcs
{
    public partial class VeyseloglunaSifaris : XtraForm
    {
        public VeyseloglunaSifaris()
        {
            InitializeComponent();
            splashScreenManager1.ShowWaitForm();
            SourceBranchCmbx.Properties.DataSource = User.BranchIn;
            grid.DataSource = _orderTable;
            progress.Hide();
            LoadUser();
        }



       

        private readonly string _userNameBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes("999.999.99999"));
        private readonly string _passwordBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes("123"));
        private readonly string _imeiBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes("OBA132465ABO"));
        private  ClsUser[] _userList;
        private ClsUser _user;
        private  ServiceSoapClient _soapService;
        private ClsUserWarehouse[] warehouses;
        private ClsUserCode[] userCodes;
        private ClsCustomers[] Customers;
        private ClsProducts[] Products;
        private ClsItemsDetail[] _itemsDetails;
        private ClsStock[] _clsStocks;
        
        private Thread _thread;
        private DataTable _orderTable = new DataTable();

        private DataTable _customers = new DataTable();
        private DataTable _products = new DataTable();
        private DataTable ItemDetails = new DataTable();
        private DataTable Stock = new DataTable();
        public void LoadUser()
        {
            try
            {
                _soapService = new ServiceSoapClient();
                
                _userList = _soapService.UserAutentication(_userNameBase64, _passwordBase64, _imeiBase64);
                if (_userList.Length == 0) return;
                _user = _userList[0];
                userCodes = _soapService.UserCode(_userNameBase64, _passwordBase64, _imeiBase64);
                warehouses = _soapService.UserWarehouse(_user.lgid, userCodes[0].usercode);
                Customers = _soapService.Customers(_userNameBase64, _passwordBase64, _imeiBase64,
                    userCodes[0].usercode);
                Products = _soapService.Products(_userNameBase64, _passwordBase64, _imeiBase64,
                    Convert.ToBase64String(Encoding.UTF8.GetBytes(userCodes[0].usercode)));
                _itemsDetails = _soapService.ProductDetails(_userNameBase64, _passwordBase64, _imeiBase64,
                    Convert.ToBase64String(Encoding.UTF8.GetBytes(userCodes[0].usercode)));
                _clsStocks = _soapService.ProductStock(_userNameBase64, _passwordBase64, _imeiBase64,
                    Convert.ToBase64String(Encoding.UTF8.GetBytes(userCodes[0].usercode)),
                    Convert.ToInt32(warehouses[0].order_warehouse), "");
                LoadTables();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"{ex.Message}\n{ex}", "Xəta!", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
            finally { splashScreenManager1.CloseWaitForm();}
        }

        private void LoadTables()
        {
            #region Customers
            _customers.Columns.Add("CLCODE", typeof (string));
            _customers.Columns.Add("CLNAME", typeof (string));
            foreach (var a in Customers)
                _customers.Rows.Add(a._customerCode, a._customerName);
            #endregion

            #region Products
            _products.Columns.Add("CODE", typeof(string));
            _products.Columns.Add("NAME", typeof(string));
            _products.Columns.Add("UNIT", typeof(string));
            _products.Columns.Add("BARCODE", typeof(string));
            _products.Columns.Add("LOGICALREF", typeof(int));
            _products.Columns.Add("PRICE", typeof(float));
            foreach (var a in Products)
                _products.Rows.Add(a.CODE, a.MALAD,a.UNITCODE,a.B2CCODE,a.LOGICALREF,float.Parse(a.PRICE.ToString(CultureInfo.InvariantCulture)));
            #endregion

            #region _itemsDetails
            ItemDetails.Columns.Add("STOKCODE", typeof(string));
            ItemDetails.Columns.Add("MAINUNIT", typeof(string));
            ItemDetails.Columns.Add("M_ADT", typeof(int));
            ItemDetails.Columns.Add("ORAN", typeof(int));
            ItemDetails.Columns.Add("BIRIM", typeof(string));
            foreach (var a in _itemsDetails)
                ItemDetails.Rows.Add(a.STOKCODE,a.MAINUNIT,a.M_ADT,a.ORAN,a.BIRIM);
            #endregion

            #region Stok
            Stock.Columns.Add("STOKCODE", typeof(string));
            Stock.Columns.Add("AMOUNT", typeof(int));
            foreach (var a in _clsStocks)
                Stock.Rows.Add(a.itemcode, a.onhand);
            #endregion

        }


        private void SourceWhouseCmbx_EditValueChanged(object sender, EventArgs e)
        {
            if (SourceBranchCmbx.Text.Trim().Length > 0)
            {
                var datarow = (DataRowView) SourceBranchCmbx.GetSelectedDataRow();
                if (_customers.Select($"CLNAME LIKE 'OBA-{datarow["NR"]}%'").Any())
                {
                   CustomerTxb.Text = (_customers.Select($"CLNAME LIKE 'OBA-{datarow["NR"]}%'").CopyToDataTable()).Rows[0]["CLCODE"].ToString().Trim();
                   ClNameTxb.Text = (_customers.Select($"CLNAME LIKE 'OBA-{datarow["NR"]}%'").CopyToDataTable()).Rows[0]["CLNAME"].ToString().Trim();
                }
                else
                {
                    CustomerTxb.Text = string.Empty;
                    ClNameTxb.Text = string.Empty;
                    XtraMessageBox.Show("Uyğun cari yoxdur!", "Diqqət", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                   
                }
            }
        }

        private bool _closeMode;

       

        private void Calculate(object sender, EventArgs e)
        {
            if (CustomerTxb.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Müştəri məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            _thread = new Thread(CalculateOrder) { IsBackground = true };
            _thread.Start();

        }

        private void CalculateOrder()
        {
            Invoke(new Action(() =>
            {
                groupControl3.Enabled = false;
                progress.Show();
            }));
            try
            {
                using (SqlConnection con = new SqlConnection(Variables.ConnectionString))
                {
                  
                    con.Open();
                    SqlCommand command = con.CreateCommand();
                    command.CommandText = "SP_ERP_OBA_VEYSELOGLU_ORDER";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PRODUCTS", _products);
                    command.Parameters.AddWithValue("@PRODUCT_DETAILS", ItemDetails);
                    command.Parameters.AddWithValue("@PRODUCTS_STOCKS", Stock);
                    command.Parameters.AddWithValue("@AMBAR", SourceBranchCmbx.Text);
                    command.Parameters.AddWithValue("@GERIYE_GUN", Convert.ToInt16(calcDayCount.Text));
                    command.Parameters.AddWithValue("@SIFARIS_GUN", Convert.ToInt16(orderDayCount.Text));
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    _orderTable = new DataTable();
                    da.Fill(_orderTable);
                    Invoke(new Action(() => { grid.DataSource = _orderTable; }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {

                    XtraMessageBox.Show(string.Format("{0}\n{1}", ex.Message, ex), "Xəta!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }));
            }
            finally
            {
                Invoke(new Action(() =>
                {
                    progress.Hide();
                    gridView1.BestFitColumns();
                    groupControl3.Enabled = true;
                }));
            }

        }

        private void gridView1_CustomDrawRowIndicator(object sender,
            RowIndicatorCustomDrawEventArgs e)
        {

            if (e.Info.Kind == IndicatorKind.Header)
            {
                e.Info.DisplayText = "№";
            }
            else if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();

        }

        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                e.Handled = XtraMessageBox.Show("Seçilmiş sətirlər silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;


            }
            if (e.Button.ButtonType == NavigatorButtonType.Custom)
            {
                if (e.Button.Tag.Equals("1"))
                {

                    SaveFileDialog sv = new SaveFileDialog();
                    sv.AddExtension = true;
                    sv.DefaultExt = "Excel | *.xlsx";
                    sv.Filter = @"Excel | *.xlsx";
                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        if (sv.FileName == string.Empty)
                        {
                            MessageBox.Show(@"Ad boşdur");
                            return;
                        }
                        gridView1.ExportToXlsx(sv.FileName);
                    }
                }
                if (e.Button.Tag.Equals("2"))
                {
                    SetAmount amount = new SetAmount();
                    if (amount.ShowDialog() == DialogResult.OK)
                    {
                        if (XtraMessageBox.Show(
                            string.Format("Seçilmiş sətirlərdə sifariş miqdarı {0} bərabər olacaq\nDavam edirsiz?",
                                amount.amount.Text.Trim()), "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                            DialogResult.Yes) return;

                        if (gridView1.GetSelectedRows().Count() <= 0) return;
                        int[] a = gridView1.GetSelectedRows();
                        for (int i = 0; i < a.Length; i++)
                        {
                            DataRowView row = (DataRowView) gridView1.GetRow(a[i]);
                            row.Row["RESULT"] = amount.amount.Text.Trim();
                            gridView1.RefreshRow(a[i]);
                            gridView1.UnselectRow(a[i]);

                        }


                    }
                    e.Handled = false;
                }
            }
        }



        private void NewPurchOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_closeMode)
                e.Cancel = XtraMessageBox.Show("Etdiyiniz dəyişiklər yadda saxlanılmayıb! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void gridView1_EditFormPrepared(object sender, EditFormPreparedEventArgs e)
        {
            Control ctrl = FindControl(e.Panel, "Update");
            if (ctrl != null)
                ctrl.Text = @"Dəyiş";
            ctrl = FindControl(e.Panel, "Cancel");
            if (ctrl != null)
                ctrl.Text = @"Ləğv Et";



        }

        public Control FindControl(Control root, string text)
        {
            if (root == null) throw new ArgumentNullException("root");
            foreach (Control child in root.Controls)
            {
                if (child.Text == text) return child;
                Control found = FindControl(child, text);
                if (found != null) return found;
            }
            return null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (view != null)
                {
                    string requested = view.GetRowCellDisplayText(e.RowHandle, view.Columns["RESULT"]).Trim();
                    if (requested=="0" || requested=="")
                    {e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


        
            if (!_orderTable.Select("RESULT>0").Any())
            {
                XtraMessageBox.Show("Uyğun material yoxdur!", "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string currency = _soapService.TodayCurrency(_userNameBase64, _passwordBase64, _imeiBase64);
            splashScreenManager1.ShowWaitForm();
            var dt = _orderTable.Select("RESULT>0").CopyToDataTable();
            var master = new ClsOrderMaster
            {
                SOURCE_WH = warehouses[0].order_warehouse,
                ARP_CODE = CustomerTxb.Text,
                DOC_TRACK_NR = "OBA"+ DateTime.Today.ToString("dd-MM-yyyy hh:mm:ss"),
                DIVISION = "0",
                SALESMAN_CODE = userCodes[0].usercode,
                RC_RATE = currency
            };

        
            ArrayOfString lines = new ArrayOfString();
        
            for (var i=0 ; i < dt.Rows.Count;i++)
            {
               
                lines.Add($"{dt.Rows[i]["ITEMCODE"]}'{dt.Rows[i]["RESULT"]}'{dt.Rows[i]["PRICE"].ToString().Replace(',','.')}'{dt.Rows[i]["UNIT"]}'{warehouses[0].order_warehouse}'{currency}'{userCodes[0].usercode}'");
            }
            
            ClsResult result = new ClsResult();

            result = _soapService.LogoOrderWithResult(_userNameBase64, _passwordBase64, _imeiBase64, 2, "", master,lines);

            XtraMessageBox.Show(result.status + "\n" + result.message);

            splashScreenManager1.CloseWaitForm();
        }



        private void gridView1_CellValueChanged(object sender,
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRowView row = (DataRowView) gridView1.GetFocusedRow();
            if (row != null)
            {
                if ((string.IsNullOrEmpty(e.Value.ToString().Trim()) ? 0f : float.Parse(e.Value.ToString())) > float.Parse(row.Row["MAXLEVEL"].ToString()))
                {
                    gridView1.CancelUpdateCurrentRow();
                    alertControl1.Show(this, "Səhf", "Maksimum stok səviyyəsini keçmək olmaz!");
                    return;
                }

                if ((string.IsNullOrEmpty(e.Value.ToString().Trim()) ? 0f :float.Parse(e.Value.ToString())) > float.Parse(row.Row["VEYSELOGLU_STOK"].ToString()))   
                {
                    row.Row["RESULT"] = float.Parse(row.Row["VEYSELOGLU_STOK"].ToString());
                    gridView1.RefreshRow(e.RowHandle);
                    alertControl1.Show(this, "Səhf", "Anbar stokundan artıq miqdar daxil etmisiniz!");
                }
            }

        }

    

        private void NewWhouseOrder_Load(object sender, EventArgs e)
        {
           
        }

        System.IO.Stream str = new System.IO.MemoryStream();

     

      
    }
}
