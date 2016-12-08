namespace ERP.General
{
    partial class WhouseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhouseList));
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRANCHNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(515, 393);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 36);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Bağla";
            // 
            // OK
            // 
            this.OK.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.OK.Appearance.Options.UseFont = true;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(379, 393);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(130, 36);
            this.OK.TabIndex = 7;
            this.OK.Text = "Seç";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(680, 377);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NR,
            this.NAME,
            this.BRANCH,
            this.BRANCHNAME});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // NR
            // 
            this.NR.Caption = "№";
            this.NR.FieldName = "NR";
            this.NR.Name = "NR";
            this.NR.OptionsColumn.AllowEdit = false;
            this.NR.OptionsColumn.AllowFocus = false;
            this.NR.OptionsColumn.ReadOnly = true;
            this.NR.Visible = true;
            this.NR.VisibleIndex = 0;
            this.NR.Width = 102;
            // 
            // NAME
            // 
            this.NAME.Caption = "Ad";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 1;
            this.NAME.Width = 253;
            // 
            // BRANCH
            // 
            this.BRANCH.Caption = "Iş Yeri №";
            this.BRANCH.FieldName = "BRANCH";
            this.BRANCH.Name = "BRANCH";
            this.BRANCH.OptionsColumn.AllowEdit = false;
            this.BRANCH.OptionsColumn.AllowFocus = false;
            this.BRANCH.Visible = true;
            this.BRANCH.VisibleIndex = 2;
            // 
            // BRANCHNAME
            // 
            this.BRANCHNAME.Caption = "Iş Yeri";
            this.BRANCHNAME.FieldName = "BRANCHNAME";
            this.BRANCHNAME.Name = "BRANCHNAME";
            this.BRANCHNAME.OptionsColumn.AllowEdit = false;
            this.BRANCHNAME.OptionsColumn.AllowFocus = false;
            this.BRANCHNAME.Visible = true;
            this.BRANCHNAME.VisibleIndex = 3;
            // 
            // WhouseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 441);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhouseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.SimpleButton OK;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NR;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn BRANCH;
        private DevExpress.XtraGrid.Columns.GridColumn BRANCHNAME;
    }
}