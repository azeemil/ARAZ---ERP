namespace ERP.Finance
{
    partial class KassTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KassTransactions));
            this.gridCotrol = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Logicalref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OFFICECODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXPLANATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CASHIERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KSCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZREPORTTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RTFICHETOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARDTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUFFTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FERQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CASHIERCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXPLAN_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.APPROVED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.officecodesCbx = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.searchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.begDate = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu();
            this.NewBtn = new DevExpress.XtraBars.BarButtonItem();
            this.EditBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ExcelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Excel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officecodesCbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCotrol
            // 
            this.gridCotrol.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridCotrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCotrol.Location = new System.Drawing.Point(2, 2);
            this.gridCotrol.MainView = this.gridView1;
            this.gridCotrol.Name = "gridCotrol";
            this.gridCotrol.Size = new System.Drawing.Size(1110, 369);
            this.gridCotrol.TabIndex = 1;
            this.gridCotrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Logicalref,
            this.DATE_,
            this.OFFICECODE,
            this.NAME,
            this.EXPLANATION,
            this.CASHIERNAME,
            this.KSCODE,
            this.ZNO,
            this.ZREPORTTOTAL,
            this.RTFICHETOTAL,
            this.CARDTOTAL,
            this.CUFFTOTAL,
            this.FERQ,
            this.CASHIERCODE,
            this.BKOD,
            this.BAD,
            this.EXPLAN_,
            this.STATUS,
            this.APPROVED});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridCotrol;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Logicalref
            // 
            this.Logicalref.Caption = "Sənəd №";
            this.Logicalref.FieldName = "LOGICALREF";
            this.Logicalref.Name = "Logicalref";
            this.Logicalref.OptionsColumn.AllowEdit = false;
            this.Logicalref.OptionsColumn.AllowFocus = false;
            this.Logicalref.OptionsColumn.ReadOnly = true;
            this.Logicalref.Visible = true;
            this.Logicalref.VisibleIndex = 0;
            this.Logicalref.Width = 59;
            // 
            // DATE_
            // 
            this.DATE_.Caption = "Tarix";
            this.DATE_.FieldName = "DATE_";
            this.DATE_.Name = "DATE_";
            this.DATE_.OptionsColumn.AllowEdit = false;
            this.DATE_.OptionsColumn.AllowFocus = false;
            this.DATE_.OptionsColumn.ReadOnly = true;
            this.DATE_.Visible = true;
            this.DATE_.VisibleIndex = 1;
            this.DATE_.Width = 68;
            // 
            // OFFICECODE
            // 
            this.OFFICECODE.Caption = "Filial №";
            this.OFFICECODE.FieldName = "OFFICECODE";
            this.OFFICECODE.Name = "OFFICECODE";
            this.OFFICECODE.OptionsColumn.AllowEdit = false;
            this.OFFICECODE.OptionsColumn.AllowFocus = false;
            this.OFFICECODE.OptionsColumn.ReadOnly = true;
            this.OFFICECODE.Visible = true;
            this.OFFICECODE.VisibleIndex = 2;
            this.OFFICECODE.Width = 52;
            // 
            // NAME
            // 
            this.NAME.Caption = "Fialial";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 3;
            // 
            // EXPLANATION
            // 
            this.EXPLANATION.Caption = "RT Kodu";
            this.EXPLANATION.FieldName = "EXPLANATION";
            this.EXPLANATION.Name = "EXPLANATION";
            this.EXPLANATION.OptionsColumn.AllowEdit = false;
            this.EXPLANATION.OptionsColumn.AllowFocus = false;
            this.EXPLANATION.OptionsColumn.ReadOnly = true;
            this.EXPLANATION.Visible = true;
            this.EXPLANATION.VisibleIndex = 4;
            this.EXPLANATION.Width = 50;
            // 
            // CASHIERNAME
            // 
            this.CASHIERNAME.Caption = "Kassir";
            this.CASHIERNAME.FieldName = "CASHIERNAME";
            this.CASHIERNAME.Name = "CASHIERNAME";
            this.CASHIERNAME.OptionsColumn.AllowEdit = false;
            this.CASHIERNAME.OptionsColumn.AllowFocus = false;
            this.CASHIERNAME.OptionsColumn.ReadOnly = true;
            this.CASHIERNAME.Visible = true;
            this.CASHIERNAME.VisibleIndex = 6;
            this.CASHIERNAME.Width = 155;
            // 
            // KSCODE
            // 
            this.KSCODE.Caption = "Kassa №";
            this.KSCODE.FieldName = "KSCODE";
            this.KSCODE.Name = "KSCODE";
            this.KSCODE.OptionsColumn.AllowEdit = false;
            this.KSCODE.OptionsColumn.AllowFocus = false;
            this.KSCODE.OptionsColumn.ReadOnly = true;
            this.KSCODE.Visible = true;
            this.KSCODE.VisibleIndex = 7;
            this.KSCODE.Width = 61;
            // 
            // ZNO
            // 
            this.ZNO.Caption = "Z №";
            this.ZNO.FieldName = "ZNO";
            this.ZNO.Name = "ZNO";
            this.ZNO.OptionsColumn.AllowEdit = false;
            this.ZNO.OptionsColumn.AllowFocus = false;
            this.ZNO.OptionsColumn.ReadOnly = true;
            this.ZNO.Visible = true;
            this.ZNO.VisibleIndex = 8;
            this.ZNO.Width = 40;
            // 
            // ZREPORTTOTAL
            // 
            this.ZREPORTTOTAL.Caption = "Z Toplam";
            this.ZREPORTTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ZREPORTTOTAL.FieldName = "ZREPORTTOTAL";
            this.ZREPORTTOTAL.Name = "ZREPORTTOTAL";
            this.ZREPORTTOTAL.OptionsColumn.AllowEdit = false;
            this.ZREPORTTOTAL.OptionsColumn.AllowFocus = false;
            this.ZREPORTTOTAL.OptionsColumn.ReadOnly = true;
            this.ZREPORTTOTAL.Visible = true;
            this.ZREPORTTOTAL.VisibleIndex = 9;
            this.ZREPORTTOTAL.Width = 61;
            // 
            // RTFICHETOTAL
            // 
            this.RTFICHETOTAL.Caption = "Iadə Məbləğ";
            this.RTFICHETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RTFICHETOTAL.FieldName = "RTFICHETOTAL";
            this.RTFICHETOTAL.Name = "RTFICHETOTAL";
            this.RTFICHETOTAL.OptionsColumn.AllowEdit = false;
            this.RTFICHETOTAL.OptionsColumn.AllowFocus = false;
            this.RTFICHETOTAL.OptionsColumn.ReadOnly = true;
            this.RTFICHETOTAL.Visible = true;
            this.RTFICHETOTAL.VisibleIndex = 10;
            this.RTFICHETOTAL.Width = 77;
            // 
            // CARDTOTAL
            // 
            this.CARDTOTAL.Caption = "Kredit Məbləğ";
            this.CARDTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CARDTOTAL.FieldName = "CARDTOTAL";
            this.CARDTOTAL.Name = "CARDTOTAL";
            this.CARDTOTAL.OptionsColumn.AllowEdit = false;
            this.CARDTOTAL.OptionsColumn.AllowFocus = false;
            this.CARDTOTAL.OptionsColumn.ReadOnly = true;
            this.CARDTOTAL.Visible = true;
            this.CARDTOTAL.VisibleIndex = 11;
            this.CARDTOTAL.Width = 76;
            // 
            // CUFFTOTAL
            // 
            this.CUFFTOTAL.Caption = "Digər Məbləğ";
            this.CUFFTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CUFFTOTAL.FieldName = "CUFFTOTAL";
            this.CUFFTOTAL.Name = "CUFFTOTAL";
            this.CUFFTOTAL.OptionsColumn.AllowEdit = false;
            this.CUFFTOTAL.OptionsColumn.AllowFocus = false;
            this.CUFFTOTAL.OptionsColumn.ReadOnly = true;
            this.CUFFTOTAL.Visible = true;
            this.CUFFTOTAL.VisibleIndex = 12;
            this.CUFFTOTAL.Width = 74;
            // 
            // FERQ
            // 
            this.FERQ.Caption = "Fərq";
            this.FERQ.FieldName = "FERQ";
            this.FERQ.Name = "FERQ";
            this.FERQ.OptionsColumn.AllowEdit = false;
            this.FERQ.OptionsColumn.AllowFocus = false;
            this.FERQ.OptionsColumn.ReadOnly = true;
            this.FERQ.Visible = true;
            this.FERQ.VisibleIndex = 13;
            this.FERQ.Width = 53;
            // 
            // CASHIERCODE
            // 
            this.CASHIERCODE.Caption = "Kassir Kodu";
            this.CASHIERCODE.FieldName = "CASHIERCODE";
            this.CASHIERCODE.Name = "CASHIERCODE";
            this.CASHIERCODE.OptionsColumn.AllowEdit = false;
            this.CASHIERCODE.OptionsColumn.AllowFocus = false;
            this.CASHIERCODE.OptionsColumn.ReadOnly = true;
            this.CASHIERCODE.Visible = true;
            this.CASHIERCODE.VisibleIndex = 5;
            this.CASHIERCODE.Width = 64;
            // 
            // BKOD
            // 
            this.BKOD.Caption = "BKOD";
            this.BKOD.FieldName = "BKOD";
            this.BKOD.Name = "BKOD";
            // 
            // BAD
            // 
            this.BAD.Caption = "BAD";
            this.BAD.FieldName = "BAD";
            this.BAD.Name = "BAD";
            // 
            // EXPLAN_
            // 
            this.EXPLAN_.Caption = "EXPLAN_";
            this.EXPLAN_.FieldName = "EXPLAN_";
            this.EXPLAN_.Name = "EXPLAN_";
            // 
            // STATUS
            // 
            this.STATUS.Caption = "Status";
            this.STATUS.FieldName = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.AllowEdit = false;
            this.STATUS.OptionsColumn.AllowFocus = false;
            this.STATUS.OptionsColumn.ReadOnly = true;
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 15;
            this.STATUS.Width = 84;
            // 
            // APPROVED
            // 
            this.APPROVED.Caption = "Təsdiq";
            this.APPROVED.FieldName = "APPROVED";
            this.APPROVED.Name = "APPROVED";
            this.APPROVED.OptionsColumn.AllowEdit = false;
            this.APPROVED.OptionsColumn.AllowFocus = false;
            this.APPROVED.OptionsColumn.ReadOnly = true;
            this.APPROVED.Visible = true;
            this.APPROVED.VisibleIndex = 14;
            this.APPROVED.Width = 45;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Excel);
            this.groupControl1.Controls.Add(this.officecodesCbx);
            this.groupControl1.Controls.Add(this.searchBtn);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.endDate);
            this.groupControl1.Controls.Add(this.begDate);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1114, 143);
            this.groupControl1.TabIndex = 2;
            // 
            // officecodesCbx
            // 
            this.officecodesCbx.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.officecodesCbx.Appearance.Options.UseFont = true;
            this.officecodesCbx.CheckOnClick = true;
            this.officecodesCbx.DisplayMember = "NAME";
            this.officecodesCbx.Dock = System.Windows.Forms.DockStyle.Left;
            this.officecodesCbx.Location = new System.Drawing.Point(2, 20);
            this.officecodesCbx.Name = "officecodesCbx";
            this.officecodesCbx.Size = new System.Drawing.Size(269, 121);
            this.officecodesCbx.TabIndex = 6;
            this.officecodesCbx.ValueMember = "NR";
            // 
            // searchBtn
            // 
            this.searchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Appearance.Options.UseFont = true;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(941, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(161, 46);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Axtar";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(321, 58);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(104, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Ləğv Et";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(321, 29);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Seç";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // endDate
            // 
            this.endDate.EditValue = null;
            this.endDate.Location = new System.Drawing.Point(647, 32);
            this.endDate.Name = "endDate";
            this.endDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.endDate.Properties.Appearance.Options.UseFont = true;
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Size = new System.Drawing.Size(143, 20);
            this.endDate.TabIndex = 2;
            // 
            // begDate
            // 
            this.begDate.EditValue = null;
            this.begDate.Location = new System.Drawing.Point(485, 32);
            this.begDate.Name = "begDate";
            this.begDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.begDate.Properties.Appearance.Options.UseFont = true;
            this.begDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.begDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.begDate.Size = new System.Drawing.Size(143, 20);
            this.begDate.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridCotrol);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 143);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1114, 373);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "groupControl2";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.NewBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.ExcelBtn)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // NewBtn
            // 
            this.NewBtn.Caption = "Yeni";
            this.NewBtn.Id = 0;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewBtn_ItemClick);
            // 
            // EditBtn
            // 
            this.EditBtn.Caption = "Dəyiş";
            this.EditBtn.Id = 1;
            this.EditBtn.Name = "EditBtn";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.NewBtn,
            this.EditBtn,
            this.ExcelBtn});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1114, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 516);
            this.barDockControlBottom.Size = new System.Drawing.Size(1114, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 516);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1114, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 516);
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Caption = "Excel";
            this.ExcelBtn.Id = 2;
            this.ExcelBtn.Name = "ExcelBtn";
            // 
            // Excel
            // 
            this.Excel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Excel.Appearance.Options.UseFont = true;
            this.Excel.Image = ((System.Drawing.Image)(resources.GetObject("Excel.Image")));
            this.Excel.Location = new System.Drawing.Point(941, 88);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(161, 46);
            this.Excel.TabIndex = 7;
            this.Excel.Text = "Excel";
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // KassTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 516);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KassTransactions";
            this.Text = "Kassir Hesab Alma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCotrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officecodesCbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn Logicalref;
        private DevExpress.XtraGrid.Columns.GridColumn DATE_;
        private DevExpress.XtraGrid.Columns.GridColumn OFFICECODE;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn EXPLANATION;
        private DevExpress.XtraGrid.Columns.GridColumn CASHIERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn KSCODE;
        private DevExpress.XtraGrid.Columns.GridColumn ZNO;
        private DevExpress.XtraGrid.Columns.GridColumn ZREPORTTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn RTFICHETOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn CARDTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn CUFFTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn FERQ;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn CASHIERCODE;
        public DevExpress.XtraGrid.GridControl gridCotrol;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BKOD;
        private DevExpress.XtraGrid.Columns.GridColumn BAD;
        private DevExpress.XtraGrid.Columns.GridColumn EXPLAN_;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn APPROVED;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit endDate;
        private DevExpress.XtraEditors.DateEdit begDate;
        private DevExpress.XtraEditors.SimpleButton searchBtn;
        private DevExpress.XtraEditors.CheckedListBoxControl officecodesCbx;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem NewBtn;
        private DevExpress.XtraBars.BarButtonItem EditBtn;
        private DevExpress.XtraEditors.SimpleButton Excel;
        private DevExpress.XtraBars.BarButtonItem ExcelBtn;
    }
}

