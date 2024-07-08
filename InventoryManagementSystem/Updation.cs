using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Transactions;

namespace InventoryManagementSystem
{
    internal class Updation
    {
        public void updateUser(int id, string name, string username, string password, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(name + " updated successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        public void updateCategory(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategories", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(name + " updated successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        public void updateProduct(int prod_id, string product, string barcode, int catID, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProduct", MainClass.con);
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
                cmd.Parameters.AddWithValue("@prodID", prod_id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(product + " updated successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        public void updateSupplier(int supID, string companyName, string contactPerson, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.con);
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
                cmd.Parameters.AddWithValue("@suppID", supID);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(companyName + " updated successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

        public void updateStock(int prodID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
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
        public void updateStockWithoutConnection(int prodID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", prodID);
                cmd.Parameters.AddWithValue("@quan", quantity);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }
        public void updateProductPrice(int prodID, float bp, float sp = 0, float discount = 0, float profit = 0)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    SqlCommand cmd;
                    string procedureName;

                    if (sp == 0 && discount == 0 && profit == 0)
                    {
                        procedureName = "st_updateProductPrice1";
                        cmd = new SqlCommand(procedureName, MainClass.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@proID", prodID);
                        cmd.Parameters.AddWithValue("@bp", bp);
                    }
                    else
                    {
                        procedureName = "st_updateProductPrice";
                        cmd = new SqlCommand(procedureName, MainClass.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@proID", prodID);
                        cmd.Parameters.AddWithValue("@bp", bp);
                        cmd.Parameters.AddWithValue("@sp", sp);
                        cmd.Parameters.AddWithValue("@dis", discount);
                        cmd.Parameters.AddWithValue("@profit", profit);
                    }

                    // Logging the SQL command for debugging purposes
                    Debug.WriteLine($"Executing Stored Procedure: {procedureName}");
                    foreach (SqlParameter param in cmd.Parameters)
                    {
                        Debug.WriteLine($"{param.ParameterName}: {param.Value}");
                    }

                    MainClass.con.Open();
                    cmd.ExecuteNonQuery();
                    MainClass.con.Close();

                    // Commit the transaction
                    transaction.Complete();
                }

                MainClass.ShowMsg("Product price updated successfully!", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(ex.Message, "Error...", "Error");
            }
        }

    }
}
