using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // saveBtn_click

            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCB.Checked)
            {
                if (serverTxt.Text != "" && databaseTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true";
                    File.WriteAllText(path+"\\connect", s);

                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login_Page log = new Login_Page();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all data to continue...");
                }
            }
            else
            {
                if (serverTxt.Text != "" && databaseTxt.Text != "" && userIDTxt.Text != "" && pswTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";User ID=" + userIDTxt.Text + ";Password=" + pswTxt.Text + ";MultipleActiveResultSets=true";
                    File.WriteAllText(path + "\\connect", s);

                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login_Page log = new Login_Page();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all data to continue...");
                }
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userIDTxt.Enabled = false;
                pswTxt.Enabled = false;
                userIDTxt.Text = "";
                pswTxt.Text = "";
            }
            else
            {
                userIDTxt.Enabled = true;
                pswTxt.Enabled = true;
            }
        }
    }
} 
