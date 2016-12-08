namespace ERP.Administrator.Properties.ApproveSystem
{
    partial class ApproveSysProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveSysProperties));
            this.typeCmbx = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SendToApprove = new DevExpress.XtraEditors.SimpleButton();
            this.save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.typeCmbx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // typeCmbx
            // 
            this.typeCmbx.EditValue = "Hər birisi";
            this.typeCmbx.Location = new System.Drawing.Point(34, 48);
            this.typeCmbx.Name = "typeCmbx";
            this.typeCmbx.Properties.AllowFocused = false;
            this.typeCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.typeCmbx.Properties.Appearance.Options.UseFont = true;
            this.typeCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeCmbx.Properties.Items.AddRange(new object[] {
            "Hər birisi",
            "İstənilən biri",
            "Növbəli"});
            this.typeCmbx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.typeCmbx.Size = new System.Drawing.Size(303, 22);
            this.typeCmbx.TabIndex = 5;
            // 
            // SendToApprove
            // 
            this.SendToApprove.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SendToApprove.Appearance.Options.UseFont = true;
            this.SendToApprove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SendToApprove.Image = ((System.Drawing.Image)(resources.GetObject("SendToApprove.Image")));
            this.SendToApprove.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.SendToApprove.Location = new System.Drawing.Point(201, 76);
            this.SendToApprove.Name = "SendToApprove";
            this.SendToApprove.Size = new System.Drawing.Size(136, 35);
            this.SendToApprove.TabIndex = 50;
            this.SendToApprove.Text = "Ləğv Et";
            // 
            // save
            // 
            this.save.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.save.Appearance.Options.UseFont = true;
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.save.Location = new System.Drawing.Point(59, 76);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(136, 35);
            this.save.TabIndex = 49;
            this.save.Text = "Yadda Saxla";
            // 
            // ApproveSysProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 148);
            this.Controls.Add(this.SendToApprove);
            this.Controls.Add(this.save);
            this.Controls.Add(this.typeCmbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApproveSysProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApproveSysProperties";
            ((System.ComponentModel.ISupportInitialize)(this.typeCmbx.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton SendToApprove;
        private DevExpress.XtraEditors.SimpleButton save;
        public DevExpress.XtraEditors.ComboBoxEdit typeCmbx;
    }
}