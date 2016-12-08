using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;

namespace ERP.Administrator
{
    partial class Permissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permissions));
            this.cancel = new DevExpress.XtraEditors.SimpleButton();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            this.tree = new DevExpress.XtraTreeList.TreeList();
            this.ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.DESCRIPTION = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.PERMISSION = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.chekbox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.combobox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TYPENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(787, 37);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(153, 48);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Ləğv Et";
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Save.Appearance.Options.UseFont = true;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Location = new System.Drawing.Point(630, 37);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(140, 48);
            this.Save.TabIndex = 12;
            this.Save.Text = "Yadda Saxla";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // tree
            // 
            this.tree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ID,
            this.DESCRIPTION,
            this.PERMISSION});
            this.tree.Dock = System.Windows.Forms.DockStyle.Left;
            this.tree.KeyFieldName = "";
            this.tree.Location = new System.Drawing.Point(2, 20);
            this.tree.Name = "tree";
            this.tree.BeginUnboundLoad();
            this.tree.AppendNode(new object[] {
            "1",
            "Market",
            false}, -1);
            this.tree.AppendNode(new object[] {
            "1.1",
            "Əməliyyatlar",
            false}, 0);
            this.tree.AppendNode(new object[] {
            "1.1.0",
            "Etiket Çapı",
            false}, 1);
            this.tree.AppendNode(new object[] {
            "1.1.2",
            "Endirimli qiymət",
            false}, 1);
            this.tree.AppendNode(new object[] {
            "1.1.2.0",
            "İncələ",
            false}, 3);
            this.tree.AppendNode(new object[] {
            "1.1.2.1",
            "Yeni",
            false}, 3);
            this.tree.AppendNode(new object[] {
            "1.1.2.2",
            "Dəyiş",
            false}, 3);
            this.tree.AppendNode(new object[] {
            "1.1.2.3",
            "Ləğv et",
            false}, 3);
            this.tree.AppendNode(new object[] {
            "1.1.3",
            "Kassirlər",
            false}, 1);
            this.tree.AppendNode(new object[] {
            "1.1.4",
            "Mal Qəbulu",
            false}, 1);
            this.tree.AppendNode(new object[] {
            "1.1.4.1",
            "Satınalma Və Satış",
            false}, 9);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.1",
            "Sənəd Növləri",
            false}, 10);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.1.0",
            "Alış",
            false}, 11);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.1.1",
            "Alış İadə",
            false}, 11);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.1.2",
            "Satış",
            false}, 11);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.1.3",
            "Satış İadə",
            false}, 11);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.1.4",
            "Topdan Satış",
            false}, 11);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.1.5",
            "Topdan Satış İadə",
            false}, 11);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.2",
            "İncələ",
            false}, 10);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.3",
            "Çap Et",
            false}, 10);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.4",
            "Silməyə Müraciət Et",
            false}, 10);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.4.1",
            "Faktura",
            false}, 20);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.4.2",
            "Irsaliyyə",
            false}, 20);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.6",
            "Toplu Çap Et",
            false}, 10);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.7",
            "Excelə Göndər",
            false}, 10);
            this.tree.AppendNode(new object[] {
            "1.1.4.1.8",
            "Fakturalanmamış İrsaliyyələr",
            false}, 10);
            this.tree.AppendNode(new object[] {
            "1.1.4.2",
            "Material Sənədləri",
            false}, 9);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.1",
            "Sənəd Növləri",
            false}, 26);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.1.0",
            "Transferlər",
            false}, 27);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.1.1",
            "Mərkəzdən Çıxan",
            false}, 27);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.1.2",
            "Mərkəzdən Gələn",
            false}, 27);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.1.3",
            "İmha",
            false}, 27);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.1.4",
            "Sərf",
            false}, 27);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.1.5",
            "Ürətim",
            false}, 27);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.2",
            "İncələ",
            false}, 26);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.3",
            "Çap Et",
            false}, 26);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.4",
            "Silməyə Müraciət Et",
            false}, 26);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.4.1",
            "Kilitli",
            false}, 36);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.4.2",
            "Kilitsiz",
            false}, 36);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.6",
            "Toplu Çap Et",
            false}, 26);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.7",
            "Excelə Göndər",
            false}, 26);
            this.tree.AppendNode(new object[] {
            "1.1.4.2.8",
            "Material Hərəkəti Hesabatı",
            false}, 26);
            this.tree.AppendNode(new object[] {
            "2",
            "Muhasibatliq",
            false}, -1);
            this.tree.AppendNode(new object[] {
            "2.1",
            "Əməliyyatlar",
            false}, 42);
            this.tree.AppendNode(new object[] {
            "2.1.1",
            "Toplu Qaimə",
            false}, 43);
            this.tree.AppendNode(new object[] {
            "2.1.2",
            "Kassir Hesab Alma",
            false}, 43);
            this.tree.AppendNode(new object[] {
            "2.1.3",
            "Sənəd Yoxlama",
            false}, 43);
            this.tree.AppendNode(new object[] {
            "2.2",
            "Hesabatlar",
            false}, 42);
            this.tree.AppendNode(new object[] {
            "3",
            "Alış",
            false}, -1);
            this.tree.AppendNode(new object[] {
            "3.1",
            "Əməliyyatlar",
            false}, 48);
            this.tree.AppendNode(new object[] {
            "3.1.1",
            "Alış Sifarişi",
            false}, 49);
            this.tree.AppendNode(new object[] {
            "3.1.1.1",
            "Incələ",
            false}, 50);
            this.tree.AppendNode(new object[] {
            "3.1.1.2",
            "Yeni",
            false}, 50);
            this.tree.AppendNode(new object[] {
            "3.1.1.3",
            "Dəyiş",
            false}, 50);
            this.tree.AppendNode(new object[] {
            "3.1.1.4",
            "Çap Et",
            false}, 50);
            this.tree.AppendNode(new object[] {
            "3.2",
            "Hesabatlar",
            false}, 48);
            this.tree.AppendNode(new object[] {
            "4",
            "Loqistika",
            false}, -1);
            this.tree.AppendNode(new object[] {
            "4.1",
            "Əməliyyatlar",
            false}, 56);
            this.tree.AppendNode(new object[] {
            "4.1.1",
            "Anbara Sifariş",
            false}, 57);
            this.tree.AppendNode(new object[] {
            "4.1.1.1",
            "Yeni",
            false}, 58);
            this.tree.AppendNode(new object[] {
            "4.1.1.2",
            "Çap et",
            false}, 58);
            this.tree.AppendNode(new object[] {
            "4.1.1.3",
            "Sil",
            false}, 58);
            this.tree.AppendNode(new object[] {
            "4.1.2",
            "Sifariş Qruplama",
            false}, 57);
            this.tree.AppendNode(new object[] {
            "4.1.2.1",
            "Yeni",
            false}, 62);
            this.tree.AppendNode(new object[] {
            "4.1.2.2",
            "Çap et",
            false}, 62);
            this.tree.AppendNode(new object[] {
            "4.1.2.3",
            "Sil",
            false}, 62);
            this.tree.AppendNode(new object[] {
            "4.1.2.4",
            "Təsdiqlə",
            false}, 62);
            this.tree.AppendNode(new object[] {
            "4.1.2.5",
            "Paylaşdır",
            false}, 62);
            this.tree.AppendNode(new object[] {
            "4.1.3",
            "Veysəloğluna Sifariş",
            false}, 57);
            this.tree.AppendNode(new object[] {
            "4.1.4",
            "Stok Seviyye",
            false}, 57);
            this.tree.AppendNode(new object[] {
            "4.1.5",
            "Mərkəz Depoya Sifariş",
            false}, 57);
            this.tree.AppendNode(new object[] {
            "4.2",
            "Hesabatlar",
            false}, 56);
            this.tree.AppendNode(new object[] {
            "4.2.1",
            "Sifariş Qarsılama",
            false}, 71);
            this.tree.AppendNode(new object[] {
            "5",
            "Müştəri Əlaqələri",
            false}, -1);
            this.tree.AppendNode(new object[] {
            "5.1",
            "Əməliyyatlar",
            false}, 73);
            this.tree.AppendNode(new object[] {
            "5.1.1",
            "Müştərilər",
            false}, 74);
            this.tree.AppendNode(new object[] {
            "5.1.1.0",
            "İncələ",
            false}, 75);
            this.tree.AppendNode(new object[] {
            "5.1.1.1",
            "Dəyişdir",
            false}, 75);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.1",
            "Status",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.2",
            "Ad",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.3",
            "Soyad",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.4",
            "Ata Adı",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.5",
            "Doğum Tarixi",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.6",
            "Əlaqə Nömrəsi",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.7",
            "Cinsi",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.8",
            "Ailə Vəziyyəti",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.1.9",
            "Sənəd Nömrəsi",
            false}, 77);
            this.tree.AppendNode(new object[] {
            "5.1.1.2",
            "Hərəkətlər",
            false}, 75);
            this.tree.AppendNode(new object[] {
            "5.1.1.3",
            "Bonus",
            false}, 75);
            this.tree.AppendNode(new object[] {
            "5.1.1.3.1",
            "Artır",
            false}, 88);
            this.tree.AppendNode(new object[] {
            "5.1.1.3.2",
            "Azalt",
            false}, 88);
            this.tree.AppendNode(new object[] {
            "5.1.1.4",
            "Transfer",
            false}, 75);
            this.tree.AppendNode(new object[] {
            "5.1.1.4.1",
            "Yadda Saxla",
            false}, 91);
            this.tree.AppendNode(new object[] {
            "5.1.1.4.2",
            "Statusu Passiv Et",
            false}, 91);
            this.tree.AppendNode(new object[] {
            "5.1.1.4.3",
            "Bütün Məlumatları Köçür",
            false}, 91);
            this.tree.AppendNode(new object[] {
            "5.1.2",
            "Vəzifələr",
            false}, 74);
            this.tree.AppendNode(new object[] {
            "5.1.3",
            "Hədiyyə",
            false}, 74);
            this.tree.AppendNode(new object[] {
            "5.1.4",
            "Lotoreya",
            false}, 74);
            this.tree.AppendNode(new object[] {
            "5.1.5",
            "Toplu Bonus",
            false}, 74);
            this.tree.AppendNode(new object[] {
            "5.1.6",
            "Toplu Müştəri",
            false}, 74);
            this.tree.AppendNode(new object[] {
            "5.2",
            "Hesabatlar",
            false}, 73);
            this.tree.AppendNode(new object[] {
            "5.2.0",
            "Bonus Kart Əməliyyatları",
            false}, 100);
            this.tree.AppendNode(new object[] {
            "6",
            "Web",
            false}, -1);
            this.tree.AppendNode(new object[] {
            "6.1",
            "Satınalma",
            false}, 102);
            this.tree.AppendNode(new object[] {
            "6.1.1",
            "Qiymətləndirmə",
            false}, 103);
            this.tree.AppendNode(new object[] {
            "6.1.2",
            "Təsdiqləmə",
            false}, 103);
            this.tree.AppendNode(new object[] {
            "6.1.3",
            "Qiymət Dəyişimi Çapı",
            false}, 103);
            this.tree.AppendNode(new object[] {
            "6.1.4",
            "Qiymet Ferqi",
            false}, 103);
            this.tree.AppendNode(new object[] {
            "6.2",
            "CRM",
            false}, 102);
            this.tree.AppendNode(new object[] {
            "6.2.1",
            "Hesabatlar",
            false}, 108);
            this.tree.EndUnboundLoad();
            this.tree.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.tree.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.tree.OptionsFind.AllowFindPanel = true;
            this.tree.OptionsView.ShowColumns = false;
            this.tree.OptionsView.ShowIndicator = false;
            this.tree.ParentFieldName = "";
            this.tree.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.combobox,
            this.chekbox});
            this.tree.Size = new System.Drawing.Size(478, 510);
            this.tree.TabIndex = 3;
            
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 124;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 178;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Caption = "DESCRIPTION";
            this.DESCRIPTION.FieldName = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Visible = true;
            this.DESCRIPTION.VisibleIndex = 1;
            this.DESCRIPTION.Width = 231;
            // 
            // PERMISSION
            // 
            this.PERMISSION.Caption = "PERMISSION";
            this.PERMISSION.ColumnEdit = this.chekbox;
            this.PERMISSION.FieldName = "PERMISSION";
            this.PERMISSION.Name = "PERMISSION";
            this.PERMISSION.Visible = true;
            this.PERMISSION.VisibleIndex = 2;
            this.PERMISSION.Width = 231;
            // 
            // chekbox
            // 
            this.chekbox.AutoHeight = false;
            this.chekbox.Name = "chekbox";
            this.chekbox.CheckedChanged += new System.EventHandler(this.chekbox_CheckedChanged);
            // 
            // combobox
            // 
            this.combobox.AutoHeight = false;
            this.combobox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combobox.Items.AddRange(new object[] {
            "Seçilməyib",
            "+",
            "-"});
            this.combobox.Name = "combobox";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(486, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(460, 510);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TYPE,
            this.TYPENAME,
            this.NAME,
            this.STATUS,
            this.NR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TYPENAME, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TYPE, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // TYPE
            // 
            this.TYPE.Caption = "TIP";
            this.TYPE.FieldName = "TYPE";
            this.TYPE.Name = "TYPE";
            // 
            // TYPENAME
            // 
            this.TYPENAME.Caption = " ";
            this.TYPENAME.FieldName = "TYPENAME";
            this.TYPENAME.Name = "TYPENAME";
            this.TYPENAME.OptionsColumn.ShowCaption = false;
            this.TYPENAME.Visible = true;
            this.TYPENAME.VisibleIndex = 3;
            // 
            // NAME
            // 
            this.NAME.Caption = "Ad";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 1;
            // 
            // STATUS
            // 
            this.STATUS.Caption = "Status";
            this.STATUS.FieldName = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 2;
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
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(952, 554);
            this.groupControl1.TabIndex = 14;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.tree);
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 20);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(948, 532);
            this.groupControl3.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Save);
            this.groupControl2.Controls.Add(this.cancel);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 554);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(952, 97);
            this.groupControl2.TabIndex = 15;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Hamısını Seç";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ləğv Et";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(952, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 651);
            this.barDockControlBottom.Size = new System.Drawing.Size(952, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 651);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(952, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 651);
            // 
            // Permissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 651);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Permissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Səlahiyyətlər";
            this.Load += new System.EventHandler(this.Permissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton cancel;
        private SimpleButton Save;
        private TreeList tree;
        private TreeListColumn ID;
        private TreeListColumn DESCRIPTION;
        private TreeListColumn PERMISSION;
        private RepositoryItemComboBox combobox;
        private RepositoryItemCheckEdit chekbox;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn TYPE;
        private GridColumn TYPENAME;
        private GridColumn NAME;
        private GridColumn STATUS;
        private GridColumn NR;
        private GroupControl groupControl1;
        private GroupControl groupControl3;
        private GroupControl groupControl2;
        private PopupMenu popupMenu1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarManager barManager1;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
    }
}