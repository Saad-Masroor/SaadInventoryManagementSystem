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
    public partial class Login_Page : Sample
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (passwordTxt.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }

            if (nameErrorLabel.Visible || passwordErrorLabel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory.", "Stop", "Error");
            }
            else
            {
                if (Retrieval.getUserDetails(usernameTxt.Text, passwordTxt.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);
                }
                else
                {

                }
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
        }
    }
}
