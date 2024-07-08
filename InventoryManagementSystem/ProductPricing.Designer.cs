namespace InventoryManagementSystem
{
    partial class ProductPricing
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
            categoryDD = new ComboBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            selectGV = new DataGridViewCheckBoxColumn();
            prodIDGV = new DataGridViewTextBoxColumn();
            prodNameGV = new DataGridViewTextBoxColumn();
            buyingPriceGV = new DataGridViewTextBoxColumn();
            profitMarginGV = new DataGridViewTextBoxColumn();
            discountGV = new DataGridViewTextBoxColumn();
            finalPriceGV = new DataGridViewTextBoxColumn();
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
            panel3.Size = new Size(1264, 39);
            // 
            // searchTxt
            // 
            searchTxt.Margin = new Padding(1, 0, 1, 0);
            searchTxt.Size = new Size(206, 21);
            // 
            // panel4
            // 
            panel4.Size = new Size(193, 38);
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(categoryDD);
            leftPanel.Controls.Add(label5);
            leftPanel.Size = new Size(193, 727);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(categoryDD, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Location = new Point(193, 0);
            rightPanel.Size = new Size(1264, 727);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(193, 60);
            // 
            // panel1
            // 
            panel1.Size = new Size(1264, 59);
            // 
            // label1
            // 
            label1.Location = new Point(-95, 0);
            // 
            // userLabel
            // 
            userLabel.Size = new Size(370, 59);
            // 
            // categoryDD
            // 
            categoryDD.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryDD.Font = new Font("Microsoft Sans Serif", 7F);
            categoryDD.FormattingEnabled = true;
            categoryDD.Location = new Point(8, 133);
            categoryDD.Margin = new Padding(2, 1, 2, 1);
            categoryDD.Name = "categoryDD";
            categoryDD.Size = new Size(174, 23);
            categoryDD.TabIndex = 28;
            categoryDD.SelectedIndexChanged += categoryDD_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 117);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 27;
            label5.Text = "Category";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { selectGV, prodIDGV, prodNameGV, buyingPriceGV, profitMarginGV, discountGV, finalPriceGV });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 98);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1264, 629);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // selectGV
            // 
            selectGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            selectGV.FalseValue = "0";
            selectGV.HeaderText = "";
            selectGV.MinimumWidth = 6;
            selectGV.Name = "selectGV";
            selectGV.TrueValue = "1";
            selectGV.Width = 6;
            // 
            // prodIDGV
            // 
            prodIDGV.HeaderText = "Product ID";
            prodIDGV.MinimumWidth = 6;
            prodIDGV.Name = "prodIDGV";
            prodIDGV.Visible = false;
            // 
            // prodNameGV
            // 
            prodNameGV.HeaderText = "Product";
            prodNameGV.MinimumWidth = 6;
            prodNameGV.Name = "prodNameGV";
            // 
            // buyingPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            buyingPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            buyingPriceGV.HeaderText = "Buying Price";
            buyingPriceGV.MinimumWidth = 6;
            buyingPriceGV.Name = "buyingPriceGV";
            // 
            // profitMarginGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            profitMarginGV.DefaultCellStyle = dataGridViewCellStyle3;
            profitMarginGV.HeaderText = "Profit Margin %";
            profitMarginGV.MinimumWidth = 6;
            profitMarginGV.Name = "profitMarginGV";
            // 
            // discountGV
            // 
            discountGV.HeaderText = "Discount %";
            discountGV.MinimumWidth = 6;
            discountGV.Name = "discountGV";
            // 
            // finalPriceGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            finalPriceGV.DefaultCellStyle = dataGridViewCellStyle4;
            finalPriceGV.HeaderText = "Final Selling Price";
            finalPriceGV.MinimumWidth = 6;
            finalPriceGV.Name = "finalPriceGV";
            // 
            // ProductPricing
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 727);
            Margin = new Padding(1, 0, 1, 0);
            Name = "ProductPricing";
            Text = "Product Pricing";
            Load += ProductPricing_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox categoryDD;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn selectGV;
        private DataGridViewTextBoxColumn prodIDGV;
        private DataGridViewTextBoxColumn prodNameGV;
        private DataGridViewTextBoxColumn buyingPriceGV;
        private DataGridViewTextBoxColumn profitMarginGV;
        private DataGridViewTextBoxColumn discountGV;
        private DataGridViewTextBoxColumn finalPriceGV;
    }
}