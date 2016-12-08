using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP.Administrator
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISPLAYNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIRSTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LASTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACTIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISADMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOBJECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.newUserBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EditUserBtn = new DevExpress.XtraEditors.SimpleButton();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.AddToGroup = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.contextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.SelectBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1240, 442);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.USERNAME,
            this.DISPLAYNAME,
            this.FIRSTNAME,
            this.LASTNAME,
            this.ACTIV,
            this.ISADMIN,
            this.EMAIL,
            this.LOBJECT});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
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
            // USERNAME
            // 
            this.USERNAME.Caption = "İstifadəçi";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.OptionsColumn.AllowEdit = false;
            this.USERNAME.OptionsColumn.AllowFocus = false;
            this.USERNAME.OptionsColumn.ReadOnly = true;
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 1;
            this.USERNAME.Width = 103;
            // 
            // DISPLAYNAME
            // 
            this.DISPLAYNAME.Caption = "Ekran Adı";
            this.DISPLAYNAME.FieldName = "DISPLAYNAME";
            this.DISPLAYNAME.Name = "DISPLAYNAME";
            this.DISPLAYNAME.OptionsColumn.AllowEdit = false;
            this.DISPLAYNAME.OptionsColumn.AllowFocus = false;
            this.DISPLAYNAME.OptionsColumn.ReadOnly = true;
            this.DISPLAYNAME.Visible = true;
            this.DISPLAYNAME.VisibleIndex = 2;
            this.DISPLAYNAME.Width = 146;
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.Caption = "Adı";
            this.FIRSTNAME.FieldName = "FIRSTNAME";
            this.FIRSTNAME.Name = "FIRSTNAME";
            this.FIRSTNAME.OptionsColumn.AllowEdit = false;
            this.FIRSTNAME.OptionsColumn.AllowFocus = false;
            this.FIRSTNAME.OptionsColumn.ReadOnly = true;
            this.FIRSTNAME.Visible = true;
            this.FIRSTNAME.VisibleIndex = 3;
            this.FIRSTNAME.Width = 153;
            // 
            // LASTNAME
            // 
            this.LASTNAME.Caption = "Soyadı";
            this.LASTNAME.FieldName = "LASTNAME";
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.OptionsColumn.AllowEdit = false;
            this.LASTNAME.OptionsColumn.AllowFocus = false;
            this.LASTNAME.OptionsColumn.ReadOnly = true;
            this.LASTNAME.Visible = true;
            this.LASTNAME.VisibleIndex = 4;
            this.LASTNAME.Width = 169;
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
            this.ACTIV.VisibleIndex = 8;
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
            this.ISADMIN.VisibleIndex = 7;
            this.ISADMIN.Width = 71;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "E-Mail";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.OptionsColumn.AllowEdit = false;
            this.EMAIL.OptionsColumn.AllowFocus = false;
            this.EMAIL.OptionsColumn.ReadOnly = true;
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 5;
            this.EMAIL.Width = 349;
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
            this.LOBJECT.VisibleIndex = 6;
            this.LOBJECT.Width = 92;
            // 
            // newUserBtn
            // 
            this.newUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newUserBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserBtn.Appearance.Options.UseFont = true;
            this.newUserBtn.Image = ((System.Drawing.Image)(resources.GetObject("newUserBtn.Image")));
            this.newUserBtn.Location = new System.Drawing.Point(12, 461);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(170, 45);
            this.newUserBtn.TabIndex = 1;
            this.newUserBtn.Text = "Yeni istifadəçi";
            this.newUserBtn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditUserBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserBtn.Appearance.Options.UseFont = true;
            this.EditUserBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditUserBtn.Image")));
            this.EditUserBtn.Location = new System.Drawing.Point(198, 461);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(170, 45);
            this.EditUserBtn.TabIndex = 2;
            this.EditUserBtn.Text = "Dəyiş";
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem3,
            this.barButtonItem4,
            this.AddToGroup,
            this.barButtonItem5});
            this.barManager.MaxItemId = 11;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1240, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 523);
            this.barDockControlBottom.Size = new System.Drawing.Size(1240, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 523);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1240, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 523);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Əsas Məlumatlar";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Səlahiyyətlər";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // AddToGroup
            // 
            this.AddToGroup.Caption = "Qruplar";
            this.AddToGroup.Id = 10;
            this.AddToGroup.Name = "AddToGroup";
            this.AddToGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddToGroup_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Yeni";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // contextMenu
            // 
            this.contextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.AddToGroup),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5, true)});
            this.contextMenu.Manager = this.barManager;
            this.contextMenu.Name = "contextMenu";
            // 
            // SelectBtn
            // 
            this.SelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn.Appearance.Options.UseFont = true;
            this.SelectBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SelectBtn.Image = ((System.Drawing.Image)(resources.GetObject("SelectBtn.Image")));
            this.SelectBtn.Location = new System.Drawing.Point(1058, 461);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(170, 45);
            this.SelectBtn.TabIndex = 7;
            this.SelectBtn.Text = "Seç";
            this.SelectBtn.Visible = false;
            // 
            // Users
            // 
            this.AccessibleName = "1.1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 523);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.EditUserBtn);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "1.1";
            this.Text = "İstifadəçilər";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GridColumn ID;
        private GridColumn USERNAME;
        private GridColumn ACTIV;
        private GridColumn ISADMIN;
        private GridColumn DISPLAYNAME;
        private GridColumn FIRSTNAME;
        private GridColumn LASTNAME;
        private GridColumn EMAIL;
        private GridColumn LOBJECT;
        private BarManager barManager;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private PopupMenu contextMenu;
        private BarButtonItem AddToGroup;
        public GridControl grid;
        public GridView gridView1;
        public SimpleButton newUserBtn;
        public SimpleButton EditUserBtn;
        public SimpleButton SelectBtn;
    }
}