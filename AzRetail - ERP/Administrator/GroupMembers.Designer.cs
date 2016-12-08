using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP.Administrator
{
    partial class GroupMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupMembers));
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GROUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACTIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISADMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOBJECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1107, 460);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(25, 476);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 35);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Yeni";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(133, 476);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(82, 35);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // GroupMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 525);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GroupMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupMembers";
            this.Load += new System.EventHandler(this.GroupMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl grid;
        private GridView gridView1;
        private GridColumn ID;
        private GridColumn GROUPNAME;
        private GridColumn ACTIV;
        private GridColumn ISADMIN;
        private GridColumn LOBJECT;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
    }
}