using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Users : Sample2
    {
        int edit = 0;   // this 0 is an indication to SAVE operation & 1 is an indication for UPDATE operation
        Retrieval r = new Retrieval();
        int userID;
        short stat;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
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
            if (nameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passTxt.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if (phoneTxt.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (emailTxt.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (nameErrorLabel.Visible || passwordErrorLabel.Visible || usernameErrorLabel.Visible || phoneErrorLabel.Visible || emailErrorLabel.Visible || statusErrorLabel.Visible)
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

                    i.insertUser(nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, statusGV);
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

                        u.updateUser(userID, nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, statusGV);
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
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, statusGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, statusGV, searchTxt.Text);
            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, statusGV);
            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, statusGV);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // nameErrorLabel
            // double-clicked by mistake
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UsernameGV"].Value.ToString();
                passTxt.Text = row.Cells["PasswordGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();

                MainClass.disable(leftPanel);
            }
        }
    }
}
