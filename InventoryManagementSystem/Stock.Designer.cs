namespace InventoryManagementSystem
{
    partial class Stock
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            prodIDGV = new DataGridViewTextBoxColumn();
            prodNameGV = new DataGridViewTextBoxColumn();
            quantityGV = new DataGridViewTextBoxColumn();
            barcodeGV = new DataGridViewTextBoxColumn();
            expiryGV = new DataGridViewTextBoxColumn();
            bpGV = new DataGridViewTextBoxColumn();
            spGV = new DataGridViewTextBoxColumn();
            catGV = new DataGridViewTextBoxColumn();
            finalGV = new DataGridViewTextBoxColumn();
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
            panel3.Size = new Size(1226, 38);
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(1, 14);
            searchTxt.Margin = new Padding(1, 0, 1, 0);
            searchTxt.Size = new Size(202, 21);
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 59);
            panel4.Margin = new Padding(1, 0, 1, 0);
            panel4.Size = new Size(193, 39);
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Margin = new Padding(1, 0, 1, 0);
            backBtn.Size = new Size(32, 59);
            // 
            // leftPanel
            // 
            leftPanel.Size = new Size(193, 777);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Location = new Point(193, 0);
            rightPanel.Size = new Size(1226, 777);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // panel2
            // 
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Size = new Size(193, 59);
            // 
            // panel1
            // 
            panel1.Size = new Size(1226, 59);
            // 
            // label1
            // 
            label1.Location = new Point(8, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Size = new Size(185, 59);
            // 
            // userLabel
            // 
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Size = new Size(238, 59);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { prodIDGV, prodNameGV, quantityGV, barcodeGV, expiryGV, bpGV, spGV, catGV, finalGV, statusGV });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 97);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1226, 680);
            dataGridView1.TabIndex = 5;
            // 
            // prodIDGV
            // 
            prodIDGV.HeaderText = "Product ID";
            prodIDGV.MinimumWidth = 6;
            prodIDGV.Name = "prodIDGV";
            prodIDGV.ReadOnly = true;
            prodIDGV.Visible = false;
            // 
            // prodNameGV
            // 
            prodNameGV.HeaderText = "Product";
            prodNameGV.MinimumWidth = 6;
            prodNameGV.Name = "prodNameGV";
            prodNameGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            quantityGV.HeaderText = "Quantity";
            quantityGV.MinimumWidth = 6;
            quantityGV.Name = "quantityGV";
            quantityGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            barcodeGV.HeaderText = "Barcode";
            barcodeGV.MinimumWidth = 6;
            barcodeGV.Name = "barcodeGV";
            barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            expiryGV.HeaderText = "Expiry Date";
            expiryGV.MinimumWidth = 6;
            expiryGV.Name = "expiryGV";
            expiryGV.ReadOnly = true;
            // 
            // bpGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            bpGV.DefaultCellStyle = dataGridViewCellStyle2;
            bpGV.HeaderText = "Buying Price";
            bpGV.MinimumWidth = 6;
            bpGV.Name = "bpGV";
            bpGV.ReadOnly = true;
            // 
            // spGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            spGV.DefaultCellStyle = dataGridViewCellStyle3;
            spGV.HeaderText = "Selling Price";
            spGV.MinimumWidth = 6;
            spGV.Name = "spGV";
            spGV.ReadOnly = true;
            // 
            // catGV
            // 
            catGV.HeaderText = "Category";
            catGV.MinimumWidth = 6;
            catGV.Name = "catGV";
            catGV.ReadOnly = true;
            // 
            // finalGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            finalGV.DefaultCellStyle = dataGridViewCellStyle4;
            finalGV.HeaderText = "Total Amount";
            finalGV.MinimumWidth = 6;
            finalGV.Name = "finalGV";
            finalGV.ReadOnly = true;
            // 
            // statusGV
            // 
            statusGV.HeaderText = "Status";
            statusGV.MinimumWidth = 6;
            statusGV.Name = "statusGV";
            statusGV.ReadOnly = true;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 777);
            Margin = new Padding(1, 0, 1, 0);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn prodIDGV;
        private DataGridViewTextBoxColumn prodNameGV;
        private DataGridViewTextBoxColumn quantityGV;
        private DataGridViewTextBoxColumn barcodeGV;
        private DataGridViewTextBoxColumn expiryGV;
        private DataGridViewTextBoxColumn bpGV;
        private DataGridViewTextBoxColumn spGV;
        private DataGridViewTextBoxColumn catGV;
        private DataGridViewTextBoxColumn finalGV;
        private DataGridViewTextBoxColumn statusGV;
    }
}