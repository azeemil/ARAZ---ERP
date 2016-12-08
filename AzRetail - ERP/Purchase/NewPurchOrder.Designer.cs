using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ERP.Purchase
{
    partial class NewPurchOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPurchOrder));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.repoCity = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.clientNameBtnEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.CalculateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.clientCodeBtnEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.orderDayCount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.calcDayCount = new DevExpress.XtraEditors.SpinEdit();
            this.WhouseLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.BranchLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.progress = new DevExpress.XtraWaitForm.ProgressPanel();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UNITCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CATEGORY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CATCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNITNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOTALSALE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SALE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kenarlasma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROGNOZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKGUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESULT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.LoadLayout = new DevExpress.XtraEditors.SimpleButton();
            this.DefaultLayout = new DevExpress.XtraEditors.SimpleButton();
            this.SaveGridViewCustomization = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repoCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientNameBtnEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCodeBtnEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDayCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDayCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhouseLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // repoCity
            // 
            this.repoCity.AutoHeight = false;
            this.repoCity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repoCity.Name = "repoCity";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.progress);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1347, 106);
            this.groupControl1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.clientNameBtnEdit);
            this.groupControl3.Controls.Add(this.CalculateBtn);
            this.groupControl3.Controls.Add(this.clientCodeBtnEdit);
            this.groupControl3.Controls.Add(this.orderDayCount);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.calcDayCount);
            this.groupControl3.Controls.Add(this.WhouseLookUp);
            this.groupControl3.Controls.Add(this.BranchLookUp);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1347, 79);
            this.groupControl3.TabIndex = 22;
            this.groupControl3.Text = "groupControl3";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(13, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cari Adı";
            // 
            // clientNameBtnEdit
            // 
            this.clientNameBtnEdit.Location = new System.Drawing.Point(110, 11);
            this.clientNameBtnEdit.Name = "clientNameBtnEdit";
            this.clientNameBtnEdit.Properties.AllowFocused = false;
            this.clientNameBtnEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.clientNameBtnEdit.Properties.Appearance.Options.UseFont = true;
            this.clientNameBtnEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.clientNameBtnEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.clientNameBtnEdit.Size = new System.Drawing.Size(221, 20);
            this.clientNameBtnEdit.TabIndex = 0;
            this.clientNameBtnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.clientNameBtnEdit_ButtonClick);
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
            // clientCodeBtnEdit
            // 
            this.clientCodeBtnEdit.Location = new System.Drawing.Point(110, 48);
            this.clientCodeBtnEdit.Name = "clientCodeBtnEdit";
            this.clientCodeBtnEdit.Properties.AllowFocused = false;
            this.clientCodeBtnEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.clientCodeBtnEdit.Properties.Appearance.Options.UseFont = true;
            this.clientCodeBtnEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.clientCodeBtnEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.clientCodeBtnEdit.Size = new System.Drawing.Size(221, 20);
            this.clientCodeBtnEdit.TabIndex = 2;
            this.clientCodeBtnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.clientNameBtnEdit_ButtonClick);
            // 
            // orderDayCount
            // 
            this.orderDayCount.EditValue = new decimal(new int[] {
            7,
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
            50,
            0,
            0,
            0});
            this.orderDayCount.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.orderDayCount.Size = new System.Drawing.Size(74, 20);
            this.orderDayCount.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(13, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Cari Kodu";
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
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(364, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "İş Yeri";
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
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(364, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Anbar";
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
            // WhouseLookUp
            // 
            this.WhouseLookUp.EnterMoveNextControl = true;
            this.WhouseLookUp.Location = new System.Drawing.Point(438, 48);
            this.WhouseLookUp.Name = "WhouseLookUp";
            this.WhouseLookUp.Properties.AllowFocused = false;
            this.WhouseLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.WhouseLookUp.Properties.Appearance.Options.UseFont = true;
            this.WhouseLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WhouseLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DIVISNR", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.WhouseLookUp.Properties.DisplayMember = "NR";
            this.WhouseLookUp.Properties.NullText = "";
            this.WhouseLookUp.Properties.ValueMember = "NR";
            this.WhouseLookUp.Size = new System.Drawing.Size(192, 20);
            this.WhouseLookUp.TabIndex = 14;
            // 
            // BranchLookUp
            // 
            this.BranchLookUp.EnterMoveNextControl = true;
            this.BranchLookUp.Location = new System.Drawing.Point(438, 11);
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
            this.BranchLookUp.TabIndex = 15;
            this.BranchLookUp.EditValueChanged += new System.EventHandler(this.BranchLookUp_EditValueChanged);
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
            this.progress.Size = new System.Drawing.Size(1347, 45);
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
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 11, true, true, "Excele Göndər", "1"),
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 9, true, true, "Miqdarı Eyniləşdir", "2")});
            this.grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.EmbeddedNavigator.TextStringFormat = "Sətir {0} \\ {1}";
            this.grid.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grid_EmbeddedNavigator_ButtonClick);
            gridLevelNode2.RelationName = "Level1";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grid.Location = new System.Drawing.Point(0, 106);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1347, 420);
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
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UNITCODE,
            this.ITEMCODE,
            this.ITEMNAME,
            this.BARCODE,
            this.CATEGORY,
            this.CATCODE,
            this.UNITNAME,
            this.STOK,
            this.TOTALSALE,
            this.SALE,
            this.Kenarlasma,
            this.PROGNOZ,
            this.STOKGUN,
            this.RESULT,
            this.AMOUNT});
            this.gridView1.FooterPanelHeight = 2;
            this.gridView1.GridControl = this.grid;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView1_EditFormShowing);
            this.gridView1.EditFormPrepared += new DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventHandler(this.gridView1_EditFormPrepared);
            // 
            // UNITCODE
            // 
            this.UNITCODE.Caption = "Ö/V";
            this.UNITCODE.FieldName = "UNITCODE";
            this.UNITCODE.Name = "UNITCODE";
            this.UNITCODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.UNITCODE.Width = 63;
            // 
            // ITEMCODE
            // 
            this.ITEMCODE.Caption = "Kod";
            this.ITEMCODE.ColumnEdit = this.repoCity;
            this.ITEMCODE.FieldName = "ITEMCODE";
            this.ITEMCODE.Name = "ITEMCODE";
            this.ITEMCODE.OptionsColumn.AllowEdit = false;
            this.ITEMCODE.OptionsColumn.AllowFocus = false;
            this.ITEMCODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.ITEMCODE.Visible = true;
            this.ITEMCODE.VisibleIndex = 1;
            this.ITEMCODE.Width = 78;
            // 
            // ITEMNAME
            // 
            this.ITEMNAME.Caption = "Ad";
            this.ITEMNAME.ColumnEdit = this.repoCity;
            this.ITEMNAME.FieldName = "ITEMNAME";
            this.ITEMNAME.Name = "ITEMNAME";
            this.ITEMNAME.OptionsColumn.AllowEdit = false;
            this.ITEMNAME.OptionsColumn.AllowFocus = false;
            this.ITEMNAME.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.ITEMNAME.Visible = true;
            this.ITEMNAME.VisibleIndex = 2;
            this.ITEMNAME.Width = 250;
            // 
            // BARCODE
            // 
            this.BARCODE.Caption = "Barkod";
            this.BARCODE.FieldName = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.OptionsColumn.AllowEdit = false;
            this.BARCODE.OptionsColumn.AllowFocus = false;
            this.BARCODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.BARCODE.Visible = true;
            this.BARCODE.VisibleIndex = 6;
            this.BARCODE.Width = 76;
            // 
            // CATEGORY
            // 
            this.CATEGORY.Caption = "Kateqoriya";
            this.CATEGORY.FieldName = "CATEGORY";
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.OptionsColumn.AllowEdit = false;
            this.CATEGORY.OptionsColumn.AllowFocus = false;
            this.CATEGORY.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.CATEGORY.Visible = true;
            this.CATEGORY.VisibleIndex = 3;
            this.CATEGORY.Width = 87;
            // 
            // CATCODE
            // 
            this.CATCODE.Caption = "Kateqoriya Kod";
            this.CATCODE.FieldName = "CATCODE";
            this.CATCODE.Name = "CATCODE";
            this.CATCODE.OptionsColumn.AllowEdit = false;
            this.CATCODE.OptionsColumn.AllowFocus = false;
            this.CATCODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.CATCODE.Visible = true;
            this.CATCODE.VisibleIndex = 4;
            this.CATCODE.Width = 84;
            // 
            // UNITNAME
            // 
            this.UNITNAME.Caption = "Ö\\V";
            this.UNITNAME.FieldName = "UNITNAME";
            this.UNITNAME.Name = "UNITNAME";
            this.UNITNAME.OptionsColumn.AllowEdit = false;
            this.UNITNAME.OptionsColumn.AllowFocus = false;
            this.UNITNAME.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.UNITNAME.Visible = true;
            this.UNITNAME.VisibleIndex = 5;
            this.UNITNAME.Width = 64;
            // 
            // STOK
            // 
            this.STOK.Caption = "Stok";
            this.STOK.FieldName = "STOK";
            this.STOK.Name = "STOK";
            this.STOK.OptionsColumn.AllowEdit = false;
            this.STOK.OptionsColumn.AllowFocus = false;
            this.STOK.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.STOK.Visible = true;
            this.STOK.VisibleIndex = 7;
            this.STOK.Width = 66;
            // 
            // TOTALSALE
            // 
            this.TOTALSALE.Caption = "Ortalama Satış";
            this.TOTALSALE.FieldName = "TOTALSALE";
            this.TOTALSALE.Name = "TOTALSALE";
            this.TOTALSALE.OptionsColumn.AllowEdit = false;
            this.TOTALSALE.OptionsColumn.AllowFocus = false;
            this.TOTALSALE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.TOTALSALE.Visible = true;
            this.TOTALSALE.VisibleIndex = 8;
            this.TOTALSALE.Width = 83;
            // 
            // SALE
            // 
            this.SALE.Caption = "Satış";
            this.SALE.FieldName = "SALE";
            this.SALE.Name = "SALE";
            this.SALE.OptionsColumn.AllowEdit = false;
            this.SALE.OptionsColumn.AllowFocus = false;
            this.SALE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.SALE.Visible = true;
            this.SALE.VisibleIndex = 10;
            this.SALE.Width = 204;
            // 
            // Kenarlasma
            // 
            this.Kenarlasma.Caption = "Kenarlasma";
            this.Kenarlasma.FieldName = "Kenarlasma";
            this.Kenarlasma.Name = "Kenarlasma";
            this.Kenarlasma.OptionsColumn.AllowEdit = false;
            this.Kenarlasma.OptionsColumn.AllowFocus = false;
            this.Kenarlasma.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.Kenarlasma.Visible = true;
            this.Kenarlasma.VisibleIndex = 9;
            this.Kenarlasma.Width = 66;
            // 
            // PROGNOZ
            // 
            this.PROGNOZ.Caption = "Proqnoz";
            this.PROGNOZ.FieldName = "PROGNOZ";
            this.PROGNOZ.Name = "PROGNOZ";
            this.PROGNOZ.OptionsColumn.AllowEdit = false;
            this.PROGNOZ.OptionsColumn.AllowFocus = false;
            this.PROGNOZ.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.PROGNOZ.Visible = true;
            this.PROGNOZ.VisibleIndex = 11;
            this.PROGNOZ.Width = 66;
            // 
            // STOKGUN
            // 
            this.STOKGUN.Caption = "Stok Gün";
            this.STOKGUN.FieldName = "STOKGUN";
            this.STOKGUN.Name = "STOKGUN";
            this.STOKGUN.OptionsColumn.AllowEdit = false;
            this.STOKGUN.OptionsColumn.AllowFocus = false;
            this.STOKGUN.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.STOKGUN.Visible = true;
            this.STOKGUN.VisibleIndex = 12;
            this.STOKGUN.Width = 62;
            // 
            // RESULT
            // 
            this.RESULT.Caption = "Ehtiyac";
            this.RESULT.FieldName = "RESULT";
            this.RESULT.Name = "RESULT";
            this.RESULT.OptionsColumn.AllowEdit = false;
            this.RESULT.OptionsColumn.AllowFocus = false;
            this.RESULT.OptionsColumn.ReadOnly = true;
            this.RESULT.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.RESULT.Visible = true;
            this.RESULT.VisibleIndex = 13;
            this.RESULT.Width = 65;
            // 
            // AMOUNT
            // 
            this.AMOUNT.Caption = "Sifariş";
            this.AMOUNT.FieldName = "AMOUNT";
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.OptionsColumn.AllowEdit = false;
            this.AMOUNT.OptionsColumn.AllowFocus = false;
            this.AMOUNT.Visible = true;
            this.AMOUNT.VisibleIndex = 14;
            this.AMOUNT.Width = 55;
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.groupControl2.Controls.Add(this.LoadLayout);
            this.groupControl2.Controls.Add(this.DefaultLayout);
            this.groupControl2.Controls.Add(this.SaveGridViewCustomization);
            this.groupControl2.Controls.Add(this.cancelBtn);
            this.groupControl2.Controls.Add(this.saveBtn);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 526);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1347, 64);
            this.groupControl2.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.Appearance.Options.UseFont = true;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.Location = new System.Drawing.Point(188, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(142, 46);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Ləğv Et";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(29, 6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(142, 46);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Yadda Saxla";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // LoadLayout
            // 
            this.LoadLayout.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LoadLayout.Appearance.Options.UseFont = true;
            this.LoadLayout.Image = ((System.Drawing.Image)(resources.GetObject("LoadLayout.Image")));
            this.LoadLayout.Location = new System.Drawing.Point(563, 12);
            this.LoadLayout.Name = "LoadLayout";
            this.LoadLayout.Size = new System.Drawing.Size(175, 33);
            this.LoadLayout.TabIndex = 7;
            this.LoadLayout.Text = "Dizaynı Yüklə";
            this.LoadLayout.Click += new System.EventHandler(this.LoadLayout_Click);
            // 
            // DefaultLayout
            // 
            this.DefaultLayout.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DefaultLayout.Appearance.Options.UseFont = true;
            this.DefaultLayout.Image = ((System.Drawing.Image)(resources.GetObject("DefaultLayout.Image")));
            this.DefaultLayout.Location = new System.Drawing.Point(744, 12);
            this.DefaultLayout.Name = "DefaultLayout";
            this.DefaultLayout.Size = new System.Drawing.Size(175, 33);
            this.DefaultLayout.TabIndex = 6;
            this.DefaultLayout.Text = "İlkin Görünüş";
            this.DefaultLayout.Click += new System.EventHandler(this.DefaultLayout_Click);
            // 
            // SaveGridViewCustomization
            // 
            this.SaveGridViewCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.SaveGridViewCustomization.Appearance.Options.UseFont = true;
            this.SaveGridViewCustomization.Image = ((System.Drawing.Image)(resources.GetObject("SaveGridViewCustomization.Image")));
            this.SaveGridViewCustomization.Location = new System.Drawing.Point(389, 12);
            this.SaveGridViewCustomization.Name = "SaveGridViewCustomization";
            this.SaveGridViewCustomization.Size = new System.Drawing.Size(168, 33);
            this.SaveGridViewCustomization.TabIndex = 5;
            this.SaveGridViewCustomization.Text = "Dizaynı Yadda Saxla";
            this.SaveGridViewCustomization.Click += new System.EventHandler(this.SaveGridViewCustomization_Click);
            // 
            // NewPurchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(1347, 590);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPurchOrder";
            this.Text = "Yeni Sifariş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPurchOrder_FormClosing);
            this.Load += new System.EventHandler(this.NewPurchOrder_Load);
            this.Resize += new System.EventHandler(this.NewPurchOrder_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.repoCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientNameBtnEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCodeBtnEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDayCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDayCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhouseLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControl1;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl2;
        private ButtonEdit clientCodeBtnEdit;
        private LabelControl labelControl1;
        private ButtonEdit clientNameBtnEdit;
        private GridControl grid;
        private GridView gridView1;
        private GridColumn ITEMCODE;
        private GridColumn ITEMNAME;
        private GridColumn CATEGORY;
        private GridColumn UNITNAME;
        private GroupControl groupControl2;
        private LookUpEdit BranchLookUp;
        private LookUpEdit WhouseLookUp;
        private SimpleButton CalculateBtn;
        private SpinEdit orderDayCount;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private SpinEdit calcDayCount;
        private GridColumn BARCODE;
        private GridColumn UNITCODE;
        private GridColumn CATCODE;
        private GridColumn STOK;
        private GridColumn SALE;
        private GridColumn TOTALSALE;
        private GridColumn Kenarlasma;
        private GridColumn PROGNOZ;
        private GridColumn STOKGUN;
        private GridColumn AMOUNT;
        private ProgressPanel progress;
        private GroupControl groupControl3;
        private SimpleButton cancelBtn;
        private SimpleButton saveBtn;
        private GridColumn RESULT;
        private RepositoryItemButtonEdit repoCity;
        private SimpleButton LoadLayout;
        private SimpleButton DefaultLayout;
        private SimpleButton SaveGridViewCustomization;
    }
}