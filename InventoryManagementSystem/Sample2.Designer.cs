namespace InventoryManagementSystem
{
    partial class Sample2
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
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            deleteBtn = new Button();
            saveBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            groupBox1 = new GroupBox();
            searchTxt = new TextBox();
            viewBtn = new Button();
            panel4 = new Panel();
            backBtn = new Button();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(panel4);
            leftPanel.Margin = new Padding(1, 0, 1, 0);
            leftPanel.Size = new Size(247, 776);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(panel3);
            rightPanel.Location = new Point(247, 0);
            rightPanel.Margin = new Padding(1, 0, 1, 0);
            rightPanel.Size = new Size(1096, 776);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(backBtn);
            panel2.Size = new Size(247, 60);
            panel2.Controls.SetChildIndex(label1, 0);
            panel2.Controls.SetChildIndex(backBtn, 0);
            // 
            // panel1
            // 
            panel1.Margin = new Padding(1, 0, 1, 0);
            panel1.Size = new Size(1096, 60);
            // 
            // label1
            // 
            label1.Location = new Point(-41, 0);
            // 
            // panel3
            // 
            panel3.BackColor = Color.Bisque;
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 60);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1096, 38);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(deleteBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(saveBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(editBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(addBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 5, 0);
            tableLayoutPanel1.Controls.Add(viewBtn, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1096, 38);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Dock = DockStyle.Fill;
            deleteBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            deleteBtn.FlatAppearance.BorderSize = 2;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(548, 1);
            deleteBtn.Margin = new Padding(2, 1, 2, 1);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(178, 36);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Dock = DockStyle.Fill;
            saveBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(366, 1);
            saveBtn.Margin = new Padding(2, 1, 2, 1);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(178, 36);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Cursor = Cursors.Hand;
            editBtn.Dock = DockStyle.Fill;
            editBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            editBtn.FlatAppearance.BorderSize = 2;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBtn.Location = new Point(184, 1);
            editBtn.Margin = new Padding(2, 1, 2, 1);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(178, 36);
            editBtn.TabIndex = 1;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Dock = DockStyle.Fill;
            addBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            addBtn.FlatAppearance.BorderSize = 2;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(2, 1);
            addBtn.Margin = new Padding(2, 1, 2, 1);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(178, 36);
            addBtn.TabIndex = 0;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchTxt);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(912, 1);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(182, 36);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SEARCH";
            // 
            // searchTxt
            // 
            searchTxt.Dock = DockStyle.Fill;
            searchTxt.Location = new Point(2, 15);
            searchTxt.Margin = new Padding(2, 1, 2, 1);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(178, 21);
            searchTxt.TabIndex = 0;
            searchTxt.TextChanged += searchTxt_TextChanged;
            // 
            // viewBtn
            // 
            viewBtn.Cursor = Cursors.Hand;
            viewBtn.Dock = DockStyle.Fill;
            viewBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            viewBtn.FlatAppearance.BorderSize = 2;
            viewBtn.FlatStyle = FlatStyle.Flat;
            viewBtn.Font = new Font("Microsoft Sans Serif", 7F);
            viewBtn.Location = new Point(730, 1);
            viewBtn.Margin = new Padding(2, 1, 2, 1);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(178, 36);
            viewBtn.TabIndex = 5;
            viewBtn.Text = "VIEW";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 60);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 38);
            panel4.TabIndex = 2;
            // 
            // backBtn
            // 
            backBtn.Dock = DockStyle.Left;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Image = Properties.Resources.backBtn1;
            backBtn.Location = new Point(0, 0);
            backBtn.Margin = new Padding(2, 1, 2, 1);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(50, 60);
            backBtn.TabIndex = 2;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // Sample2
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 776);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Sample2";
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Panel panel3;
        protected TableLayoutPanel tableLayoutPanel1;
        protected Button addBtn;
        protected Button deleteBtn;
        protected Button saveBtn;
        protected Button editBtn;
        protected GroupBox groupBox1;
        protected TextBox searchTxt;
        protected Panel panel4;
        protected Button backBtn;
        protected Button viewBtn;
    }
}