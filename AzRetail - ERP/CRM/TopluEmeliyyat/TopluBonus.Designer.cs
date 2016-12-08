namespace ERP.CRM.TopluEmeliyyat
{
    partial class TopluBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopluBonus));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.Closebtn = new DevExpress.XtraEditors.SimpleButton();
            this.Savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Kart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bonus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.Copybtn = new DevExpress.XtraBars.BarButtonItem();
            this.Clearbtn = new DevExpress.XtraBars.BarButtonItem();
            this.Cleanbtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP.General.Wait), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.memoEdit1);
            this.groupControl1.Controls.Add(this.Closebtn);
            this.groupControl1.Controls.Add(this.Savebtn);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 235);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(738, 109);
            this.groupControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(11, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Açıqlama:";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.memoEdit1.Location = new System.Drawing.Point(75, 15);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(356, 82);
            this.memoEdit1.TabIndex = 2;
            // 
            // Closebtn
            // 
            this.Closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Closebtn.Appearance.Options.UseFont = true;
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Closebtn.Location = new System.Drawing.Point(620, 75);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(100, 25);
            this.Closebtn.TabIndex = 1;
            this.Closebtn.Text = "Bağla";
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Savebtn.Appearance.Options.UseFont = true;
            this.Savebtn.Image = ((System.Drawing.Image)(resources.GetObject("Savebtn.Image")));
            this.Savebtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Savebtn.Location = new System.Drawing.Point(495, 75);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(100, 25);
            this.Savebtn.TabIndex = 0;
            this.Savebtn.Text = "Yadda saxla";
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(738, 235);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kart,
            this.Bonus,
            this.Result});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Kart
            // 
            this.Kart.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Kart.AppearanceHeader.Options.UseFont = true;
            this.Kart.Caption = "Kart no.";
            this.Kart.FieldName = "KartNo";
            this.Kart.Name = "Kart";
            this.Kart.Visible = true;
            this.Kart.VisibleIndex = 1;
            // 
            // Bonus
            // 
            this.Bonus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Bonus.AppearanceHeader.Options.UseFont = true;
            this.Bonus.Caption = "Bonus";
            this.Bonus.FieldName = "Bonus";
            this.Bonus.Name = "Bonus";
            this.Bonus.Visible = true;
            this.Bonus.VisibleIndex = 2;
            // 
            // Result
            // 
            this.Result.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Result.AppearanceHeader.Options.UseFont = true;
            this.Result.Caption = "Nəticə";
            this.Result.FieldName = "Result";
            this.Result.Name = "Result";
            this.Result.OptionsColumn.AllowEdit = false;
            this.Result.OptionsColumn.AllowFocus = false;
            this.Result.OptionsColumn.ReadOnly = true;
            this.Result.Visible = true;
            this.Result.VisibleIndex = 3;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Copybtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.Clearbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.Cleanbtn)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // Copybtn
            // 
            this.Copybtn.Caption = "Kopyala";
            this.Copybtn.Id = 0;
            this.Copybtn.Name = "Copybtn";
            this.Copybtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Copybtn_ItemClick);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Caption = "Təmizlə";
            this.Clearbtn.Id = 1;
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Clearbtn_ItemClick);
            // 
            // Cleanbtn
            // 
            this.Cleanbtn.Caption = "Seçilmişləri sil";
            this.Cleanbtn.Id = 2;
            this.Cleanbtn.Name = "Cleanbtn";
            this.Cleanbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Cleanbtn_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Copybtn,
            this.Clearbtn,
            this.Cleanbtn});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(738, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 344);
            this.barDockControlBottom.Size = new System.Drawing.Size(738, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 344);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(738, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 344);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // TopluBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 344);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TopluBonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopluBonus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Closebtn;
        private DevExpress.XtraEditors.SimpleButton Savebtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Kart;
        private DevExpress.XtraGrid.Columns.GridColumn Bonus;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Result;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem Copybtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.BarButtonItem Clearbtn;
        private DevExpress.XtraBars.BarButtonItem Cleanbtn;
    }
}