using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem
{
    public partial class Products : Sample2
    {
        int edit = 0;   // this 0 is an indication to SAVE operation & 1 is an indication for UPDATE operation
        Retrieval r = new Retrieval();
        int productID;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (productTxt.Text == "") { prodNameErrorLabel.Visible = true; } else { prodNameErrorLabel.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (expiryDatePicker.Value < DateTime.Now) { expiryErrorLabel.Visible = true; expiryErrorLabel.Text = "Invalid Date!"; } else { expiryErrorLabel.Visible = false; }
            if (expiryDatePicker.Value.Date == DateTime.Now.Date) { expiryErrorLabel.Visible = false; }
            if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }

            if (prodNameErrorLabel.Visible || barcodeErrorLabel.Visible || expiryErrorLabel.Visible || categoryErrorLabel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory.", "Stop", "Error");     // Error is the type of message
            }
            else
            {
                if (edit == 0)      // code for SAVE operation
                {
                    Insertion i = new Insertion();

                    if (expiryDatePicker.Value.Date == DateTime.Now.Date)
                    {
                        i.insertProduct(productTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue));
                    }
                    else
                    {
                        i.insertProduct(productTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue), expiryDatePicker.Value);
                    }

                    r.showProducts(dataGridView1, prodIDGV, prodNameGV, expiryGV, catGV, catIDGV, barcodeGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)     // code for UPDATE operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update selected record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        
                        if (expiryDatePicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(productID, productTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue));
                        }
                        else
                        {
                            u.updateProduct(productID, productTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue), expiryDatePicker.Value);
                        }

                        r.showProducts(dataGridView1, prodIDGV, prodNameGV, expiryGV, catGV, catIDGV, barcodeGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete selected record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(productID, "st_deleteProduct", "@prodID");
                    r.showProducts(dataGridView1, prodIDGV, prodNameGV, expiryGV, catGV, catIDGV, barcodeGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, prodIDGV, prodNameGV, expiryGV, catGV, catIDGV, barcodeGV);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                productID = Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString());
                productTxt.Text = row.Cells["prodNameGV"].Value.ToString();
                barcodeTxt.Text = row.Cells["barcodeGV"].Value.ToString();
                
                if (row.Cells["expiryGV"].FormattedValue.ToString() == "")
                {
                    expiryDatePicker.Value = DateTime.Now;
                }
                else
                {
                    expiryDatePicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                }

                categoryDD.SelectedValue = row.Cells["catIDGV"].Value.ToString();

                MainClass.disable(leftPanel);
            }
        }
    }
}
