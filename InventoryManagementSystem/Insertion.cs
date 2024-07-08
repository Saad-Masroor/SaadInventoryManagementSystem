using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Diagnostics;
using System.Windows.Forms; 


namespace InventoryManagementSystem
{
    internal class Insertion
    {
        public void insertUser (string name, string username, string password, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(name+" added to the system successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        public void insertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategories", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(name + " added to the system successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        public void insertProduct(string product, string barcode, int catID, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);

                if (expiry == null) 
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                
                cmd.Parameters.AddWithValue("@catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(product + " added to the system successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        public void insertSupplier(string companyName, string contactPerson, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", companyName);
                cmd.Parameters.AddWithValue("@conPerson", contactPerson);
                cmd.Parameters.AddWithValue("@phone1", phone1);

                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }

                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@status", status);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(companyName + " added to the system successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        private Int64 purchaseInvoiceID;

        public Int64 insertPurchaseInvoice(DateTime date, int doneBy, int suppID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductInvoice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", doneBy);
                cmd.Parameters.AddWithValue("@suppID", suppID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getLatestPurchaseInvoiceID";
                cmd.Parameters.Clear();
                purchaseInvoiceID = Convert.ToInt32(cmd.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
            return purchaseInvoiceID;
        }

        public void insertProductPrice(int proID, float buyingPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingPrice);
                cmd.Parameters.AddWithValue("@sp", DBNull.Value);
                cmd.Parameters.AddWithValue("@disc", DBNull.Value);
                cmd.Parameters.AddWithValue("@profit", DBNull.Value);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        int pidCount;
        public int insertPurchaseInvoiceDetails(Int64 purInvoiceID, int prodID, int quantity, float tPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID", purInvoiceID);
                cmd.Parameters.AddWithValue("@prodID", prodID);
                cmd.Parameters.AddWithValue("@quan", quantity);
                cmd.Parameters.AddWithValue("@totPrice", tPrice);
                MainClass.con.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return pidCount;
        }

        public void insertStock(Int64 prodID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", prodID);
                cmd.Parameters.AddWithValue("@quan", quantity);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }

        public void insertDeletedItemPI(Int64 piID, int proID, int quan, int userID, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertTrackDeletedItemPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", piID);
                cmd.Parameters.AddWithValue("@usrID", userID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }
        int salCount = 0;
        Retrieval r = new Retrieval();
        Updation u = new Updation();
        Int32 salesID;
        public void insertSales(DataGridView gv, string proIDGV, string quantityGV, int doneBy, DateTime dt, float tAmount, float tDiscount, float aGiven, float aReturned, string payType)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totamt", tAmount);
                    cmd.Parameters.AddWithValue("@totdis", tDiscount);
                    cmd.Parameters.AddWithValue("@given", aGiven);
                    cmd.Parameters.AddWithValue("@return", aReturned);
                    if (payType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 0);

                    }
                    else if (payType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 1);

                    }
                    else if (payType == "Credit Card"){
                        cmd.Parameters.AddWithValue("@pyType", 2);

                    }
                    MainClass.con.Open();
                    salCount = cmd.ExecuteNonQuery();

                    if (salCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        salesID = Convert.ToInt32(cmd2.ExecuteScalar());



                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            if (row.Cells[proIDGV].Value != null && row.Cells[quantityGV].Value != null)
                            {
                                SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.con);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Parameters.AddWithValue("@salID", salesID);
                                cmd3.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells[proIDGV].Value.ToString()));
                                cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[quantityGV].Value.ToString()));
                                cmd3.ExecuteNonQuery();
                                int stockofProduct = Convert.ToInt32(r.getProductQuantityWithoutConnection(Convert.ToInt32(row.Cells[proIDGV].Value.ToString())));
                                int currentQuanofProduct = Convert.ToInt32(row.Cells[quantityGV].Value.ToString());
                                int finalProductQuantity = stockofProduct - currentQuanofProduct;
                                u.updateStockWithoutConnection(Convert.ToInt32(row.Cells[proIDGV].Value.ToString()), finalProductQuantity);
                            }
                        }
                    }

                    MainClass.con.Close();
                    MainClass.ShowMsg("Sales Successfull", "SUCCESS", "Success");
                    sc.Complete();
                }        
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }
    }
}
