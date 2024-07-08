namespace InventoryManagementSystem
{
    partial class PurchaseInvoice
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
            label2 = new Label();
            supplierDD = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            unitPriceTxt = new TextBox();
            productTxt = new TextBox();
            barcodeTxt = new TextBox();
            quantityTxt = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            prodIDGV = new DataGridViewTextBoxColumn();
            prodNameGV = new DataGridViewTextBoxColumn();
            quantityGV = new DataGridViewTextBoxColumn();
            perUnitPriceGV = new DataGridViewTextBoxColumn();
            totalAmountGV = new DataGridViewTextBoxColumn();
            deleteGV = new DataGridViewButtonColumn();
            cartBtn = new Button();
            label7 = new Label();
            totalAmountLabel = new Label();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            grossTotalLabel = new Label();
            label8 = new Label();
            supplierErrorLabel = new Label();
            barcodeErrorLabel = new Label();
            quantityErrorLabel = new Label();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 59);
            panel3.Margin = new Padding(1, 0, 1, 0);
            panel3.Size = new Size(1292, 38);
            // 
            // searchTxt
            // 
            searchTxt.Margin = new Padding(1, 0, 1, 0);
            searchTxt.Size = new Size(209, 21);
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
            leftPanel.Controls.Add(totalAmountLabel);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(cartBtn);
            leftPanel.Controls.Add(quantityTxt);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(barcodeTxt);
            leftPanel.Controls.Add(productTxt);
            leftPanel.Controls.Add(unitPriceTxt);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(supplierDD);
            leftPanel.Controls.Add(label2);
            leftPanel.Controls.Add(supplierErrorLabel);
            leftPanel.Controls.Add(barcodeErrorLabel);
            leftPanel.Controls.Add(quantityErrorLabel);
            leftPanel.Size = new Size(193, 780);
            leftPanel.Controls.SetChildIndex(quantityErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(barcodeErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(supplierErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(supplierDD, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(unitPriceTxt, 0);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(productTxt, 0);
            leftPanel.Controls.SetChildIndex(barcodeTxt, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(quantityTxt, 0);
            leftPanel.Controls.SetChildIndex(cartBtn, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(totalAmountLabel, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(panel5);
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Location = new Point(193, 0);
            rightPanel.Size = new Size(1292, 780);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            rightPanel.Controls.SetChildIndex(panel5, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(193, 60);
            // 
            // panel1
            // 
            panel1.Size = new Size(1292, 59);
            // 
            // label1
            // 
            label1.Location = new Point(-95, 0);
            // 
            // userLabel
            // 
            userLabel.Size = new Size(370, 59);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7F);
            label2.Location = new Point(8, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Select Supplier";
            // 
            // supplierDD
            // 
            supplierDD.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierDD.Font = new Font("Microsoft Sans Serif", 7F);
            supplierDD.FormattingEnabled = true;
            supplierDD.Location = new Point(5, 136);
            supplierDD.Margin = new Padding(2, 1, 2, 1);
            supplierDD.Name = "supplierDD";
            supplierDD.Size = new Size(177, 23);
            supplierDD.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7F);
            label3.Location = new Point(4, 160);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Barcode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7F);
            label4.Location = new Point(5, 208);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 7F);
            label5.Location = new Point(5, 256);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 9;
            label5.Text = "Per Unit Price";
            // 
            // unitPriceTxt
            // 
            unitPriceTxt.Font = new Font("Microsoft Sans Serif", 7F);
            unitPriceTxt.Location = new Point(6, 281);
            unitPriceTxt.Margin = new Padding(2, 1, 2, 1);
            unitPriceTxt.Name = "unitPriceTxt";
            unitPriceTxt.Size = new Size(175, 21);
            unitPriceTxt.TabIndex = 3;
            unitPriceTxt.TextChanged += unitPriceTxt_TextChanged;
            // 
            // productTxt
            // 
            productTxt.Font = new Font("Microsoft Sans Serif", 7F);
            productTxt.Location = new Point(6, 234);
            productTxt.Margin = new Padding(2, 1, 2, 1);
            productTxt.Name = "productTxt";
            productTxt.Size = new Size(175, 21);
            productTxt.TabIndex = 2;
            productTxt.TextChanged += productTxt_TextChanged;
            // 
            // barcodeTxt
            // 
            barcodeTxt.Font = new Font("Microsoft Sans Serif", 7F);
            barcodeTxt.Location = new Point(5, 186);
            barcodeTxt.Margin = new Padding(2, 1, 2, 1);
            barcodeTxt.Name = "barcodeTxt";
            barcodeTxt.Size = new Size(175, 21);
            barcodeTxt.TabIndex = 1;
            barcodeTxt.TextChanged += barcodeTxt_TextChanged;
            barcodeTxt.Validating += barcodeTxt_Validating;
            barcodeTxt.Validated += barcodeTxt_Validated;
            // 
            // quantityTxt
            // 
            quantityTxt.Font = new Font("Microsoft Sans Serif", 7F);
            quantityTxt.Location = new Point(7, 329);
            quantityTxt.Margin = new Padding(2, 1, 2, 1);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(175, 21);
            quantityTxt.TabIndex = 4;
            quantityTxt.TextChanged += quantityTxt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 7F);
            label6.Location = new Point(6, 303);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 14;
            label6.Text = "Quantity";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { prodIDGV, prodNameGV, quantityGV, perUnitPriceGV, totalAmountGV, deleteGV });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 97);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1292, 650);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // perUnitPriceGV
            // 
            perUnitPriceGV.HeaderText = "Per Unit Price";
            perUnitPriceGV.MinimumWidth = 6;
            perUnitPriceGV.Name = "perUnitPriceGV";
            perUnitPriceGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            totalAmountGV.HeaderText = "Total Amount";
            totalAmountGV.MinimumWidth = 6;
            totalAmountGV.Name = "totalAmountGV";
            totalAmountGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            deleteGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            deleteGV.HeaderText = "Action";
            deleteGV.MinimumWidth = 6;
            deleteGV.Name = "deleteGV";
            deleteGV.ReadOnly = true;
            deleteGV.Text = "DELETE";
            deleteGV.UseColumnTextForButtonValue = true;
            // 
            // cartBtn
            // 
            cartBtn.Cursor = Cursors.Hand;
            cartBtn.FlatAppearance.BorderSize = 3;
            cartBtn.FlatStyle = FlatStyle.Flat;
            cartBtn.Font = new Font("Microsoft Sans Serif", 7F);
            cartBtn.Location = new Point(8, 365);
            cartBtn.Margin = new Padding(2, 1, 2, 1);
            cartBtn.Name = "cartBtn";
            cartBtn.Size = new Size(174, 46);
            cartBtn.TabIndex = 5;
            cartBtn.Text = "ADD TO CART";
            cartBtn.UseVisualStyleBackColor = true;
            cartBtn.Click += cartBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 7F);
            label7.Location = new Point(8, 412);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 16;
            label7.Text = "Total Amount";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Microsoft Sans Serif", 10F);
            totalAmountLabel.Location = new Point(67, 427);
            totalAmountLabel.Margin = new Padding(2, 0, 2, 0);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(40, 20);
            totalAmountLabel.TabIndex = 17;
            totalAmountLabel.Text = "0.00";
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 747);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(1292, 33);
            panel5.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.46342F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5365849F));
            tableLayoutPanel2.Controls.Add(grossTotalLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1292, 33);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // grossTotalLabel
            // 
            grossTotalLabel.Dock = DockStyle.Fill;
            grossTotalLabel.Font = new Font("Microsoft Sans Serif", 10F);
            grossTotalLabel.Location = new Point(899, 0);
            grossTotalLabel.Margin = new Padding(2, 0, 2, 0);
            grossTotalLabel.Name = "grossTotalLabel";
            grossTotalLabel.Size = new Size(391, 33);
            grossTotalLabel.TabIndex = 18;
            grossTotalLabel.Text = "0.00";
            grossTotalLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Microsoft Sans Serif", 10F);
            label8.Location = new Point(2, 0);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(893, 33);
            label8.TabIndex = 18;
            label8.Text = "Gross Total";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // supplierErrorLabel
            // 
            supplierErrorLabel.AutoSize = true;
            supplierErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierErrorLabel.ForeColor = Color.Aqua;
            supplierErrorLabel.Location = new Point(102, 110);
            supplierErrorLabel.Margin = new Padding(2, 0, 2, 0);
            supplierErrorLabel.Name = "supplierErrorLabel";
            supplierErrorLabel.Size = new Size(20, 25);
            supplierErrorLabel.TabIndex = 18;
            supplierErrorLabel.Text = "*";
            supplierErrorLabel.Visible = false;
            // 
            // barcodeErrorLabel
            // 
            barcodeErrorLabel.AutoSize = true;
            barcodeErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcodeErrorLabel.ForeColor = Color.Aqua;
            barcodeErrorLabel.Location = new Point(61, 160);
            barcodeErrorLabel.Margin = new Padding(2, 0, 2, 0);
            barcodeErrorLabel.Name = "barcodeErrorLabel";
            barcodeErrorLabel.Size = new Size(20, 25);
            barcodeErrorLabel.TabIndex = 19;
            barcodeErrorLabel.Text = "*";
            barcodeErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            quantityErrorLabel.AutoSize = true;
            quantityErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityErrorLabel.ForeColor = Color.Aqua;
            quantityErrorLabel.Location = new Point(61, 303);
            quantityErrorLabel.Margin = new Padding(2, 0, 2, 0);
            quantityErrorLabel.Name = "quantityErrorLabel";
            quantityErrorLabel.Size = new Size(20, 25);
            quantityErrorLabel.TabIndex = 20;
            quantityErrorLabel.Text = "*";
            quantityErrorLabel.Visible = false;
            // 
            // PurchaseInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 780);
            Margin = new Padding(1, 0, 1, 0);
            Name = "PurchaseInvoice";
            Text = "PurchaseInvoice";
            Load += PurchaseInvoice_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox supplierDD;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox barcodeTxt;
        private TextBox productTxt;
        private TextBox unitPriceTxt;
        private TextBox quantityTxt;
        private Label label6;
        private DataGridView dataGridView1;
        private Button cartBtn;
        private Label label7;
        private Label totalAmountLabel;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label grossTotalLabel;
        private Label label8;
        private Label supplierErrorLabel;
        private Label barcodeErrorLabel;
        private Label quantityErrorLabel;
        private DataGridViewTextBoxColumn prodIDGV;
        private DataGridViewTextBoxColumn prodNameGV;
        private DataGridViewTextBoxColumn quantityGV;
        private DataGridViewTextBoxColumn perUnitPriceGV;
        private DataGridViewTextBoxColumn totalAmountGV;
        private DataGridViewButtonColumn deleteGV;
    }
}