using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP
{
    partial class FirmList
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
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TITLE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(454, 390);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 36);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Bağla";
            // 
            // OK
            // 
            this.OK.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.OK.Appearance.Options.UseFont = true;
            this.OK.Location = new System.Drawing.Point(318, 390);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(130, 36);
            this.OK.TabIndex = 4;
            this.OK.Text = "Seç";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(596, 368);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NR,
            this.FIRM,
            this.TITLE});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // FIRM
            // 
            this.FIRM.Caption = "Firma";
            this.FIRM.FieldName = "NAME";
            this.FIRM.Name = "FIRM";
            this.FIRM.OptionsColumn.AllowEdit = false;
            this.FIRM.OptionsColumn.AllowFocus = false;
            this.FIRM.OptionsColumn.ReadOnly = true;
            this.FIRM.Visible = true;
            this.FIRM.VisibleIndex = 1;
            this.FIRM.Width = 221;
            // 
            // TITLE
            // 
            this.TITLE.Caption = "Başliq";
            this.TITLE.FieldName = "TITLE";
            this.TITLE.Name = "TITLE";
            this.TITLE.OptionsColumn.AllowEdit = false;
            this.TITLE.OptionsColumn.AllowFocus = false;
            this.TITLE.OptionsColumn.ReadOnly = true;
            this.TITLE.Visible = true;
            this.TITLE.VisibleIndex = 2;
            this.TITLE.Width = 253;
            // 
            // ClientCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 438);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.gridControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientCards";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton Cancel;
        private SimpleButton OK;
        public GridControl gridControl1;
        public GridView gridView1;
        private GridColumn NR;
        private GridColumn FIRM;
        private GridColumn TITLE;
    }
}