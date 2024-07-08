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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem
{
    public partial class Suppliers : Sample2
    {
        int edit = 0;   // this 0 is an indication to SAVE operation & 1 is an indication for UPDATE operation
        Retrieval r = new Retrieval();
        int supplierID;
        short stat;

        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
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
            if (supplierCompanyTxt.Text == "") { supplierNameErrorLabel.Visible = true; } else { supplierNameErrorLabel.Visible = false; }
            if (personNameTxt.Text == "") { personNameErrorLabel.Visible = true; } else { personNameErrorLabel.Visible = false; }
            if (phone1Txt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            if (addressTxt.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (supplierNameErrorLabel.Visible || personNameErrorLabel.Visible || phone1ErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory.", "Stop", "Error");     // Error is the type of message
            }
            else
            {
                if (statusDD.SelectedIndex == 0)    // status ACTIVE
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)   // status INACTIVE
                {
                    stat = 0;
                }

                if (edit == 0)      // code for SAVE operation
                {
                    Insertion i = new Insertion();

                    if (phone2Txt.Text == "" && ntnTxt.Text != "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                    }
                    else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, null);
                    }
                    else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, null);
                    }
                    else
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                    }

                    r.showSupplier(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)     // code for UPDATE operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update selected record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();

                        if (statusDD.SelectedIndex == 0)    // status ACTIVE
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)   // status INACTIVE
                        {
                            stat = 0;
                        }

                        if (phone2Txt.Text == "" && ntnTxt.Text != "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                        }
                        else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, null);
                        }
                        else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, null);
                        }
                        else
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                        }

                        r.showSupplier(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
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
                    d.delete(supplierID, "st_deleteSupplier", "@suppID");
                    r.showSupplier(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showSupplier(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                supplierCompanyTxt.Text = row.Cells["companyGV"].Value.ToString();
                personNameTxt.Text = row.Cells["personGV"].Value.ToString();
                phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
                phone2Txt.Text = row.Cells["phone2GV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                ntnTxt.Text = row.Cells["ntnGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();

                MainClass.disable(leftPanel);
            }
        }
    }
}
