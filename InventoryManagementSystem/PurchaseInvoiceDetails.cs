using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        Retrieval r = new Retrieval();
        Insertion i = new Insertion();
        Updation u = new Updation();
        Deletion d = new Deletion();

        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseInvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        public override void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseInvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // clicked by mistake
        }

        private void purchaseInvoiceDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purchaseInvoiceDD.SelectedIndex != -1 && purchaseInvoiceDD.SelectedIndex != 0)
            {
                float gt = 0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purchaseInvoiceDD.SelectedValue.ToString()), dataGridView1, mPIDGV, prodIDGV, prodNameGV, quantityGV, perUnitPriceGV, totalAmountGV);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                }
                grossTotalLabel.Text = gt.ToString();
                gt = 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete " + row.Cells["prodNameGV"].Value.ToString() + "?\n\n\tDELETION WILL EFFECT STOCK INVENTORY!", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItemPI(Convert.ToInt64(purchaseInvoiceDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Retrieval.USER_ID, DateTime.Today);
                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()));
                            int quantity;

                            if (ob != null)
                            {
                                quantity = Convert.ToInt32(ob);
                                quantity -= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), quantity);
                                float total = Convert.ToSingle(grossTotalLabel.Text) - Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                                grossTotalLabel.Text = total.ToString();
                                d.delete(Convert.ToInt64(row.Cells["mPIDGV"].Value.ToString()), "st_deleteProductFromPID", "@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
                    }
                }
            }
        }
    }
}
