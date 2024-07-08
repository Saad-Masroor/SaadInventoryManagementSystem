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
    public partial class Categories : Sample2
    {
        int edit = 0;   // this 0 is an indication to SAVE operation & 1 is an indication for UPDATE operation
        Retrieval r = new Retrieval();
        int catID;
        short stat;

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
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
            if (categoryNameTxt.Text == "") { categoryNameErrorLabel.Visible = true; } else { categoryNameErrorLabel.Visible = false; }
            if (activeDD.SelectedIndex == -1) { activeErrorLabel.Visible = true; } else { activeErrorLabel.Visible = false; }

            if (categoryNameErrorLabel.Visible || activeErrorLabel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory.", "Stop", "Error");     // Error is the type of message
            }
            else
            {
                if (activeDD.SelectedIndex == 0)    // active status ACTIVE
                {
                    stat = 1;
                }
                else if (activeDD.SelectedIndex == 1)   // active status INACTIVE
                {
                    stat = 0;
                }

                if (edit == 0)      // code for SAVE operation
                {
                    Insertion i = new Insertion();

                    i.insertCategory(categoryNameTxt.Text, stat);
                    r.showCategories(dataGridView1, categoryIDGV, NameGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)     // code for UPDATE operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update selected record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();

                        if (activeDD.SelectedIndex == 0)    // status ACTIVE
                        {
                            stat = 1;
                        }
                        else if (activeDD.SelectedIndex == 1)   // status INACTIVE
                        {
                            stat = 0;
                        }

                        u.updateCategory(catID, categoryNameTxt.Text, stat);
                        r.showCategories(dataGridView1, categoryIDGV, NameGV, statusGV);
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
                    d.delete(catID, "st_deleteCategories", "@id");
                    r.showCategories(dataGridView1, categoryIDGV, NameGV, statusGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, categoryIDGV, NameGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["categoryIDGV"].Value.ToString());
                categoryNameTxt.Text = row.Cells["NameGV"].Value.ToString();
                activeDD.SelectedItem = row.Cells["statusGV"].Value.ToString();

                MainClass.disable(leftPanel);
            }
        }
    }
}
