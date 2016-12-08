using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using ERP.General;
using UnityObjects;


namespace ERP.Finance
{
    public partial class ExcelToInvoice : XtraForm
    {
        public ExcelToInvoice()
        {
            InitializeComponent();
            
            SetTable();
            gridControl1.DataSource = _dt;
            _units = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                $"SELECT LINENR,CODE,UNITSETREF FROM {Variables.FirmDb}LG_{Variables.FirmNr}_UNITSETL");
            _app = Variables.UnityApplication;
            dateEdit.DateTime=DateTime.Today;
        }
        private readonly UnityApplicationClass _app;
        DataTable GetUnits(string unitRef)
        {
            DataTable sorted = new DataTable();
           if(_units.Select($"UNITSETREF={unitRef}").Any())
             sorted = _units.Select($"UNITSETREF={unitRef}", "LINENR ASC").CopyToDataTable();
            return sorted;
        }
        private readonly DataTable _units;
        void SetTable()
        {
            _dt = new DataTable();
            #region Master
            _dt.Columns.Add("ID", typeof(int));
            _dt.Columns.Add("LINETYPE", typeof(int));
            _dt.Columns.Add("LINETYPENAME", typeof(string));
            _dt.Columns.Add("BRANCH", typeof(int));
            _dt.Columns.Add("BRANCHNAME", typeof(string));
            _dt.Columns.Add("SOURCEINDEX", typeof(int));
            _dt.Columns.Add("WHOUSE", typeof(string));
            _dt.Columns.Add("WHOUSEBRANCH", typeof(string));
            _dt.Columns.Add("CLIENTCODE", typeof(string));
            _dt.Columns.Add("CLIENTNAME", typeof(string));
            _dt.Columns.Add("COSTCENTRECODE", typeof(string));
            _dt.Columns.Add("COSTCENTRENAME", typeof(string));
            _dt.Columns.Add("TRADINGGROUPCODE", typeof(string));
            _dt.Columns.Add("TRADINGGROUPNAME", typeof(string));
            _dt.Columns.Add("PROJECTCODE", typeof(string));
            _dt.Columns.Add("PROJECTNAME", typeof(string));
            _dt.Columns.Add("EXPLANATION", typeof(string));
            _dt.Columns.Add("DATE", typeof(DateTime));
            _dt.Columns.Add("ERRORSTRING", typeof(string));
            _dt.Columns.Add("BILLED", typeof(bool));
            _dt.Columns.Add("RESULT", typeof(string));
            #endregion
            #region Detail
            _dt.Columns.Add("ITEMREF", typeof(int));
            _dt.Columns.Add("CODE", typeof(string));
            _dt.Columns.Add("BARCODE", typeof(string));
            _dt.Columns.Add("NAME", typeof(string));
            _dt.Columns.Add("AMOUNT", typeof(float));
            _dt.Columns.Add("UNIT", typeof(string));
            _dt.Columns.Add("UNITSETREF", typeof(int));
            _dt.Columns.Add("PRICE", typeof(float));
            _dt.Columns.Add("LINETOTAL", typeof(float));
            #endregion
            #region ColumnProperities
            _dt.Columns["LINETOTAL"].Expression = "PRICE*AMOUNT";
            _dt.Columns["ID"].AutoIncrement = true;
            _dt.Columns["ID"].AutoIncrementSeed = _dt.Columns["ID"].AutoIncrementSeed = 1;
            _dt.Columns["SOURCEINDEX"].AllowDBNull = true;
            _dt.Columns["WHOUSEBRANCH"].AllowDBNull = true;
            _dt.Columns["BILLED"].DefaultValue = false;
            #endregion
        }
        string ClipboardData
        {
            get
            {
               
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";
                if (iData.GetDataPresent(DataFormats.Text))
                    return  (string)iData.GetData(DataFormats.Text);
                return "";
            }
        }
        void AddRow(string data)
        {
            if (data == string.Empty) return;
            var rowData = data.Split(new[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries);
            var newRow = gridView1.GetFocusedDataRow();
            var startColumnIndex = gridView1.FocusedColumn.VisibleIndex;

          
         
            foreach (var rowCell  in rowData)
            {
                var cell = rowCell.Split('\t');
                var rowHandle = gridView1.FocusedRowHandle;
                var currentRow = gridView1.GetDataRow(rowHandle);
                for (var i = 0; i < cell.Length; i++)
                {
                    var visibleColumn = gridView1.GetVisibleColumn(startColumnIndex+i);
                    if (visibleColumn == null) break;
                    try
                    {
                      
                        RefreshRow(visibleColumn, cell[i], currentRow);
                        gridView1.RefreshRowCell(rowHandle, visibleColumn);
                       
                    }
                    catch
                    {
                        // ignored
                    }
                }
                gridView1.UpdateCurrentRow();
                if (gridView1.IsLastVisibleRow)
                {

                    gridView1.AddNewRow();
                    // gridView1.MoveLastVisible();
                    gridView1.MoveNext();
                    gridView1.RefreshEditor(true);
                    var row = gridView1.GetFocusedDataRow();
                    var type = TypeCmbx.Text.Split('-');
                    row["LINETYPE"] = type[0].Trim();
                    row["LINETYPENAME"] = type[1].Trim();
                    row["DATE"] = dateEdit.DateTime;
                    gridView1.UpdateCurrentRow();
                }
                else
                {
                    gridView1.MoveNext();
                   // gridView1.RefreshEditor(true);
                }


            }
           
        }
        private DataTable _dt;

        bool ValidateRows()
        {
           
            var count = 0;
            foreach (DataRow row in _dt.Rows)
            {
                if((bool)row["BILLED"]) continue;
                if (string.IsNullOrEmpty(row["BRANCH"]?.ToString().Trim()))
                {
                    count++;
                    row["RESULT"] = "Filial daxil edilməyib";
                }
                if (string.IsNullOrEmpty(row["SOURCEINDEX"]?.ToString().Trim()))
                {
                    count++;
                    row["RESULT"] = "Anbar daxil edilməyib";
                }
                if (string.IsNullOrEmpty(row["DATE"]?.ToString().Trim()))
                {
                    count++;
                    row["RESULT"] = "Tarix daxil edilməyib";
                }
                if (string.IsNullOrEmpty(row["CODE"]?.ToString().Trim()))
                {
                    count++;
                    row["RESULT"] = "Material daxil edilməyib";
                }
                if (string.IsNullOrEmpty(row["AMOUNT"]?.ToString().Trim()))
                {
                    count++;
                    row["RESULT"] = "Miqdar daxil edilməyib";
                }
                if (string.IsNullOrEmpty(row["PRICE"]?.ToString().Trim()))
                {
                    count++;
                    row["RESULT"] = "Qiymet daxil edilməyib";
                }
            }

            return (count==0);
        }
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Down)
            {
                if (gridView1.IsLastVisibleRow)
                {
                    gridView1.AddNewRow();
                    var row = gridView1.GetFocusedDataRow();
                    var type = TypeCmbx.Text.Split('-');
                    row["LINETYPE"] = type[0].Trim();
                    row["LINETYPENAME"] = type[1].Trim();
                    row["DATE"] = dateEdit.DateTime;
                }
            }
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "DATE")
            {
                gridView1.RefreshRow(e.RowHandle); return;
            }
            if (string.IsNullOrEmpty(e.Value?.ToString())) return;
            switch (e.Column.Name)
            {
                #region Branch
                case "BRANCH":
                {
                    var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                        $"SELECT NR,NAME FROM L_CAPIDIV WHERE FIRMNR={Variables.FirmNr} AND NR={e.Value}");
                    if (dt.Rows.Count == 0)
                    {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Iş yeri tapılmadı!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                        var newRow = gridView1.GetDataRow(e.RowHandle);
                        newRow.BeginEdit();
                        newRow["BRANCH"] = dt.Rows[0]["NR"];
                        newRow["BRANCHNAME"] = dt.Rows[0]["NAME"];
                        if (newRow["WHOUSEBRANCH"].ToString().Trim() != dt.Rows[0]["NR"].ToString().Trim())
                        {
                            newRow["SOURCEINDEX"] = DBNull.Value;
                            newRow["WHOUSE"] = DBNull.Value;
                            newRow["WHOUSEBRANCH"] = DBNull.Value;
                        }
                        newRow.EndEdit();

                    }
                    break;
                case "BRANCHNAME":
                    {
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                            $"SELECT NR,NAME FROM L_CAPIDIV WHERE FIRMNR={Variables.FirmNr} AND NAME='{e.Value.ToString().Trim()}'");
                        if (dt.Rows.Count == 0)
                        {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Iş yeri tapılmadı!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var newRow = gridView1.GetDataRow(e.RowHandle);
                        newRow.BeginEdit();
                        newRow["BRANCH"] = dt.Rows[0]["NR"];
                        newRow["BRANCHNAME"] = dt.Rows[0]["NAME"];
                        if (newRow["WHOUSEBRANCH"].ToString().Trim() != dt.Rows[0]["NR"].ToString().Trim())
                        {
                            newRow["SOURCEINDEX"] = DBNull.Value;
                            newRow["WHOUSE"] = DBNull.Value;
                            newRow["WHOUSEBRANCH"] = DBNull.Value;
                        }
                        newRow.BeginEdit();
                    }
                    break;
                #endregion
                #region Whouse
                case "SOURCEINDEX":
                    {
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection, 
                   $@" SELECT DIV.NR BRANCH,DIV.NAME BRANCHNAME,WH.NR,WH.NAME FROM L_CAPIDIV DIV
                    INNER JOIN L_CAPIWHOUSE WH ON WH.DIVISNR = DIV.NR 
                    AND WH.FIRMNR = DIV.FIRMNR AND DIV.FIRMNR = { Variables.FirmNr} AND WH.NR={e.Value}");
                       
                        if (dt.Rows.Count == 0)
                        {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Anbar tapılmadı!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var row = dt.Rows[0];
                        var newRow = gridView1.GetDataRow(e.RowHandle);
                        if (newRow["BRANCH"].ToString().Trim() != row["BRANCH"].ToString().Trim())
                        {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Anbar nömrəsi iş yerinə uygun deyil!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        newRow.BeginEdit();
                        newRow["SOURCEINDEX"] = row["NR"];
                        newRow["WHOUSE"] = row["NAME"];
                        newRow["WHOUSEBRANCH"] = row["BRANCH"];
                        newRow.EndEdit();
                    }
                    break;
                case "WHOUSE":
                    {
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                   $@" SELECT DIV.NR BRANCH,DIV.NAME BRANCHNAME,WH.NR,WH.NAME FROM L_CAPIDIV DIV
                    INNER JOIN L_CAPIWHOUSE WH ON WH.DIVISNR = DIV.NR 
                    AND WH.FIRMNR = DIV.FIRMNR AND DIV.FIRMNR = {Variables.FirmNr} AND WH.NAME='{e.Value}'");

                        if (dt.Rows.Count == 0)
                        {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Anbar tapılmadı!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var row = dt.Rows[0];
                        var newRow = gridView1.GetDataRow(e.RowHandle);
                        if (newRow["BRANCH"].ToString().Trim() != row["BRANCH"].ToString().Trim())
                        {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Anbar nömrəsi iş yerinə uygun deyil!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        newRow.BeginEdit();
                        newRow["SOURCEINDEX"] = row["NR"];
                        newRow["WHOUSE"] = row["NAME"];
                        newRow["WHOUSEBRANCH"] = row["BRANCH"];
                        newRow.EndEdit();
                    }
                    break;
                #endregion
                #region ClientCards 
                case "CLIENTCODE":
                case "CLIENTNAME":
                    {
                       var filtr = string.Format(" WHERE {1} LIKE '{0}'", e.Value.ToString().Trim(), (e.Column.Name== "CLIENTNAME") ? "DEFINITION_" : "CODE");
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                  string.Format(@"SELECT CODE,DEFINITION_ N'DEFINITION_' FROM {1}LG_{2}_CLCARD {0}", filtr, Variables.FirmDb, Variables.FirmNr));

                        if (dt.Rows.Count == 0)
                        {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Cari tapılmadı!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var row = dt.Rows[0];
                        var currentRow = gridView1.GetDataRow(e.RowHandle);
                        currentRow.BeginEdit();
                        currentRow["CLIENTCODE"] = row["CODE"];
                        currentRow["CLIENTNAME"] = row["DEFINITION_"];
                        currentRow.EndEdit();
                    }
                    break;
                #endregion
                #region Items
                case "CODE":
                case "NAME":
                    {
                        var currentRow = gridView1.GetFocusedDataRow();
                        var type = (int)currentRow["LINETYPE"];
                        string query;
                        switch (type)
                        {
                            case 4:
                                {
                                    var filtr = (e.Column.Name == "CODE") ? $" CODE LIKE '{ e.Value.ToString().Trim()}%'" : $" DEFINITION_ LIKE '%{ e.Value.ToString().Trim()}%'";
                                    query =
                                        $@" SELECT LOGICALREF,'' BARCODE ,CODE,DEFINITION_ NAME,UNITSETREF FROM {Variables.FirmDb}LG_{Variables.FirmNr}_SRVCARD WHERE  CARDTYPE=1 AND {filtr} ";
                                }
                                break;
                            case 9:
                                {
                                    var filtr = (e.Column.Name == "CODE") ? $" CODE LIKE '%{e.Value.ToString().Trim()}%'" : $" DEFINITION_ LIKE '%{ e.Value.ToString().Trim()}%'";
                                    query =
                                        $@" SELECT LOGICALREF,'' BARCODE ,CODE,DEFINITION_ NAME,UNITSETREF FROM {Variables.FirmDb}LG_{Variables.FirmNr}_SRVCARD WHERE  CARDTYPE=2 AND  {filtr} ";
                                }
                                break;
                            default:
                                {
                                    var filtr = (e.Column.Name == "CODE") ? $" CODE LIKE '%{ e.Value.ToString().Trim()}%'" : $" NAME LIKE '%{e.Value.ToString().Trim()}%'";
                                    query = string.Format(@"SELECT ITEM.LOGICALREF ,
             (SELECT TOP 1 BARCODE FROM {0}LG_{1}_UNITBARCODE BARCODE WHERE BARCODE.ITEMREF=ITEM.LOGICALREF) BARCODE
            ,ITEM.CODE, ITEM.NAME,ITEM.UNITSETREF  FROM  {0}LG_{1}_ITEMS ITEM  WHERE {2}        
			 ", Variables.FirmDb, Variables.FirmNr, filtr);


                                }
                                break;
                        }
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection, string.Format(query));
                        if (dt.Rows.Count == 0)
                        {
                            gridView1.CancelUpdateCurrentRow();
                            return;
                        }
                        var row = dt.Rows[0];
                        currentRow.BeginEdit();
                        currentRow["ITEMREF"] = row["LOGICALREF"];
                        currentRow["CODE"] = row["CODE"];
                        currentRow["BARCODE"] = row["BARCODE"];
                        currentRow["NAME"] = row["NAME"];
                        currentRow["UNITSETREF"] = row["UNITSETREF"];
                        currentRow.EndEdit();
                    }
                    break;
                    #endregion
            }
            gridView1.RefreshRow(e.RowHandle);
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
                if (gridView1.FocusedColumn.Name.Length > 0)
                {
                    AddRow(ClipboardData);
                }
        }
        private void RefreshRow(GridColumn column,object value,DataRow currentRow)
        {
            if (string.IsNullOrEmpty(value.ToString())) return;
            switch (column.Name)
            {
                #region Branch
                case "BRANCH":
                {
                    int outValue;
                        if (!int.TryParse(value.ToString(),out outValue)) return;
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                            $"SELECT NR,NAME FROM L_CAPIDIV WHERE FIRMNR={Variables.FirmNr} AND NR={outValue}");
                        if (dt.Rows.Count == 0)
                        return;
                      
                        currentRow.BeginEdit();
                        currentRow["BRANCH"] = dt.Rows[0]["NR"];
                        currentRow["BRANCHNAME"] = dt.Rows[0]["NAME"];
                        if (currentRow["WHOUSEBRANCH"].ToString().Trim() != dt.Rows[0]["NR"].ToString().Trim())
                        {
                            currentRow["SOURCEINDEX"] = DBNull.Value;
                            currentRow["WHOUSE"] = DBNull.Value;
                            currentRow["WHOUSEBRANCH"] = dt.Rows[0]["NR"];
                        }
                        currentRow.EndEdit();

                    }
                    break;
                case "BRANCHNAME":
                    {
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                            $"SELECT NR,NAME FROM L_CAPIDIV WHERE FIRMNR={Variables.FirmNr} AND NAME='{value.ToString().Trim()}'");
                        if (dt.Rows.Count == 0)
                        {
                            gridView1.CancelUpdateCurrentRow();
                            return;
                        }
                       
                        currentRow.BeginEdit();
                        currentRow["BRANCH"] = dt.Rows[0]["NR"];
                        currentRow["BRANCHNAME"] = dt.Rows[0]["NAME"];
                        if (currentRow["WHOUSEBRANCH"].ToString().Trim() != dt.Rows[0]["NR"].ToString().Trim())
                        {
                            currentRow["SOURCEINDEX"] = DBNull.Value;
                            currentRow["WHOUSE"] = DBNull.Value;
                            currentRow["WHOUSEBRANCH"] = DBNull.Value;
                        }
                        currentRow.BeginEdit();
                    }
                    break;
                #endregion
                #region Whouse
                case "SOURCEINDEX":
                    {
                        int outValue;
                        if (!int.TryParse(value.ToString(), out outValue)) return;
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                   $@" SELECT DIV.NR BRANCH,DIV.NAME BRANCHNAME,WH.NR,WH.NAME FROM L_CAPIDIV DIV
                    INNER JOIN L_CAPIWHOUSE WH ON WH.DIVISNR = DIV.NR 
                    AND WH.FIRMNR = DIV.FIRMNR AND DIV.FIRMNR = { Variables.FirmNr} AND WH.NR={value}");

                        if (dt.Rows.Count == 0) return;
                        var row = dt.Rows[0];
                        if (currentRow["BRANCH"].ToString().Trim() != row["BRANCH"].ToString().Trim()) return;
                        currentRow.BeginEdit();
                        currentRow["SOURCEINDEX"] = row["NR"];
                        currentRow["WHOUSE"] = row["NAME"];
                        currentRow["WHOUSEBRANCH"] = row["BRANCH"];
                        currentRow.EndEdit();
                    }
                    break;
                case "WHOUSE":
                    {
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                   $@" SELECT DIV.NR BRANCH,DIV.NAME BRANCHNAME,WH.NR,WH.NAME FROM L_CAPIDIV DIV
                    INNER JOIN L_CAPIWHOUSE WH ON WH.DIVISNR = DIV.NR 
                    AND WH.FIRMNR = DIV.FIRMNR AND DIV.FIRMNR = {Variables.FirmNr} AND WH.NAME='{value}'");

                        if (dt.Rows.Count == 0)
                        {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Anbar tapılmadı!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var row = dt.Rows[0];
                   
                        if (currentRow["BRANCH"].ToString().Trim() != row["BRANCH"].ToString().Trim())
                        {
                            gridView1.CancelUpdateCurrentRow();
                            XtraMessageBox.Show("Anbar nömrəsi iş yerinə uygun deyil!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        currentRow.BeginEdit();
                        currentRow["SOURCEINDEX"] = row["NR"];
                        currentRow["WHOUSE"] = row["NAME"];
                        currentRow["WHOUSEBRANCH"] = row["BRANCH"];
                        currentRow.EndEdit();
                    }
                    break;
                #endregion
                #region ClientCards 
                case "CLIENTCODE":
                case "CLIENTNAME":
                    {
                        var filtr = string.Format(" WHERE {1} LIKE '{0}'", value.ToString().Trim(), (column.Name == "CLIENTNAME") ? "DEFINITION_" : "CODE");
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                  string.Format(@"SELECT CODE,DEFINITION_ N'DEFINITION_' FROM {1}LG_{2}_CLCARD {0}", filtr, Variables.FirmDb, Variables.FirmNr));
                      
                        if (dt.Rows.Count == 0)
                        {
                            currentRow["CLIENTCODE"] = "";
                            currentRow["CLIENTNAME"] = "";
                            return;
                        }
                        var row = dt.Rows[0];
                       
                        currentRow.BeginEdit();
                        currentRow["CLIENTCODE"] = row["CODE"];
                        currentRow["CLIENTNAME"] = row["DEFINITION_"];
                        currentRow.EndEdit();
                    }
                    break;
                #endregion
                #region Items
                case "CODE":
                case "NAME":
                    {
                       
                        var type = (int) currentRow["LINETYPE"];
                        string query;
                        switch (type)
                        {
                            case 4:
                            {
                                var filtr = (column.Name=="CODE") ? $" CODE LIKE '{ value.ToString().Trim()}%'" : $" DEFINITION_ LIKE '%{ value.ToString().Trim()}%'";
                                query =
                                    $@" SELECT LOGICALREF,'' BARCODE ,CODE,DEFINITION_ NAME,UNITSETREF FROM {Variables.FirmDb}LG_{Variables.FirmNr}_SRVCARD WHERE  CARDTYPE=1 AND {filtr} ";
                            }
                                break;
                            case 9:
                            {
                                var filtr = (column.Name == "CODE") ? $" CODE LIKE '%{value.ToString().Trim()}%'" : $" DEFINITION_ LIKE '%{ value.ToString().Trim()}%'";
                                query =
                                    $@" SELECT LOGICALREF,'' BARCODE ,CODE,DEFINITION_ NAME,UNITSETREF FROM {Variables.FirmDb}LG_{Variables.FirmNr}_SRVCARD WHERE  CARDTYPE=2 AND  {filtr} ";
                            }
                                break;
                            default:
                            {
                                var filtr = (column.Name == "CODE") ? $" CODE LIKE '%{ value.ToString().Trim()}%'" : $" NAME LIKE '%{value.ToString().Trim()}%'";
                                query = string.Format(@"SELECT ITEM.LOGICALREF ,
             (SELECT TOP 1 BARCODE FROM {0}LG_{1}_UNITBARCODE BARCODE WHERE BARCODE.ITEMREF=ITEM.LOGICALREF) BARCODE
            ,ITEM.CODE, ITEM.NAME,ITEM.UNITSETREF  FROM  {0}LG_{1}_ITEMS ITEM  WHERE {2}        
			 ", Variables.FirmDb, Variables.FirmNr, filtr);


                            }
                                break;
                        }
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,string.Format(query));
                        if (dt.Rows.Count == 0) return;
                      
                        var row = dt.Rows[0];
                        currentRow.BeginEdit();
                        currentRow["ITEMREF"] = row["LOGICALREF"];
                        currentRow["CODE"] = row["CODE"];
                        currentRow["BARCODE"] = row["BARCODE"];
                        currentRow["NAME"] = row["NAME"];
                        currentRow["UNITSETREF"] = row["UNITSETREF"];
                        if (_units.Select($"UNITSETREF={row["UNITSETREF"]}").Any())
                            currentRow["UNIT"] = _units.Select($"UNITSETREF={row["UNITSETREF"]}", "LINENR ASC").CopyToDataTable()
                                .Rows[0]["CODE"];
                        

                        currentRow.EndEdit();
                    }
                    break;
                #endregion
                #region decimal
                case "AMOUNT":
                {
                    float outValue;
                    if (!float.TryParse(value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture,
                        out outValue)) return;
                    currentRow.BeginEdit();
                    currentRow["AMOUNT"] = outValue;
                    currentRow.EndEdit();
                }
                    break;
                
                case "PRICE":
                    {
                        float outValue;
                        if (!(float.TryParse(value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture,
                                out outValue))) return;
                        currentRow.BeginEdit();
                        currentRow["PRICE"] = outValue;
                        currentRow.EndEdit();
                    }
                    break;
                #endregion
                #region Projects
                case "PROJECTCODE":
                case "PROJECTNAME":
                    {
                        var filtr = string.Format(" WHERE {1} LIKE '{0}'", value.ToString().Trim(), (column.Name == "PROJECTNAME") ? "NAME" : "CODE");
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                  string.Format(@"SELECT CODE,NAME N'DEFINITION_' FROM {1}LG_{2}_PROJECT {0}", filtr, Variables.FirmDb, Variables.FirmNr));

                        if (dt.Rows.Count == 0) return;
                        var row = dt.Rows[0];
                        currentRow.BeginEdit();
                        currentRow["PROJECTCODE"] = row["CODE"];
                        currentRow["PROJECTNAME"] = row["DEFINITION_"];
                        currentRow.EndEdit();
                    }
                    break;
                #endregion
                #region Costcentre
                case "COSTCENTRECODE":
                case "COSTCENTRENAME":
                    {
                        var filtr = string.Format(" WHERE {1} LIKE '{0}'", value.ToString().Trim(), (column.Name == "COSTCENTRENAME") ? "DEFINITION_" : "CODE");
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                  string.Format(@"SELECT CODE,DEFINITION_ N'DEFINITION_' FROM {1}LG_{2}_EMCENTER {0}", filtr, Variables.FirmDb, Variables.FirmNr));

                        if (dt.Rows.Count == 0)return;
                        var row = dt.Rows[0];
                        currentRow.BeginEdit();
                        currentRow["COSTCENTRECODE"] = row["CODE"];
                        currentRow["COSTCENTRENAME"] = row["DEFINITION_"];
                        currentRow.EndEdit();
                    }
                    break;
                #endregion
                #region Date And Explanation
                case "EXPLANATION":
                {
                       
                        currentRow.BeginEdit();
                        currentRow["EXPLANATION"] = value.ToString().Replace('\'',' ');
                        currentRow.EndEdit();
                 }
                    break;
                case "DATE":
                    {
                       
                        DateTime dt;
                         if(!DateTime.TryParse(value.ToString(), CultureInfo.InvariantCulture,DateTimeStyles.None, out dt)) return;
                        currentRow.BeginEdit();
                        currentRow["DATE"] = dt;
                        currentRow.EndEdit();
                    }
                    break;

                #endregion
                #region TradingGroup
                case "TRADINGGROUPCODE":
                case "TRADINGGROUPNAME":
                    {
                        var filtr = string.Format(" AND  {1} LIKE '{0}'", value.ToString().Trim(), (column.Name == "TRADINGGROUPNAME") ? "GDEF" : "GCODE");
                        var dt = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                            $@"SELECT GCODE N'CODE',GDEF N'DEFINITION_' FROM L_TRADGRP WHERE ACTIVE=0  {filtr}");

                        if (dt.Rows.Count == 0) return;
                        var row = dt.Rows[0];
                        currentRow.BeginEdit();
                        currentRow["TRADINGGROUPCODE"] = row["CODE"];
                        currentRow["TRADINGGROUPNAME"] = row["DEFINITION_"];
                        currentRow.EndEdit();
                    }
                    break;
                    #endregion
            }
        }

        #region repostory
        private void BranchRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BranchList branch = new BranchList();
            if (branch.ShowDialog() == DialogResult.OK)
            {
                var row = branch.gridView1.GetFocusedDataRow();
                if (row == null) return;
                var currentRow = gridView1.GetFocusedDataRow();
                currentRow["BRANCH"] = row["NR"];
                currentRow["BRANCHNAME"] = row["NAME"];
                if (currentRow["WHOUSEBRANCH"].ToString().Trim() != row["NR"].ToString().Trim())
                {
                    currentRow["SOURCEINDEX"] = DBNull.Value;
                    currentRow["WHOUSE"] = DBNull.Value;

                }
                gridView1.UpdateCurrentRow();
            }
        }
        private void WhouseRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            WhouseList branch = new WhouseList();
            if (branch.ShowDialog() == DialogResult.OK)
            {
                var row = branch.gridView1.GetFocusedDataRow();
                if (row == null) return;
                var currentRow = gridView1.GetFocusedDataRow();
                if (currentRow["BRANCH"].ToString().Trim() != row["BRANCH"].ToString().Trim())
                {
                    XtraMessageBox.Show("Anbar nömrəsi iş yerinə uygun deyil!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridView1.CancelUpdateCurrentRow();
                    return;
                }
                currentRow.BeginEdit();
                currentRow["SOURCEINDEX"] = row["NR"];
                currentRow["WHOUSE"] = row["NAME"];
                currentRow["WHOUSEBRANCH"] = row["BRANCH"];
                currentRow.EndEdit();

            }
        }
        private void ClientRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ClientCards cards = new ClientCards();
            if (cards.ShowDialog() == DialogResult.OK)
            {
                var row = cards.gridView1.GetFocusedDataRow();
                if (row == null) return;
                var currentRow = gridView1.GetFocusedDataRow();
                currentRow.BeginEdit();
                currentRow["CLIENTCODE"] = row["CODE"];
                currentRow["CLIENTNAME"] = row["DEFINITION_"];
                currentRow.EndEdit();
            }
        }
        private void ItemRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var currentRow = gridView1.GetFocusedDataRow();

            ItemList item = new ItemList {Type = (int) currentRow["LINETYPE"]};
            if (item.ShowDialog() == DialogResult.OK)
            {
                var row = item.view.GetFocusedDataRow();
                if (row == null) return;
                currentRow["ITEMREF"] = row["LOGICALREF"];
                currentRow["CODE"] = row["CODE"];
                currentRow["BARCODE"] = row["BARCODE"];
                currentRow["NAME"] = row["NAME"];
                currentRow["UNITSETREF"] = row["UNITSETREF"];
                if (_units.Select($"UNITSETREF={row["UNITSETREF"]}").Any())
                    currentRow["UNIT"] = _units.Select($"UNITSETREF={row["UNITSETREF"]}", "LINENR ASC").CopyToDataTable()
                        .Rows[0]["CODE"];
                gridView1.UpdateCurrentRow();
            }
        }
        private void UnitRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var currentRow = gridView1.GetFocusedDataRow();
            if(string.IsNullOrEmpty(currentRow["UNITSETREF"].ToString().Trim()))
            return;
            Units unit = new Units();
            unit.list.DataSource = GetUnits(currentRow["UNITSETREF"].ToString());
            if (unit.ShowDialog() == DialogResult.OK)
            {
                var item = unit.list.SelectedValue;
                if(item==null) return;
                currentRow.BeginEdit();
                currentRow["UNIT"] = item.ToString();
                currentRow.EndEdit();
                gridView1.UpdateCurrentRow();
            }
            
        }
        private void ProjectCodeRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var currentRow = gridView1.GetFocusedDataRow();
              ProjAndCost item  = new ProjAndCost(1);
            if (item.ShowDialog() == DialogResult.OK)
            {
                var row = item.gridView1.GetFocusedDataRow();
                if (row == null) return;
                currentRow["PROJECTCODE"] = row["CODE"];
                currentRow["PROJECTNAME"] = row["DEFINITION_"];
                gridView1.UpdateCurrentRow();
            }
        }
        private void CostCentreRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var currentRow = gridView1.GetFocusedDataRow();
            ProjAndCost item = new ProjAndCost(0);
            if (item.ShowDialog() == DialogResult.OK)
            {
                var row = item.gridView1.GetFocusedDataRow();
                if (row == null) return;
                currentRow["COSTCENTRECODE"] = row["CODE"];
                currentRow["COSTCENTRENAME"] = row["DEFINITION_"];
                gridView1.UpdateCurrentRow();
            }
        }
        private void TradingGroupRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var currentRow = gridView1.GetFocusedDataRow();
            ProjAndCost item = new ProjAndCost(2);
            if (item.ShowDialog() == DialogResult.OK)
            {
                var row = item.gridView1.GetFocusedDataRow();
                if (row == null) return;
                currentRow["TRADINGGROUPCODE"] = row["CODE"];
                currentRow["TRADINGGROUPNAME"] = row["DEFINITION_"];
                gridView1.UpdateCurrentRow();
            }
        }
        #endregion

        private void ExcelToInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridView1.SaveLayoutToRegistry(@"HKEY_CURRENT_USER\Software\AzRetail - ERP\Layouts\ExcelToInvoice");
          
        }
        private void ExcelToInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                using (var str = new System.IO.MemoryStream())
                {
                    gridView1.SaveLayoutToStream(str);
                    str.Seek(0, System.IO.SeekOrigin.Begin);
                }
                gridView1.RestoreLayoutFromRegistry(@"HKEY_CURRENT_USER\Software\AzRetail - ERP\Layouts\ExcelToInvoice");
            }
            catch (Exception)
            {
                // ignored
            }

          
        }
        private void DeleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          gridView1.DeleteSelectedRows();
        }
        private void ClearList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _dt.Clear();
        }
        private void SetDefaultWhouse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0) return;
            var selectedRows = gridView1.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                var row = gridView1.GetDataRow(rowHandle);
                if (string.IsNullOrEmpty(row["BRANCH"]?.ToString())) continue;
                var result = Functions.GetSqlServerDataTable(Variables.TigerConnection,
                $@" SELECT DIV.NR BRANCH,DIV.NAME BRANCHNAME,WH.NR,WH.NAME FROM L_CAPIDIV DIV
                    INNER JOIN L_CAPIWHOUSE WH ON WH.DIVISNR = DIV.NR 
                    AND WH.FIRMNR = DIV.FIRMNR AND DIV.FIRMNR = { Variables.FirmNr} AND  WH.DIVISNR={row["BRANCH"]}");
                if(result.Rows.Count==0) continue;
                row.BeginEdit();
                row["SOURCEINDEX"] = result.Rows[0]["NR"];
                row["WHOUSE"] = result.Rows[0]["NAME"];
                row["WHOUSEBRANCH"] = result.Rows[0]["BRANCH"];
                row.EndEdit();

            }
        }
        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
                popupMenu1.ShowPopup(MousePosition);
        }
        private void ColCustomizationBtn_Click(object sender, EventArgs e)
        {
            gridView1.ShowCustomization();
        }
        private void ColumnstPopUpBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Davam edirsiz?", "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes)
                return;

            if (!_dt.Select("BILLED = 0").Any()) return;
            if (!ValidateRows())
            {
                XtraMessageBox.Show(
                    "Xətalı sətirlər var!\n Xanalar mütləq daxil edilməlidir!", "Diqqət!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            splashScreenManager1.ShowWaitForm();
            if (!_app.LoggedIn)
                if (
                    !_app.Login(Variables.TigerUserName, Variables.TigerUserPassword, int.Parse(Variables.FirmNr),
                        int.Parse(Variables.FirmPeriod)))
                {
                    XtraMessageBox.Show(_app.GetLastErrorString(), "Diqqət", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    splashScreenManager1.CloseWaitForm();
                    return;
                }
            string ficheno;
            string errorMessage;
            #region group
            if (groupByBranch.Checked)
            {
                DataTable master = _dt.DefaultView.ToTable(true, "LINETYPE", "BRANCH", "SOURCEINDEX", "CLIENTCODE",
                    "COSTCENTRECODE", "TRADINGGROUPCODE", "PROJECTCODE", "EXPLANATION", "DATE");
                foreach (DataRow row in master.Rows)
                {

                    var filter = string.Format(@"LINETYPE={0} AND BRANCH={1} AND SOURCEINDEX={2} AND CLIENTCODE = '{3}' 
                    AND COSTCENTRECODE = '{4}' AND TRADINGGROUPCODE = '{5}' AND PROJECTCODE ='{6}' AND EXPLANATION={7} AND DATE='{8}' AND BILLED=0",
                        row["LINETYPE"],
                        row["BRANCH"],
                        row["SOURCEINDEX"],
                        row["CLIENTCODE"],
                        row["COSTCENTRECODE"],
                        row["TRADINGGROUPCODE"],
                        row["PROJECTCODE"],
                        row["EXPLANATION"],
                        row["DATE"]);
                    var filtered = _dt.Select(filter);
                    if (!filtered.Any()) continue;
                    var filteredTable = filtered.CopyToDataTable();
                    int lineType = (int)filteredTable.Rows[0]["LINETYPE"];

                    switch (lineType)
                    {
                        case 1:
                        case 4:
                        case 6:
                            {
                                if (Purch(filteredTable.Rows[0], filteredTable.Select(), out ficheno, out errorMessage))
                                {
                                    foreach (DataRow dr in filteredTable.Select())
                                    {
                                        dr["BILLED"] = true;
                                        dr["RESULT"] = ficheno;
                                    }
                                }
                                else
                                {
                                    foreach (DataRow dr in filteredTable.Select())
                                        dr["ERRORSTRING"] = errorMessage;
                                }
                                break;
                            }

                        case 2:
                        case 3:
                        case 7:
                        case 8:
                        case 9:
                            {
                                if (Sale(filteredTable.Rows[0], filteredTable.Select(), out ficheno, out errorMessage))
                                {
                                   
                                   
                                }
                                else
                                {
                                    foreach (DataRow dr in filteredTable.Select())
                                        dr["ERRORSTRING"] = errorMessage;
                                }

                                break;
                            }

                    }
                    ////

                }
            }
#endregion
            else
            {

               
                foreach (DataRow row in _dt.Select("BILLED=0"))
                {
                    int lineType = (int)row["LINETYPE"];
                    switch (lineType)
                    {
                        case 1:
                        case 4:
                        case 6:
                        {
                            if (Purch(row, row, out ficheno, out errorMessage))
                            {
                                row["BILLED"] = true;
                                row["RESULT"] = ficheno;}
                            else
                            {
                                row["ERRORSTRING"] = errorMessage;
                            }
                                break;
                         }

                        case 2:
                        case 3:
                        case 7:
                        case 8:
                        case 9:
                        {
                                if (Sale(row, row, out ficheno, out errorMessage))
                                {
                                    row["BILLED"] = true;
                                    row["RESULT"] = ficheno;
                                }
                                else
                                {
                                    row["ERRORSTRING"] = errorMessage;
                                }

                                break;
                        }

                    }

                }


            }
            splashScreenManager1.CloseWaitForm();
        }
      

        #region Groupped
        public bool Sale(DataRow  master, DataRow [] detail, out string ficheno, out string errorMessage)
        {
            bool result = false;
            string id = master["ID"].ToString();
            int trcode = (int)master["LINETYPE"];
            var sourceIndex = master["SOURCEINDEX"].ToString();
            Data invoice = _app.NewDataObject(DataObjectType.doSalesInvoice);
            invoice.New();
            invoice.DataFields.FieldByName("TYPE").Value = (int)master["LINETYPE"];
            invoice.DataFields.FieldByName("NUMBER").Value = "~";
            invoice.DataFields.FieldByName("DOC_NUMBER").Value = ((int)master["ID"]).ToString("D10");
            invoice.DataFields.FieldByName("DATE").Value = (DateTime)master["DATE"];
            invoice.DataFields.FieldByName("ARP_CODE").Value = master["CLIENTCODE"].ToString().Trim();
            invoice.DataFields.FieldByName("AUXIL_CODE").Value = "SISTEM";
            invoice.DataFields.FieldByName("DIVISION").Value = master["BRANCH"].ToString().Trim();
            invoice.DataFields.FieldByName("SOURCE_WH").Value = sourceIndex;
            invoice.DataFields.FieldByName("NOTES1").Value = master["EXPLANATION"].ToString().Trim();
            invoice.DataFields.FieldByName("NOTES2").Value = General.User.UserName;
            invoice.DataFields.FieldByName("NOTES4").Value = General.User.UserId;
            invoice.DataFields.FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            invoice.DataFields.FieldByName("TRADING_GRP").Value = master["TRADINGGROUPCODE"]; // Ticari islem qrupu 
            invoice.DataFields.FieldByName("OHP_CODE").Value = master["COSTCENTRECODE"]; // Mesref merkezi
            invoice.DataFields.FieldByName("PROJECT_CODE").Value = master["PROJECTCODE"]; // Project code

            if (trcode == 2) invoice.DataFields.FieldByName("SOURCE_COST_GRP").Value = 1;
            Lines dispatch = invoice.DataFields.FieldByName("DISPATCHES").Lines;

            dispatch.AppendLine();
            dispatch[(dispatch.Count - 1)].FieldByName("TYPE").Value = (int)master["LINETYPE"];
            dispatch[(dispatch.Count - 1)].FieldByName("NUMBER").Value = "~";
            dispatch[(dispatch.Count - 1)].FieldByName("DOC_NUMBER").Value = ((int)master["ID"]).ToString("D10");
            dispatch[(dispatch.Count - 1)].FieldByName("DATE").Value = (DateTime)master["DATE"];
            dispatch[(dispatch.Count - 1)].FieldByName("ARP_CODE").Value = master["CLIENTCODE"].ToString().Trim();
            dispatch[(dispatch.Count - 1)].FieldByName("AUXIL_CODE").Value = "SISTEM";
            dispatch[(dispatch.Count - 1)].FieldByName("DIVISION").Value = master["BRANCH"].ToString();
            dispatch[(dispatch.Count - 1)].FieldByName("SOURCE_WH").Value = sourceIndex;
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES1").Value = master["EXPLANATION"].ToString().Trim();
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES2").Value = General.User.UserName;
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES4").Value = General.User.UserId;
            dispatch[(dispatch.Count - 1)].FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            dispatch[(dispatch.Count - 1)].FieldByName("TRADING_GRP").Value = master["TRADINGGROUPCODE"]; // Ticari islem qrupu 
            dispatch[(dispatch.Count - 1)].FieldByName("OHP_CODE").Value = master["COSTCENTRECODE"]; // Mesref merkezi
            dispatch[(dispatch.Count - 1)].FieldByName("PROJECT_CODE").Value = master["PROJECTCODE"]; // Project code
            if (trcode == 2) dispatch[(dispatch.Count - 1)].FieldByName("SOURCE_COST_GRP").Value = 1;
          

            Lines transaction = invoice.DataFields.FieldByName("TRANSACTIONS").Lines;
            for (var i = 0; i < detail.Length; i++)
            {

                transaction.AppendLine();
                if (trcode == 2)
                {
                    transaction[(transaction.Count - 1)].FieldByName("SOURCECOSTGRP").Value = 1;
                    transaction[(transaction.Count - 1)].FieldByName("RET_COST_TYPE").Value = 1;
                }

                transaction[(transaction.Count - 1)].FieldByName("TYPE").Value = (trcode == 4 || trcode == 9) ? 4 : 0;
                transaction[(transaction.Count - 1)].FieldByName("SOURCEINDEX").Value = sourceIndex;
                transaction[(transaction.Count - 1)].FieldByName("MASTER_CODE").Value = detail[i]["CODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("QUANTITY").Value = (float)detail[i]["AMOUNT"];
                transaction[(transaction.Count - 1)].FieldByName("UNIT_CODE").Value = detail[i]["UNIT"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("PRICE").Value = (float)detail[i]["PRICE"];

                transaction[(transaction.Count - 1)].FieldByName("PROJECT_CODE").Value = detail[i]["PROJECTCODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("OHP_CODE1").Value = detail[i]["COSTCENTRECODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("DESCRIPTION").Value = detail[i]["EXPLANATION"].ToString().Trim();

            }

          
            errorMessage = null;
            if (!invoice.Post())
            {

                if (invoice.ErrorCode != 0)
                {

                    errorMessage += @" DB Error : ( " + (invoice.ErrorCode) + ") - " + invoice.ErrorDesc;
                }
                else if (invoice.ValidateErrors.Count > 0)
                {
                    for (int i = 0; i < invoice.ValidateErrors.Count - 1; i++)
                        errorMessage += @"XML Error : (" + (invoice.ValidateErrors[i].ID) + ") - " +
                                        invoice.ValidateErrors[i].Error;

                }

                if (errorMessage == null) errorMessage = _app.GetLastErrorString();
                errorMessage = (string.IsNullOrEmpty(errorMessage)) ? invoice.ErrorDesc : errorMessage;
                ficheno = null;
            }
            else
            {
                ficheno = invoice.DataFields.FieldByName("NUMBER").Value.ToString();
                result = true;
            }
            return result;

        }
        public bool Purch(DataRow master, DataRow[] detail , out string ficheno, out string errorMessage)
        {
            bool result = false;
            var trcode = (int) master["LINETYPE"];
            var sourceIndex = master["SOURCEINDEX"].ToString();
            Data invoice = _app.NewDataObject(DataObjectType.doPurchInvoice);
            invoice.New();
            invoice.New();
            invoice.DataFields.FieldByName("TYPE").Value = trcode;
            invoice.DataFields.FieldByName("NUMBER").Value = "~";
            invoice.DataFields.FieldByName("DOC_NUMBER").Value = ((int)master["ID"]).ToString("D10");
            invoice.DataFields.FieldByName("DATE").Value = (DateTime)master["DATE"];
            invoice.DataFields.FieldByName("ARP_CODE").Value = master["CLIENTCODE"].ToString().Trim();
            invoice.DataFields.FieldByName("AUXIL_CODE").Value = "SISTEM";
            invoice.DataFields.FieldByName("DIVISION").Value = master["BRANCH"].ToString().Trim();
            invoice.DataFields.FieldByName("SOURCE_WH").Value = sourceIndex;
            invoice.DataFields.FieldByName("NOTES1").Value = master["EXPLANATION"].ToString().Trim();
            invoice.DataFields.FieldByName("NOTES2").Value = General.User.UserName;
            invoice.DataFields.FieldByName("NOTES4").Value = General.User.UserId;
            invoice.DataFields.FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            invoice.DataFields.FieldByName("TRADING_GRP").Value = master["TRADINGGROUPCODE"]; // Ticari islem qrupu 
            invoice.DataFields.FieldByName("OHP_CODE").Value = master["COSTCENTRECODE"]; // Mesref merkezi
            invoice.DataFields.FieldByName("PROJECT_CODE").Value = master["PROJECTCODE"]; // Project code

            Lines dispatch = invoice.DataFields.FieldByName("DISPATCHES").Lines;

            dispatch.AppendLine();
            dispatch[(dispatch.Count - 1)].FieldByName("TYPE").Value = (int)master["LINETYPE"];
            dispatch[(dispatch.Count - 1)].FieldByName("NUMBER").Value = "~";
            dispatch[(dispatch.Count - 1)].FieldByName("DOC_NUMBER").Value = ((int)master["ID"]).ToString("D10");
            dispatch[(dispatch.Count - 1)].FieldByName("DATE").Value = (DateTime)master["DATE"];
            dispatch[(dispatch.Count - 1)].FieldByName("ARP_CODE").Value = master["CLIENTCODE"].ToString().Trim();
            dispatch[(dispatch.Count - 1)].FieldByName("AUXIL_CODE").Value = "SISTEM";
            dispatch[(dispatch.Count - 1)].FieldByName("DIVISION").Value = master["BRANCH"].ToString();
            dispatch[(dispatch.Count - 1)].FieldByName("SOURCE_WH").Value = sourceIndex;
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES1").Value = master["EXPLANATION"].ToString().Trim();
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES2").Value = General.User.UserName;
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES4").Value = General.User.UserId;
            dispatch[(dispatch.Count - 1)].FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            dispatch[(dispatch.Count - 1)].FieldByName("TRADING_GRP").Value = master["TRADINGGROUPCODE"]; // Ticari islem qrupu 
            dispatch[(dispatch.Count - 1)].FieldByName("OHP_CODE").Value = master["COSTCENTRECODE"]; // Mesref merkezi
            dispatch[(dispatch.Count - 1)].FieldByName("PROJECT_CODE").Value = master["PROJECTCODE"]; // Project code

            Lines transaction = invoice.DataFields.FieldByName("TRANSACTIONS").Lines;

            for (var i = 0; i < detail.Length; i++)
            {

                transaction.AppendLine();
              
                transaction[(transaction.Count - 1)].FieldByName("TYPE").Value = (trcode == 4 || trcode == 9) ? 4 : 0;
                transaction[(transaction.Count - 1)].FieldByName("SOURCEINDEX").Value = sourceIndex;
                transaction[(transaction.Count - 1)].FieldByName("MASTER_CODE").Value = detail[i]["CODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("QUANTITY").Value = (float)detail[i]["AMOUNT"];
                transaction[(transaction.Count - 1)].FieldByName("UNIT_CODE").Value = detail[i]["UNIT"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("PRICE").Value = (float)detail[i]["PRICE"];

                transaction[(transaction.Count - 1)].FieldByName("PROJECT_CODE").Value = detail[i]["PROJECTCODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("OHP_CODE1").Value = detail[i]["COSTCENTRECODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("DESCRIPTION").Value = detail[i]["EXPLANATION"].ToString().Trim();

            }

            errorMessage = null;
            if (!invoice.Post())
            {

                if (invoice.ErrorCode != 0)
                {

                    errorMessage += @" DB Error : ( " + (invoice.ErrorCode) + ") - " + invoice.ErrorDesc;
                }
                else if (invoice.ValidateErrors.Count > 0)
                {
                    for (int i = 0; i < invoice.ValidateErrors.Count - 1; i++)
                        errorMessage += @"XML Error : (" + (invoice.ValidateErrors[i].ID) + ") - " +
                                        invoice.ValidateErrors[i].Error;

                }
                ficheno = null;
                errorMessage = (string.IsNullOrEmpty(errorMessage)) ? invoice.ErrorDesc : errorMessage;
                errorMessage = (string.IsNullOrEmpty(errorMessage)) ? _app.GetLastErrorString() : errorMessage;
            }
            else
            {
                ficheno = invoice.DataFields.FieldByName("NUMBER").Value.ToString();
                result = true;
            }
            return result;

        }
        #endregion
        public bool Sale(DataRow master, DataRow detail, out string ficheno, out string errorMessage)
        {
            bool result = false;
            int trcode = int.Parse(master["LINETYPE"].ToString());
            var sourceIndex = master["SOURCEINDEX"].ToString();
            Data invoice = _app.NewDataObject(DataObjectType.doSalesInvoice);

            invoice.New();
            invoice.DataFields.FieldByName("TYPE").Value = (int)master["LINETYPE"];
            invoice.DataFields.FieldByName("NUMBER").Value = "~";
            invoice.DataFields.FieldByName("DOC_NUMBER").Value = ((int)master["ID"]).ToString("D10");
            invoice.DataFields.FieldByName("DATE").Value = (DateTime)master["DATE"];
            invoice.DataFields.FieldByName("ARP_CODE").Value = master["CLIENTCODE"].ToString().Trim();
            invoice.DataFields.FieldByName("AUXIL_CODE").Value = "SISTEM";
            invoice.DataFields.FieldByName("DIVISION").Value = master["BRANCH"].ToString().Trim();
            invoice.DataFields.FieldByName("SOURCE_WH").Value = sourceIndex;
            invoice.DataFields.FieldByName("NOTES1").Value = master["EXPLANATION"].ToString().Trim();
            invoice.DataFields.FieldByName("NOTES2").Value = General.User.UserName;
            invoice.DataFields.FieldByName("NOTES4").Value = General.User.UserId;
            invoice.DataFields.FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            invoice.DataFields.FieldByName("TRADING_GRP").Value = master["TRADINGGROUPCODE"]; // Ticari islem qrupu 
            invoice.DataFields.FieldByName("OHP_CODE").Value = master["COSTCENTRECODE"]; // Mesref merkezi
            invoice.DataFields.FieldByName("PROJECT_CODE").Value = master["PROJECTCODE"]; // Project code

            Lines dispatch = invoice.DataFields.FieldByName("DISPATCHES").Lines;

            dispatch.AppendLine();
            dispatch[(dispatch.Count - 1)].FieldByName("TYPE").Value = (int)master["LINETYPE"];
            dispatch[(dispatch.Count - 1)].FieldByName("NUMBER").Value = "~";
            dispatch[(dispatch.Count - 1)].FieldByName("DOC_NUMBER").Value = ((int)master["ID"]).ToString("D10");
            dispatch[(dispatch.Count - 1)].FieldByName("DATE").Value = (DateTime)master["DATE"];
            dispatch[(dispatch.Count - 1)].FieldByName("ARP_CODE").Value = master["CLIENTCODE"].ToString().Trim();
            dispatch[(dispatch.Count - 1)].FieldByName("AUXIL_CODE").Value = "SISTEM";
            dispatch[(dispatch.Count - 1)].FieldByName("DIVISION").Value = master["BRANCH"].ToString();
            dispatch[(dispatch.Count - 1)].FieldByName("SOURCE_WH").Value = sourceIndex;
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES1").Value = master["EXPLANATION"].ToString().Trim();
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES2").Value = General.User.UserName;
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES4").Value = General.User.UserId;
            dispatch[(dispatch.Count - 1)].FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            dispatch[(dispatch.Count - 1)].FieldByName("TRADING_GRP").Value = master["TRADINGGROUPCODE"]; // Ticari islem qrupu 
            dispatch[(dispatch.Count - 1)].FieldByName("OHP_CODE").Value = master["COSTCENTRECODE"]; // Mesref merkezi
            dispatch[(dispatch.Count - 1)].FieldByName("PROJECT_CODE").Value = master["PROJECTCODE"]; // Project code


           
            Lines transaction = invoice.DataFields.FieldByName("TRANSACTIONS").Lines;
        
                transaction.AppendLine();
                if (trcode == 2)
                {
                    transaction[(transaction.Count - 1)].FieldByName("SOURCECOSTGRP").Value = 1;
                    transaction[(transaction.Count - 1)].FieldByName("RET_COST_TYPE").Value = 0;
                }
               
                transaction[(transaction.Count - 1)].FieldByName("TYPE").Value = (trcode==4|| trcode==9) ? 4 : 0;
                transaction[(transaction.Count - 1)].FieldByName("SOURCEINDEX").Value = sourceIndex;
                transaction[(transaction.Count - 1)].FieldByName("MASTER_CODE").Value = detail["CODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("QUANTITY").Value = (float)detail["AMOUNT"];
                transaction[(transaction.Count - 1)].FieldByName("UNIT_CODE").Value = detail["UNIT"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("PRICE").Value = (float)detail["PRICE"];

                transaction[(transaction.Count - 1)].FieldByName("PROJECT_CODE").Value = detail["PROJECTCODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("OHP_CODE1").Value = detail["COSTCENTRECODE"].ToString();
                transaction[(transaction.Count - 1)].FieldByName("DESCRIPTION").Value =  detail["EXPLANATION"].ToString().Trim();

            errorMessage = null;
            if (!invoice.Post())
            {

                if (invoice.ErrorCode != 0)
                {

                    errorMessage += @" DB Error : ( " + (invoice.ErrorCode) + ") - " + invoice.ErrorDesc;
                }
                else if (invoice.ValidateErrors.Count > 0)
                {
                    for (int i = 0; i < invoice.ValidateErrors.Count - 1; i++)
                        errorMessage += @"XML Error : (" + (invoice.ValidateErrors[i].ID) + ") - " +
                                        invoice.ValidateErrors[i].Error;

                }

                if (errorMessage == null) errorMessage = _app.GetLastErrorString();
                errorMessage = (string.IsNullOrEmpty(errorMessage)) ? invoice.ErrorDesc : errorMessage;
                ficheno = null;
            }
            else
            {
                ficheno = invoice.DataFields.FieldByName("NUMBER").Value.ToString();
                result = true;
            }
            return result;

        }
        public bool Purch(DataRow master, DataRow detail, out string ficheno, out string errorMessage)
        {
           

            bool result = false;
            var sourceIndex = master["SOURCEINDEX"].ToString();
            var trcode = (int) master["LINETYPE"];
            Data invoice = _app.NewDataObject(DataObjectType.doPurchInvoice);
            invoice.New();
            invoice.DataFields.FieldByName("TYPE").Value = trcode;
            invoice.DataFields.FieldByName("NUMBER").Value = "~";
            invoice.DataFields.FieldByName("DOC_NUMBER").Value = ((int)master["ID"]).ToString("D10");
            invoice.DataFields.FieldByName("DATE").Value = (DateTime)master["DATE"];
            invoice.DataFields.FieldByName("ARP_CODE").Value = master["CLIENTCODE"].ToString().Trim();
            invoice.DataFields.FieldByName("AUXIL_CODE").Value = "SISTEM";
            invoice.DataFields.FieldByName("DIVISION").Value = master["BRANCH"].ToString().Trim();
            invoice.DataFields.FieldByName("SOURCE_WH").Value = sourceIndex;
            invoice.DataFields.FieldByName("NOTES1").Value = master["EXPLANATION"].ToString().Trim();
            invoice.DataFields.FieldByName("NOTES2").Value = General.User.UserName;
            invoice.DataFields.FieldByName("NOTES4").Value = General.User.UserId;
            invoice.DataFields.FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            invoice.DataFields.FieldByName("TRADING_GRP").Value = master["TRADINGGROUPCODE"]; // Ticari islem qrupu 
            invoice.DataFields.FieldByName("OHP_CODE").Value = master["COSTCENTRECODE"]; // Mesref merkezi
            invoice.DataFields.FieldByName("PROJECT_CODE").Value = master["PROJECTCODE"]; // Project code

            Lines dispatch = invoice.DataFields.FieldByName("DISPATCHES").Lines;

            dispatch.AppendLine();
            dispatch[(dispatch.Count - 1)].FieldByName("TYPE").Value = (int)master["LINETYPE"];
            dispatch[(dispatch.Count - 1)].FieldByName("NUMBER").Value = "~";
            dispatch[(dispatch.Count - 1)].FieldByName("DOC_NUMBER").Value = ((int)master["ID"]).ToString("D10");
            dispatch[(dispatch.Count - 1)].FieldByName("DATE").Value = (DateTime)master["DATE"];
            dispatch[(dispatch.Count - 1)].FieldByName("ARP_CODE").Value = master["CLIENTCODE"].ToString().Trim();
            dispatch[(dispatch.Count - 1)].FieldByName("AUXIL_CODE").Value = "SISTEM";
            dispatch[(dispatch.Count - 1)].FieldByName("DIVISION").Value = master["BRANCH"].ToString();
            dispatch[(dispatch.Count - 1)].FieldByName("SOURCE_WH").Value = sourceIndex;
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES1").Value = master["EXPLANATION"].ToString().Trim();
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES2").Value = General.User.UserName;
            dispatch[(dispatch.Count - 1)].FieldByName("NOTES4").Value = General.User.UserId;
            dispatch[(dispatch.Count - 1)].FieldByName("DOC_TRACK_NR").Value = "PROGRAMLASDIRMA";
            dispatch[(dispatch.Count - 1)].FieldByName("TRADING_GRP").Value = master["TRADINGGROUPCODE"]; // Ticari islem qrupu 
            dispatch[(dispatch.Count - 1)].FieldByName("OHP_CODE").Value = master["COSTCENTRECODE"]; // Mesref merkezi
            dispatch[(dispatch.Count - 1)].FieldByName("PROJECT_CODE").Value = master["PROJECTCODE"]; // Project code

            Lines transaction = invoice.DataFields.FieldByName("TRANSACTIONS").Lines;

           
            transaction.AppendLine();
            transaction[(transaction.Count - 1)].FieldByName("TYPE").Value = (trcode == 4 || trcode == 9) ? 4 : 0;
            transaction[(transaction.Count - 1)].FieldByName("SOURCEINDEX").Value = sourceIndex;
            transaction[(transaction.Count - 1)].FieldByName("MASTER_CODE").Value = detail["CODE"].ToString();
            transaction[(transaction.Count - 1)].FieldByName("QUANTITY").Value = (float)detail["AMOUNT"];
            transaction[(transaction.Count - 1)].FieldByName("UNIT_CODE").Value = detail["UNIT"].ToString();
            transaction[(transaction.Count - 1)].FieldByName("PRICE").Value = (float)detail["PRICE"];
            transaction[(transaction.Count - 1)].FieldByName("PROJECT_CODE").Value = detail["PROJECTCODE"].ToString();
            transaction[(transaction.Count - 1)].FieldByName("OHP_CODE1").Value = detail["COSTCENTRECODE"].ToString();
            transaction[(transaction.Count - 1)].FieldByName("DESCRIPTION").Value = detail["EXPLANATION"].ToString().Trim();

            errorMessage = null;
            if (!invoice.Post())
            {

                if (invoice.ErrorCode != 0)
                {

                    errorMessage += @" DB Error : ( " + (invoice.ErrorCode) + ") - " + invoice.ErrorDesc;
                }
                else if (invoice.ValidateErrors.Count > 0)
                {
                    for (int i = 0; i < invoice.ValidateErrors.Count - 1; i++)
                        errorMessage += @"XML Error : (" + (invoice.ValidateErrors[i].ID) + ") - " +
                                        invoice.ValidateErrors[i].Error;

                }
                ficheno = null;
                errorMessage = (string.IsNullOrEmpty(errorMessage)) ? invoice.ErrorDesc : errorMessage;
                errorMessage = (string.IsNullOrEmpty(errorMessage)) ? _app.GetLastErrorString() : errorMessage;
            }
            else
            {
                ficheno = invoice.DataFields.FieldByName("NUMBER").Value.ToString();
                result = true;
            }
            return result;

        }

      
    }

}