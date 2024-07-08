namespace InventoryManagementSystem
{
    partial class Categories
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
            label4 = new Label();
            categoryNameTxt = new TextBox();
            label3 = new Label();
            categoryNameErrorLabel = new Label();
            activeErrorLabel = new Label();
            activeDD = new ComboBox();
            dataGridView1 = new DataGridView();
            categoryIDGV = new DataGridViewTextBoxColumn();
            NameGV = new DataGridViewTextBoxColumn();
            statusGV = new DataGridViewTextBoxColumn();
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
            panel3.Size = new Size(1274, 59);
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(1, 14);
            searchTxt.Margin = new Padding(1, 0, 1, 0);
            searchTxt.Size = new Size(210, 21);
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 59);
            panel4.Margin = new Padding(1, 0, 1, 0);
            panel4.Size = new Size(197, 34);
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Margin = new Padding(1, 0, 1, 0);
            backBtn.Size = new Size(61, 59);
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(activeDD);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(categoryNameTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(categoryNameErrorLabel);
            leftPanel.Controls.Add(activeErrorLabel);
            leftPanel.Size = new Size(197, 765);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(activeErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(categoryNameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(categoryNameTxt, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(activeDD, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Location = new Point(197, 0);
            rightPanel.Size = new Size(1274, 765);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // panel2
            // 
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Size = new Size(197, 59);
            // 
            // panel1
            // 
            panel1.Size = new Size(1274, 59);
            // 
            // label1
            // 
            label1.Location = new Point(12, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Size = new Size(185, 59);
            // 
            // userLabel
            // 
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Size = new Size(238, 59);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 162);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 22;
            label4.Text = "Is Active";
            // 
            // categoryNameTxt
            // 
            categoryNameTxt.Font = new Font("Microsoft Sans Serif", 7F);
            categoryNameTxt.Location = new Point(8, 140);
            categoryNameTxt.Margin = new Padding(2, 1, 2, 1);
            categoryNameTxt.Name = "categoryNameTxt";
            categoryNameTxt.Size = new Size(174, 21);
            categoryNameTxt.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 124);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 19;
            label3.Text = "Category Name";
            // 
            // categoryNameErrorLabel
            // 
            categoryNameErrorLabel.AutoSize = true;
            categoryNameErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryNameErrorLabel.ForeColor = Color.Aqua;
            categoryNameErrorLabel.Location = new Point(162, 124);
            categoryNameErrorLabel.Margin = new Padding(2, 0, 2, 0);
            categoryNameErrorLabel.Name = "categoryNameErrorLabel";
            categoryNameErrorLabel.Size = new Size(20, 25);
            categoryNameErrorLabel.TabIndex = 21;
            categoryNameErrorLabel.Text = "*";
            categoryNameErrorLabel.Visible = false;
            // 
            // activeErrorLabel
            // 
            activeErrorLabel.AutoSize = true;
            activeErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activeErrorLabel.ForeColor = Color.Aqua;
            activeErrorLabel.Location = new Point(162, 162);
            activeErrorLabel.Margin = new Padding(2, 0, 2, 0);
            activeErrorLabel.Name = "activeErrorLabel";
            activeErrorLabel.Size = new Size(20, 25);
            activeErrorLabel.TabIndex = 24;
            activeErrorLabel.Text = "*";
            activeErrorLabel.Visible = false;
            // 
            // activeDD
            // 
            activeDD.DropDownStyle = ComboBoxStyle.DropDownList;
            activeDD.Font = new Font("Microsoft Sans Serif", 7F);
            activeDD.FormattingEnabled = true;
            activeDD.Items.AddRange(new object[] { "Yes", "No" });
            activeDD.Location = new Point(8, 181);
            activeDD.Margin = new Padding(2, 1, 2, 1);
            activeDD.Name = "activeDD";
            activeDD.Size = new Size(176, 23);
            activeDD.TabIndex = 25;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { categoryIDGV, NameGV, statusGV });
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
            dataGridView1.Size = new Size(1274, 647);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // categoryIDGV
            // 
            categoryIDGV.HeaderText = "CategoryID";
            categoryIDGV.MinimumWidth = 6;
            categoryIDGV.Name = "categoryIDGV";
            categoryIDGV.ReadOnly = true;
            categoryIDGV.Visible = false;
            // 
            // NameGV
            // 
            NameGV.HeaderText = "Name";
            NameGV.MinimumWidth = 6;
            NameGV.Name = "NameGV";
            NameGV.ReadOnly = true;
            // 
            // statusGV
            // 
            statusGV.HeaderText = "Status";
            statusGV.MinimumWidth = 6;
            statusGV.Name = "statusGV";
            statusGV.ReadOnly = true;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 765);
            Margin = new Padding(1, 0, 1, 0);
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private TextBox categoryNameTxt;
        private Label label3;
        private Label categoryNameErrorLabel;
        private Label activeErrorLabel;
        private ComboBox activeDD;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn categoryIDGV;
        private DataGridViewTextBoxColumn NameGV;
        private DataGridViewTextBoxColumn statusGV;
    }
}