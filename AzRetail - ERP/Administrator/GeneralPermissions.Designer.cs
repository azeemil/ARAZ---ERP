using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ERP.Administrator
{
    partial class GeneralPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralPermissions));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.isAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.ApiUse = new DevExpress.XtraEditors.CheckEdit();
            this.userStatus = new DevExpress.XtraEditors.CheckEdit();
            this.cancel = new DevExpress.XtraEditors.SimpleButton();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApiUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.isAdmin);
            this.groupControl1.Controls.Add(this.ApiUse);
            this.groupControl1.Controls.Add(this.userStatus);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(364, 142);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Əsas Məlumatlar";
            // 
            // isAdmin
            // 
            this.isAdmin.Location = new System.Drawing.Point(10, 94);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.isAdmin.Properties.Appearance.Options.UseFont = true;
            this.isAdmin.Properties.Caption = "Administrator";
            this.isAdmin.Size = new System.Drawing.Size(111, 22);
            this.isAdmin.TabIndex = 3;
            // 
            // ApiUse
            // 
            this.ApiUse.Location = new System.Drawing.Point(10, 66);
            this.ApiUse.Name = "ApiUse";
            this.ApiUse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ApiUse.Properties.Appearance.Options.UseFont = true;
            this.ApiUse.Properties.Caption = "Api Istifadəsi";
            this.ApiUse.Size = new System.Drawing.Size(111, 22);
            this.ApiUse.TabIndex = 2;
            // 
            // userStatus
            // 
            this.userStatus.Location = new System.Drawing.Point(10, 38);
            this.userStatus.Name = "userStatus";
            this.userStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.userStatus.Properties.Appearance.Options.UseFont = true;
            this.userStatus.Properties.Caption = "Status";
            this.userStatus.Size = new System.Drawing.Size(75, 22);
            this.userStatus.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(227, 163);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 48);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Ləğv Et";
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Save.Appearance.Options.UseFont = true;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Location = new System.Drawing.Point(81, 163);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(140, 48);
            this.Save.TabIndex = 14;
            this.Save.Text = "Yadda Saxla";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // GeneralPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 223);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "GeneralPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GeneralPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApiUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControl1;
        private CheckEdit isAdmin;
        private CheckEdit ApiUse;
        private CheckEdit userStatus;
        private SimpleButton cancel;
        private SimpleButton Save;
    }
}