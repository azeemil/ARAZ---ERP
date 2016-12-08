namespace ERP.Logistcs.CentralWHouse
{
    partial class CentralWhouseOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentralWhouseOrders));
            this.branchCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.branchChbx = new DevExpress.XtraEditors.CheckEdit();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.whouseCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.BegDate = new DevExpress.XtraEditors.DateEdit();
            this.WhouseChbx = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.SourceBranchCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.SourceBranchChbx = new DevExpress.XtraEditors.CheckEdit();
            this.SourceIndexCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.SourcheIndexChbx = new DevExpress.XtraEditors.CheckEdit();
            this.dateChbx = new DevExpress.XtraEditors.CheckEdit();
            this.NewBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ModifyBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ROWNR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORDERREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GROUPPED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOURCEBRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIVNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOURCEINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WHOUSENAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESTBRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIVNAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESTINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WHOUSENAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORDERTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ROWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.branchCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whouseCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhouseChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceBranchCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceBranchChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceIndexCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourcheIndexChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // branchCmbx
            // 
            this.branchCmbx.Location = new System.Drawing.Point(102, 35);
            this.branchCmbx.Name = "branchCmbx";
            this.branchCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.branchCmbx.Properties.Appearance.Options.UseFont = true;
            this.branchCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.branchCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.branchCmbx.Properties.ValueMember = "NR";
            this.branchCmbx.Size = new System.Drawing.Size(129, 22);
            this.branchCmbx.TabIndex = 20;
            // 
            // branchChbx
            // 
            this.branchChbx.Location = new System.Drawing.Point(11, 35);
            this.branchChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.branchChbx.Name = "branchChbx";
            this.branchChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.branchChbx.Properties.Appearance.Options.UseFont = true;
            this.branchChbx.Properties.Caption = "(G)İş Yeri";
            this.branchChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.branchChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.branchChbx.Size = new System.Drawing.Size(85, 22);
            this.branchChbx.TabIndex = 19;
            this.branchChbx.Tag = "1";
            this.branchChbx.BackgroundImageChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(498, 61);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(239, 40);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // whouseCmbx
            // 
            this.whouseCmbx.Location = new System.Drawing.Point(102, 71);
            this.whouseCmbx.Name = "whouseCmbx";
            this.whouseCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.whouseCmbx.Properties.Appearance.Options.UseFont = true;
            this.whouseCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.whouseCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.whouseCmbx.Properties.ValueMember = "NR";
            this.whouseCmbx.Size = new System.Drawing.Size(128, 22);
            this.whouseCmbx.TabIndex = 13;
            // 
            // EndDate
            // 
            this.EndDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.EndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EndDate.Location = new System.Drawing.Point(649, 33);
            this.EndDate.Name = "EndDate";
            this.EndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EndDate.Properties.Appearance.Options.UseFont = true;
            this.EndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Size = new System.Drawing.Size(88, 24);
            this.EndDate.TabIndex = 11;
            // 
            // BegDate
            // 
            this.BegDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.BegDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BegDate.Location = new System.Drawing.Point(558, 33);
            this.BegDate.Name = "BegDate";
            this.BegDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BegDate.Properties.Appearance.Options.UseFont = true;
            this.BegDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.BegDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BegDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BegDate.Size = new System.Drawing.Size(86, 24);
            this.BegDate.TabIndex = 10;
            // 
            // WhouseChbx
            // 
            this.WhouseChbx.Location = new System.Drawing.Point(11, 71);
            this.WhouseChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WhouseChbx.Name = "WhouseChbx";
            this.WhouseChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.WhouseChbx.Properties.Appearance.Options.UseFont = true;
            this.WhouseChbx.Properties.Caption = "(G)Anbar";
            this.WhouseChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.WhouseChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.WhouseChbx.Size = new System.Drawing.Size(85, 22);
            this.WhouseChbx.TabIndex = 12;
            this.WhouseChbx.Tag = "2";
            this.WhouseChbx.BackgroundImageChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.SourceBranchCmbx);
            this.groupControl2.Controls.Add(this.SourceBranchChbx);
            this.groupControl2.Controls.Add(this.SourceIndexCmbx);
            this.groupControl2.Controls.Add(this.SourcheIndexChbx);
            this.groupControl2.Controls.Add(this.branchCmbx);
            this.groupControl2.Controls.Add(this.branchChbx);
            this.groupControl2.Controls.Add(this.SearchBtn);
            this.groupControl2.Controls.Add(this.whouseCmbx);
            this.groupControl2.Controls.Add(this.EndDate);
            this.groupControl2.Controls.Add(this.BegDate);
            this.groupControl2.Controls.Add(this.dateChbx);
            this.groupControl2.Controls.Add(this.WhouseChbx);
            this.groupControl2.Location = new System.Drawing.Point(484, 34);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(743, 109);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Axtarış";
            // 
            // SourceBranchCmbx
            // 
            this.SourceBranchCmbx.Location = new System.Drawing.Point(344, 35);
            this.SourceBranchCmbx.Name = "SourceBranchCmbx";
            this.SourceBranchCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SourceBranchCmbx.Properties.Appearance.Options.UseFont = true;
            this.SourceBranchCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SourceBranchCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.SourceBranchCmbx.Properties.ValueMember = "NR";
            this.SourceBranchCmbx.Size = new System.Drawing.Size(127, 22);
            this.SourceBranchCmbx.TabIndex = 24;
            // 
            // SourceBranchChbx
            // 
            this.SourceBranchChbx.Location = new System.Drawing.Point(257, 35);
            this.SourceBranchChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceBranchChbx.Name = "SourceBranchChbx";
            this.SourceBranchChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SourceBranchChbx.Properties.Appearance.Options.UseFont = true;
            this.SourceBranchChbx.Properties.Caption = "(Ç)İş Yeri";
            this.SourceBranchChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.SourceBranchChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.SourceBranchChbx.Size = new System.Drawing.Size(77, 22);
            this.SourceBranchChbx.TabIndex = 23;
            this.SourceBranchChbx.Tag = "1";
            this.SourceBranchChbx.BackgroundImageChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SourceIndexCmbx
            // 
            this.SourceIndexCmbx.Location = new System.Drawing.Point(345, 71);
            this.SourceIndexCmbx.Name = "SourceIndexCmbx";
            this.SourceIndexCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SourceIndexCmbx.Properties.Appearance.Options.UseFont = true;
            this.SourceIndexCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SourceIndexCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.SourceIndexCmbx.Properties.ValueMember = "NR";
            this.SourceIndexCmbx.Size = new System.Drawing.Size(126, 22);
            this.SourceIndexCmbx.TabIndex = 22;
            // 
            // SourcheIndexChbx
            // 
            this.SourcheIndexChbx.Location = new System.Drawing.Point(257, 71);
            this.SourcheIndexChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourcheIndexChbx.Name = "SourcheIndexChbx";
            this.SourcheIndexChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SourcheIndexChbx.Properties.Appearance.Options.UseFont = true;
            this.SourcheIndexChbx.Properties.Caption = "(Ç)Anbar";
            this.SourcheIndexChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.SourcheIndexChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.SourcheIndexChbx.Size = new System.Drawing.Size(77, 22);
            this.SourcheIndexChbx.TabIndex = 21;
            this.SourcheIndexChbx.Tag = "2";
            this.SourcheIndexChbx.BackgroundImageChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // dateChbx
            // 
            this.dateChbx.EditValue = true;
            this.dateChbx.Location = new System.Drawing.Point(491, 35);
            this.dateChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateChbx.Name = "dateChbx";
            this.dateChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateChbx.Properties.Appearance.Options.UseFont = true;
            this.dateChbx.Properties.Caption = "Tarix";
            this.dateChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.dateChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dateChbx.Size = new System.Drawing.Size(59, 22);
            this.dateChbx.TabIndex = 9;
            this.dateChbx.Tag = "5";
            this.dateChbx.BackgroundImageChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // NewBtn
            // 
            this.NewBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Appearance.Options.UseFont = true;
            this.NewBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBtn.Image")));
            this.NewBtn.Location = new System.Drawing.Point(5, 23);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(70, 34);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "Yeni";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.ModifyBtn);
            this.groupControl3.Controls.Add(this.DeleteBtn);
            this.groupControl3.Controls.Add(this.NewBtn);
            this.groupControl3.Location = new System.Drawing.Point(217, 34);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(261, 109);
            this.groupControl3.TabIndex = 19;
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBtn.Appearance.Options.UseFont = true;
            this.ModifyBtn.Image = ((System.Drawing.Image)(resources.GetObject("ModifyBtn.Image")));
            this.ModifyBtn.Location = new System.Drawing.Point(81, 23);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(70, 34);
            this.ModifyBtn.TabIndex = 3;
            this.ModifyBtn.Text = "Çap Et";
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Appearance.Options.UseFont = true;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Location = new System.Drawing.Point(157, 23);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(70, 34);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 369);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1229, 145);
            this.groupControl1.TabIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "NAME";
            this.gridColumn1.FieldName = "NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "BARCODE";
            this.gridColumn3.FieldName = "BARCODE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CODE";
            this.gridColumn2.FieldName = "CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // ROWNR
            // 
            this.ROWNR.Caption = "ROWNR";
            this.ROWNR.FieldName = "ROWNR";
            this.ROWNR.Name = "ROWNR";
            this.ROWNR.Visible = true;
            this.ROWNR.VisibleIndex = 0;
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
            // grid
            // 
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1229, 369);
            this.grid.TabIndex = 7;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view,
            this.Detail,
            this.detailView});
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
            this.LOGICALREF,
            this.STATUS,
            this.DATE_,
            this.ORDERREF,
            this.GROUPPED,
            this.SOURCEBRANCH,
            this.DIVNAME1,
            this.SOURCEINDEX,
            this.WHOUSENAME1,
            this.DESTBRANCH,
            this.DIVNAME2,
            this.DESTINDEX,
            this.WHOUSENAME2,
            this.ORDERTYPE});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.view.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.view_RowStyle);
            // 
            // LOGICALREF
            // 
            this.LOGICALREF.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LOGICALREF.AppearanceHeader.Options.UseFont = true;
            this.LOGICALREF.Caption = "Sənəd №";
            this.LOGICALREF.FieldName = "LOGICALREF";
            this.LOGICALREF.Name = "LOGICALREF";
            this.LOGICALREF.OptionsColumn.AllowEdit = false;
            this.LOGICALREF.OptionsColumn.AllowFocus = false;
            this.LOGICALREF.OptionsColumn.ReadOnly = true;
            this.LOGICALREF.Visible = true;
            this.LOGICALREF.VisibleIndex = 0;
            this.LOGICALREF.Width = 67;
            // 
            // STATUS
            // 
            this.STATUS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.STATUS.AppearanceHeader.Options.UseFont = true;
            this.STATUS.Caption = "STATUS";
            this.STATUS.FieldName = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.AllowEdit = false;
            this.STATUS.OptionsColumn.AllowFocus = false;
            this.STATUS.OptionsColumn.ReadOnly = true;
            this.STATUS.Width = 119;
            // 
            // DATE_
            // 
            this.DATE_.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DATE_.AppearanceHeader.Options.UseFont = true;
            this.DATE_.Caption = "Tarix";
            this.DATE_.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm";
            this.DATE_.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DATE_.FieldName = "DATE_";
            this.DATE_.Name = "DATE_";
            this.DATE_.OptionsColumn.AllowEdit = false;
            this.DATE_.OptionsColumn.AllowFocus = false;
            this.DATE_.OptionsColumn.ReadOnly = true;
            this.DATE_.Visible = true;
            this.DATE_.VisibleIndex = 3;
            this.DATE_.Width = 107;
            // 
            // ORDERREF
            // 
            this.ORDERREF.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ORDERREF.AppearanceHeader.Options.UseFont = true;
            this.ORDERREF.Caption = "Qrup №";
            this.ORDERREF.FieldName = "ORDERREF";
            this.ORDERREF.Name = "ORDERREF";
            this.ORDERREF.OptionsColumn.AllowEdit = false;
            this.ORDERREF.OptionsColumn.AllowFocus = false;
            this.ORDERREF.OptionsColumn.ReadOnly = true;
            this.ORDERREF.Visible = true;
            this.ORDERREF.VisibleIndex = 2;
            this.ORDERREF.Width = 59;
            // 
            // GROUPPED
            // 
            this.GROUPPED.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.GROUPPED.AppearanceHeader.Options.UseFont = true;
            this.GROUPPED.Caption = "İnteqrasiya";
            this.GROUPPED.FieldName = "GROUPPED";
            this.GROUPPED.Name = "GROUPPED";
            this.GROUPPED.OptionsColumn.AllowEdit = false;
            this.GROUPPED.OptionsColumn.AllowFocus = false;
            this.GROUPPED.OptionsColumn.ReadOnly = true;
            this.GROUPPED.Visible = true;
            this.GROUPPED.VisibleIndex = 1;
            this.GROUPPED.Width = 79;
            // 
            // SOURCEBRANCH
            // 
            this.SOURCEBRANCH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SOURCEBRANCH.AppearanceHeader.Options.UseFont = true;
            this.SOURCEBRANCH.Caption = "(Ç)Filial №";
            this.SOURCEBRANCH.FieldName = "SOURCEBRANCH";
            this.SOURCEBRANCH.Name = "SOURCEBRANCH";
            this.SOURCEBRANCH.OptionsColumn.AllowEdit = false;
            this.SOURCEBRANCH.OptionsColumn.AllowFocus = false;
            this.SOURCEBRANCH.OptionsColumn.ReadOnly = true;
            this.SOURCEBRANCH.Visible = true;
            this.SOURCEBRANCH.VisibleIndex = 8;
            this.SOURCEBRANCH.Width = 72;
            // 
            // DIVNAME1
            // 
            this.DIVNAME1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DIVNAME1.AppearanceHeader.Options.UseFont = true;
            this.DIVNAME1.Caption = "(Ç)Filial";
            this.DIVNAME1.FieldName = "DIVNAME1";
            this.DIVNAME1.Name = "DIVNAME1";
            this.DIVNAME1.OptionsColumn.AllowEdit = false;
            this.DIVNAME1.OptionsColumn.AllowFocus = false;
            this.DIVNAME1.OptionsColumn.ReadOnly = true;
            this.DIVNAME1.Visible = true;
            this.DIVNAME1.VisibleIndex = 9;
            this.DIVNAME1.Width = 103;
            // 
            // SOURCEINDEX
            // 
            this.SOURCEINDEX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SOURCEINDEX.AppearanceHeader.Options.UseFont = true;
            this.SOURCEINDEX.Caption = "(Ç)Anbar №";
            this.SOURCEINDEX.FieldName = "SOURCEINDEX";
            this.SOURCEINDEX.Name = "SOURCEINDEX";
            this.SOURCEINDEX.OptionsColumn.AllowEdit = false;
            this.SOURCEINDEX.OptionsColumn.AllowFocus = false;
            this.SOURCEINDEX.OptionsColumn.ReadOnly = true;
            this.SOURCEINDEX.Visible = true;
            this.SOURCEINDEX.VisibleIndex = 10;
            this.SOURCEINDEX.Width = 84;
            // 
            // WHOUSENAME1
            // 
            this.WHOUSENAME1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.WHOUSENAME1.AppearanceHeader.Options.UseFont = true;
            this.WHOUSENAME1.Caption = "(Ç)Anbar";
            this.WHOUSENAME1.FieldName = "WHOUSENAME1";
            this.WHOUSENAME1.Name = "WHOUSENAME1";
            this.WHOUSENAME1.OptionsColumn.AllowEdit = false;
            this.WHOUSENAME1.OptionsColumn.AllowFocus = false;
            this.WHOUSENAME1.OptionsColumn.ReadOnly = true;
            this.WHOUSENAME1.Visible = true;
            this.WHOUSENAME1.VisibleIndex = 11;
            this.WHOUSENAME1.Width = 139;
            // 
            // DESTBRANCH
            // 
            this.DESTBRANCH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DESTBRANCH.AppearanceHeader.Options.UseFont = true;
            this.DESTBRANCH.Caption = "(G)Filial №";
            this.DESTBRANCH.FieldName = "DESTBRANCH";
            this.DESTBRANCH.Name = "DESTBRANCH";
            this.DESTBRANCH.OptionsColumn.AllowEdit = false;
            this.DESTBRANCH.OptionsColumn.AllowFocus = false;
            this.DESTBRANCH.OptionsColumn.ReadOnly = true;
            this.DESTBRANCH.Visible = true;
            this.DESTBRANCH.VisibleIndex = 4;
            this.DESTBRANCH.Width = 72;
            // 
            // DIVNAME2
            // 
            this.DIVNAME2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DIVNAME2.AppearanceHeader.Options.UseFont = true;
            this.DIVNAME2.Caption = "(G)Filial";
            this.DIVNAME2.FieldName = "DIVNAME2";
            this.DIVNAME2.Name = "DIVNAME2";
            this.DIVNAME2.OptionsColumn.AllowEdit = false;
            this.DIVNAME2.OptionsColumn.AllowFocus = false;
            this.DIVNAME2.OptionsColumn.ReadOnly = true;
            this.DIVNAME2.Visible = true;
            this.DIVNAME2.VisibleIndex = 5;
            this.DIVNAME2.Width = 137;
            // 
            // DESTINDEX
            // 
            this.DESTINDEX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DESTINDEX.AppearanceHeader.Options.UseFont = true;
            this.DESTINDEX.Caption = "(G)Anbar №";
            this.DESTINDEX.FieldName = "DESTINDEX";
            this.DESTINDEX.Name = "DESTINDEX";
            this.DESTINDEX.OptionsColumn.AllowEdit = false;
            this.DESTINDEX.OptionsColumn.AllowFocus = false;
            this.DESTINDEX.OptionsColumn.ReadOnly = true;
            this.DESTINDEX.Visible = true;
            this.DESTINDEX.VisibleIndex = 6;
            this.DESTINDEX.Width = 86;
            // 
            // WHOUSENAME2
            // 
            this.WHOUSENAME2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.WHOUSENAME2.AppearanceHeader.Options.UseFont = true;
            this.WHOUSENAME2.Caption = "(G)Anbar";
            this.WHOUSENAME2.FieldName = "WHOUSENAME2";
            this.WHOUSENAME2.Name = "WHOUSENAME2";
            this.WHOUSENAME2.OptionsColumn.AllowEdit = false;
            this.WHOUSENAME2.OptionsColumn.AllowFocus = false;
            this.WHOUSENAME2.OptionsColumn.ReadOnly = true;
            this.WHOUSENAME2.Visible = true;
            this.WHOUSENAME2.VisibleIndex = 7;
            this.WHOUSENAME2.Width = 138;
            // 
            // ORDERTYPE
            // 
            this.ORDERTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ORDERTYPE.AppearanceHeader.Options.UseFont = true;
            this.ORDERTYPE.Caption = "Növ";
            this.ORDERTYPE.FieldName = "ORDERTYPE";
            this.ORDERTYPE.Name = "ORDERTYPE";
            this.ORDERTYPE.OptionsColumn.AllowEdit = false;
            this.ORDERTYPE.OptionsColumn.AllowFocus = false;
            this.ORDERTYPE.OptionsColumn.ReadOnly = true;
            this.ORDERTYPE.Visible = true;
            this.ORDERTYPE.VisibleIndex = 12;
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
            // CentralWhouseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 514);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CentralWhouseOrders";
            this.Text = "Mərkəz Anbar Sifarişləri";
            this.Load += new System.EventHandler(this.WhouseOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branchCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whouseCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhouseChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SourceBranchCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceBranchChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceIndexCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourcheIndexChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedComboBoxEdit branchCmbx;
        private DevExpress.XtraEditors.CheckEdit branchChbx;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
        private DevExpress.XtraEditors.CheckedComboBoxEdit whouseCmbx;
        private DevExpress.XtraEditors.DateEdit EndDate;
        private DevExpress.XtraEditors.DateEdit BegDate;
        private DevExpress.XtraEditors.CheckEdit WhouseChbx;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit dateChbx;
        private DevExpress.XtraEditors.SimpleButton NewBtn;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ROWNR;
        private DevExpress.XtraGrid.Views.Grid.GridView detailView;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn LOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn ORDERREF;
        private DevExpress.XtraGrid.Columns.GridColumn DATE_;
        private DevExpress.XtraGrid.Columns.GridColumn GROUPPED;
        private DevExpress.XtraGrid.Columns.GridColumn SOURCEBRANCH;
        private DevExpress.XtraGrid.Columns.GridColumn DIVNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn WHOUSENAME1;
        private DevExpress.XtraGrid.Columns.GridColumn SOURCEINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn DESTBRANCH;
        private DevExpress.XtraGrid.Views.Grid.GridView Detail;
        private DevExpress.XtraGrid.Columns.GridColumn ROWID;
        private DevExpress.XtraGrid.Columns.GridColumn ITEMCODE;
        private DevExpress.XtraEditors.CheckedComboBoxEdit SourceBranchCmbx;
        private DevExpress.XtraEditors.CheckEdit SourceBranchChbx;
        private DevExpress.XtraEditors.CheckedComboBoxEdit SourceIndexCmbx;
        private DevExpress.XtraEditors.CheckEdit SourcheIndexChbx;
        private DevExpress.XtraGrid.Columns.GridColumn DIVNAME2;
        private DevExpress.XtraGrid.Columns.GridColumn DESTINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn WHOUSENAME2;
        private DevExpress.XtraEditors.SimpleButton ModifyBtn;
        private DevExpress.XtraEditors.SimpleButton DeleteBtn;
        private DevExpress.XtraGrid.Columns.GridColumn ORDERTYPE;
    }
}