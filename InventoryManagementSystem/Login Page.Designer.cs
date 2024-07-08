namespace InventoryManagementSystem
{
    partial class Login_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            label4 = new Label();
            loginBtn = new Button();
            nameErrorLabel = new Label();
            passwordErrorLabel = new Label();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(loginBtn);
            leftPanel.Controls.Add(passwordTxt);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(usernameTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(nameErrorLabel);
            leftPanel.Controls.Add(passwordErrorLabel);
            leftPanel.Margin = new Padding(1, 0, 1, 0);
            leftPanel.Size = new Size(258, 860);
            leftPanel.Controls.SetChildIndex(passwordErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(nameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(usernameTxt, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(passwordTxt, 0);
            leftPanel.Controls.SetChildIndex(loginBtn, 0);
            // 
            // rightPanel
            // 
            rightPanel.Location = new Point(258, 0);
            rightPanel.Margin = new Padding(1, 0, 1, 0);
            rightPanel.Size = new Size(1271, 860);
            // 
            // panel2
            // 
            panel2.Size = new Size(258, 29);
            // 
            // panel1
            // 
            panel1.Margin = new Padding(1, 0, 1, 0);
            panel1.Size = new Size(1271, 29);
            // 
            // label1
            // 
            label1.Location = new Point(73, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 176);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Microsoft Sans Serif", 7F);
            usernameTxt.Location = new Point(8, 204);
            usernameTxt.Margin = new Padding(2, 1, 2, 1);
            usernameTxt.MaxLength = 30;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(237, 21);
            usernameTxt.TabIndex = 3;
            usernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Microsoft Sans Serif", 7F);
            passwordTxt.Location = new Point(9, 255);
            passwordTxt.Margin = new Padding(2, 1, 2, 1);
            passwordTxt.MaxLength = 30;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(236, 21);
            passwordTxt.TabIndex = 5;
            passwordTxt.UseSystemPasswordChar = true;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 231);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.FlatAppearance.BorderColor = Color.White;
            loginBtn.FlatAppearance.BorderSize = 3;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Location = new Point(35, 297);
            loginBtn.Margin = new Padding(2, 1, 2, 1);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(175, 35);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameErrorLabel.ForeColor = Color.Aqua;
            nameErrorLabel.Location = new Point(89, 178);
            nameErrorLabel.Margin = new Padding(2, 0, 2, 0);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(20, 25);
            nameErrorLabel.TabIndex = 15;
            nameErrorLabel.Text = "*";
            nameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordErrorLabel.ForeColor = Color.Aqua;
            passwordErrorLabel.Location = new Point(87, 231);
            passwordErrorLabel.Margin = new Padding(2, 0, 2, 0);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(20, 25);
            passwordErrorLabel.TabIndex = 16;
            passwordErrorLabel.Text = "*";
            passwordErrorLabel.Visible = false;
            // 
            // Login_Page
            // 
            AcceptButton = loginBtn;
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 860);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login_Page";
            Text = "Login_Page";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox passwordTxt;
        private Label label4;
        private TextBox usernameTxt;
        private Label label3;
        private Button loginBtn;
        private Label nameErrorLabel;
        private Label passwordErrorLabel;
    }
}