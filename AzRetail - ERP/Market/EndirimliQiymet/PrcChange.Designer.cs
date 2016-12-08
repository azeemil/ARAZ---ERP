namespace ERP.Market.EndirimliQiymet
{
    partial class PrcChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrcChange));
            this.HeaderGrp = new DevExpress.XtraEditors.GroupControl();
            this.ReadBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EditBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.NewBtn = new DevExpress.XtraEditors.SimpleButton();
            this.FiltrGrp = new DevExpress.XtraEditors.GroupControl();
            this.branchChbx = new DevExpress.XtraEditors.CheckEdit();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.BegDate = new DevExpress.XtraEditors.DateEdit();
            this.dateChbx = new DevExpress.XtraEditors.CheckEdit();
            this.branchCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.APPROVED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CREATEDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COMMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CANCELLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRANCHNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CREATEDDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.RefreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ShowPopUp = new DevExpress.XtraBars.BarButtonItem();
            this.NewPopUp = new DevExpress.XtraBars.BarButtonItem();
            this.EditPopUp = new DevExpress.XtraBars.BarButtonItem();
            this.CancelPopUp = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderGrp)).BeginInit();
            this.HeaderGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrGrp)).BeginInit();
            this.FiltrGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGrp
            // 
            this.HeaderGrp.Controls.Add(this.ReadBtn);
            this.HeaderGrp.Controls.Add(this.EditBtn);
            this.HeaderGrp.Controls.Add(this.DeleteBtn);
            this.HeaderGrp.Controls.Add(this.NewBtn);
            this.HeaderGrp.Controls.Add(this.FiltrGrp);
            this.HeaderGrp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HeaderGrp.Location = new System.Drawing.Point(0, 403);
            this.HeaderGrp.Name = "HeaderGrp";
            this.HeaderGrp.Size = new System.Drawing.Size(1078, 100);
            this.HeaderGrp.TabIndex = 0;
            // 
            // ReadBtn
            // 
            this.ReadBtn.AllowFocus = false;
            this.ReadBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBtn.Appearance.Options.UseFont = true;
            this.ReadBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReadBtn.Image")));
            this.ReadBtn.Location = new System.Drawing.Point(10, 30);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(70, 34);
            this.ReadBtn.TabIndex = 7;
            this.ReadBtn.Text = "Incələ";
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AllowFocus = false;
            this.EditBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Appearance.Options.UseFont = true;
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.Location = new System.Drawing.Point(158, 30);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(70, 34);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Dəyiş";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AllowFocus = false;
            this.DeleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Appearance.Options.UseFont = true;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Location = new System.Drawing.Point(234, 30);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 34);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Ləğv et";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.AllowFocus = false;
            this.NewBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Appearance.Options.UseFont = true;
            this.NewBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBtn.Image")));
            this.NewBtn.Location = new System.Drawing.Point(82, 30);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(70, 34);
            this.NewBtn.TabIndex = 4;
            this.NewBtn.Text = "Yeni";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // FiltrGrp
            // 
            this.FiltrGrp.Controls.Add(this.branchChbx);
            this.FiltrGrp.Controls.Add(this.SearchBtn);
            this.FiltrGrp.Controls.Add(this.EndDate);
            this.FiltrGrp.Controls.Add(this.BegDate);
            this.FiltrGrp.Controls.Add(this.dateChbx);
            this.FiltrGrp.Controls.Add(this.branchCmbx);
            this.FiltrGrp.Dock = System.Windows.Forms.DockStyle.Right;
            this.FiltrGrp.Location = new System.Drawing.Point(490, 20);
            this.FiltrGrp.Name = "FiltrGrp";
            this.FiltrGrp.Size = new System.Drawing.Size(586, 78);
            this.FiltrGrp.TabIndex = 0;
            // 
            // branchChbx
            // 
            this.branchChbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.branchChbx.EditValue = true;
            this.branchChbx.Location = new System.Drawing.Point(30, 22);
            this.branchChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.branchChbx.Name = "branchChbx";
            this.branchChbx.Properties.AllowFocused = false;
            this.branchChbx.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchChbx.Properties.Appearance.Options.UseFont = true;
            this.branchChbx.Properties.Caption = "Iş Yeri";
            this.branchChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.branchChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.branchChbx.Size = new System.Drawing.Size(62, 22);
            this.branchChbx.TabIndex = 26;
            this.branchChbx.Tag = "1";
            this.branchChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AllowFocus = false;
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(379, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(196, 40);
            this.SearchBtn.TabIndex = 25;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // EndDate
            // 
            this.EndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.EndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EndDate.Location = new System.Drawing.Point(220, 49);
            this.EndDate.Name = "EndDate";
            this.EndDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Properties.Appearance.Options.UseFont = true;
            this.EndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Size = new System.Drawing.Size(110, 22);
            this.EndDate.TabIndex = 24;
            // 
            // BegDate
            // 
            this.BegDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BegDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.BegDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BegDate.Location = new System.Drawing.Point(105, 49);
            this.BegDate.Name = "BegDate";
            this.BegDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BegDate.Properties.Appearance.Options.UseFont = true;
            this.BegDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.BegDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BegDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BegDate.Size = new System.Drawing.Size(109, 22);
            this.BegDate.TabIndex = 23;
            // 
            // dateChbx
            // 
            this.dateChbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateChbx.EditValue = true;
            this.dateChbx.Location = new System.Drawing.Point(31, 49);
            this.dateChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateChbx.Name = "dateChbx";
            this.dateChbx.Properties.AllowFocused = false;
            this.dateChbx.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateChbx.Properties.Appearance.Options.UseFont = true;
            this.dateChbx.Properties.Caption = "Tarix";
            this.dateChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.dateChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dateChbx.Size = new System.Drawing.Size(59, 22);
            this.dateChbx.TabIndex = 22;
            this.dateChbx.Tag = "5";
            this.dateChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // branchCmbx
            // 
            this.branchCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.branchCmbx.Location = new System.Drawing.Point(105, 24);
            this.branchCmbx.Name = "branchCmbx";
            this.branchCmbx.Properties.AllowFocused = false;
            this.branchCmbx.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchCmbx.Properties.Appearance.Options.UseFont = true;
            this.branchCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.branchCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.branchCmbx.Properties.ValueMember = "NR";
            this.branchCmbx.Size = new System.Drawing.Size(162, 20);
            this.branchCmbx.TabIndex = 21;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1078, 403);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.APPROVED,
            this.BRANCH,
            this.CREATEDUSER,
            this.COMMENT,
            this.CANCELLED,
            this.BRANCHNAME,
            this.CREATEDDATE});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "№";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 78;
            // 
            // APPROVED
            // 
            this.APPROVED.Caption = "Təsdiqlənib";
            this.APPROVED.FieldName = "APPROVED";
            this.APPROVED.Name = "APPROVED";
            this.APPROVED.OptionsColumn.AllowEdit = false;
            this.APPROVED.OptionsColumn.AllowFocus = false;
            this.APPROVED.OptionsColumn.ReadOnly = true;
            this.APPROVED.Visible = true;
            this.APPROVED.VisibleIndex = 1;
            this.APPROVED.Width = 85;
            // 
            // BRANCH
            // 
            this.BRANCH.Caption = "Filial №";
            this.BRANCH.FieldName = "BRANCH";
            this.BRANCH.Name = "BRANCH";
            this.BRANCH.OptionsColumn.AllowEdit = false;
            this.BRANCH.OptionsColumn.AllowFocus = false;
            this.BRANCH.OptionsColumn.ReadOnly = true;
            this.BRANCH.Visible = true;
            this.BRANCH.VisibleIndex = 2;
            this.BRANCH.Width = 77;
            // 
            // CREATEDUSER
            // 
            this.CREATEDUSER.Caption = "İstifadəçi";
            this.CREATEDUSER.FieldName = "CREATEDUSER";
            this.CREATEDUSER.Name = "CREATEDUSER";
            this.CREATEDUSER.OptionsColumn.AllowEdit = false;
            this.CREATEDUSER.OptionsColumn.AllowFocus = false;
            this.CREATEDUSER.OptionsColumn.ReadOnly = true;
            this.CREATEDUSER.Visible = true;
            this.CREATEDUSER.VisibleIndex = 4;
            this.CREATEDUSER.Width = 213;
            // 
            // COMMENT
            // 
            this.COMMENT.Caption = "Rəy";
            this.COMMENT.FieldName = "COMMENT";
            this.COMMENT.Name = "COMMENT";
            this.COMMENT.OptionsColumn.AllowEdit = false;
            this.COMMENT.OptionsColumn.AllowFocus = false;
            this.COMMENT.OptionsColumn.ReadOnly = true;
            this.COMMENT.Visible = true;
            this.COMMENT.VisibleIndex = 5;
            this.COMMENT.Width = 360;
            // 
            // CANCELLED
            // 
            this.CANCELLED.Caption = "Ləğv Olunub";
            this.CANCELLED.FieldName = "CANCELLED";
            this.CANCELLED.Name = "CANCELLED";
            this.CANCELLED.OptionsColumn.AllowEdit = false;
            this.CANCELLED.OptionsColumn.AllowFocus = false;
            this.CANCELLED.OptionsColumn.ReadOnly = true;
            this.CANCELLED.Visible = true;
            this.CANCELLED.VisibleIndex = 6;
            this.CANCELLED.Width = 74;
            // 
            // BRANCHNAME
            // 
            this.BRANCHNAME.Caption = "Filial";
            this.BRANCHNAME.FieldName = "BRANCHNAME";
            this.BRANCHNAME.Name = "BRANCHNAME";
            this.BRANCHNAME.OptionsColumn.AllowEdit = false;
            this.BRANCHNAME.OptionsColumn.AllowFocus = false;
            this.BRANCHNAME.OptionsColumn.ReadOnly = true;
            this.BRANCHNAME.Visible = true;
            this.BRANCHNAME.VisibleIndex = 3;
            this.BRANCHNAME.Width = 173;
            // 
            // CREATEDDATE
            // 
            this.CREATEDDATE.Caption = "Tarix";
            this.CREATEDDATE.FieldName = "CREATEDDATE";
            this.CREATEDDATE.Name = "CREATEDDATE";
            this.CREATEDDATE.OptionsColumn.AllowEdit = false;
            this.CREATEDDATE.OptionsColumn.AllowFocus = false;
            this.CREATEDDATE.OptionsColumn.ReadOnly = true;
            this.CREATEDDATE.Visible = true;
            this.CREATEDDATE.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ləğv Olunub";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 74;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ləğv Olunub";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 74;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.RefreshBtn),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ShowPopUp, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.NewPopUp),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditPopUp),
            new DevExpress.XtraBars.LinkPersistInfo(this.CancelPopUp)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Caption = "Yenilə";
            this.RefreshBtn.Id = 4;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshBtn_ItemClick);
            // 
            // ShowPopUp
            // 
            this.ShowPopUp.Caption = "İncələ";
            this.ShowPopUp.Id = 0;
            this.ShowPopUp.Name = "ShowPopUp";
            this.ShowPopUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ShowPopUp_ItemClick);
            // 
            // NewPopUp
            // 
            this.NewPopUp.Caption = "Yeni";
            this.NewPopUp.Id = 1;
            this.NewPopUp.Name = "NewPopUp";
            this.NewPopUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewPopUp_ItemClick);
            // 
            // EditPopUp
            // 
            this.EditPopUp.Caption = "Dəyiş";
            this.EditPopUp.Id = 2;
            this.EditPopUp.Name = "EditPopUp";
            this.EditPopUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditPopUp_ItemClick);
            // 
            // CancelPopUp
            // 
            this.CancelPopUp.Caption = "Ləğv et";
            this.CancelPopUp.Id = 3;
            this.CancelPopUp.Name = "CancelPopUp";
            this.CancelPopUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CancelPopUp_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ShowPopUp,
            this.NewPopUp,
            this.EditPopUp,
            this.CancelPopUp,
            this.RefreshBtn});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1078, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 503);
            this.barDockControlBottom.Size = new System.Drawing.Size(1078, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 503);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1078, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 503);
            // 
            // PrcChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 503);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.HeaderGrp);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrcChange";
            this.Text = "Endirimli qiymət";
            this.Load += new System.EventHandler(this.PrcChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderGrp)).EndInit();
            this.HeaderGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FiltrGrp)).EndInit();
            this.FiltrGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branchChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl HeaderGrp;
        private DevExpress.XtraEditors.GroupControl FiltrGrp;
        private DevExpress.XtraEditors.CheckedComboBoxEdit branchCmbx;
        private DevExpress.XtraEditors.DateEdit EndDate;
        private DevExpress.XtraEditors.DateEdit BegDate;
        private DevExpress.XtraEditors.CheckEdit dateChbx;
        private DevExpress.XtraEditors.CheckEdit branchChbx;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn APPROVED;
        private DevExpress.XtraGrid.Columns.GridColumn BRANCH;
        private DevExpress.XtraGrid.Columns.GridColumn CREATEDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn COMMENT;
        private DevExpress.XtraGrid.Columns.GridColumn CANCELLED;
        private DevExpress.XtraGrid.Columns.GridColumn BRANCHNAME;
        private DevExpress.XtraEditors.SimpleButton EditBtn;
        private DevExpress.XtraEditors.SimpleButton DeleteBtn;
        private DevExpress.XtraEditors.SimpleButton NewBtn;
        private DevExpress.XtraEditors.SimpleButton ReadBtn;
        private DevExpress.XtraGrid.Columns.GridColumn CREATEDDATE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem ShowPopUp;
        private DevExpress.XtraBars.BarButtonItem NewPopUp;
        private DevExpress.XtraBars.BarButtonItem EditPopUp;
        private DevExpress.XtraBars.BarButtonItem CancelPopUp;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem RefreshBtn;
    }
}