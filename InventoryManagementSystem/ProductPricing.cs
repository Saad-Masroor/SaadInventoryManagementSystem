using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ProductPricing : Sample2
    {
        Retrieval r = new Retrieval();
        Updation u = new Updation();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public ProductPricing()
        {
            InitializeComponent();
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");
        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                r.showProductsWRTCategory(Convert.ToInt32(categoryDD.SelectedValue.ToString()), dataGridView1, prodIDGV, prodNameGV, buyingPriceGV, finalPriceGV, discountGV, profitMarginGV);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
                {
                    float buyingPrice = Convert.ToSingle(row.Cells["buyingPriceGV"].Value ?? "0");
                    float profitMargin = Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString() ?? "0");
                    profitMargin = profitMargin / 100;
                    float amountToIncrease = profitMargin * buyingPrice;
                    float finalSellingPrice = buyingPrice + amountToIncrease;
                    float discount;

                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        discount = finalSellingPrice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discount = 0;
                    }

                    row.Cells["finalPriceGV"].Value = finalSellingPrice - discount;
                }
                else
                {
                    row.Cells["finalPriceGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                    row.Cells["profitMarginGV"].Value = null;
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                dataGridView1.BeginEdit(true);
            }

        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            int chk = 0;
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        chk += 1;
                        float disc, profMargin, bp, sp;
                        int pID = Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                        disc = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        profMargin = row.Cells["profitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString());

                        if (disc == 0 && profMargin == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["finalPriceGV"].Value.ToString());
                        }

                        u.updateProductPrice(pID, bp, sp, disc, profMargin);
                    }
                }

                if (chk > 0)
                {
                    MainClass.ShowMsg("Product price updated successfully.", "Success", "Success");
                    chk = 0;
                }
                else
                {
                    MainClass.ShowMsg("No Product(s) Selected.", "Error", "Error");
                    chk = 0;
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
