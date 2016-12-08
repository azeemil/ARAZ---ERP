using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;

namespace ERP.Administrator
{
    partial class Modul
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modul));
            this.ModulsTree = new DevExpress.XtraTreeList.TreeList();
            this.ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.LEVEL = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.DESCRIPTION = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IMAGEINDEX = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.PARENTID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.səviyyə1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.səviyyə2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.səviyyə3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.səviyyə4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.səviyyə5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dəyişToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ModulNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.SaveModulBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CancelModulBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LevelLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.activty = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulsTree)).BeginInit();
            this.ContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModulNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ModulsTree
            // 
            this.ModulsTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ID,
            this.LEVEL,
            this.DESCRIPTION,
            this.IMAGEINDEX,
            this.PARENTID});
            this.ModulsTree.ContextMenuStrip = this.ContextMenu;
            this.ModulsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModulsTree.FooterPanelHeight = 0;
            this.ModulsTree.Location = new System.Drawing.Point(2, 21);
            this.ModulsTree.Name = "ModulsTree";
            this.ModulsTree.OptionsBehavior.Editable = false;
            this.ModulsTree.OptionsView.ShowColumns = false;
            this.ModulsTree.Size = new System.Drawing.Size(574, 456);
            this.ModulsTree.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Width = 53;
            // 
            // LEVEL
            // 
            this.LEVEL.Caption = "Level";
            this.LEVEL.FieldName = "LEVEL";
            this.LEVEL.Name = "LEVEL";
            this.LEVEL.Width = 49;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Caption = "Description";
            this.DESCRIPTION.FieldName = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Visible = true;
            this.DESCRIPTION.VisibleIndex = 0;
            this.DESCRIPTION.Width = 229;
            // 
            // IMAGEINDEX
            // 
            this.IMAGEINDEX.Caption = "IMAGEINDEX";
            this.IMAGEINDEX.FieldName = "IMAGEINDEX";
            this.IMAGEINDEX.Name = "IMAGEINDEX";
            // 
            // PARENTID
            // 
            this.PARENTID.Caption = "PARENTID";
            this.PARENTID.FieldName = "PARENTID";
            this.PARENTID.Name = "PARENTID";
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItem,
            this.dəyişToolStripMenuItem1});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // NewItem
            // 
            this.NewItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.səviyyə1ToolStripMenuItem,
            this.səviyyə2ToolStripMenuItem,
            this.səviyyə3ToolStripMenuItem,
            this.səviyyə4ToolStripMenuItem,
            this.səviyyə5ToolStripMenuItem});
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(117, 22);
            this.NewItem.Text = "Əlavə Et";
            // 
            // səviyyə1ToolStripMenuItem
            // 
            this.səviyyə1ToolStripMenuItem.Name = "səviyyə1ToolStripMenuItem";
            this.səviyyə1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.səviyyə1ToolStripMenuItem.Text = "Səviyyə 1";
            //this.səviyyə1ToolStripMenuItem.Click += new System.EventHandler(this.səviyyə1ToolStripMenuItem_Click);
            // 
            // səviyyə2ToolStripMenuItem
            // 
            this.səviyyə2ToolStripMenuItem.Name = "səviyyə2ToolStripMenuItem";
            this.səviyyə2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.səviyyə2ToolStripMenuItem.Text = "Səviyyə 2";
          //  this.səviyyə2ToolStripMenuItem.Click += new System.EventHandler(this.səviyyə2ToolStripMenuItem_Click);
            // 
            // səviyyə3ToolStripMenuItem
            // 
            this.səviyyə3ToolStripMenuItem.Name = "səviyyə3ToolStripMenuItem";
            this.səviyyə3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.səviyyə3ToolStripMenuItem.Text = "Səviyyə 3";
          //  this.səviyyə3ToolStripMenuItem.Click += new System.EventHandler(this.səviyyə3ToolStripMenuItem_Click);
            // 
            // səviyyə4ToolStripMenuItem
            // 
            this.səviyyə4ToolStripMenuItem.Name = "səviyyə4ToolStripMenuItem";
            this.səviyyə4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.səviyyə4ToolStripMenuItem.Text = "Səviyyə 4";
            //this.səviyyə4ToolStripMenuItem.Click += new System.EventHandler(this.səviyyə4ToolStripMenuItem_Click);
            // 
            // səviyyə5ToolStripMenuItem
            // 
            this.səviyyə5ToolStripMenuItem.Name = "səviyyə5ToolStripMenuItem";
            this.səviyyə5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.səviyyə5ToolStripMenuItem.Text = "Səviyyə 5";
            this.səviyyə5ToolStripMenuItem.Click += new System.EventHandler(this.səviyyə5ToolStripMenuItem_Click);
            // 
            // dəyişToolStripMenuItem1
            // 
            this.dəyişToolStripMenuItem1.Name = "dəyişToolStripMenuItem1";
            this.dəyişToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.dəyişToolStripMenuItem1.Text = "Dəyiş";
            this.dəyişToolStripMenuItem1.Click += new System.EventHandler(this.dəyişToolStripMenuItem1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ModulsTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(578, 479);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menu Dizayner";
            // 
            // ModulNameTxt
            // 
            this.ModulNameTxt.Enabled = false;
            this.ModulNameTxt.Location = new System.Drawing.Point(119, 44);
            this.ModulNameTxt.Name = "ModulNameTxt";
            this.ModulNameTxt.Size = new System.Drawing.Size(175, 20);
            this.ModulNameTxt.TabIndex = 2;
            // 
            // SaveModulBtn
            // 
            this.SaveModulBtn.Enabled = false;
            this.SaveModulBtn.Location = new System.Drawing.Point(398, 38);
            this.SaveModulBtn.Name = "SaveModulBtn";
            this.SaveModulBtn.Size = new System.Drawing.Size(93, 23);
            this.SaveModulBtn.TabIndex = 3;
            this.SaveModulBtn.Text = "Yadda Saxla";
          //  this.SaveModulBtn.Click += new System.EventHandler(this.SaveModulBtn_Click);
            // 
            // CancelModulBtn
            // 
            this.CancelModulBtn.Enabled = false;
            this.CancelModulBtn.Location = new System.Drawing.Point(398, 85);
            this.CancelModulBtn.Name = "CancelModulBtn";
            this.CancelModulBtn.Size = new System.Drawing.Size(93, 23);
            this.CancelModulBtn.TabIndex = 4;
            this.CancelModulBtn.Text = "Ləğv Et";
            this.CancelModulBtn.Click += new System.EventHandler(this.CancelModulBtn_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.activty);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.LevelLookUp);
            this.groupControl2.Controls.Add(this.ModulNameTxt);
            this.groupControl2.Controls.Add(this.SaveModulBtn);
            this.groupControl2.Controls.Add(this.CancelModulBtn);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(578, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(542, 189);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Modullar";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(27, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 16);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Üst Modul";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(27, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Ad";
            // 
            // LevelLookUp
            // 
            this.LevelLookUp.Enabled = false;
            this.LevelLookUp.Location = new System.Drawing.Point(119, 88);
            this.LevelLookUp.Name = "LevelLookUp";
            this.LevelLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LevelLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPTION", "AD")});
            this.LevelLookUp.Properties.DisplayMember = "DESCRIPTION";
            this.LevelLookUp.Properties.NullText = "";
            this.LevelLookUp.Properties.ValueMember = "ID";
            this.LevelLookUp.Size = new System.Drawing.Size(175, 20);
            this.LevelLookUp.TabIndex = 11;
            // 
            // activty
            // 
            this.activty.EditValue = true;
            this.activty.Location = new System.Drawing.Point(27, 135);
            this.activty.Name = "activty";
            this.activty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.activty.Properties.Appearance.Options.UseFont = true;
            this.activty.Properties.Caption = "Aktivlik";
            this.activty.Size = new System.Drawing.Size(124, 20);
            this.activty.TabIndex = 13;
            // 
            // Modul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 479);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dizayner";
            this.Load += new System.EventHandler(this.Modul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModulsTree)).EndInit();
            this.ContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModulNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activty.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TreeList ModulsTree;
        private TreeListColumn ID;
        private GroupControl groupControl1;
        private TreeListColumn LEVEL;
        private TreeListColumn DESCRIPTION;
        private TreeListColumn IMAGEINDEX;
        private TreeListColumn PARENTID;
        private TextEdit ModulNameTxt;
        private SimpleButton SaveModulBtn;
        private SimpleButton CancelModulBtn;
        private GroupControl groupControl2;
        private ContextMenuStrip ContextMenu;
        private ToolStripMenuItem NewItem;
        private LabelControl labelControl1;
        private LookUpEdit LevelLookUp;
        private LabelControl labelControl2;
        private ToolStripMenuItem səviyyə1ToolStripMenuItem;
        private ToolStripMenuItem səviyyə2ToolStripMenuItem;
        private ToolStripMenuItem dəyişToolStripMenuItem1;
        private ToolStripMenuItem səviyyə3ToolStripMenuItem;
        private ToolStripMenuItem səviyyə4ToolStripMenuItem;
        private ToolStripMenuItem səviyyə5ToolStripMenuItem;
        private CheckEdit activty;
    }
}