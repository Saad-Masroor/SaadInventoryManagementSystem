using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Retrieval
    {
        private string[] productData = new string[6];   // for getProductWRTBarcode() to receive product data
        private bool chkPPExist;

        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statusGV, string data = null)  // for int, add '?' to make it nullable && data is OPTIONABLE PARAMETER
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUserData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUserDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMsg("Unable to load data.", "Error", "Error");
            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn statusGV)  // for int, add '?' to make it nullable && data is OPTIONABLE PARAMETER
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMsg("Unable to load data.", "Error", "Error");
            }
        }

        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        public void showProducts(DataGridView gv, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, DataGridViewColumn catIDGv, DataGridViewColumn barcodeGV)  // for int, add '?' to make it nullable && data is OPTIONABLE PARAMETER
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                prodIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                prodNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGv.DataPropertyName = dt.Columns["Category ID"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMsg("Unable to load data.", "Error", "Error");
            }
        }

        private object productStockCount = 0;
        public object getProductQuantity(int productID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", productID);
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return productStockCount;
        }

        public object getProductQuantityWithoutConnection(int productID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", productID);
                productStockCount = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return productStockCount;
        }

        public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDGV, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn quantityGV, DataGridViewColumn unitPriceGV, DataGridViewColumn totalPriceGV)  // for int, add '?' to make it nullable && data is OPTIONABLE PARAMETER
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                prodIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                prodNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                unitPriceGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totalPriceGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMsg("Unable to load data.", "Error", "Error");
            }
        }

        public void showProductsWRTCategory(int catID, DataGridView gv, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn discGV, DataGridViewColumn profitGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                prodIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                prodNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                discGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitGV.DataPropertyName = dt.Columns["Profit"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMsg("Unable to load data.", "Error", "Error");
            }
        }

        public bool checkProdPriceExistance(int proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    chkPPExist = true;
                }
                else
                {
                    chkPPExist = false;
                }

                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }

            return chkPPExist;
        }
        public static int USER_ID
        {
            get;
            private set;
        }

        public static string EMP_NAME
        {
            get;
            private set;
        }

        private static string userName = null, passWord = null; // for getUserDetails() error input process
        private static bool checkLogin;

        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    checkLogin = true;

                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        userName = dr["Username"].ToString();
                        passWord = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;

                    if (username != null && password != null)
                    {
                        if (userName != username && passWord == password)
                        {
                            MainClass.ShowMsg("Invalid Username", "Error", "Error");
                        }
                        else if (userName == username && passWord != password)
                        {
                            MainClass.ShowMsg("Invalid Password", "Error", "Error");
                        }
                        else if (userName != username && passWord != password)
                        {
                            MainClass.ShowMsg("Invalid Username and Password", "Error", "Error");
                        }
                    }
                }

                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.ShowMsg("Unable to login...", "Error", "Error");
            }

            return checkLogin;
        }

        public void showSupplier(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn compNameGV, DataGridViewColumn personGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)  // for int, add '?' to make it nullable && data is OPTIONABLE PARAMETER
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                compNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMsg("Unable to load data.", "Error", "Error");
            }
        }

        public string[] getProductWRTBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); ;

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productData[0] = dr[0].ToString();  // prod id
                        productData[1] = dr[1].ToString();  // prod name
                        productData[2] = dr[2].ToString();  // barcode
                        productData[3] = dr[3].ToString();  // selling price
                        productData[4] = dr[4].ToString();  // discount
                        productData[5] = dr[5].ToString();  // final selling price
                    }
                }
                else
                {
                    Array.Clear(productData, 0, productData.Length); // On wrong Barcode
                }

                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }

            return productData;
        }

        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcodeGV, DataGridViewColumn expiryGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn catGV, DataGridViewColumn stockGV, DataGridViewColumn statusGV, DataGridViewColumn totalAmountGV)  // for int, add '?' to make it nullable && data is OPTIONABLE PARAMETER
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getAllStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                stockGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMsg("Unable to load data.", "Error", "Error");
            }
        }
    }
}
