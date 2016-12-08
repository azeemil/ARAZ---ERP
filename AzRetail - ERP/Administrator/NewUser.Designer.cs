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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountController = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.UserName.VisibleIndex = 1;
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
            this.FirstName.VisibleIndex = 2;
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
            this.LastName.VisibleIndex = 3;
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
            this.Email.VisibleIndex = 4;
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
            this.DisplayName.VisibleIndex = 0;
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
            this.AccountController.VisibleIndex = 5;
            this.AccountController.Width = 96;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 525);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni istifadəçi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

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
    }
}