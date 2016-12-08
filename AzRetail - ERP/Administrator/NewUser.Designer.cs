using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP.Administrator
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountController = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1253, 525);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
           
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserName,
            this.FirstName,
            this.LastName,
            this.Email,
            this.DisplayName,
            this.AccountController});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // UserName
            // 
            this.UserName.Caption = "Istifadəçi";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.OptionsColumn.AllowEdit = false;
            this.UserName.OptionsColumn.AllowFocus = false;
            this.UserName.OptionsColumn.ReadOnly = true;
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "Adı";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.OptionsColumn.AllowEdit = false;
            this.FirstName.OptionsColumn.AllowFocus = false;
            this.FirstName.OptionsColumn.ReadOnly = true;
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 3;
            // 
            // LastName
            // 
            this.LastName.Caption = "Soyadı";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.OptionsColumn.AllowEdit = false;
            this.LastName.OptionsColumn.AllowFocus = false;
            this.LastName.OptionsColumn.ReadOnly = true;
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 4;
            // 
            // Email
            // 
            this.Email.Caption = "E-mail";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.OptionsColumn.AllowEdit = false;
            this.Email.OptionsColumn.AllowFocus = false;
            this.Email.OptionsColumn.ReadOnly = true;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 5;
            // 
            // DisplayName
            // 
            this.DisplayName.Caption = "Ekran Adı";
            this.DisplayName.FieldName = "DisplayName";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.OptionsColumn.AllowEdit = false;
            this.DisplayName.OptionsColumn.AllowFocus = false;
            this.DisplayName.OptionsColumn.ReadOnly = true;
            this.DisplayName.Visible = true;
            this.DisplayName.VisibleIndex = 1;
            // 
            // AccountController
            // 
            this.AccountController.Caption = "Aktiv";
            this.AccountController.FieldName = "AccountController";
            this.AccountController.Name = "AccountController";
            this.AccountController.OptionsColumn.AllowEdit = false;
            this.AccountController.OptionsColumn.AllowFocus = false;
            this.AccountController.OptionsColumn.ReadOnly = true;
            this.AccountController.Visible = true;
            this.AccountController.VisibleIndex = 6;
            this.AccountController.Width = 96;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Seç";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
        
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Toplu Əlavə Et";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
          
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1253, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 525);
            this.barDockControlBottom.Size = new System.Drawing.Size(1253, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 525);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1253, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 525);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 525);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni istifadəçi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn UserName;
        private GridColumn FirstName;
        private GridColumn LastName;
        private GridColumn Email;
        private GridColumn DisplayName;
        private GridColumn AccountController;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}