namespace ERP.Administrator.ReportDesigns
{
    partial class ReportDesigns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDesigns));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.typeCmbx = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.UserPermissionBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SetDefaultBtn = new DevExpress.XtraBars.BarButtonItem();
            this.CopyBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.NewBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EditBtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEMPLATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESIGNEDFOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP.General.Wait), true, true, true);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.typeCmbx);
            this.groupControl1.Controls.Add(this.CopyBtn);
            this.groupControl1.Controls.Add(this.DeleteBtn);
            this.groupControl1.Controls.Add(this.NewBtn);
            this.groupControl1.Controls.Add(this.EditBtn);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 302);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(809, 87);
            this.groupControl1.TabIndex = 0;
            // 
            // typeCmbx
            // 
            this.typeCmbx.EditValue = "Etiket Çap";
            this.typeCmbx.Location = new System.Drawing.Point(390, 41);
            this.typeCmbx.MenuManager = this.barManager1;
            this.typeCmbx.Name = "typeCmbx";
            this.typeCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.typeCmbx.Properties.Appearance.Options.UseFont = true;
            this.typeCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeCmbx.Properties.Items.AddRange(new object[] {
            "Etiket Çap",
            "Hədiyyə",
            "Satınalma Və Satış",
            "Material Hərəkətləri",
            "Fakturalanmamiş İrsaliyyələr",
            "Material Hərəkətləri Hesabatı",
            "Alış Satış Sifarişi",
            "Anbara Sifariş Tələbi",
            "Anbar Qrupu",
            "Anbar Qrupu Pivot"});
            this.typeCmbx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.typeCmbx.Size = new System.Drawing.Size(316, 22);
            this.typeCmbx.TabIndex = 4;
            this.typeCmbx.SelectedIndexChanged += new System.EventHandler(this.typeCmbx_SelectedIndexChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.UserPermissionBtn,
            this.SetDefaultBtn});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(809, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 389);
            this.barDockControlBottom.Size = new System.Drawing.Size(809, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 389);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(809, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 389);
            // 
            // UserPermissionBtn
            // 
            this.UserPermissionBtn.Caption = "İstifadəçi Hüquqları";
            this.UserPermissionBtn.Id = 0;
            this.UserPermissionBtn.Name = "UserPermissionBtn";
            this.UserPermissionBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserPermissionBtn_ItemClick);
            // 
            // SetDefaultBtn
            // 
            this.SetDefaultBtn.Caption = "Default Sənəd Tipi";
            this.SetDefaultBtn.Id = 1;
            this.SetDefaultBtn.Name = "SetDefaultBtn";
            this.SetDefaultBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SetDefaultBtn_ItemClick);
            // 
            // CopyBtn
            // 
            this.CopyBtn.AllowFocus = false;
            this.CopyBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CopyBtn.Appearance.Options.UseFont = true;
            this.CopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("CopyBtn.Image")));
            this.CopyBtn.Location = new System.Drawing.Point(272, 35);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(94, 40);
            this.CopyBtn.TabIndex = 3;
            this.CopyBtn.Text = "Kopyala";
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AllowFocus = false;
            this.DeleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.Appearance.Options.UseFont = true;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Location = new System.Drawing.Point(183, 35);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(83, 40);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.AllowFocus = false;
            this.NewBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.NewBtn.Appearance.Options.UseFont = true;
            this.NewBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBtn.Image")));
            this.NewBtn.Location = new System.Drawing.Point(5, 35);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(83, 40);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "Yeni";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AllowFocus = false;
            this.EditBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.EditBtn.Appearance.Options.UseFont = true;
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.Location = new System.Drawing.Point(94, 35);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(83, 40);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "Dəyiş";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(809, 302);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TEMPLATE,
            this.NAME,
            this.STATUS,
            this.DESIGNEDFOR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // TEMPLATE
            // 
            this.TEMPLATE.Caption = "Dizayn";
            this.TEMPLATE.FieldName = "TEMPLATE";
            this.TEMPLATE.Name = "TEMPLATE";
            // 
            // NAME
            // 
            this.NAME.Caption = "Dizayn";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 0;
            this.NAME.Width = 411;
            // 
            // STATUS
            // 
            this.STATUS.Caption = "Status";
            this.STATUS.FieldName = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.AllowEdit = false;
            this.STATUS.OptionsColumn.AllowFocus = false;
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 1;
            this.STATUS.Width = 114;
            // 
            // DESIGNEDFOR
            // 
            this.DESIGNEDFOR.Caption = "Default";
            this.DESIGNEDFOR.FieldName = "DESIGNEDFOR";
            this.DESIGNEDFOR.Name = "DESIGNEDFOR";
            this.DESIGNEDFOR.OptionsColumn.AllowEdit = false;
            this.DESIGNEDFOR.OptionsColumn.AllowFocus = false;
            this.DESIGNEDFOR.Visible = true;
            this.DESIGNEDFOR.VisibleIndex = 2;
            this.DESIGNEDFOR.Width = 86;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.UserPermissionBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.SetDefaultBtn)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // ReportDesigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 389);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportDesigns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dizaynlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton NewBtn;
        private DevExpress.XtraEditors.SimpleButton EditBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton DeleteBtn;
        private DevExpress.XtraGrid.Columns.GridColumn TEMPLATE;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraEditors.SimpleButton CopyBtn;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem UserPermissionBtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.ComboBoxEdit typeCmbx;
        private DevExpress.XtraGrid.Columns.GridColumn DESIGNEDFOR;
        private DevExpress.XtraBars.BarButtonItem SetDefaultBtn;
    }
}