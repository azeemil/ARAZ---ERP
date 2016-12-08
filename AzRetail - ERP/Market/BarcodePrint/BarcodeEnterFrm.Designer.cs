namespace ERP.Market.BarcodePrint
{
    partial class BarcodeEnterFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERP.Market.BarcodePrint.BarcodeEnterFrm));
            this.BarcodeTxt = new DevExpress.XtraEditors.TextEdit();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CountTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BranchNoTxt = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchNoTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Location = new System.Drawing.Point(65, 17);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BarcodeTxt.Properties.Appearance.Options.UseFont = true;
            this.BarcodeTxt.Size = new System.Drawing.Size(188, 22);
            this.BarcodeTxt.TabIndex = 0;
            this.BarcodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeTxt_KeyDown);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Location = new System.Drawing.Point(271, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(86, 23);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CountTxt
            // 
            this.CountTxt.EditValue = "1";
            this.CountTxt.Location = new System.Drawing.Point(322, 58);
            this.CountTxt.Name = "CountTxt";
            this.CountTxt.Properties.Mask.EditMask = "f0";
            this.CountTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CountTxt.Properties.MaxLength = 2;
            this.CountTxt.Size = new System.Drawing.Size(35, 20);
            this.CountTxt.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(271, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Miqdar";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(16, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Barkod";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(16, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Filial";
            // 
            // BranchNoTxt
            // 
            this.BranchNoTxt.EditValue = "";
            this.BranchNoTxt.Enabled = false;
            this.BranchNoTxt.Location = new System.Drawing.Point(65, 59);
            this.BranchNoTxt.Name = "BranchNoTxt";
            this.BranchNoTxt.Properties.Mask.EditMask = "f0";
            this.BranchNoTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BranchNoTxt.Properties.MaxLength = 15;
            this.BranchNoTxt.Size = new System.Drawing.Size(35, 20);
            this.BranchNoTxt.TabIndex = 5;
            // 
            // BarcodeEnterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 89);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.BranchNoTxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.CountTxt);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BarcodeTxt);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeEnterFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkod";
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchNoTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit BarcodeTxt;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
        private DevExpress.XtraEditors.TextEdit CountTxt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit BranchNoTxt;
    }
}