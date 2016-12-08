namespace ERP.General
{
    partial class Units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Units));
            this.list = new DevExpress.XtraEditors.ListBoxControl();
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.DisplayMember = "CODE";
            this.list.Dock = System.Windows.Forms.DockStyle.Top;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(307, 239);
            this.list.TabIndex = 0;
            this.list.ValueMember = "CODE";
            this.list.DoubleClick += new System.EventHandler(this.list_DoubleClick);
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(155, 245);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 36);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Bağla";
            // 
            // OK
            // 
            this.OK.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.OK.Appearance.Options.UseFont = true;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(19, 245);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(130, 36);
            this.OK.TabIndex = 6;
            this.OK.Text = "Seç";
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 292);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.list);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Units";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Units";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.ListBoxControl list;
        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.SimpleButton OK;
    }
}