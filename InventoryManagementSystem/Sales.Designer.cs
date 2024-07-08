namespace InventoryManagementSystem
{
    partial class Sales
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            label2 = new Label();
            barcodeTxt = new TextBox();
            dataGridView1 = new DataGridView();
            prodIDGV = new DataGridViewTextBoxColumn();
            prodNameGV = new DataGridViewTextBoxColumn();
            quantityGV = new DataGridViewTextBoxColumn();
            perUnitPriceGV = new DataGridViewTextBoxColumn();
            discGV = new DataGridViewTextBoxColumn();
            totalAmountGV = new DataGridViewTextBoxColumn();
            deleteGV = new DataGridViewButtonColumn();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            grossTotalLabel = new Label();
            label8 = new Label();
            lbl_remainingStock = new Label();
            tb_remainingStock = new TextBox();
            btn_pay = new Button();
            gb_pay = new GroupBox();
            btn_checkout = new Button();
            tb_changeGive = new TextBox();
            label7 = new Label();
            tb_amountGiven = new TextBox();
            label6 = new Label();
            cb_paymentType = new ComboBox();
            tb_totalDiscount = new TextBox();
            tb_grossTotal = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gb_pay.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 59);
            panel3.Margin = new Padding(1, 0, 1, 0);
            panel3.Size = new Size(1394, 38);
            // 
            // searchTxt
            // 
            searchTxt.Margin = new Padding(1, 0, 1, 0);
            searchTxt.Size = new Size(226, 21);
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 59);
            panel4.Size = new Size(245, 38);
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Size = new Size(50, 59);
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(gb_pay);
            leftPanel.Controls.Add(panel6);
            leftPanel.Controls.Add(tb_remainingStock);
            leftPanel.Controls.Add(lbl_remainingStock);
            leftPanel.Controls.Add(label2);
            leftPanel.Size = new Size(245, 794);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(lbl_remainingStock, 0);
            leftPanel.Controls.SetChildIndex(tb_remainingStock, 0);
            leftPanel.Controls.SetChildIndex(panel6, 0);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(gb_pay, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(panel5);
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Location = new Point(245, 0);
            rightPanel.Size = new Size(1394, 794);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            rightPanel.Controls.SetChildIndex(panel5, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(245, 59);
            // 
            // panel1
            // 
            panel1.Size = new Size(1394, 59);
            // 
            // label1
            // 
            label1.Location = new Point(-43, 0);
            label1.Size = new Size(288, 59);
            // 
            // userLabel
            // 
            userLabel.Size = new Size(370, 59);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 120);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 18);
            label2.TabIndex = 3;
            label2.Text = "Enter Barcode";
            // 
            // barcodeTxt
            // 
            barcodeTxt.Dock = DockStyle.Top;
            barcodeTxt.Font = new Font("Microsoft Sans Serif", 7F);
            barcodeTxt.Location = new Point(0, 0);
            barcodeTxt.Margin = new Padding(2, 1, 2, 1);
            barcodeTxt.MaxLength = 100;
            barcodeTxt.Name = "barcodeTxt";
            barcodeTxt.Size = new Size(222, 21);
            barcodeTxt.TabIndex = 4;
            barcodeTxt.TextChanged += barcodeTxt_TextChanged;
            barcodeTxt.Validating += barcodeTxt_Validating;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { prodIDGV, prodNameGV, quantityGV, perUnitPriceGV, discGV, totalAmountGV, deleteGV });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 97);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1394, 617);
            dataGridView1.TabIndex = 5;
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            perUnitPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            perUnitPriceGV.HeaderText = "Per Unit Price";
            perUnitPriceGV.MinimumWidth = 6;
            perUnitPriceGV.Name = "perUnitPriceGV";
            perUnitPriceGV.ReadOnly = true;
            // 
            // discGV
            // 
            discGV.HeaderText = "Discount";
            discGV.MinimumWidth = 6;
            discGV.Name = "discGV";
            discGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            totalAmountGV.DefaultCellStyle = dataGridViewCellStyle3;
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
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 714);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(1394, 80);
            panel5.TabIndex = 6;
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
            tableLayoutPanel2.Size = new Size(1394, 80);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // grossTotalLabel
            // 
            grossTotalLabel.Dock = DockStyle.Fill;
            grossTotalLabel.Font = new Font("Microsoft Sans Serif", 10F);
            grossTotalLabel.Location = new Point(970, 0);
            grossTotalLabel.Margin = new Padding(2, 0, 2, 0);
            grossTotalLabel.Name = "grossTotalLabel";
            grossTotalLabel.Size = new Size(422, 80);
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
            label8.Size = new Size(964, 80);
            label8.TabIndex = 18;
            label8.Text = "Gross Total";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_remainingStock
            // 
            lbl_remainingStock.AutoSize = true;
            lbl_remainingStock.Location = new Point(8, 179);
            lbl_remainingStock.Name = "lbl_remainingStock";
            lbl_remainingStock.Size = new Size(121, 18);
            lbl_remainingStock.TabIndex = 5;
            lbl_remainingStock.Text = "Remaining Stock";
            // 
            // tb_remainingStock
            // 
            tb_remainingStock.Enabled = false;
            tb_remainingStock.Font = new Font("Microsoft Sans Serif", 7F);
            tb_remainingStock.Location = new Point(4, 198);
            tb_remainingStock.Margin = new Padding(2, 1, 2, 1);
            tb_remainingStock.MaxLength = 100;
            tb_remainingStock.Name = "tb_remainingStock";
            tb_remainingStock.Size = new Size(222, 21);
            tb_remainingStock.TabIndex = 6;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.OrangeRed;
            btn_pay.Cursor = Cursors.Hand;
            btn_pay.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btn_pay.FlatAppearance.BorderSize = 2;
            btn_pay.FlatStyle = FlatStyle.Flat;
            btn_pay.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pay.ForeColor = Color.Snow;
            btn_pay.Location = new Point(24, 473);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(187, 63);
            btn_pay.TabIndex = 7;
            btn_pay.Text = "&PAY ";
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // gb_pay
            // 
            gb_pay.Controls.Add(btn_checkout);
            gb_pay.Controls.Add(tb_changeGive);
            gb_pay.Controls.Add(label7);
            gb_pay.Controls.Add(tb_amountGiven);
            gb_pay.Controls.Add(label6);
            gb_pay.Controls.Add(cb_paymentType);
            gb_pay.Controls.Add(tb_totalDiscount);
            gb_pay.Controls.Add(tb_grossTotal);
            gb_pay.Controls.Add(btn_pay);
            gb_pay.Controls.Add(label3);
            gb_pay.Controls.Add(label5);
            gb_pay.Controls.Add(label4);
            gb_pay.Dock = DockStyle.Bottom;
            gb_pay.ForeColor = Color.White;
            gb_pay.Location = new Point(0, 246);
            gb_pay.Name = "gb_pay";
            gb_pay.Size = new Size(245, 548);
            gb_pay.TabIndex = 8;
            gb_pay.TabStop = false;
            gb_pay.Text = "Payments";
            // 
            // btn_checkout
            // 
            btn_checkout.BackColor = Color.OrangeRed;
            btn_checkout.Cursor = Cursors.Hand;
            btn_checkout.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btn_checkout.FlatAppearance.BorderSize = 2;
            btn_checkout.FlatStyle = FlatStyle.Flat;
            btn_checkout.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_checkout.ForeColor = Color.Snow;
            btn_checkout.Location = new Point(24, 404);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(187, 63);
            btn_checkout.TabIndex = 20;
            btn_checkout.Text = "&CHECKOUT";
            btn_checkout.UseVisualStyleBackColor = false;
            btn_checkout.Click += btn_checkout_Click;
            // 
            // tb_changeGive
            // 
            tb_changeGive.Enabled = false;
            tb_changeGive.Location = new Point(12, 362);
            tb_changeGive.Name = "tb_changeGive";
            tb_changeGive.Size = new Size(216, 24);
            tb_changeGive.TabIndex = 19;
            tb_changeGive.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 341);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 18);
            label7.TabIndex = 18;
            label7.Text = "Change to give";
            label7.Click += label7_Click;
            // 
            // tb_amountGiven
            // 
            tb_amountGiven.Location = new Point(10, 290);
            tb_amountGiven.Name = "tb_amountGiven";
            tb_amountGiven.Size = new Size(216, 24);
            tb_amountGiven.TabIndex = 17;
            tb_amountGiven.TextChanged += tb_amountGiven_TextChanged;
            tb_amountGiven.Validating += tb_amountGiven_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 269);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 18);
            label6.TabIndex = 16;
            label6.Text = "Amount Given";
            // 
            // cb_paymentType
            // 
            cb_paymentType.FormattingEnabled = true;
            cb_paymentType.Items.AddRange(new object[] { "Cash", "Debit Card", "Credit Card" });
            cb_paymentType.Location = new Point(10, 216);
            cb_paymentType.Name = "cb_paymentType";
            cb_paymentType.Size = new Size(216, 26);
            cb_paymentType.TabIndex = 15;
            // 
            // tb_totalDiscount
            // 
            tb_totalDiscount.Enabled = false;
            tb_totalDiscount.Location = new Point(8, 146);
            tb_totalDiscount.Name = "tb_totalDiscount";
            tb_totalDiscount.Size = new Size(216, 24);
            tb_totalDiscount.TabIndex = 14;
            // 
            // tb_grossTotal
            // 
            tb_grossTotal.Enabled = false;
            tb_grossTotal.Location = new Point(10, 69);
            tb_grossTotal.Name = "tb_grossTotal";
            tb_grossTotal.Size = new Size(216, 24);
            tb_grossTotal.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 48);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 10;
            label3.Text = "Gross Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 195);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 18);
            label5.TabIndex = 12;
            label5.Text = "Payment Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 125);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 18);
            label4.TabIndex = 11;
            label4.Text = "Total Discount";
            // 
            // panel6
            // 
            panel6.Controls.Add(barcodeTxt);
            panel6.Location = new Point(4, 141);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 23);
            panel6.TabIndex = 9;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 794);
            Margin = new Padding(1, 0, 1, 0);
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            gb_pay.ResumeLayout(false);
            gb_pay.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox barcodeTxt;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label grossTotalLabel;
        private Label label8;
        private DataGridViewTextBoxColumn prodIDGV;
        private DataGridViewTextBoxColumn prodNameGV;
        private DataGridViewTextBoxColumn quantityGV;
        private DataGridViewTextBoxColumn perUnitPriceGV;
        private DataGridViewTextBoxColumn discGV;
        private DataGridViewTextBoxColumn totalAmountGV;
        private DataGridViewButtonColumn deleteGV;
        private Label lbl_remainingStock;
        private TextBox tb_remainingStock;
        private Button btn_pay;
        private GroupBox gb_pay;
        private Panel panel6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cb_paymentType;
        private TextBox tb_totalDiscount;
        private TextBox tb_grossTotal;
        private TextBox tb_changeGive;
        private Label label7;
        private TextBox tb_amountGiven;
        private Label label6;
        private Button btn_checkout;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}