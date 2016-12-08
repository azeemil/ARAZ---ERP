namespace ERP.Market.BarcodePrint
{
    partial class PriceEtiketPrint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERP.Market.BarcodePrint.PriceEtiketPrint));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRICE_TAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRICE_KESIR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BranchLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BarkodEnter = new DevExpress.XtraBars.BarButtonItem();
            this.MobilePrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrcChangeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrintSelected = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteSelectedBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ClearBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DesignLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PrinterName = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Excel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesignLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1079, 420);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CODE,
            this.NAME,
            this.BARCODE,
            this.COUNT,
            this.UNIT,
            this.PRICE,
            this.BRANCH,
            this.PRICE_TAM,
            this.PRICE_KESIR});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // CODE
            // 
            this.CODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CODE.AppearanceHeader.Options.UseFont = true;
            this.CODE.Caption = "Kod";
            this.CODE.FieldName = "CODE";
            this.CODE.Name = "CODE";
            this.CODE.OptionsColumn.AllowEdit = false;
            this.CODE.OptionsColumn.AllowFocus = false;
            this.CODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CODE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CODE", "Say = {0}")});
            this.CODE.Visible = true;
            this.CODE.VisibleIndex = 2;
            this.CODE.Width = 79;
            // 
            // NAME
            // 
            this.NAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.NAME.AppearanceHeader.Options.UseFont = true;
            this.NAME.Caption = "Ad";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 3;
            this.NAME.Width = 293;
            // 
            // BARCODE
            // 
            this.BARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BARCODE.AppearanceHeader.Options.UseFont = true;
            this.BARCODE.Caption = "Barkod";
            this.BARCODE.FieldName = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.OptionsColumn.AllowEdit = false;
            this.BARCODE.OptionsColumn.AllowFocus = false;
            this.BARCODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BARCODE.Visible = true;
            this.BARCODE.VisibleIndex = 4;
            this.BARCODE.Width = 189;
            // 
            // COUNT
            // 
            this.COUNT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.COUNT.AppearanceHeader.Options.UseFont = true;
            this.COUNT.Caption = "Say";
            this.COUNT.FieldName = "COUNT";
            this.COUNT.Name = "COUNT";
            this.COUNT.OptionsColumn.AllowEdit = false;
            this.COUNT.OptionsColumn.AllowFocus = false;
            this.COUNT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.COUNT.Visible = true;
            this.COUNT.VisibleIndex = 5;
            this.COUNT.Width = 40;
            // 
            // UNIT
            // 
            this.UNIT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.UNIT.AppearanceHeader.Options.UseFont = true;
            this.UNIT.Caption = "Ö/V";
            this.UNIT.FieldName = "UNITNAME";
            this.UNIT.Name = "UNIT";
            this.UNIT.OptionsColumn.AllowEdit = false;
            this.UNIT.OptionsColumn.AllowFocus = false;
            this.UNIT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.UNIT.Visible = true;
            this.UNIT.VisibleIndex = 6;
            this.UNIT.Width = 71;
            // 
            // PRICE
            // 
            this.PRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.PRICE.AppearanceHeader.Options.UseFont = true;
            this.PRICE.Caption = "Qiymət";
            this.PRICE.FieldName = "PRICE";
            this.PRICE.Name = "PRICE";
            this.PRICE.OptionsColumn.AllowEdit = false;
            this.PRICE.OptionsColumn.AllowFocus = false;
            this.PRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.PRICE.Visible = true;
            this.PRICE.VisibleIndex = 7;
            this.PRICE.Width = 174;
            // 
            // BRANCH
            // 
            this.BRANCH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BRANCH.AppearanceHeader.Options.UseFont = true;
            this.BRANCH.Caption = "Filial";
            this.BRANCH.FieldName = "BRANCH";
            this.BRANCH.Name = "BRANCH";
            this.BRANCH.OptionsColumn.AllowEdit = false;
            this.BRANCH.OptionsColumn.AllowFocus = false;
            this.BRANCH.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BRANCH.Visible = true;
            this.BRANCH.VisibleIndex = 1;
            this.BRANCH.Width = 48;
            // 
            // PRICE_TAM
            // 
            this.PRICE_TAM.FieldName = "PRICE_TAM";
            this.PRICE_TAM.Name = "PRICE_TAM";
            this.PRICE_TAM.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // PRICE_KESIR
            // 
            this.PRICE_KESIR.FieldName = "PRICE_KESIR";
            this.PRICE_KESIR.Name = "PRICE_KESIR";
            this.PRICE_KESIR.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(10, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Filial";
            // 
            // BranchLookUp
            // 
            this.BranchLookUp.EnterMoveNextControl = true;
            this.BranchLookUp.Location = new System.Drawing.Point(82, 32);
            this.BranchLookUp.Name = "BranchLookUp";
            this.BranchLookUp.Properties.AllowFocused = false;
            this.BranchLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BranchLookUp.Properties.Appearance.Options.UseFont = true;
            this.BranchLookUp.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BranchLookUp.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Gray;
            this.BranchLookUp.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.BranchLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BranchLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad")});
            this.BranchLookUp.Properties.DisplayMember = "NR";
            this.BranchLookUp.Properties.NullText = "";
            this.BranchLookUp.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.BranchLookUp.Properties.ValueMember = "NR";
            this.BranchLookUp.Size = new System.Drawing.Size(192, 20);
            this.BranchLookUp.TabIndex = 25;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarkodEnter),
            new DevExpress.XtraBars.LinkPersistInfo(this.MobilePrintBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.PrcChangeBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.PrintBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.PrintSelected),
            new DevExpress.XtraBars.LinkPersistInfo(this.DeleteBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.DeleteSelectedBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.ClearBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.Excel, true)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // BarkodEnter
            // 
            this.BarkodEnter.Caption = "Barkodla Giriş";
            this.BarkodEnter.Id = 0;
            this.BarkodEnter.ImageUri.Uri = "Columns";
            this.BarkodEnter.Name = "BarkodEnter";
            this.BarkodEnter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarkodEnter_ItemClick);
            // 
            // MobilePrintBtn
            // 
            this.MobilePrintBtn.Caption = "Əl Terminalı";
            this.MobilePrintBtn.Id = 6;
            this.MobilePrintBtn.Name = "MobilePrintBtn";
            this.MobilePrintBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MobilePrintBtn_ItemClick);
            // 
            // PrcChangeBtn
            // 
            this.PrcChangeBtn.Caption = "Qiymət Dəyişimi";
            this.PrcChangeBtn.Id = 7;
            this.PrcChangeBtn.Name = "PrcChangeBtn";
            this.PrcChangeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrcChangeBtn_ItemClick);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Caption = "Çap Et";
            this.PrintBtn.Id = 1;
            this.PrintBtn.ImageUri.Uri = "Print";
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintBtn_ItemClick);
            // 
            // PrintSelected
            // 
            this.PrintSelected.Caption = "Toplu Çap";
            this.PrintSelected.Id = 2;
            this.PrintSelected.ImageUri.Uri = "Print";
            this.PrintSelected.Name = "PrintSelected";
            this.PrintSelected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintSelected_ItemClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Caption = "Sil";
            this.DeleteBtn.Id = 3;
            this.DeleteBtn.ImageUri.Uri = "Cancel";
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBtn_ItemClick);
            // 
            // DeleteSelectedBtn
            // 
            this.DeleteSelectedBtn.Caption = "Seçilənləri sil";
            this.DeleteSelectedBtn.Id = 4;
            this.DeleteSelectedBtn.ImageUri.Uri = "Delete";
            this.DeleteSelectedBtn.Name = "DeleteSelectedBtn";
            this.DeleteSelectedBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteSelectedBtn_ItemClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Caption = "Təmizlə";
            this.ClearBtn.Id = 5;
            this.ClearBtn.ImageUri.Uri = "Clear";
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearBtn_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarkodEnter,
            this.PrintBtn,
            this.PrintSelected,
            this.DeleteBtn,
            this.DeleteSelectedBtn,
            this.ClearBtn,
            this.MobilePrintBtn,
            this.PrcChangeBtn,
            this.Excel});
            this.barManager1.MaxItemId = 9;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1083, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Size = new System.Drawing.Size(1083, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 568);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1083, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 568);
            // 
            // DesignLookUp
            // 
            this.DesignLookUp.EnterMoveNextControl = true;
            this.DesignLookUp.Location = new System.Drawing.Point(82, 69);
            this.DesignLookUp.Name = "DesignLookUp";
            this.DesignLookUp.Properties.AllowFocused = false;
            this.DesignLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.DesignLookUp.Properties.Appearance.Options.UseFont = true;
            this.DesignLookUp.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DesignLookUp.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Gray;
            this.DesignLookUp.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.DesignLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DesignLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEMPLATE", "TEMPLATE", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.DesignLookUp.Properties.DisplayMember = "NAME";
            this.DesignLookUp.Properties.NullText = "";
            this.DesignLookUp.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.DesignLookUp.Properties.ValueMember = "TEMPLATE";
            this.DesignLookUp.Size = new System.Drawing.Size(192, 20);
            this.DesignLookUp.TabIndex = 30;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(10, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 16);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Dizayn";
            // 
            // PrinterName
            // 
            this.PrinterName.Location = new System.Drawing.Point(392, 33);
            this.PrinterName.MenuManager = this.barManager1;
            this.PrinterName.Name = "PrinterName";
            this.PrinterName.Properties.AllowFocused = false;
            this.PrinterName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.PrinterName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.PrinterName.Size = new System.Drawing.Size(261, 20);
            this.PrinterName.TabIndex = 36;
            this.PrinterName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.PrinterName_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.progressBarControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.BranchLookUp);
            this.groupControl1.Controls.Add(this.PrinterName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.DesignLookUp);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1083, 126);
            this.groupControl1.TabIndex = 41;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(2, 95);
            this.progressBarControl1.MenuManager = this.barManager1;
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Size = new System.Drawing.Size(1079, 29);
            this.progressBarControl1.TabIndex = 39;
            this.progressBarControl1.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(314, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 16);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Printer";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 126);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1083, 442);
            this.groupControl2.TabIndex = 42;
            // 
            // Excel
            // 
            this.Excel.Caption = "Excel";
            this.Excel.Glyph = ((System.Drawing.Image)(resources.GetObject("Excel.Glyph")));
            this.Excel.Id = 8;
            this.Excel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Excel.LargeGlyph")));
            this.Excel.Name = "Excel";
            this.Excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Excel_ItemClick);
            // 
            // PriceEtiketPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 568);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PriceEtiketPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiket çapı";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesignLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CODE;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn COUNT;
        private DevExpress.XtraGrid.Columns.GridColumn UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn PRICE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn BRANCH;
        private DevExpress.XtraEditors.LookUpEdit BranchLookUp;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem BarkodEnter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn PRICE_TAM;
        private DevExpress.XtraGrid.Columns.GridColumn PRICE_KESIR;
        private DevExpress.XtraEditors.LookUpEdit DesignLookUp;
        private DevExpress.XtraEditors.ButtonEdit PrinterName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarButtonItem PrintBtn;
        private DevExpress.XtraBars.BarButtonItem PrintSelected;
        private DevExpress.XtraBars.BarButtonItem DeleteBtn;
        private DevExpress.XtraBars.BarButtonItem DeleteSelectedBtn;
        private DevExpress.XtraBars.BarButtonItem ClearBtn;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraBars.BarButtonItem MobilePrintBtn;
        private DevExpress.XtraBars.BarButtonItem PrcChangeBtn;
        private DevExpress.XtraBars.BarButtonItem Excel;
    }
}

