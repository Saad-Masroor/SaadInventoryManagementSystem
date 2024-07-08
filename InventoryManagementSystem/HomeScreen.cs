using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void prodCategoriesBtn_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            MainClass.showWindow(c, this, MDI.ActiveForm);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI m = new MDI();
            userLabel.Text = Retrieval.EMP_NAME;
            m.logOutToolStripMenuItem.Enabled = true;
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void purchaseInvoiceBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice pi = new PurchaseInvoice();
            MainClass.showWindow(pi, this, MDI.ActiveForm);
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void prodPricingBtn_Click(object sender, EventArgs e)
        {
            ProductPricing pp = new ProductPricing();
            MainClass.showWindow(pp, this, MDI.ActiveForm);
        }
    }
}
