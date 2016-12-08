namespace ERP.Finance
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.errorstring = new DevExpress.XtraEditors.ListBoxControl();
            this.total = new DevExpress.XtraEditors.ListBoxControl();
            this.clcard = new DevExpress.XtraEditors.ListBoxControl();
            this.type = new DevExpress.XtraEditors.ListBoxControl();
            this.docnoLst = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorstring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docnoLst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.errorstring);
            this.groupControl1.Controls.Add(this.total);
            this.groupControl1.Controls.Add(this.clcard);
            this.groupControl1.Controls.Add(this.type);
            this.groupControl1.Controls.Add(this.docnoLst);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(912, 391);
            this.groupControl1.TabIndex = 6;
            // 
            // errorstring
            // 
            this.errorstring.Dock = System.Windows.Forms.DockStyle.Left;
            this.errorstring.Location = new System.Drawing.Point(489, 21);
            this.errorstring.Name = "errorstring";
            this.errorstring.Size = new System.Drawing.Size(423, 368);
            this.errorstring.TabIndex = 0;
            this.errorstring.SelectedIndexChanged += new System.EventHandler(this.docnoLst_SelectedIndexChanged);
            // 
            // total
            // 
            this.total.Dock = System.Windows.Forms.DockStyle.Left;
            this.total.Location = new System.Drawing.Point(404, 21);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(85, 368);
            this.total.TabIndex = 4;
            this.total.SelectedIndexChanged += new System.EventHandler(this.docnoLst_SelectedIndexChanged);
            // 
            // clcard
            // 
            this.clcard.Dock = System.Windows.Forms.DockStyle.Left;
            this.clcard.Location = new System.Drawing.Point(229, 21);
            this.clcard.Name = "clcard";
            this.clcard.Size = new System.Drawing.Size(175, 368);
            this.clcard.TabIndex = 1;
            this.clcard.SelectedIndexChanged += new System.EventHandler(this.docnoLst_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.Dock = System.Windows.Forms.DockStyle.Left;
            this.type.Location = new System.Drawing.Point(97, 21);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(132, 368);
            this.type.TabIndex = 3;
            this.type.SelectedIndexChanged += new System.EventHandler(this.docnoLst_SelectedIndexChanged);
            // 
            // docnoLst
            // 
            this.docnoLst.Dock = System.Windows.Forms.DockStyle.Left;
            this.docnoLst.Location = new System.Drawing.Point(2, 21);
            this.docnoLst.Name = "docnoLst";
            this.docnoLst.Size = new System.Drawing.Size(95, 368);
            this.docnoLst.TabIndex = 2;
            this.docnoLst.SelectedIndexChanged += new System.EventHandler(this.docnoLst_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(765, 397);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 39);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "OK";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 440);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorstring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docnoLst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.ListBoxControl errorstring;
        public DevExpress.XtraEditors.ListBoxControl total;
        public DevExpress.XtraEditors.ListBoxControl clcard;
        public DevExpress.XtraEditors.ListBoxControl type;
        public DevExpress.XtraEditors.ListBoxControl docnoLst;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}