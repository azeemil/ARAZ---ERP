using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors.Repository;

namespace ERP
{
    partial class MainForm
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barMng = new DevExpress.XtraBars.BarManager(this.components);
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.MenuToolBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.UserToolBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.TemaToolBarItem = new DevExpress.XtraBars.BarSubItem();
            this.SkinManager = new DevExpress.XtraBars.SkinBarSubItem();
            this.SaveTemaBarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ToolBarMdiChildrenList = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.menuBar = new DevExpress.XtraBars.Bar();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.userNameStsBar = new DevExpress.XtraBars.BarStaticItem();
            this.FirmNrStsBar = new DevExpress.XtraBars.BarStaticItem();
            this.FirmNameStsBar = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.AppNameStsBar = new DevExpress.XtraBars.BarHeaderItem();
            this.AppVersionStsBar = new DevExpress.XtraBars.BarHeaderItem();
            this.MdiToolBar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockMng = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockMenuPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.MenuAccordion = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.AdministratorAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.usersAdminElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.groupsAdminElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AccMobileNumbersItm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.optionAdminElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MarketReportTemplatesAccItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.TerminalAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MarketAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MarketTransactionAccElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MarketPrintPriceAccItm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.EndirimliQiymetAccItm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MarketKassirAccItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MalQebuluAccElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.FinanceAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AccountingTransactionActElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DocumentKontrolAccItm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CassirHesabAlmaActElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PurchAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PurchTransactionsAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PurchOrdersAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.LogisticsAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.LogistcsTransactionAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.WhouseOrders = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.OrderGroupActElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.VeyselogluObaSifarisAccItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MinMaxStokControlAccItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CRMAccElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CRMAcOperation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CustomersAccItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CrmPositions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CrmGiftsAccItm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CrmReportsAccGrp = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CrmLogsAccElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.GroupImages = new DevExpress.Utils.ImageCollection(this.components);
            this.toolBarImges = new DevExpress.Utils.ImageCollection(this.components);
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.windowsUserName = new DevExpress.XtraBars.BarHeaderItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.ToolBarItems = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barMdiChildrenListItem = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barLinkContainerItem2 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barMdiChildrenListItem3 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.CarlendarStsBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.barBtn0 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockingMenuItem2 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem6 = new DevExpress.XtraBars.BarStaticItem();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP.General.Wait), true, true, true);
            this.LogistcsReportingAcElmnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.LogistcsTransferedAmountİtm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.barMng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockMng)).BeginInit();
            this.dockMenuPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuAccordion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarImges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barMng
            // 
            this.barMng.AllowCustomization = false;
            this.barMng.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.toolBar,
            this.menuBar,
            this.statusBar,
            this.MdiToolBar});
            this.barMng.DockControls.Add(this.barDockControlTop);
            this.barMng.DockControls.Add(this.barDockControlBottom);
            this.barMng.DockControls.Add(this.barDockControlLeft);
            this.barMng.DockControls.Add(this.barDockControlRight);
            this.barMng.DockManager = this.dockMng;
            this.barMng.Form = this;
            this.barMng.Images = this.toolBarImges;
            this.barMng.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuToolBarItem,
            this.barSubItem1,
            this.UserToolBarItem,
            this.barStaticItem1,
            this.windowsUserName,
            this.skinBarSubItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barEditItem1,
            this.barListItem1,
            this.userNameStsBar,
            this.TemaToolBarItem,
            this.SkinManager,
            this.SaveTemaBarBtn,
            this.ToolBarMdiChildrenList,
            this.barLinkContainerItem1,
            this.ToolBarItems,
            this.barMdiChildrenListItem,
            this.barDockingMenuItem1,
            this.barLinkContainerItem2,
            this.barMdiChildrenListItem3,
            this.barEditItem2,
            this.CarlendarStsBar,
            this.barEditItem3,
            this.barEditItem4,
            this.barBtn0,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem1,
            this.FirmNrStsBar,
            this.barHeaderItem1,
            this.FirmNameStsBar,
            this.barDockingMenuItem2,
            this.AppVersionStsBar,
            this.barStaticItem5,
            this.barStaticItem4,
            this.barStaticItem6,
            this.AppNameStsBar});
            this.barMng.MainMenu = this.menuBar;
            this.barMng.MaxItemId = 48;
            this.barMng.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemPictureEdit1});
            this.barMng.ShowFullMenus = true;
            this.barMng.ShowScreenTipsInMenus = true;
            this.barMng.StatusBar = this.statusBar;
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Alətlər";
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 1;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.MenuToolBarItem, "Menu", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.UserToolBarItem),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.TemaToolBarItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ToolBarMdiChildrenList, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)});
            this.toolBar.OptionsBar.AllowQuickCustomization = false;
            this.toolBar.OptionsBar.DrawSizeGrip = true;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Tools";
            // 
            // MenuToolBarItem
            // 
            this.MenuToolBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.MenuToolBarItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.MenuToolBarItem.Caption = "Menu";
            this.MenuToolBarItem.Id = 0;
            this.MenuToolBarItem.ImageIndex = 0;
            this.MenuToolBarItem.LargeImageIndex = 1;
            this.MenuToolBarItem.Name = "MenuToolBarItem";
            this.MenuToolBarItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            toolTipTitleItem1.Text = "Menu";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.MenuToolBarItem.SuperTip = superToolTip1;
            this.MenuToolBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuToolBarItem_ItemClick);
            // 
            // UserToolBarItem
            // 
            this.UserToolBarItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.UserToolBarItem.Caption = "Istifadəçi";
            this.UserToolBarItem.Id = 2;
            this.UserToolBarItem.ImageIndex = 4;
            this.UserToolBarItem.LargeImageIndex = 3;
            this.UserToolBarItem.Name = "UserToolBarItem";
            this.UserToolBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserToolBarItem_ItemClick);
            // 
            // TemaToolBarItem
            // 
            this.TemaToolBarItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.TemaToolBarItem.Caption = "Tema";
            this.TemaToolBarItem.Id = 13;
            this.TemaToolBarItem.ImageIndex = 11;
            this.TemaToolBarItem.LargeImageIndex = 5;
            this.TemaToolBarItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.SkinManager, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.SaveTemaBarBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.TemaToolBarItem.Name = "TemaToolBarItem";
            // 
            // SkinManager
            // 
            this.SkinManager.Border = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.SkinManager.Caption = "Temalar";
            this.SkinManager.Glyph = ((System.Drawing.Image)(resources.GetObject("SkinManager.Glyph")));
            this.SkinManager.Id = 14;
            this.SkinManager.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SkinManager.LargeGlyph")));
            this.SkinManager.Name = "SkinManager";
            // 
            // SaveTemaBarBtn
            // 
            this.SaveTemaBarBtn.Caption = "Yadda Saxla";
            this.SaveTemaBarBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("SaveTemaBarBtn.Glyph")));
            this.SaveTemaBarBtn.Id = 15;
            this.SaveTemaBarBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SaveTemaBarBtn.LargeGlyph")));
            this.SaveTemaBarBtn.Name = "SaveTemaBarBtn";
            this.SaveTemaBarBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveTemaBarBtn_ItemClick);
            // 
            // ToolBarMdiChildrenList
            // 
            this.ToolBarMdiChildrenList.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.ToolBarMdiChildrenList.Caption = "Pəncərələr";
            this.ToolBarMdiChildrenList.Id = 16;
            this.ToolBarMdiChildrenList.ImageIndex = 12;
            this.ToolBarMdiChildrenList.LargeImageIndex = 6;
            this.ToolBarMdiChildrenList.Name = "ToolBarMdiChildrenList";
            // 
            // menuBar
            // 
            this.menuBar.BarAppearance.Normal.Font = new System.Drawing.Font("Arial", 8F);
            this.menuBar.BarAppearance.Normal.Options.UseFont = true;
            this.menuBar.BarAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.menuBar.BarAppearance.Pressed.Options.UseFont = true;
            this.menuBar.BarName = "Main menu";
            this.menuBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.menuBar.DockCol = 0;
            this.menuBar.DockRow = 0;
            this.menuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.menuBar.HideWhenMerging = DevExpress.Utils.DefaultBoolean.False;
            this.menuBar.OptionsBar.AllowQuickCustomization = false;
            this.menuBar.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.menuBar.OptionsBar.DrawDragBorder = false;
            this.menuBar.OptionsBar.DrawSizeGrip = true;
            this.menuBar.OptionsBar.MultiLine = true;
            this.menuBar.OptionsBar.UseWholeRow = true;
            this.menuBar.Text = "Main menu";
            // 
            // statusBar
            // 
            this.statusBar.BarAppearance.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusBar.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.statusBar.BarAppearance.Normal.Options.UseBorderColor = true;
            this.statusBar.BarAppearance.Normal.Options.UseFont = true;
            this.statusBar.BarAppearance.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.statusBar.BarAppearance.Pressed.Options.UseBackColor = true;
            this.statusBar.BarName = "Status";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.userNameStsBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.FirmNrStsBar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.FirmNameStsBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem5, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.AppNameStsBar),
            new DevExpress.XtraBars.LinkPersistInfo(this.AppVersionStsBar)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // userNameStsBar
            // 
            this.userNameStsBar.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.userNameStsBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.userNameStsBar.Glyph = ((System.Drawing.Image)(resources.GetObject("userNameStsBar.Glyph")));
            this.userNameStsBar.Id = 12;
            this.userNameStsBar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("userNameStsBar.LargeGlyph")));
            this.userNameStsBar.Name = "userNameStsBar";
            this.userNameStsBar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.userNameStsBar.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // FirmNrStsBar
            // 
            this.FirmNrStsBar.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.FirmNrStsBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.FirmNrStsBar.Caption = "FirmNr";
            this.FirmNrStsBar.Glyph = ((System.Drawing.Image)(resources.GetObject("FirmNrStsBar.Glyph")));
            this.FirmNrStsBar.Id = 38;
            this.FirmNrStsBar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("FirmNrStsBar.LargeGlyph")));
            this.FirmNrStsBar.Name = "FirmNrStsBar";
            this.FirmNrStsBar.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // FirmNameStsBar
            // 
            this.FirmNameStsBar.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.FirmNameStsBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.FirmNameStsBar.Caption = "FirmName";
            this.FirmNameStsBar.Glyph = ((System.Drawing.Image)(resources.GetObject("FirmNameStsBar.Glyph")));
            this.FirmNameStsBar.Id = 40;
            this.FirmNameStsBar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("FirmNameStsBar.LargeGlyph")));
            this.FirmNameStsBar.Name = "FirmNameStsBar";
            this.FirmNameStsBar.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Caption = "                                 ";
            this.barStaticItem5.Id = 43;
            this.barStaticItem5.Name = "barStaticItem5";
            this.barStaticItem5.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // AppNameStsBar
            // 
            this.AppNameStsBar.Caption = "AppName";
            this.AppNameStsBar.Id = 46;
            this.AppNameStsBar.Name = "AppNameStsBar";
            // 
            // AppVersionStsBar
            // 
            this.AppVersionStsBar.Caption = "AppVersion";
            this.AppVersionStsBar.Id = 42;
            this.AppVersionStsBar.Name = "AppVersionStsBar";
            // 
            // MdiToolBar
            // 
            this.MdiToolBar.BarName = "MdiToolBar";
            this.MdiToolBar.DockCol = 0;
            this.MdiToolBar.DockRow = 1;
            this.MdiToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.MdiToolBar.OptionsBar.AllowQuickCustomization = false;
            this.MdiToolBar.OptionsBar.DrawBorder = false;
            this.MdiToolBar.OptionsBar.DrawDragBorder = false;
            this.MdiToolBar.OptionsBar.MultiLine = true;
            this.MdiToolBar.Text = "MdiToolBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barDockControlTop.Appearance.Options.UseBorderColor = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1354, 71);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.barDockControlBottom.Appearance.Options.UseFont = true;
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Size = new System.Drawing.Size(1354, 60);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 392);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1354, 71);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 392);
            // 
            // dockMng
            // 
            this.dockMng.Form = this;
            this.dockMng.MenuManager = this.barMng;
            this.dockMng.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockMenuPanel});
            this.dockMng.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockMenuPanel
            // 
            this.dockMenuPanel.Controls.Add(this.dockPanel1_Container);
            this.dockMenuPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockMenuPanel.ID = new System.Guid("dfa956aa-67db-48a7-8248-1bc93f9374db");
            this.dockMenuPanel.Image = global::ERP.Properties.Resources.dock_icon_580_100025091_large_22;
            this.dockMenuPanel.Location = new System.Drawing.Point(0, 71);
            this.dockMenuPanel.Name = "dockMenuPanel";
            this.dockMenuPanel.OriginalSize = new System.Drawing.Size(272, 200);
            this.dockMenuPanel.Size = new System.Drawing.Size(272, 392);
            this.dockMenuPanel.Text = "Menu";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.MenuAccordion);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(264, 365);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // MenuAccordion
            // 
            this.MenuAccordion.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Simple;
            this.MenuAccordion.DistanceBetweenRootGroups = 0;
            this.MenuAccordion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuAccordion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AdministratorAcElmnt,
            this.TerminalAcElmnt,
            this.MarketAcElmnt,
            this.FinanceAcElmnt,
            this.PurchAcElmnt,
            this.LogisticsAcElmnt,
            this.CRMAccElmnt});
            this.MenuAccordion.Images = this.GroupImages;
            this.MenuAccordion.Location = new System.Drawing.Point(0, 0);
            this.MenuAccordion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.MenuAccordion.Name = "MenuAccordion";
            this.MenuAccordion.Size = new System.Drawing.Size(264, 365);
            this.MenuAccordion.TabIndex = 0;
            this.MenuAccordion.Text = "accordionControl1";
            // 
            // AdministratorAcElmnt
            // 
            this.AdministratorAcElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.usersAdminElmnt,
            this.groupsAdminElmnt,
            this.AccMobileNumbersItm,
            this.optionAdminElmnt});
            this.AdministratorAcElmnt.Expanded = true;
            this.AdministratorAcElmnt.ImageIndex = 1;
            this.AdministratorAcElmnt.Name = "AdministratorAcElmnt";
            this.AdministratorAcElmnt.Text = "Administrator";
            // 
            // usersAdminElmnt
            // 
            this.usersAdminElmnt.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.usersAdminElmnt.Appearance.Hovered.Options.UseFont = true;
            this.usersAdminElmnt.Image = ((System.Drawing.Image)(resources.GetObject("usersAdminElmnt.Image")));
            this.usersAdminElmnt.Name = "usersAdminElmnt";
            this.usersAdminElmnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.usersAdminElmnt.Tag = "";
            this.usersAdminElmnt.Text = "İstifadəçilər";
            this.usersAdminElmnt.Click += new System.EventHandler(this.AccordionClick);
            // 
            // groupsAdminElmnt
            // 
            this.groupsAdminElmnt.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupsAdminElmnt.Appearance.Hovered.Options.UseFont = true;
            this.groupsAdminElmnt.Image = ((System.Drawing.Image)(resources.GetObject("groupsAdminElmnt.Image")));
            this.groupsAdminElmnt.Name = "groupsAdminElmnt";
            this.groupsAdminElmnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.groupsAdminElmnt.Tag = "1.2";
            this.groupsAdminElmnt.Text = "Qruplar";
            this.groupsAdminElmnt.Click += new System.EventHandler(this.AccordionClick);
            // 
            // AccMobileNumbersItm
            // 
            this.AccMobileNumbersItm.Image = ((System.Drawing.Image)(resources.GetObject("AccMobileNumbersItm.Image")));
            this.AccMobileNumbersItm.Name = "AccMobileNumbersItm";
            this.AccMobileNumbersItm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AccMobileNumbersItm.Text = "Nömrələr";
            this.AccMobileNumbersItm.Click += new System.EventHandler(this.AccMobileNumbersItm_Click);
            // 
            // optionAdminElmnt
            // 
            this.optionAdminElmnt.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.optionAdminElmnt.Appearance.Hovered.Options.UseFont = true;
            this.optionAdminElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MarketReportTemplatesAccItem});
            this.optionAdminElmnt.Expanded = true;
            this.optionAdminElmnt.Image = ((System.Drawing.Image)(resources.GetObject("optionAdminElmnt.Image")));
            this.optionAdminElmnt.Name = "optionAdminElmnt";
            this.optionAdminElmnt.Text = "Tənzimləmələr";
            // 
            // MarketReportTemplatesAccItem
            // 
            this.MarketReportTemplatesAccItem.Name = "MarketReportTemplatesAccItem";
            this.MarketReportTemplatesAccItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MarketReportTemplatesAccItem.Text = "Dizaynlar";
            this.MarketReportTemplatesAccItem.Click += new System.EventHandler(this.ReportTemplatesAccItem_Click);
            // 
            // TerminalAcElmnt
            // 
            this.TerminalAcElmnt.ImageIndex = 4;
            this.TerminalAcElmnt.Name = "TerminalAcElmnt";
            this.TerminalAcElmnt.Text = "Terminal";
            this.TerminalAcElmnt.Visible = false;
            // 
            // MarketAcElmnt
            // 
            this.MarketAcElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MarketTransactionAccElmnt});
            this.MarketAcElmnt.Expanded = true;
            this.MarketAcElmnt.ImageIndex = 6;
            this.MarketAcElmnt.Name = "MarketAcElmnt";
            this.MarketAcElmnt.Text = "Market";
            // 
            // MarketTransactionAccElmnt
            // 
            this.MarketTransactionAccElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MarketPrintPriceAccItm,
            this.EndirimliQiymetAccItm,
            this.MarketKassirAccItem,
            this.MalQebuluAccElement});
            this.MarketTransactionAccElmnt.Expanded = true;
            this.MarketTransactionAccElmnt.Name = "MarketTransactionAccElmnt";
            this.MarketTransactionAccElmnt.Text = "Əməliyyatlar";
            // 
            // MarketPrintPriceAccItm
            // 
            this.MarketPrintPriceAccItm.Name = "MarketPrintPriceAccItm";
            this.MarketPrintPriceAccItm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MarketPrintPriceAccItm.Text = "Etiket Çapı";
            this.MarketPrintPriceAccItm.Click += new System.EventHandler(this.MarketPrintPriceAccItm_Click);
            // 
            // EndirimliQiymetAccItm
            // 
            this.EndirimliQiymetAccItm.Name = "EndirimliQiymetAccItm";
            this.EndirimliQiymetAccItm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.EndirimliQiymetAccItm.Text = "Endirimli Qiymət";
            this.EndirimliQiymetAccItm.Click += new System.EventHandler(this.EndirimliQiymetAccItm_Click);
            // 
            // MarketKassirAccItem
            // 
            this.MarketKassirAccItem.Name = "MarketKassirAccItem";
            this.MarketKassirAccItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MarketKassirAccItem.Text = "Kassirlər";
            this.MarketKassirAccItem.Click += new System.EventHandler(this.MarketKassirAccItem_Click);
            // 
            // MalQebuluAccElement
            // 
            this.MalQebuluAccElement.Name = "MalQebuluAccElement";
            this.MalQebuluAccElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MalQebuluAccElement.Text = "Mal Qəbulu";
            this.MalQebuluAccElement.Click += new System.EventHandler(this.MalQebuluAccElement_Click);
            // 
            // FinanceAcElmnt
            // 
            this.FinanceAcElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AccountingTransactionActElmnt});
            this.FinanceAcElmnt.Expanded = true;
            this.FinanceAcElmnt.ImageIndex = 16;
            this.FinanceAcElmnt.Name = "FinanceAcElmnt";
            this.FinanceAcElmnt.Text = "Mühasibat";
            // 
            // AccountingTransactionActElmnt
            // 
            this.AccountingTransactionActElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.DocumentKontrolAccItm,
            this.CassirHesabAlmaActElmnt});
            this.AccountingTransactionActElmnt.Expanded = true;
            this.AccountingTransactionActElmnt.Name = "AccountingTransactionActElmnt";
            this.AccountingTransactionActElmnt.Text = "Əməliyyatlar";
            // 
            // DocumentKontrolAccItm
            // 
            this.DocumentKontrolAccItm.Name = "DocumentKontrolAccItm";
            this.DocumentKontrolAccItm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.DocumentKontrolAccItm.Text = "Sənəd Yoxlama";
            this.DocumentKontrolAccItm.Click += new System.EventHandler(this.DocumentKontrolAccItm_Click);
            // 
            // CassirHesabAlmaActElmnt
            // 
            this.CassirHesabAlmaActElmnt.Name = "CassirHesabAlmaActElmnt";
            this.CassirHesabAlmaActElmnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CassirHesabAlmaActElmnt.Text = "Kassir Hesab Alma";
            this.CassirHesabAlmaActElmnt.Click += new System.EventHandler(this.CassirHesabAlmaActElmnt_Click);
            // 
            // PurchAcElmnt
            // 
            this.PurchAcElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.PurchTransactionsAcElmnt});
            this.PurchAcElmnt.Expanded = true;
            this.PurchAcElmnt.ImageIndex = 17;
            this.PurchAcElmnt.Name = "PurchAcElmnt";
            this.PurchAcElmnt.Text = "Alış";
            // 
            // PurchTransactionsAcElmnt
            // 
            this.PurchTransactionsAcElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.PurchOrdersAcElmnt});
            this.PurchTransactionsAcElmnt.Name = "PurchTransactionsAcElmnt";
            this.PurchTransactionsAcElmnt.Text = "Əməliyyatlar";
            // 
            // PurchOrdersAcElmnt
            // 
            this.PurchOrdersAcElmnt.Name = "PurchOrdersAcElmnt";
            this.PurchOrdersAcElmnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PurchOrdersAcElmnt.Text = "Alış Sifarişləri";
            this.PurchOrdersAcElmnt.Click += new System.EventHandler(this.AccordionClick);
            // 
            // LogisticsAcElmnt
            // 
            this.LogisticsAcElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.LogistcsTransactionAcElmnt,
            this.LogistcsReportingAcElmnt});
            this.LogisticsAcElmnt.Expanded = true;
            this.LogisticsAcElmnt.ImageIndex = 18;
            this.LogisticsAcElmnt.Name = "LogisticsAcElmnt";
            this.LogisticsAcElmnt.Text = "Loqistika";
            // 
            // LogistcsTransactionAcElmnt
            // 
            this.LogistcsTransactionAcElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.WhouseOrders,
            this.OrderGroupActElmnt,
            this.VeyselogluObaSifarisAccItem,
            this.MinMaxStokControlAccItem});
            this.LogistcsTransactionAcElmnt.Name = "LogistcsTransactionAcElmnt";
            this.LogistcsTransactionAcElmnt.Text = "Əməliyyatlar";
            // 
            // WhouseOrders
            // 
            this.WhouseOrders.Name = "WhouseOrders";
            this.WhouseOrders.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.WhouseOrders.Text = "Anbar Sifarişi";
            this.WhouseOrders.Click += new System.EventHandler(this.AccordionClick);
            // 
            // OrderGroupActElmnt
            // 
            this.OrderGroupActElmnt.Name = "OrderGroupActElmnt";
            this.OrderGroupActElmnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.OrderGroupActElmnt.Text = "Sifariş Qruplama";
            this.OrderGroupActElmnt.Click += new System.EventHandler(this.AccordionClick);
            // 
            // VeyselogluObaSifarisAccItem
            // 
            this.VeyselogluObaSifarisAccItem.Name = "VeyselogluObaSifarisAccItem";
            this.VeyselogluObaSifarisAccItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.VeyselogluObaSifarisAccItem.Text = "Veyseloglu Sifarisi";
            this.VeyselogluObaSifarisAccItem.Click += new System.EventHandler(this.VeyselogluObaSifarisAccItem_Click);
            // 
            // MinMaxStokControlAccItem
            // 
            this.MinMaxStokControlAccItem.Name = "MinMaxStokControlAccItem";
            this.MinMaxStokControlAccItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MinMaxStokControlAccItem.Text = "Material Səviyyə Kontrol";
            this.MinMaxStokControlAccItem.Click += new System.EventHandler(this.MinMaxStokControlAccItem_Click);
            // 
            // CRMAccElmnt
            // 
            this.CRMAccElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.CRMAcOperation,
            this.CrmReportsAccGrp});
            this.CRMAccElmnt.Expanded = true;
            this.CRMAccElmnt.ImageIndex = 19;
            this.CRMAccElmnt.Name = "CRMAccElmnt";
            this.CRMAccElmnt.Text = "Müştəri Əlaqələri";
            // 
            // CRMAcOperation
            // 
            this.CRMAcOperation.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.CustomersAccItem,
            this.CrmPositions,
            this.CrmGiftsAccItm});
            this.CRMAcOperation.Expanded = true;
            this.CRMAcOperation.Name = "CRMAcOperation";
            this.CRMAcOperation.Text = "Əməliyyatlar";
            // 
            // CustomersAccItem
            // 
            this.CustomersAccItem.Name = "CustomersAccItem";
            this.CustomersAccItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CustomersAccItem.Text = "Müştərilər";
            this.CustomersAccItem.Click += new System.EventHandler(this.CustomersItm_Click);
            // 
            // CrmPositions
            // 
            this.CrmPositions.Name = "CrmPositions";
            this.CrmPositions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CrmPositions.Text = "Vəzifələr";
            this.CrmPositions.Click += new System.EventHandler(this.CrmPositions_Click);
            // 
            // CrmGiftsAccItm
            // 
            this.CrmGiftsAccItm.Name = "CrmGiftsAccItm";
            this.CrmGiftsAccItm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CrmGiftsAccItm.Text = "Hədiyyə";
            this.CrmGiftsAccItm.Click += new System.EventHandler(this.CrmGiftsAccItm_Click);
            // 
            // CrmReportsAccGrp
            // 
            this.CrmReportsAccGrp.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.CrmLogsAccElmnt});
            this.CrmReportsAccGrp.Expanded = true;
            this.CrmReportsAccGrp.Name = "CrmReportsAccGrp";
            this.CrmReportsAccGrp.Text = "Hesabatlar";
            // 
            // CrmLogsAccElmnt
            // 
            this.CrmLogsAccElmnt.Name = "CrmLogsAccElmnt";
            this.CrmLogsAccElmnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CrmLogsAccElmnt.Text = "Kart Əməliyyatları";
            this.CrmLogsAccElmnt.Click += new System.EventHandler(this.CrmLogsAccElmnt_Click);
            // 
            // GroupImages
            // 
            this.GroupImages.ImageSize = new System.Drawing.Size(24, 24);
            this.GroupImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("GroupImages.ImageStream")));
            this.GroupImages.Images.SetKeyName(0, "12065698671516857163pitr_red_menu_icon_set_2.svg.hi.png");
            this.GroupImages.Images.SetKeyName(1, "Administrator_image.jpg");
            this.GroupImages.Images.SetKeyName(2, "images (1).jpg");
            this.GroupImages.Images.SetKeyName(3, "images (1).png");
            this.GroupImages.Images.SetKeyName(4, "images (2).jpg");
            this.GroupImages.Images.SetKeyName(5, "images.jpg");
            this.GroupImages.Images.SetKeyName(6, "market_ico.jpg");
            this.GroupImages.Images.SetKeyName(7, "menu_icon.jpg");
            this.GroupImages.Images.SetKeyName(8, "menu_icon_2.jpg");
            this.GroupImages.Images.SetKeyName(9, "modul_!.png");
            this.GroupImages.Images.SetKeyName(10, "number-icon-set.jpg");
            this.GroupImages.Images.SetKeyName(11, "theme.jpg");
            this.GroupImages.Images.SetKeyName(12, "window.jpg");
            this.GroupImages.Images.SetKeyName(13, "window2.jpg");
            this.GroupImages.Images.SetKeyName(14, "скачанные файлы.jpg");
            this.GroupImages.Images.SetKeyName(17, "images (3).jpg");
            this.GroupImages.Images.SetKeyName(18, "logistics.jpg");
            this.GroupImages.Images.SetKeyName(19, "CRM.png");
            // 
            // toolBarImges
            // 
            this.toolBarImges.ImageSize = new System.Drawing.Size(32, 32);
            this.toolBarImges.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("toolBarImges.ImageStream")));
            this.toolBarImges.Images.SetKeyName(0, "12065698671516857163pitr_red_menu_icon_set_2.svg.hi.png");
            this.toolBarImges.Images.SetKeyName(1, "Administrator_image.jpg");
            this.toolBarImges.Images.SetKeyName(2, "dock-icon_580-100025091-large.png");
            this.toolBarImges.Images.SetKeyName(3, "dock-icon_580-100025091-large_22.png");
            this.toolBarImges.Images.SetKeyName(4, "images (1).jpg");
            this.toolBarImges.Images.SetKeyName(5, "images (1).png");
            this.toolBarImges.Images.SetKeyName(6, "images (2).jpg");
            this.toolBarImges.Images.SetKeyName(7, "market_ico.jpg");
            this.toolBarImges.Images.SetKeyName(8, "menu_icon.jpg");
            this.toolBarImges.Images.SetKeyName(9, "menu_icon_2.jpg");
            this.toolBarImges.Images.SetKeyName(10, "modul_!.png");
            this.toolBarImges.Images.SetKeyName(11, "theme.jpg");
            this.toolBarImges.Images.SetKeyName(12, "window.jpg");
            this.toolBarImges.Images.SetKeyName(13, "window2.jpg");
            this.toolBarImges.Images.SetKeyName(14, "скачанные файлы.jpg");
            // 
            // barSubItem1
            // 
            this.barSubItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barSubItem1.Caption = "Sənəd";
            this.barSubItem1.Id = 1;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Çıxış";
            this.barButtonItem1.Id = 37;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // windowsUserName
            // 
            this.windowsUserName.Caption = "WindowsUserName";
            this.windowsUserName.Id = 4;
            this.windowsUserName.Name = "windowsUserName";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skins";
            this.skinBarSubItem1.Id = 6;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.barStaticItem2.Id = 7;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.Size = new System.Drawing.Size(32, 0);
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barStaticItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barStaticItem3.Id = 8;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.Size = new System.Drawing.Size(32, 0);
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = null;
            this.barEditItem1.Id = 47;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 10;
            this.barListItem1.Name = "barListItem1";
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 17;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // ToolBarItems
            // 
            this.ToolBarItems.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ToolBarItems.Caption = "Görünüş";
            this.ToolBarItems.Id = 18;
            this.ToolBarItems.Name = "ToolBarItems";
            this.ToolBarItems.ShowDockPanels = true;
            this.ToolBarItems.ShowMenuCaption = true;
            this.ToolBarItems.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barMdiChildrenListItem
            // 
            this.barMdiChildrenListItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barMdiChildrenListItem.Caption = "Pəncərə";
            this.barMdiChildrenListItem.Id = 19;
            this.barMdiChildrenListItem.Name = "barMdiChildrenListItem";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
            this.barDockingMenuItem1.Id = 20;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // barLinkContainerItem2
            // 
            this.barLinkContainerItem2.Caption = "barLinkContainerItem2";
            this.barLinkContainerItem2.Id = 21;
            this.barLinkContainerItem2.Name = "barLinkContainerItem2";
            // 
            // barMdiChildrenListItem3
            // 
            this.barMdiChildrenListItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.barMdiChildrenListItem3.Caption = "Pəncərələr";
            this.barMdiChildrenListItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barMdiChildrenListItem3.Glyph")));
            this.barMdiChildrenListItem3.Id = 22;
            this.barMdiChildrenListItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMdiChildrenListItem3.LargeGlyph")));
            this.barMdiChildrenListItem3.Name = "barMdiChildrenListItem3";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Kalendar";
            this.barEditItem2.Edit = this.repositoryItemDateEdit1;
            this.barEditItem2.Id = 23;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // CarlendarStsBar
            // 
            this.CarlendarStsBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.CarlendarStsBar.CanOpenEdit = false;
            this.CarlendarStsBar.Caption = "barEditItem3";
            this.CarlendarStsBar.Edit = this.repositoryItemDateEdit2;
            this.CarlendarStsBar.EditWidth = 137;
            this.CarlendarStsBar.Glyph = ((System.Drawing.Image)(resources.GetObject("CarlendarStsBar.Glyph")));
            this.CarlendarStsBar.Id = 24;
            this.CarlendarStsBar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("CarlendarStsBar.LargeGlyph")));
            this.CarlendarStsBar.Name = "CarlendarStsBar";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemDateEdit2.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Edit = this.repositoryItemMarqueeProgressBar1;
            this.barEditItem3.Id = 25;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "barEditItem4";
            this.barEditItem4.Edit = this.repositoryItemPictureEdit1;
            this.barEditItem4.Glyph = global::ERP.Properties.Resources._123551;
            this.barEditItem4.Id = 26;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // barBtn0
            // 
            this.barBtn0.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barBtn0.Caption = "1";
            this.barBtn0.Id = 27;
            this.barBtn0.ImageIndex = 8;
            this.barBtn0.LargeImageIndex = 8;
            this.barBtn0.Name = "barBtn0";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 28;
            this.barButtonItem2.ImageIndex = 9;
            this.barButtonItem2.LargeImageIndex = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 29;
            this.barButtonItem3.ImageIndex = 10;
            this.barButtonItem3.LargeImageIndex = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 30;
            this.barButtonItem4.ImageIndex = 11;
            this.barButtonItem4.LargeImageIndex = 11;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 31;
            this.barButtonItem5.ImageIndex = 12;
            this.barButtonItem5.LargeImageIndex = 12;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 32;
            this.barButtonItem6.ImageIndex = 13;
            this.barButtonItem6.LargeImageIndex = 13;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 33;
            this.barButtonItem7.ImageIndex = 14;
            this.barButtonItem7.LargeImageIndex = 14;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 34;
            this.barButtonItem8.ImageIndex = 15;
            this.barButtonItem8.LargeImageIndex = 15;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 35;
            this.barButtonItem9.ImageIndex = 16;
            this.barButtonItem9.LargeImageIndex = 16;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 36;
            this.barButtonItem10.ImageIndex = 17;
            this.barButtonItem10.LargeImageIndex = 17;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "FIrmName";
            this.barHeaderItem1.Id = 39;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barDockingMenuItem2
            // 
            this.barDockingMenuItem2.Caption = "barDockingMenuItem2";
            this.barDockingMenuItem2.Id = 41;
            this.barDockingMenuItem2.Name = "barDockingMenuItem2";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "barStaticItem4";
            this.barStaticItem4.Id = 44;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem6
            // 
            this.barStaticItem6.Caption = "AppName";
            this.barStaticItem6.Id = 45;
            this.barStaticItem6.Name = "barStaticItem6";
            this.barStaticItem6.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Mal Qəbulu";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // LogistcsReportingAcElmnt
            // 
            this.LogistcsReportingAcElmnt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.LogistcsTransferedAmountİtm});
            this.LogistcsReportingAcElmnt.Expanded = true;
            this.LogistcsReportingAcElmnt.Name = "LogistcsReportingAcElmnt";
            this.LogistcsReportingAcElmnt.Text = "Hesabatlar";
            this.LogistcsReportingAcElmnt.TextPosition = DevExpress.XtraBars.Navigation.TextPosition.BeforeImage;
            // 
            // LogistcsTransferedAmountİtm
            // 
            this.LogistcsTransferedAmountİtm.Name = "LogistcsTransferedAmountİtm";
            this.LogistcsTransferedAmountİtm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.LogistcsTransferedAmountİtm.Text = "Sifariş Qarşılama";
            this.LogistcsTransferedAmountİtm.Click += new System.EventHandler(this.LogistcsTransferedAmountİtm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 523);
            this.Controls.Add(this.dockMenuPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAZ - ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barMng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockMng)).EndInit();
            this.dockMenuPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuAccordion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarImges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BarManager barMng;
        private Bar toolBar;
        private Bar menuBar;
        private Bar statusBar;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private DockManager dockMng;
        private ControlContainer dockPanel1_Container;
        private BarButtonItem MenuToolBarItem;
        private BarButtonItem UserToolBarItem;
        private BarSubItem barSubItem1;
        private BarHeaderItem windowsUserName;
        private BarStaticItem barStaticItem1;
        //
        private SkinBarSubItem skinBarSubItem1;
        private BarStaticItem barStaticItem2;
        private BarStaticItem barStaticItem3;
        private BarEditItem barEditItem1;
        private BarListItem barListItem1;
        private BarStaticItem userNameStsBar;
        private BarSubItem TemaToolBarItem;
        private SkinBarSubItem SkinManager;
        private BarButtonItem SaveTemaBarBtn;
        private BarMdiChildrenListItem ToolBarMdiChildrenList;
        private BarToolbarsListItem ToolBarItems;
        private BarMdiChildrenListItem barMdiChildrenListItem;
        private BarLinkContainerItem barLinkContainerItem1;
        private BarDockingMenuItem barDockingMenuItem1;
        private BarMdiChildrenListItem barMdiChildrenListItem3;
        private BarEditItem CarlendarStsBar;
        private RepositoryItemDateEdit repositoryItemDateEdit2;
        private BarLinkContainerItem barLinkContainerItem2;
        private BarEditItem barEditItem2;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private BarEditItem barEditItem3;
        private RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private BarButtonItem barBtn0;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private BarButtonItem barButtonItem8;
        private BarButtonItem barButtonItem9;
        private BarButtonItem barButtonItem10;
        private BarEditItem barEditItem4;
        private RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private BarButtonItem barButtonItem1;
        private BarStaticItem FirmNrStsBar;
        private BarStaticItem FirmNameStsBar;
        private BarStaticItem barStaticItem5;
        private BarHeaderItem AppVersionStsBar;
        private BarHeaderItem barHeaderItem1;
        private BarDockingMenuItem barDockingMenuItem2;
        private BarHeaderItem AppNameStsBar;
        private BarStaticItem barStaticItem4;
        private BarStaticItem barStaticItem6;
        public SharedImageCollection sharedImages;
        private Bar MdiToolBar;
        private AccordionControl MenuAccordion;
        private AccordionControlElement AdministratorAcElmnt;
        private AccordionControlElement TerminalAcElmnt;
        private AccordionControlElement FinanceAcElmnt;
        private ImageCollection toolBarImges;
        private AccordionControlElement MarketAcElmnt;
        private ImageCollection GroupImages;
        private AccordionControlElement usersAdminElmnt;
       
     
        private AccordionControlElement groupsAdminElmnt;
        private AccordionControlElement optionAdminElmnt;
        public DockPanel dockMenuPanel;
        private AccordionControlElement PurchAcElmnt;
        private AccordionControlElement PurchTransactionsAcElmnt;
        private AccordionControlElement PurchOrdersAcElmnt;
        private AccordionControlElement LogisticsAcElmnt;
        private AccordionControlElement LogistcsTransactionAcElmnt;
        private AccordionControlElement WhouseOrders;
        private AccordionControlElement OrderGroupActElmnt;
        private AccordionControlElement CRMAccElmnt;
        private AccordionControlElement CRMAcOperation;
        private AccordionControlElement CustomersAccItem;
        private AccordionControlElement CrmPositions;
        private AccordionControlElement CrmReportsAccGrp;
        private AccordionControlElement CrmLogsAccElmnt;
        private AccordionControlElement MarketTransactionAccElmnt;
        private AccordionControlElement MarketPrintPriceAccItm;
        private AccordionControlElement MarketReportTemplatesAccItem;
        private AccordionControlElement AccountingTransactionActElmnt;
        private AccordionControlElement CassirHesabAlmaActElmnt;
        private AccordionControlElement EndirimliQiymetAccItm;
        private AccordionControlElement VeyselogluObaSifarisAccItem;
        private AccordionControlElement MarketKassirAccItem;
        private AccordionControlElement DocumentKontrolAccItm;
        private AccordionControlElement MinMaxStokControlAccItem;
        private AccordionControlElement CrmGiftsAccItm;
        private AccordionControlElement AccMobileNumbersItm;
        private AccordionControlElement accordionControlElement1;
        private AccordionControlElement MalQebuluAccElement;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private AccordionControlElement LogistcsReportingAcElmnt;
        private AccordionControlElement LogistcsTransferedAmountİtm;
    }
}

