namespace InventoryManagementSystem
{
    partial class Users
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label3 = new Label();
            nameTxt = new TextBox();
            usernameTxt = new TextBox();
            label4 = new Label();
            passTxt = new TextBox();
            label5 = new Label();
            phoneTxt = new TextBox();
            label6 = new Label();
            emailTxt = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            nameErrorLabel = new Label();
            usernameErrorLabel = new Label();
            passwordErrorLabel = new Label();
            phoneErrorLabel = new Label();
            emailErrorLabel = new Label();
            dataGridView1 = new DataGridView();
            userIDGV = new DataGridViewTextBoxColumn();
            NameGV = new DataGridViewTextBoxColumn();
            UsernameGV = new DataGridViewTextBoxColumn();
            PasswordGV = new DataGridViewTextBoxColumn();
            EmailGV = new DataGridViewTextBoxColumn();
            PhoneGV = new DataGridViewTextBoxColumn();
            statusGV = new DataGridViewTextBoxColumn();
            label8 = new Label();
            statusDD = new ComboBox();
            statusErrorLabel = new Label();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 59);
            panel3.Margin = new Padding(1, 0, 1, 0);
            panel3.Size = new Size(1279, 59);
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(1, 14);
            searchTxt.Margin = new Padding(1, 0, 1, 0);
            searchTxt.Size = new Size(210, 21);
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(1, 0, 1, 0);
            panel4.Size = new Size(206, 0);
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Margin = new Padding(1, 0, 1, 0);
            backBtn.Size = new Size(60, 59);
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(statusDD);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(emailTxt);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(phoneTxt);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(passTxt);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(usernameTxt);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(nameTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(nameErrorLabel);
            leftPanel.Controls.Add(usernameErrorLabel);
            leftPanel.Controls.Add(passwordErrorLabel);
            leftPanel.Controls.Add(phoneErrorLabel);
            leftPanel.Controls.Add(emailErrorLabel);
            leftPanel.Controls.Add(statusErrorLabel);
            leftPanel.Size = new Size(206, 786);
            leftPanel.Controls.SetChildIndex(statusErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(emailErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(phoneErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(passwordErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(usernameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(nameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(nameTxt, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(usernameTxt, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(passTxt, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(phoneTxt, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(emailTxt, 0);
            leftPanel.Controls.SetChildIndex(panel5, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(statusDD, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Location = new Point(206, 0);
            rightPanel.Size = new Size(1279, 786);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // panel2
            // 
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Size = new Size(206, 59);
            // 
            // panel1
            // 
            panel1.Size = new Size(1279, 59);
            // 
            // label1
            // 
            label1.Location = new Point(21, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Size = new Size(185, 59);
            // 
            // userLabel
            // 
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Size = new Size(238, 59);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Microsoft Sans Serif", 7F);
            nameTxt.Location = new Point(11, 143);
            nameTxt.Margin = new Padding(2, 1, 2, 1);
            nameTxt.MaxLength = 40;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(171, 21);
            nameTxt.TabIndex = 4;
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Microsoft Sans Serif", 7F);
            usernameTxt.Location = new Point(11, 181);
            usernameTxt.Margin = new Padding(2, 1, 2, 1);
            usernameTxt.MaxLength = 30;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(171, 21);
            usernameTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 165);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // passTxt
            // 
            passTxt.Font = new Font("Microsoft Sans Serif", 7F);
            passTxt.Location = new Point(12, 217);
            passTxt.Margin = new Padding(2, 1, 2, 1);
            passTxt.MaxLength = 30;
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(171, 21);
            passTxt.TabIndex = 8;
            passTxt.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 201);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // phoneTxt
            // 
            phoneTxt.Font = new Font("Microsoft Sans Serif", 7F);
            phoneTxt.Location = new Point(12, 256);
            phoneTxt.Margin = new Padding(2, 1, 2, 1);
            phoneTxt.MaxLength = 15;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(171, 21);
            phoneTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 239);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 16);
            label6.TabIndex = 9;
            label6.Text = "Phone (03XX-XXXXXXX)";
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Microsoft Sans Serif", 7F);
            emailTxt.Location = new Point(12, 303);
            emailTxt.Margin = new Padding(2, 1, 2, 1);
            emailTxt.MaxLength = 50;
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(171, 21);
            emailTxt.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 287);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 16);
            label7.TabIndex = 11;
            label7.Text = "Email";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 59);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(206, 38);
            panel5.TabIndex = 13;
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameErrorLabel.ForeColor = Color.Aqua;
            nameErrorLabel.Location = new Point(162, 127);
            nameErrorLabel.Margin = new Padding(2, 0, 2, 0);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(20, 25);
            nameErrorLabel.TabIndex = 14;
            nameErrorLabel.Text = "*";
            nameErrorLabel.Visible = false;
            nameErrorLabel.Click += label8_Click;
            // 
            // usernameErrorLabel
            // 
            usernameErrorLabel.AutoSize = true;
            usernameErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameErrorLabel.ForeColor = Color.Aqua;
            usernameErrorLabel.Location = new Point(163, 165);
            usernameErrorLabel.Margin = new Padding(2, 0, 2, 0);
            usernameErrorLabel.Name = "usernameErrorLabel";
            usernameErrorLabel.Size = new Size(20, 25);
            usernameErrorLabel.TabIndex = 15;
            usernameErrorLabel.Text = "*";
            usernameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordErrorLabel.ForeColor = Color.Aqua;
            passwordErrorLabel.Location = new Point(163, 203);
            passwordErrorLabel.Margin = new Padding(2, 0, 2, 0);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(20, 25);
            passwordErrorLabel.TabIndex = 16;
            passwordErrorLabel.Text = "*";
            passwordErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.AutoSize = true;
            phoneErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneErrorLabel.ForeColor = Color.Aqua;
            phoneErrorLabel.Location = new Point(163, 239);
            phoneErrorLabel.Margin = new Padding(2, 0, 2, 0);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(20, 25);
            phoneErrorLabel.TabIndex = 17;
            phoneErrorLabel.Text = "*";
            phoneErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailErrorLabel.ForeColor = Color.Aqua;
            emailErrorLabel.Location = new Point(163, 287);
            emailErrorLabel.Margin = new Padding(2, 0, 2, 0);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(20, 25);
            emailErrorLabel.TabIndex = 18;
            emailErrorLabel.Text = "*";
            emailErrorLabel.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkRed;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, statusGV });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 118);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1279, 668);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // userIDGV
            // 
            userIDGV.HeaderText = "UserID";
            userIDGV.MinimumWidth = 6;
            userIDGV.Name = "userIDGV";
            userIDGV.ReadOnly = true;
            userIDGV.Visible = false;
            // 
            // NameGV
            // 
            NameGV.HeaderText = "Name";
            NameGV.MinimumWidth = 6;
            NameGV.Name = "NameGV";
            NameGV.ReadOnly = true;
            // 
            // UsernameGV
            // 
            UsernameGV.HeaderText = "Username";
            UsernameGV.MinimumWidth = 6;
            UsernameGV.Name = "UsernameGV";
            UsernameGV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            PasswordGV.HeaderText = "Password";
            PasswordGV.MinimumWidth = 6;
            PasswordGV.Name = "PasswordGV";
            PasswordGV.ReadOnly = true;
            PasswordGV.Visible = false;
            // 
            // EmailGV
            // 
            EmailGV.HeaderText = "Email";
            EmailGV.MinimumWidth = 6;
            EmailGV.Name = "EmailGV";
            EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            PhoneGV.HeaderText = "Phone #";
            PhoneGV.MinimumWidth = 6;
            PhoneGV.Name = "PhoneGV";
            PhoneGV.ReadOnly = true;
            // 
            // statusGV
            // 
            statusGV.HeaderText = "Status";
            statusGV.MinimumWidth = 6;
            statusGV.Name = "statusGV";
            statusGV.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 336);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 16);
            label8.TabIndex = 19;
            label8.Text = "Status";
            // 
            // statusDD
            // 
            statusDD.DropDownStyle = ComboBoxStyle.DropDownList;
            statusDD.Font = new Font("Microsoft Sans Serif", 7F);
            statusDD.FormattingEnabled = true;
            statusDD.Items.AddRange(new object[] { "Active", "In-active" });
            statusDD.Location = new Point(12, 352);
            statusDD.Margin = new Padding(2, 1, 2, 1);
            statusDD.Name = "statusDD";
            statusDD.Size = new Size(171, 23);
            statusDD.TabIndex = 20;
            // 
            // statusErrorLabel
            // 
            statusErrorLabel.AutoSize = true;
            statusErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusErrorLabel.ForeColor = Color.Aqua;
            statusErrorLabel.Location = new Point(163, 336);
            statusErrorLabel.Margin = new Padding(2, 0, 2, 0);
            statusErrorLabel.Name = "statusErrorLabel";
            statusErrorLabel.Size = new Size(20, 25);
            statusErrorLabel.TabIndex = 21;
            statusErrorLabel.Text = "*";
            statusErrorLabel.Visible = false;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 786);
            Margin = new Padding(1, 0, 1, 0);
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameTxt;
        private Label label4;
        private TextBox nameTxt;
        private Label label3;
        private TextBox passTxt;
        private Label label5;
        private TextBox phoneTxt;
        private Label label6;
        private TextBox emailTxt;
        private Label label7;
        private Panel panel5;
        private Label nameErrorLabel;
        private Label usernameErrorLabel;
        private Label passwordErrorLabel;
        private Label phoneErrorLabel;
        private Label emailErrorLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userIDGV;
        private DataGridViewTextBoxColumn NameGV;
        private DataGridViewTextBoxColumn UsernameGV;
        private DataGridViewTextBoxColumn PasswordGV;
        private DataGridViewTextBoxColumn EmailGV;
        private DataGridViewTextBoxColumn PhoneGV;
        private DataGridViewTextBoxColumn statusGV;
        private Label label8;
        private ComboBox statusDD;
        private Label statusErrorLabel;
    }
}