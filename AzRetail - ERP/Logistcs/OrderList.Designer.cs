namespace ERP.Logistcs
{
    partial class OrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            this.DESTBRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIVNAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESTINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WHOUSENAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ROWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 414);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(824, 61);
            this.groupControl1.TabIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(734, 26);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Bağla";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(653, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Seç";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.grid.Size = new System.Drawing.Size(824, 475);
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
            this.DESTBRANCH,
            this.DIVNAME2,
            this.DESTINDEX,
            this.WHOUSENAME2});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsSelection.MultiSelect = true;
            this.view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            // 
            // LOGICALREF
            // 
            this.LOGICALREF.Caption = "Sənəd №";
            this.LOGICALREF.FieldName = "LOGICALREF";
            this.LOGICALREF.Name = "LOGICALREF";
            this.LOGICALREF.OptionsColumn.AllowEdit = false;
            this.LOGICALREF.OptionsColumn.AllowFocus = false;
            this.LOGICALREF.OptionsColumn.ReadOnly = true;
            this.LOGICALREF.Visible = true;
            this.LOGICALREF.VisibleIndex = 1;
            this.LOGICALREF.Width = 57;
            // 
            // STATUS
            // 
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
            this.DATE_.Caption = "Tarix";
            this.DATE_.FieldName = "DATE_";
            this.DATE_.Name = "DATE_";
            this.DATE_.OptionsColumn.AllowEdit = false;
            this.DATE_.OptionsColumn.AllowFocus = false;
            this.DATE_.OptionsColumn.ReadOnly = true;
            this.DATE_.Visible = true;
            this.DATE_.VisibleIndex = 2;
            this.DATE_.Width = 82;
            // 
            // DESTBRANCH
            // 
            this.DESTBRANCH.Caption = "(G)Filial №";
            this.DESTBRANCH.FieldName = "DESTBRANCH";
            this.DESTBRANCH.Name = "DESTBRANCH";
            this.DESTBRANCH.OptionsColumn.AllowEdit = false;
            this.DESTBRANCH.OptionsColumn.AllowFocus = false;
            this.DESTBRANCH.OptionsColumn.ReadOnly = true;
            this.DESTBRANCH.Visible = true;
            this.DESTBRANCH.VisibleIndex = 3;
            this.DESTBRANCH.Width = 62;
            // 
            // DIVNAME2
            // 
            this.DIVNAME2.Caption = "(G)Filial";
            this.DIVNAME2.FieldName = "DIVNAME2";
            this.DIVNAME2.Name = "DIVNAME2";
            this.DIVNAME2.OptionsColumn.AllowEdit = false;
            this.DIVNAME2.OptionsColumn.AllowFocus = false;
            this.DIVNAME2.OptionsColumn.ReadOnly = true;
            this.DIVNAME2.Visible = true;
            this.DIVNAME2.VisibleIndex = 4;
            this.DIVNAME2.Width = 107;
            // 
            // DESTINDEX
            // 
            this.DESTINDEX.Caption = "(G)Anbar №";
            this.DESTINDEX.FieldName = "DESTINDEX";
            this.DESTINDEX.Name = "DESTINDEX";
            this.DESTINDEX.OptionsColumn.AllowEdit = false;
            this.DESTINDEX.OptionsColumn.AllowFocus = false;
            this.DESTINDEX.OptionsColumn.ReadOnly = true;
            this.DESTINDEX.Visible = true;
            this.DESTINDEX.VisibleIndex = 5;
            this.DESTINDEX.Width = 73;
            // 
            // WHOUSENAME2
            // 
            this.WHOUSENAME2.Caption = "(G)Anbar";
            this.WHOUSENAME2.FieldName = "WHOUSENAME2";
            this.WHOUSENAME2.Name = "WHOUSENAME2";
            this.WHOUSENAME2.OptionsColumn.AllowEdit = false;
            this.WHOUSENAME2.OptionsColumn.AllowFocus = false;
            this.WHOUSENAME2.OptionsColumn.ReadOnly = true;
            this.WHOUSENAME2.Visible = true;
            this.WHOUSENAME2.VisibleIndex = 6;
            this.WHOUSENAME2.Width = 218;
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
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 475);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupControl1);
           
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anbar Sifarişləri";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ROWNR;
        private DevExpress.XtraGrid.Views.Grid.GridView detailView;
        private DevExpress.XtraGrid.Columns.GridColumn LOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn DATE_;
        private DevExpress.XtraGrid.Columns.GridColumn DESTBRANCH;
        private DevExpress.XtraGrid.Views.Grid.GridView Detail;
        private DevExpress.XtraGrid.Columns.GridColumn ROWID;
        private DevExpress.XtraGrid.Columns.GridColumn ITEMCODE;
        private DevExpress.XtraGrid.Columns.GridColumn DIVNAME2;
        private DevExpress.XtraGrid.Columns.GridColumn DESTINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn WHOUSENAME2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraGrid.GridControl grid;
        public DevExpress.XtraGrid.Views.Grid.GridView view;
    }
}