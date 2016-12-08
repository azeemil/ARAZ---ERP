namespace ERP.CRM
{
    partial class CrmPositionNewEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrmPositionNewEdit));
            this.CancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.NameTxt = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.Appearance.Options.UseFont = true;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelBtn.Image")));
            this.CancelBtn.Location = new System.Drawing.Point(195, 73);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(92, 22);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Ləğv et";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Appearance.Options.UseFont = true;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(67, 72);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Yadda saxla";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(40, 33);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(247, 20);
            this.NameTxt.TabIndex = 4;
            // 
            // CrmPositionNewEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 118);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrmPositionNewEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.NameTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton CancelBtn;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        public DevExpress.XtraEditors.TextEdit NameTxt;
    }
}