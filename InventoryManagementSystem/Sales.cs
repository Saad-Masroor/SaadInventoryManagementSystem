using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Sales : Sample2
    {
        string[] prodARR = new string[6]; // for barcodeTxt_Validating() to store returning value from (r.) methods
        //int productID;  // for barcodeTxt_TextChanged() to catch returning product id 
        float grossAmount = 0; // for barcodeTxt_Validating() to update gross amount label at bottom
        bool prodChk;
        Retrieval r = new Retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        string receiptText = "";
        public Sales()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                tb_grossTotal.Text = "";
                tb_totalDiscount.Text = "";
                tb_amountGiven.Text = "";
                tb_changeGive.Text = "";
                int qCount = 0, sQuant = 0, nQuant = 0;
                prodARR = r.getProductWRTBarcode(barcodeTxt.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (prodARR[0] == row.Cells["prodIDGV"].Value.ToString()) // get quantity count
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    }
                }
                sQuant = Convert.ToInt32(r.getProductQuantity(Convert.ToInt32(prodARR[0])));
                tb_remainingStock.Text = (sQuant - 1).ToString();
                // Sales shouldn't be more than stock
                nQuant = sQuant - qCount;
                if (nQuant <= 0)
                {
                    MessageBox.Show("Not enough stock available.");
                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["prodIDGV"].Value.ToString() == prodARR[0])
                            {
                                prodChk = true;
                                break;
                            }
                            else
                            {
                                prodChk = false;
                            }
                        }

                        if (prodChk == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["prodIDGV"].Value.ToString() == prodARR[0])
                                {
                                    row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                    float disc = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) + Convert.ToSingle(prodARR[4]);
                                    row.Cells["discGV"].Value = disc;

                                    float total = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) - disc;
                                    row.Cells["totalAmountGV"].Value = total;
                                }
                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                        }
                    }

                    // Recalculate gross amount and total discount
                    grossAmount = 0;
                    float totalDiscount = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        grossAmount += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                        totalDiscount += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                    }

                    grossTotalLabel.Text = Math.Round(grossAmount, 0).ToString();
                    tb_totalDiscount.Text = Math.Round(totalDiscount, 0).ToString();
                    barcodeTxt.Focus();
                    barcodeTxt.Text = "";
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6) // Assuming column 6 is the delete button column
                {
                    tb_grossTotal.Text = "";
                    tb_totalDiscount.Text = "";
                    tb_amountGiven.Text = "";
                    tb_changeGive.Text = "";
                    float gt, total, disc;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int quantity = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());

                    if (quantity == 1)
                    {
                        gt = Convert.ToSingle(grossTotalLabel.Text);
                        gt = gt - Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                        grossTotalLabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (quantity > 1)
                    {
                        quantity--;
                        row.Cells["quantityGV"].Value = quantity;
                        disc = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) - Convert.ToSingle(prodARR[4]);
                        row.Cells["discGV"].Value = disc;
                        total = Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) - disc;
                        row.Cells["totalAmountGV"].Value = total;

                        // Recalculate gross amount
                        grossAmount = 0;
                        foreach (DataGridViewRow row1 in dataGridView1.Rows)
                        {
                            grossAmount += Convert.ToSingle(row1.Cells["totalAmountGV"].Value.ToString());
                        }

                        grossTotalLabel.Text = grossAmount.ToString();
                    }

                    // Recalculate total discount
                    float totalDiscount = 0;
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        totalDiscount += Convert.ToSingle(row1.Cells["discGV"].Value.ToString());
                    }
                    tb_totalDiscount.Text = totalDiscount.ToString();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Add your event handler code here
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                float dis = 0;
                grossAmount = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                    grossAmount += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                }
                tb_grossTotal.Text = Math.Round(grossAmount, 0).ToString();
                tb_totalDiscount.Text = Math.Round(dis, 0).ToString();
            }
        }

        private void tb_amountGiven_TextChanged(object sender, EventArgs e)
        {
            if (tb_amountGiven.Text != "")
            {
                if (!rg.Match(tb_amountGiven.Text).Success)
                {
                    tb_amountGiven.Text = "";
                    tb_amountGiven.Focus();
                }
                else
                {

                }
            }
            else
            {
                tb_changeGive.Text = "";
            }

        }

        private void tb_amountGiven_Validating(object sender, CancelEventArgs e)
        {
            if (tb_amountGiven.Text != "" && tb_grossTotal.Text != "")
            {
                if (!(Convert.ToSingle(tb_grossTotal.Text) <= Convert.ToSingle(tb_amountGiven.Text)))
                {
                    tb_amountGiven.Text = "";
                    tb_changeGive.Text = "";
                    tb_amountGiven.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(tb_amountGiven.Text);
                    float amountReturn = amountGiven - Convert.ToSingle(tb_grossTotal.Text);
                    tb_changeGive.Text = Math.Round(amountReturn, 0).ToString();
                }
            }

        }
        Insertion i = new Insertion();
        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (tb_amountGiven.Text != "" && tb_totalDiscount.Text != "" && tb_grossTotal.Text != "" && cb_paymentType.SelectedIndex != -1 && tb_amountGiven.Text != "")
            {
                DialogResult dr = MessageBox.Show("" +
                    "\n\n\tTotal Amount :: " + tb_grossTotal.Text + "\n\t" +
                    "Total Discount :: " + tb_totalDiscount.Text + "\n\t" +
                    "Amount Given :: " + tb_amountGiven.Text + "\n\t" +
                    "Amount Returned :: " + tb_changeGive.Text + "\n\t" +
                    "Are You Sure, Submit Current Sales?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "prodIDGV", "quantityGV", Retrieval.USER_ID, DateTime.Now, Convert.ToSingle(tb_grossTotal.Text), Convert.ToSingle(tb_totalDiscount.Text), Convert.ToSingle(tb_amountGiven.Text), Convert.ToSingle(tb_changeGive.Text), cb_paymentType.SelectedItem.ToString());
                    MainClass.enable_reset(gb_pay);
                    tb_remainingStock.Text = "";
                    dataGridView1.Rows.Clear();
                    grossTotalLabel.Text = "0.00";

                    // Generate and preview the receipt
                    GenerateReceipt();
                    ShowPrintPreview();
                }
            }
        }

        private void GenerateReceipt()
        {
            int userId = Retrieval.USER_ID;
            string query = "EXEC st_getSalesReceipt @userId"; // Call the stored procedure

            using (SqlConnection connection = new SqlConnection(MainClass.con.ConnectionString)) // Use the connection from MainClass
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);

                    connection.Open(); // Open the connection

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            StringBuilder receiptBuilder = new StringBuilder();
                            receiptBuilder.AppendLine("----- Sales Receipt -----");

                            while (reader.Read())
                            {
                                receiptBuilder.AppendLine($"Sales ID: {reader["Sales ID"]}");
                                receiptBuilder.AppendLine($"Date: {reader["Date"]}");
                                receiptBuilder.AppendLine($"User: {reader["User"]}");
                                receiptBuilder.AppendLine();
                                receiptBuilder.AppendLine("Items:");
                                receiptBuilder.AppendLine("------------------------------");
                                receiptBuilder.AppendLine("Barcode | Quantity | Price | Discount | Total");
                                receiptBuilder.AppendLine($"{reader["Barcode"]} | {reader["Quantity"]} | {reader["Product Price"]} | {reader["Per Product Discount"]} | {reader["Per Product Total"]}");
                                receiptBuilder.AppendLine();
                                receiptBuilder.AppendLine($"Total Discount: {reader["Total Discount"]}");
                                receiptBuilder.AppendLine($"Total Amount: {reader["Total Amount"]}");
                                receiptBuilder.AppendLine($"Amount Given: {reader["Amount Given"]}");
                                receiptBuilder.AppendLine($"Amount Returned: {reader["Amount Return"]}");
                                receiptBuilder.AppendLine($"Payment Type: {reader["Pay Type"]}");
                                receiptBuilder.AppendLine("------------------------------");
                                receiptBuilder.AppendLine("Thank you for your purchase!");
                            }

                            receiptText = receiptBuilder.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No recent sales found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while generating the receipt: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close(); // Ensure the connection is closed
                    }
                }
            }
        }

        private void ShowPrintPreview()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receiptText, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }
    }
}