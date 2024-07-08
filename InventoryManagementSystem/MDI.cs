using System.IO;
namespace InventoryManagementSystem
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path + "\\connect"))
            {
                Login_Page log = new Login_Page();
                MainClass.showWindow(log, this);
            }
            else
            {
                Settings set = new Settings();
                MainClass.showWindow(set, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.showWindow(set, this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI m = new MDI();
            Login_Page set = new Login_Page();
            MainClass.showWindow(set, this);
            m.logOutToolStripMenuItem.Enabled = false;
        }
    }
}
