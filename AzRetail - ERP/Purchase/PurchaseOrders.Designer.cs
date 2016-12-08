using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP.Purchase
{
    partial class PurchaseOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrders));
            this.Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ROWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLOGICALREF3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FICHENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEFINITION_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOURCEINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WHNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ROWNR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.NewBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.branchCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.branchChbx = new DevExpress.XtraEditors.CheckEdit();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.whouseCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.BegDate = new DevExpress.XtraEditors.DateEdit();
            this.dateChbx = new DevExpress.XtraEditors.CheckEdit();
            this.WhouseChbx = new DevExpress.XtraEditors.CheckEdit();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.DetailsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.SharedImages = new DevExpress.Utils.SharedImageCollection(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP.General.Wait), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whouseCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhouseChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SharedImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SharedImages.ImageSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Detail
            // 
            this.Detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ROWID,
            this.ITEMCODE});
            this.Detail.GridControl = this.grid;
            this.Detail.Name = "Detail";
            // 
            // ROWID
            // 
            this.ROWID.Caption = "№";
            this.ROWID.FieldName = "ROW";
            this.ROWID.Name = "ROWID";
            this.ROWID.Visible = true;
            this.ROWID.VisibleIndex = 0;
            // 
            // ITEMCODE
            // 
            this.ITEMCODE.Caption = "gridColumn1";
            this.ITEMCODE.FieldName = "CODE";
            this.ITEMCODE.Name = "ITEMCODE";
            this.ITEMCODE.Visible = true;
            this.ITEMCODE.VisibleIndex = 1;
            // 
            // grid
            // 
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1314, 470);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view,
            this.detailView,
            this.Detail});
            this.grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_MouseClick);
            // 
            // view
            // 
            this.view.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.view.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.view.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.view.Appearance.SelectedRow.Options.UseBackColor = true;
            this.view.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.view.AppearancePrint.OddRow.BorderColor = System.Drawing.Color.Silver;
            this.view.AppearancePrint.OddRow.Options.UseBorderColor = true;
            this.view.AppearancePrint.Row.BorderColor = System.Drawing.Color.Black;
            this.view.AppearancePrint.Row.Options.UseBorderColor = true;
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLOGICALREF3,
            this.FICHENO,
            this.DOCODE,
            this.DATE_,
            this.CODE,
            this.DEFINITION_,
            this.BRANCH,
            this.NAME,
            this.SOURCEINDEX,
            this.WHNAME});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colLOGICALREF3
            // 
            this.colLOGICALREF3.FieldName = "LOGICALREF";
            this.colLOGICALREF3.Name = "colLOGICALREF3";
            // 
            // FICHENO
            // 
            this.FICHENO.Caption = "Qaimə №";
            this.FICHENO.FieldName = "FICHENO";
            this.FICHENO.Name = "FICHENO";
            this.FICHENO.OptionsColumn.AllowEdit = false;
            this.FICHENO.OptionsColumn.AllowFocus = false;
            this.FICHENO.Visible = true;
            this.FICHENO.VisibleIndex = 0;
            this.FICHENO.Width = 119;
            // 
            // DOCODE
            // 
            this.DOCODE.Caption = "Sənəd №";
            this.DOCODE.FieldName = "DOCODE";
            this.DOCODE.Name = "DOCODE";
            this.DOCODE.OptionsColumn.AllowEdit = false;
            this.DOCODE.OptionsColumn.AllowFocus = false;
            this.DOCODE.Visible = true;
            this.DOCODE.VisibleIndex = 1;
            this.DOCODE.Width = 130;
            // 
            // DATE_
            // 
            this.DATE_.Caption = "Tarix";
            this.DATE_.FieldName = "DATE_";
            this.DATE_.Name = "DATE_";
            this.DATE_.OptionsColumn.AllowEdit = false;
            this.DATE_.OptionsColumn.AllowFocus = false;
            this.DATE_.Visible = true;
            this.DATE_.VisibleIndex = 2;
            this.DATE_.Width = 139;
            // 
            // CODE
            // 
            this.CODE.Caption = "Cari №";
            this.CODE.FieldName = "CODE";
            this.CODE.Name = "CODE";
            this.CODE.OptionsColumn.AllowEdit = false;
            this.CODE.OptionsColumn.AllowFocus = false;
            this.CODE.Visible = true;
            this.CODE.VisibleIndex = 7;
            this.CODE.Width = 156;
            // 
            // DEFINITION_
            // 
            this.DEFINITION_.Caption = "Cari ";
            this.DEFINITION_.FieldName = "DEFINITION_";
            this.DEFINITION_.Name = "DEFINITION_";
            this.DEFINITION_.OptionsColumn.AllowEdit = false;
            this.DEFINITION_.OptionsColumn.AllowFocus = false;
            this.DEFINITION_.Visible = true;
            this.DEFINITION_.VisibleIndex = 8;
            this.DEFINITION_.Width = 354;
            // 
            // BRANCH
            // 
            this.BRANCH.Caption = "Filial №";
            this.BRANCH.FieldName = "BRANCH";
            this.BRANCH.Name = "BRANCH";
            this.BRANCH.OptionsColumn.AllowEdit = false;
            this.BRANCH.OptionsColumn.AllowFocus = false;
            this.BRANCH.Visible = true;
            this.BRANCH.VisibleIndex = 3;
            this.BRANCH.Width = 66;
            // 
            // NAME
            // 
            this.NAME.Caption = "Filial";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 4;
            this.NAME.Width = 135;
            // 
            // SOURCEINDEX
            // 
            this.SOURCEINDEX.Caption = "Anbar №";
            this.SOURCEINDEX.FieldName = "SOURCEINDEX";
            this.SOURCEINDEX.Name = "SOURCEINDEX";
            this.SOURCEINDEX.OptionsColumn.AllowEdit = false;
            this.SOURCEINDEX.OptionsColumn.AllowFocus = false;
            this.SOURCEINDEX.Visible = true;
            this.SOURCEINDEX.VisibleIndex = 5;
            this.SOURCEINDEX.Width = 74;
            // 
            // WHNAME
            // 
            this.WHNAME.Caption = "Anbar";
            this.WHNAME.FieldName = "WHNAME";
            this.WHNAME.Name = "WHNAME";
            this.WHNAME.OptionsColumn.AllowEdit = false;
            this.WHNAME.OptionsColumn.AllowFocus = false;
            this.WHNAME.Visible = true;
            this.WHNAME.VisibleIndex = 6;
            this.WHNAME.Width = 121;
            // 
            // detailView
            // 
            this.detailView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ROWNR,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1});
            this.detailView.GridControl = this.grid;
            this.detailView.Name = "detailView";
            // 
            // ROWNR
            // 
            this.ROWNR.Caption = "ROWNR";
            this.ROWNR.FieldName = "ROWNR";
            this.ROWNR.Name = "ROWNR";
            this.ROWNR.Visible = true;
            this.ROWNR.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CODE";
            this.gridColumn2.FieldName = "CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "BARCODE";
            this.gridColumn3.FieldName = "BARCODE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "NAME";
            this.gridColumn1.FieldName = "NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 470);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1314, 136);
            this.groupControl1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.NewBtn);
            this.groupControl3.Location = new System.Drawing.Point(425, 25);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(261, 109);
            this.groupControl3.TabIndex = 19;
            // 
            // NewBtn
            // 
            this.NewBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Appearance.Options.UseFont = true;
            this.NewBtn.Image = global::ERP.Properties.Resources._png_converted__1_;
            this.NewBtn.Location = new System.Drawing.Point(157, 28);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(99, 44);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "Yeni";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.branchCmbx);
            this.groupControl2.Controls.Add(this.branchChbx);
            this.groupControl2.Controls.Add(this.SearchBtn);
            this.groupControl2.Controls.Add(this.whouseCmbx);
            this.groupControl2.Controls.Add(this.EndDate);
            this.groupControl2.Controls.Add(this.BegDate);
            this.groupControl2.Controls.Add(this.dateChbx);
            this.groupControl2.Controls.Add(this.WhouseChbx);
            this.groupControl2.Location = new System.Drawing.Point(692, 25);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(620, 109);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Axtarış";
            // 
            // branchCmbx
            // 
            this.branchCmbx.Location = new System.Drawing.Point(122, 32);
            this.branchCmbx.Name = "branchCmbx";
            this.branchCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.branchCmbx.Properties.Appearance.Options.UseFont = true;
            this.branchCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.branchCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.branchCmbx.Properties.ValueMember = "NR";
            this.branchCmbx.Size = new System.Drawing.Size(149, 22);
            this.branchCmbx.TabIndex = 20;
            // 
            // branchChbx
            // 
            this.branchChbx.Location = new System.Drawing.Point(11, 35);
            this.branchChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.branchChbx.Name = "branchChbx";
            this.branchChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.branchChbx.Properties.Appearance.Options.UseFont = true;
            this.branchChbx.Properties.Caption = "İş Yeri";
            this.branchChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.branchChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.branchChbx.Size = new System.Drawing.Size(105, 22);
            this.branchChbx.TabIndex = 19;
            this.branchChbx.Tag = "1";
            this.branchChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(373, 66);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(239, 40);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // whouseCmbx
            // 
            this.whouseCmbx.Location = new System.Drawing.Point(123, 68);
            this.whouseCmbx.Name = "whouseCmbx";
            this.whouseCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.whouseCmbx.Properties.Appearance.Options.UseFont = true;
            this.whouseCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.whouseCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.whouseCmbx.Properties.ValueMember = "NR";
            this.whouseCmbx.Size = new System.Drawing.Size(149, 22);
            this.whouseCmbx.TabIndex = 13;
            // 
            // EndDate
            // 
            this.EndDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.EndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EndDate.Location = new System.Drawing.Point(495, 30);
            this.EndDate.Name = "EndDate";
            this.EndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EndDate.Properties.Appearance.Options.UseFont = true;
            this.EndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Size = new System.Drawing.Size(117, 24);
            this.EndDate.TabIndex = 11;
            // 
            // BegDate
            // 
            this.BegDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.BegDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BegDate.Location = new System.Drawing.Point(369, 30);
            this.BegDate.Name = "BegDate";
            this.BegDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BegDate.Properties.Appearance.Options.UseFont = true;
            this.BegDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.BegDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BegDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BegDate.Size = new System.Drawing.Size(116, 24);
            this.BegDate.TabIndex = 10;
            // 
            // dateChbx
            // 
            this.dateChbx.EditValue = true;
            this.dateChbx.Location = new System.Drawing.Point(293, 35);
            this.dateChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateChbx.Name = "dateChbx";
            this.dateChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateChbx.Properties.Appearance.Options.UseFont = true;
            this.dateChbx.Properties.Caption = "Tarix";
            this.dateChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.dateChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dateChbx.Size = new System.Drawing.Size(70, 22);
            this.dateChbx.TabIndex = 9;
            this.dateChbx.Tag = "5";
            this.dateChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // WhouseChbx
            // 
            this.WhouseChbx.Location = new System.Drawing.Point(11, 71);
            this.WhouseChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WhouseChbx.Name = "WhouseChbx";
            this.WhouseChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.WhouseChbx.Properties.Appearance.Options.UseFont = true;
            this.WhouseChbx.Properties.Caption = "Anbar";
            this.WhouseChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.WhouseChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.WhouseChbx.Size = new System.Drawing.Size(105, 22);
            this.WhouseChbx.TabIndex = 12;
            this.WhouseChbx.Tag = "2";
            this.WhouseChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.DetailsBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Caption = "Incələ";
            this.DetailsBtn.Id = 0;
            this.DetailsBtn.ImageIndex = 5;
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Tag = ((short)(1));
            this.DetailsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DetailsBtn_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Çap Et";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageIndex = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Tag = ((short)(2));
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DetailsBtn_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.SharedImages;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.DetailsBtn,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1314, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Size = new System.Drawing.Size(1314, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 606);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1314, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 606);
            // 
            // SharedImages
            // 
            // 
            // 
            // 
            this.SharedImages.ImageSource.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("SharedImages.ImageSource.ImageStream")));
            this.SharedImages.ImageSource.Images.SetKeyName(0, "images (1).png");
            this.SharedImages.ImageSource.Images.SetKeyName(1, "images (8).jpg");
            this.SharedImages.ImageSource.Images.SetKeyName(2, "images (18).jpg");
            this.SharedImages.ImageSource.Images.SetKeyName(3, "invoiceicon.jpg");
            this.SharedImages.ImageSource.Images.SetKeyName(4, "print_icon.png");
            this.SharedImages.ImageSource.Images.SetKeyName(5, "show_detail.jpg");
            this.SharedImages.ImageSource.Images.SetKeyName(6, "скачанные файлы (2).jpg");
            this.SharedImages.ImageSource.Images.SetKeyName(7, "скачанные файлы.jpg");
            this.SharedImages.ParentControl = this;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // PurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 606);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseOrders";
            this.Text = "Alış Sifarişləri";
            ((System.ComponentModel.ISupportInitialize)(this.Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branchCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whouseCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhouseChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SharedImages.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SharedImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupControl groupControl1;
        private SimpleButton NewBtn;
        private GridControl grid;
        private GridView Detail;
        private GridColumn ROWID;
        private GridView view;
        private GridColumn colLOGICALREF3;
        private GridColumn FICHENO;
        private GridColumn DOCODE;
        private GridColumn DATE_;
        private GridColumn CODE;
        private GridColumn DEFINITION_;
        private GridColumn SOURCEINDEX;
        private GridColumn NAME;
        private GroupControl groupControl2;
        private CheckedComboBoxEdit whouseCmbx;
        private DateEdit EndDate;
        private DateEdit BegDate;
        private CheckEdit dateChbx;
        private CheckEdit WhouseChbx;
        private SimpleButton SearchBtn;
        private GridColumn BRANCH;
        private GridColumn WHNAME;
        private GridColumn ITEMCODE;
        private GroupControl groupControl3;
        private CheckedComboBoxEdit branchCmbx;
        private CheckEdit branchChbx;
        private GridView detailView;
        private GridColumn ROWNR;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn gridColumn1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem DetailsBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SharedImageCollection SharedImages;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}