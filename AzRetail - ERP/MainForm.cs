using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using ERP.Finance;
using ERP.General;
using ERP.Logistcs;
using ERP.Market;


namespace ERP
{
    public partial class MainForm : XtraForm

    {
        public MainForm()
        {
          
            InitializeComponent();
            Variables.MForm = this;LoadAppDefaults();
            SetTags();
            LoadPermissions();
            MenuAccordion.CollapseAll();
        }
      
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        
        }

        private void SaveTemaBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Registr.SetSkin(UserLookAndFeel.Default.SkinName);
        }

        private void MenuToolBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            dockMenuPanel.Visibility=DockVisibility.Visible;
        }

        private void UserToolBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Istifadəçini dəyişməyə əminsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Variables.ExitMode = false;
                Dispose();
            }
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Programnan çıxmağa əminsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
      
        }

        private void HelpBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            HelpForm form = new HelpForm();
            OpenOrBringToFront(form);
        }

        
    }
}
