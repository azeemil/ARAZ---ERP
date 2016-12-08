using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP.Administrator
{
    partial class Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GROUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACTIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISADMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOBJECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditGroupBtn = new DevExpress.XtraEditors.SimpleButton();
            this.newGroupBtn = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenu = new DevExpress.XtraBars.PopupMenu();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.SelectBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Location = new System.Drawing.Point(2, 3);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1079, 488);
            this.grid.TabIndex = 1;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.GROUPNAME,
            this.ACTIV,
            this.ISADMIN,
            this.LOBJECT});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "Id";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 47;
            // 
            // GROUPNAME
            // 
            this.GROUPNAME.Caption = "Qrup";
            this.GROUPNAME.FieldName = "GROUPNAME";
            this.GROUPNAME.Name = "GROUPNAME";
            this.GROUPNAME.OptionsColumn.AllowEdit = false;
            this.GROUPNAME.OptionsColumn.AllowFocus = false;
            this.GROUPNAME.OptionsColumn.ReadOnly = true;
            this.GROUPNAME.Visible = true;
            this.GROUPNAME.VisibleIndex = 1;
            this.GROUPNAME.Width = 103;
            // 
            // ACTIV
            // 
            this.ACTIV.Caption = "Status";
            this.ACTIV.FieldName = "ACTIV";
            this.ACTIV.Name = "ACTIV";
            this.ACTIV.OptionsColumn.AllowEdit = false;
            this.ACTIV.OptionsColumn.AllowFocus = false;
            this.ACTIV.OptionsColumn.ReadOnly = true;
            this.ACTIV.Visible = true;
            this.ACTIV.VisibleIndex = 4;
            this.ACTIV.Width = 90;
            // 
            // ISADMIN
            // 
            this.ISADMIN.Caption = "Admin";
            this.ISADMIN.FieldName = "ISADMIN";
            this.ISADMIN.Name = "ISADMIN";
            this.ISADMIN.OptionsColumn.AllowEdit = false;
            this.ISADMIN.OptionsColumn.AllowFocus = false;
            this.ISADMIN.OptionsColumn.ReadOnly = true;
            this.ISADMIN.Visible = true;
            this.ISADMIN.VisibleIndex = 3;
            this.ISADMIN.Width = 71;
            // 
            // LOBJECT
            // 
            this.LOBJECT.Caption = "Api Istifadəsi";
            this.LOBJECT.FieldName = "LOBJECT";
            this.LOBJECT.Name = "LOBJECT";
            this.LOBJECT.OptionsColumn.AllowEdit = false;
            this.LOBJECT.OptionsColumn.AllowFocus = false;
            this.LOBJECT.OptionsColumn.ReadOnly = true;
            this.LOBJECT.Visible = true;
            this.LOBJECT.VisibleIndex = 2;
            this.LOBJECT.Width = 92;
            // 
            // EditGroupBtn
            // 
            this.EditGroupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditGroupBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditGroupBtn.Appearance.Options.UseFont = true;
            this.EditGroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditGroupBtn.Image")));
            this.EditGroupBtn.Location = new System.Drawing.Point(177, 497);
            this.EditGroupBtn.Name = "EditGroupBtn";
            this.barManager.SetPopupContextMenu(this.EditGroupBtn, this.contextMenu);
            this.EditGroupBtn.Size = new System.Drawing.Size(155, 45);
            this.EditGroupBtn.TabIndex = 4;
            this.EditGroupBtn.Text = "Dəyiş";
            this.EditGroupBtn.Click += new System.EventHandler(this.EditGroupBtn_Click);
            // 
            // newGroupBtn
            // 
            this.newGroupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newGroupBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGroupBtn.Appearance.Options.UseFont = true;
            this.newGroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("newGroupBtn.Image")));
            this.newGroupBtn.Location = new System.Drawing.Point(16, 497);
            this.newGroupBtn.Name = "newGroupBtn";
            this.newGroupBtn.Size = new System.Drawing.Size(150, 45);
            this.newGroupBtn.TabIndex = 3;
            this.newGroupBtn.Text = "Yeni Qrup";
            this.newGroupBtn.Click += new System.EventHandler(this.newGroupBtn_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5, true)});
            this.contextMenu.Manager = this.barManager;
            this.contextMenu.Name = "contextMenu";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Əsas Məlumatlar";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Səlahiyyətlər";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Yeni";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.barToggleSwitchItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager.MaxItemId = 7;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1084, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 553);
            this.barDockControlBottom.Size = new System.Drawing.Size(1084, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1084, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 0;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 1;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // SelectBtn
            // 
            this.SelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn.Appearance.Options.UseFont = true;
            this.SelectBtn.Image = ((System.Drawing.Image)(resources.GetObject("SelectBtn.Image")));
            this.SelectBtn.Location = new System.Drawing.Point(900, 497);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(150, 45);
            this.SelectBtn.TabIndex = 9;
            this.SelectBtn.Text = "Seç";
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 553);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.EditGroupBtn);
            this.Controls.Add(this.newGroupBtn);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Groups";
            this.Text = "Qruplar";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridColumn ID;
        private GridColumn GROUPNAME;
        private GridColumn ACTIV;
        private GridColumn ISADMIN;
        private GridColumn LOBJECT;
        private SimpleButton EditGroupBtn;
        private SimpleButton newGroupBtn;
        private PopupMenu contextMenu;
        private BarEditItem barEditItem1;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarToggleSwitchItem barToggleSwitchItem1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarManager barManager;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private SimpleButton SelectBtn;
        public GridControl grid;
        public GridView gridView1;
    }
}