namespace InventoryManagementSystem
{
    partial class Settings
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
            serverTxt = new TextBox();
            databaseTxt = new TextBox();
            label4 = new Label();
            userIDTxt = new TextBox();
            label5 = new Label();
            pswTxt = new TextBox();
            label6 = new Label();
            saveBtn = new Button();
            isCB = new CheckBox();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(isCB);
            leftPanel.Controls.Add(saveBtn);
            leftPanel.Controls.Add(pswTxt);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(userIDTxt);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(databaseTxt);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(serverTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Size = new Size(239, 696);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(serverTxt, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(databaseTxt, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(userIDTxt, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(pswTxt, 0);
            leftPanel.Controls.SetChildIndex(saveBtn, 0);
            leftPanel.Controls.SetChildIndex(isCB, 0);
            // 
            // rightPanel
            // 
            rightPanel.Location = new Point(239, 0);
            rightPanel.Margin = new Padding(2, 1, 2, 1);
            rightPanel.Size = new Size(1081, 696);
            // 
            // panel2
            // 
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Size = new Size(239, 59);
            // 
            // panel1
            // 
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Size = new Size(1081, 59);
            // 
            // label1
            // 
            label1.Location = new Point(54, 0);
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
            label3.Location = new Point(8, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 2;
            label3.Text = "Server";
            // 
            // serverTxt
            // 
            serverTxt.Location = new Point(6, 130);
            serverTxt.Margin = new Padding(2, 1, 2, 1);
            serverTxt.MaxLength = 50;
            serverTxt.Name = "serverTxt";
            serverTxt.Size = new Size(220, 24);
            serverTxt.TabIndex = 3;
            // 
            // databaseTxt
            // 
            databaseTxt.Location = new Point(6, 172);
            databaseTxt.Margin = new Padding(2, 1, 2, 1);
            databaseTxt.MaxLength = 50;
            databaseTxt.Name = "databaseTxt";
            databaseTxt.Size = new Size(220, 24);
            databaseTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 153);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 4;
            label4.Text = "Database";
            // 
            // userIDTxt
            // 
            userIDTxt.Location = new Point(6, 215);
            userIDTxt.Margin = new Padding(2, 1, 2, 1);
            userIDTxt.MaxLength = 30;
            userIDTxt.Name = "userIDTxt";
            userIDTxt.Size = new Size(220, 24);
            userIDTxt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 195);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 18);
            label5.TabIndex = 6;
            label5.Text = "User ID";
            // 
            // pswTxt
            // 
            pswTxt.Location = new Point(6, 257);
            pswTxt.Margin = new Padding(2, 1, 2, 1);
            pswTxt.MaxLength = 30;
            pswTxt.Name = "pswTxt";
            pswTxt.Size = new Size(220, 24);
            pswTxt.TabIndex = 9;
            pswTxt.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 237);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // saveBtn
            // 
            saveBtn.FlatAppearance.BorderColor = Color.White;
            saveBtn.FlatAppearance.BorderSize = 3;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Location = new Point(9, 336);
            saveBtn.Margin = new Padding(2, 1, 2, 1);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(217, 38);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += button1_Click;
            // 
            // isCB
            // 
            isCB.AutoSize = true;
            isCB.Location = new Point(8, 302);
            isCB.Margin = new Padding(2, 1, 2, 1);
            isCB.Name = "isCB";
            isCB.Size = new Size(151, 22);
            isCB.TabIndex = 11;
            isCB.Text = "Integrated Security";
            isCB.UseVisualStyleBackColor = true;
            isCB.CheckedChanged += isCB_CheckedChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 696);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Settings";
            Text = "Settings";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox pswTxt;
        private Label label6;
        private TextBox userIDTxt;
        private Label label5;
        private TextBox databaseTxt;
        private Label label4;
        private TextBox serverTxt;
        private Label label3;
        private CheckBox isCB;
        private Button saveBtn;
    }
}