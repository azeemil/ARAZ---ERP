using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ERP.Logistcs
{
    partial class VeyseloglunaSifaris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeyseloglunaSifaris));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ClNameTxb = new DevExpress.XtraEditors.TextEdit();
            this.CustomerTxb = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SourceBranchCmbx = new DevExpress.XtraEditors.LookUpEdit();
            this.CalculateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.orderDayCount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.calcDayCount = new DevExpress.XtraEditors.SpinEdit();
            this.progress = new DevExpress.XtraWaitForm.ProgressPanel();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ITEMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCity = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNITNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SALE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROGNOZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKGUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ANBARSTOKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESULT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ICSAYI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORTALAMASATIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MINLEVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAXLEVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP.General.Wait), true, true);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClNameTxb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTxb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceBranchCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDayCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDayCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.progress);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1354, 106);
            this.groupControl1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.ClNameTxb);
            this.groupControl3.Controls.Add(this.CustomerTxb);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.SourceBranchCmbx);
            this.groupControl3.Controls.Add(this.CalculateBtn);
            this.groupControl3.Controls.Add(this.orderDayCount);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.calcDayCount);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1354, 79);
            this.groupControl3.TabIndex = 22;
            this.groupControl3.Text = "groupControl3";
            // 
            // ClNameTxb
            // 
            this.ClNameTxb.Location = new System.Drawing.Point(321, 9);
            this.ClNameTxb.Name = "ClNameTxb";
            this.ClNameTxb.Properties.ReadOnly = true;
            this.ClNameTxb.Size = new System.Drawing.Size(291, 20);
            this.ClNameTxb.TabIndex = 26;
            // 
            // CustomerTxb
            // 
            this.CustomerTxb.Location = new System.Drawing.Point(321, 35);
            this.CustomerTxb.Name = "CustomerTxb";
            this.CustomerTxb.Properties.ReadOnly = true;
            this.CustomerTxb.Size = new System.Drawing.Size(291, 20);
            this.CustomerTxb.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Filial";
            // 
            // SourceBranchCmbx
            // 
            this.SourceBranchCmbx.EnterMoveNextControl = true;
            this.SourceBranchCmbx.Location = new System.Drawing.Point(86, 11);
            this.SourceBranchCmbx.Name = "SourceBranchCmbx";
            this.SourceBranchCmbx.Properties.AllowFocused = false;
            this.SourceBranchCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SourceBranchCmbx.Properties.Appearance.Options.UseFont = true;
            this.SourceBranchCmbx.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SourceBranchCmbx.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Gray;
            this.SourceBranchCmbx.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.SourceBranchCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SourceBranchCmbx.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad")});
            this.SourceBranchCmbx.Properties.DisplayMember = "NR";
            this.SourceBranchCmbx.Properties.NullText = "";
            this.SourceBranchCmbx.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.SourceBranchCmbx.Properties.ValueMember = "NR";
            this.SourceBranchCmbx.Size = new System.Drawing.Size(192, 20);
            this.SourceBranchCmbx.TabIndex = 24;
            this.SourceBranchCmbx.EditValueChanged += new System.EventHandler(this.SourceWhouseCmbx_EditValueChanged);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.CalculateBtn.Appearance.Options.UseFont = true;
            this.CalculateBtn.Image = ((System.Drawing.Image)(resources.GetObject("CalculateBtn.Image")));
            this.CalculateBtn.Location = new System.Drawing.Point(919, 20);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(180, 54);
            this.CalculateBtn.TabIndex = 20;
            this.CalculateBtn.Text = "Hesabla";
            this.CalculateBtn.Click += new System.EventHandler(this.Calculate);
            // 
            // orderDayCount
            // 
            this.orderDayCount.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.orderDayCount.Location = new System.Drawing.Point(822, 48);
            this.orderDayCount.Name = "orderDayCount";
            this.orderDayCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.orderDayCount.Properties.Appearance.Options.UseFont = true;
            this.orderDayCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDayCount.Properties.IsFloatValue = false;
            this.orderDayCount.Properties.Mask.BeepOnError = true;
            this.orderDayCount.Properties.Mask.EditMask = "N00";
            this.orderDayCount.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.orderDayCount.Properties.MinValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.orderDayCount.Size = new System.Drawing.Size(74, 20);
            this.orderDayCount.TabIndex = 19;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(654, 51);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 16);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Sifariş Günü";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(654, 14);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(118, 16);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Hesablanacaq Gün";
            // 
            // calcDayCount
            // 
            this.calcDayCount.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.calcDayCount.Location = new System.Drawing.Point(822, 11);
            this.calcDayCount.Name = "calcDayCount";
            this.calcDayCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.calcDayCount.Properties.Appearance.Options.UseFont = true;
            this.calcDayCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcDayCount.Properties.IsFloatValue = false;
            this.calcDayCount.Properties.Mask.BeepOnError = true;
            this.calcDayCount.Properties.Mask.EditMask = "N00";
            this.calcDayCount.Properties.MaxValue = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.calcDayCount.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.calcDayCount.Size = new System.Drawing.Size(74, 20);
            this.calcDayCount.TabIndex = 16;
            // 
            // progress
            // 
            this.progress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progress.Appearance.Options.UseBackColor = true;
            this.progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress.Location = new System.Drawing.Point(0, 61);
            this.progress.Name = "progress";
            this.progress.ShowCaption = false;
            this.progress.ShowDescription = false;
            this.progress.Size = new System.Drawing.Size(1354, 45);
            this.progress.TabIndex = 21;
            this.progress.Text = "progressPanel1";
            this.progress.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // grid
            // 
            this.grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grid.EmbeddedNavigator.Buttons.CancelEdit.Hint = "Yadda saxla";
            this.grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grid.EmbeddedNavigator.Buttons.Edit.Hint = "Dəyiş";
            this.grid.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grid.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 11, true, true, "Excelə Göndər", "1"),
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 9, true, true, "Miqdar dəyiş", "2")});
            this.grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.EmbeddedNavigator.TextStringFormat = "Sətir {0} \\ {1}";
            this.grid.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grid_EmbeddedNavigator_ButtonClick);
            gridLevelNode1.RelationName = "Level1";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 106);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCity});
            this.grid.Size = new System.Drawing.Size(1354, 420);
            this.grid.TabIndex = 7;
            this.grid.UseEmbeddedNavigator = true;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.AppearancePrint.EvenRow.BorderColor = System.Drawing.Color.Black;
            this.gridView1.AppearancePrint.EvenRow.Options.UseBorderColor = true;
            this.gridView1.AppearancePrint.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.AppearancePrint.OddRow.Options.UseBorderColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ITEMCODE,
            this.ITEMNAME,
            this.BARCODE,
            this.UNITNAME,
            this.STOK,
            this.SALE,
            this.PROGNOZ,
            this.STOKGUN,
            this.ANBARSTOKU,
            this.AMOUNT,
            this.RESULT,
            this.ICSAYI,
            this.ORTALAMASATIS,
            this.PRICE,
            this.MINLEVEL,
            this.MAXLEVEL});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.FooterPanelHeight = 2;
            this.gridView1.GridControl = this.grid;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.EditFormPrepared += new DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventHandler(this.gridView1_EditFormPrepared);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // ITEMCODE
            // 
            this.ITEMCODE.Caption = "Kod";
            this.ITEMCODE.ColumnEdit = this.repoCity;
            this.ITEMCODE.FieldName = "ITEMCODE";
            this.ITEMCODE.Name = "ITEMCODE";
            this.ITEMCODE.OptionsColumn.AllowEdit = false;
            this.ITEMCODE.OptionsColumn.AllowFocus = false;
            this.ITEMCODE.OptionsColumn.ReadOnly = true;
            this.ITEMCODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.ITEMCODE.Visible = true;
            this.ITEMCODE.VisibleIndex = 1;
            this.ITEMCODE.Width = 58;
            // 
            // repoCity
            // 
            this.repoCity.AutoHeight = false;
            this.repoCity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repoCity.Name = "repoCity";
            // 
            // ITEMNAME
            // 
            this.ITEMNAME.Caption = "Ad";
            this.ITEMNAME.ColumnEdit = this.repoCity;
            this.ITEMNAME.FieldName = "ITEMNAME";
            this.ITEMNAME.Name = "ITEMNAME";
            this.ITEMNAME.OptionsColumn.AllowEdit = false;
            this.ITEMNAME.OptionsColumn.AllowFocus = false;
            this.ITEMNAME.OptionsColumn.ReadOnly = true;
            this.ITEMNAME.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.ITEMNAME.Visible = true;
            this.ITEMNAME.VisibleIndex = 3;
            this.ITEMNAME.Width = 191;
            // 
            // BARCODE
            // 
            this.BARCODE.Caption = "Barkod";
            this.BARCODE.FieldName = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.OptionsColumn.AllowEdit = false;
            this.BARCODE.OptionsColumn.AllowFocus = false;
            this.BARCODE.OptionsColumn.ReadOnly = true;
            this.BARCODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.BARCODE.Visible = true;
            this.BARCODE.VisibleIndex = 2;
            this.BARCODE.Width = 78;
            // 
            // UNITNAME
            // 
            this.UNITNAME.Caption = "Ö\\V";
            this.UNITNAME.FieldName = "UNIT";
            this.UNITNAME.Name = "UNITNAME";
            this.UNITNAME.OptionsColumn.AllowEdit = false;
            this.UNITNAME.OptionsColumn.AllowFocus = false;
            this.UNITNAME.OptionsColumn.ReadOnly = true;
            this.UNITNAME.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.UNITNAME.Visible = true;
            this.UNITNAME.VisibleIndex = 4;
            this.UNITNAME.Width = 40;
            // 
            // STOK
            // 
            this.STOK.Caption = "Stok";
            this.STOK.FieldName = "FILIAL_STOKU";
            this.STOK.Name = "STOK";
            this.STOK.OptionsColumn.AllowEdit = false;
            this.STOK.OptionsColumn.AllowFocus = false;
            this.STOK.OptionsColumn.ReadOnly = true;
            this.STOK.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.STOK.Visible = true;
            this.STOK.VisibleIndex = 5;
            this.STOK.Width = 55;
            // 
            // SALE
            // 
            this.SALE.Caption = "Satış";
            this.SALE.FieldName = "SATIS";
            this.SALE.Name = "SALE";
            this.SALE.OptionsColumn.AllowEdit = false;
            this.SALE.OptionsColumn.AllowFocus = false;
            this.SALE.OptionsColumn.ReadOnly = true;
            this.SALE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.SALE.Visible = true;
            this.SALE.VisibleIndex = 6;
            this.SALE.Width = 44;
            // 
            // PROGNOZ
            // 
            this.PROGNOZ.Caption = "Proqnoz";
            this.PROGNOZ.FieldName = "PROGNOZ";
            this.PROGNOZ.Name = "PROGNOZ";
            this.PROGNOZ.OptionsColumn.AllowEdit = false;
            this.PROGNOZ.OptionsColumn.AllowFocus = false;
            this.PROGNOZ.OptionsColumn.ReadOnly = true;
            this.PROGNOZ.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.PROGNOZ.Visible = true;
            this.PROGNOZ.VisibleIndex = 9;
            this.PROGNOZ.Width = 55;
            // 
            // STOKGUN
            // 
            this.STOKGUN.Caption = "Stok Gün";
            this.STOKGUN.FieldName = "STOKGUN";
            this.STOKGUN.Name = "STOKGUN";
            this.STOKGUN.OptionsColumn.AllowEdit = false;
            this.STOKGUN.OptionsColumn.AllowFocus = false;
            this.STOKGUN.OptionsColumn.ReadOnly = true;
            this.STOKGUN.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.STOKGUN.Visible = true;
            this.STOKGUN.VisibleIndex = 8;
            this.STOKGUN.Width = 54;
            // 
            // ANBARSTOKU
            // 
            this.ANBARSTOKU.Caption = "Anbar Stoku";
            this.ANBARSTOKU.FieldName = "VEYSELOGLU_STOK";
            this.ANBARSTOKU.Name = "ANBARSTOKU";
            this.ANBARSTOKU.OptionsColumn.AllowEdit = false;
            this.ANBARSTOKU.OptionsColumn.AllowFocus = false;
            this.ANBARSTOKU.OptionsColumn.ReadOnly = true;
            this.ANBARSTOKU.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.ANBARSTOKU.Visible = true;
            this.ANBARSTOKU.VisibleIndex = 11;
            this.ANBARSTOKU.Width = 74;
            // 
            // AMOUNT
            // 
            this.AMOUNT.Caption = "Ehtiyac";
            this.AMOUNT.FieldName = "AMOUNT";
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.OptionsColumn.AllowEdit = false;
            this.AMOUNT.OptionsColumn.AllowFocus = false;
            this.AMOUNT.OptionsColumn.ReadOnly = true;
            this.AMOUNT.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.AMOUNT.Visible = true;
            this.AMOUNT.VisibleIndex = 10;
            this.AMOUNT.Width = 55;
            // 
            // RESULT
            // 
            this.RESULT.AppearanceCell.Options.HighPriority = true;
            this.RESULT.Caption = "Sifariş";
            this.RESULT.FieldName = "RESULT";
            this.RESULT.Name = "RESULT";
            this.RESULT.Visible = true;
            this.RESULT.VisibleIndex = 16;
            this.RESULT.Width = 81;
            // 
            // ICSAYI
            // 
            this.ICSAYI.Caption = "İç Sayı";
            this.ICSAYI.FieldName = "ICSAYI";
            this.ICSAYI.Name = "ICSAYI";
            this.ICSAYI.OptionsColumn.AllowEdit = false;
            this.ICSAYI.OptionsColumn.AllowFocus = false;
            this.ICSAYI.OptionsColumn.ReadOnly = true;
            this.ICSAYI.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.ICSAYI.Visible = true;
            this.ICSAYI.VisibleIndex = 12;
            // 
            // ORTALAMASATIS
            // 
            this.ORTALAMASATIS.Caption = "Ortalama satiş";
            this.ORTALAMASATIS.FieldName = "ORTALAMA_SATIS";
            this.ORTALAMASATIS.Name = "ORTALAMASATIS";
            this.ORTALAMASATIS.OptionsColumn.AllowEdit = false;
            this.ORTALAMASATIS.OptionsColumn.AllowFocus = false;
            this.ORTALAMASATIS.OptionsColumn.ReadOnly = true;
            this.ORTALAMASATIS.Visible = true;
            this.ORTALAMASATIS.VisibleIndex = 7;
            this.ORTALAMASATIS.Width = 80;
            // 
            // PRICE
            // 
            this.PRICE.Caption = "Qiymət";
            this.PRICE.FieldName = "PRICE";
            this.PRICE.Name = "PRICE";
            this.PRICE.OptionsColumn.AllowEdit = false;
            this.PRICE.OptionsColumn.AllowFocus = false;
            this.PRICE.Visible = true;
            this.PRICE.VisibleIndex = 13;
            // 
            // MINLEVEL
            // 
            this.MINLEVEL.Caption = "Minimum Stok";
            this.MINLEVEL.FieldName = "MINLEVEL";
            this.MINLEVEL.Name = "MINLEVEL";
            this.MINLEVEL.OptionsColumn.AllowEdit = false;
            this.MINLEVEL.OptionsColumn.AllowFocus = false;
            this.MINLEVEL.Visible = true;
            this.MINLEVEL.VisibleIndex = 14;
            // 
            // MAXLEVEL
            // 
            this.MAXLEVEL.Caption = "Maksimum Stok";
            this.MAXLEVEL.FieldName = "MAXLEVEL";
            this.MAXLEVEL.Name = "MAXLEVEL";
            this.MAXLEVEL.OptionsColumn.AllowEdit = false;
            this.MAXLEVEL.OptionsColumn.AllowFocus = false;
            this.MAXLEVEL.Visible = true;
            this.MAXLEVEL.VisibleIndex = 15;
            this.MAXLEVEL.Width = 83;
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.groupControl2.Controls.Add(this.cancelBtn);
            this.groupControl2.Controls.Add(this.saveBtn);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 526);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1354, 64);
            this.groupControl2.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.Appearance.Options.UseFont = true;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.Location = new System.Drawing.Point(148, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 33);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Ləğv Et";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(24, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(118, 33);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Yadda Saxla";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // alertControl1
            // 
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alertControl1.ShowPinButton = false;
            this.alertControl1.ShowToolTips = false;
            // 
            // VeyseloglunaSifaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(1354, 590);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VeyseloglunaSifaris";
            this.Text = "Yeni Sifariş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPurchOrder_FormClosing);
            this.Load += new System.EventHandler(this.NewWhouseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClNameTxb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTxb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceBranchCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDayCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDayCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControl1;
        private GridControl grid;
        private GridView gridView1;
        private GridColumn ITEMCODE;
        private RepositoryItemButtonEdit repoCity;
        private GridColumn ITEMNAME;
        private GridColumn UNITNAME;
        private GroupControl groupControl2;
        private GridColumn BARCODE;
        private GridColumn STOK;
        private GridColumn SALE;
        private GridColumn PROGNOZ;
        private GridColumn STOKGUN;
        private GridColumn AMOUNT;
        private ProgressPanel progress;
        private SimpleButton cancelBtn;
        private SimpleButton saveBtn;
        private GridColumn RESULT;
        private GridColumn ANBARSTOKU;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private GridColumn ICSAYI;
        private GroupControl groupControl3;
        private LabelControl labelControl1;
        private LookUpEdit SourceBranchCmbx;
        private SimpleButton CalculateBtn;
        private SpinEdit orderDayCount;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private SpinEdit calcDayCount;
        private TextEdit CustomerTxb;
        private TextEdit ClNameTxb;
        private GridColumn ORTALAMASATIS;
        private GridColumn PRICE;
        private GridColumn MINLEVEL;
        private GridColumn MAXLEVEL;
    }
}