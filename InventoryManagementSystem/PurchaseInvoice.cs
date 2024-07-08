using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class PurchaseInvoice : Sample2
    {
        int edit = 0;   // this 0 is an indication to SAVE operation & 1 is an indication for UPDATE operation
        Retrieval r = new Retrieval();
        Updation u = new Updation();
        int purchaseInvoiceID;
        int productID;  // for barcodeTxt_TextChanged() to catch returning product id 
        string[] prodARR = new string[3]; // for barcodeTxt_TextChanged() to store returning value from (r.) methods
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        float grossTotal, total;

        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        int count = 0;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Insertion i = new Insertion();
                Updation u = new Updation();
                int count = 0;
                int updateCount = 0;
                int insertCount = 0;

                using (TransactionScope sc = new TransactionScope())
                {
                    Int64 purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, Retrieval.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        count += i.insertPurchaseInvoiceDetails(purchaseInvoiceID,
                                                                 Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()),
                                                                 Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()),
                                                                 Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString()));

                        // Update or Insert Product Price
                        if (r.checkProdPriceExistance(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString())))
                        {
                            u.updateProductPrice(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()),
                                                 Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()));
                            updateCount++;
                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()),
                                                 Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()));
                            insertCount++;
                        }

                        // Update or Insert Stock
                        int quantity;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()));
                        if (ob != null)
                        {
                            quantity = Convert.ToInt32(ob);
                            quantity += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), quantity);
                        }
                        else
                        {
                            i.insertStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()),
                                          Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                        }
                    }

                    if (count > 0)
                    {
                        MainClass.ShowMsg($"Purchase Invoice created successfully with {updateCount} product price updates and {insertCount} new product price inserts.", "Success", "Success");
                    }
                    else
                    {
                        MainClass.ShowMsg("Unable to create Purchase Invoice.", "Error", "Error");
                    }
                    sc.Complete();
                }
            }
            else
            {
                MainClass.ShowMsg("No items in the cart to save.", "Error", "Error");
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
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            /*MainClass.disable_reset(leftPanel);*/
            r.getList("st_getSupplierList", supplierDD, "Company", "ID");
        }

        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void barcodeTxt_Validated(object sender, EventArgs e)
        {

        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            if (quantityTxt.Text != "")
            {
                if (rg.Match(quantityTxt.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(quantityTxt.Text);
                    price = Convert.ToSingle(unitPriceTxt.Text);
                    tot = quan * price;
                    totalAmountLabel.Text = tot.ToString("##########.##");
                }
                else
                {
                    quantityTxt.SelectAll();
                }
            }
            else
            {
                totalAmountLabel.Text = "0.00";
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (quantityTxt.Text == "") { quantityErrorLabel.Visible = true; } else { quantityErrorLabel.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (supplierDD.SelectedIndex == -1 || supplierDD.SelectedIndex == 0) { supplierErrorLabel.Visible = true; } else { supplierErrorLabel.Visible = false; }

            if (quantityErrorLabel.Visible || barcodeErrorLabel.Visible || supplierErrorLabel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory.", "Stop", "Error");     // Error is the type of message
            }
            else
            {
                dataGridView1.Rows.Add(productID, productTxt.Text, quantityTxt.Text, unitPriceTxt.Text, totalAmountLabel.Text);
                grossTotal += Convert.ToSingle(totalAmountLabel.Text);
                grossTotalLabel.Text = grossTotal.ToString();
                productID = 0;
                productTxt.Text = "";
                unitPriceTxt.Text = "";
                barcodeTxt.Text = "";
                totalAmountLabel.Text = "0.00";
                quantityTxt.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    grossTotal -= Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                    grossTotalLabel.Text = grossTotal.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void unitPriceTxt_TextChanged(object sender, EventArgs e)
        {
            if (unitPriceTxt.Text != "")
            {
                if (!rg.Match(unitPriceTxt.Text).Success)
                {
                    unitPriceTxt.Text = "";
                    unitPriceTxt.Focus();
                }
            }
        }

        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                prodARR = r.getProductWRTBarcode(barcodeTxt.Text);
                productID = Convert.ToInt32(prodARR[0]);
                productTxt.Text = prodARR[1];
                string barco = prodARR[2];
                productTxt.Enabled = false;

                if (barco != null)
                {
                    unitPriceTxt.Focus();
                }
            }
            else
            {
                productID = 0;
                productTxt.Text = "";
                unitPriceTxt.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }

        private void productTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
