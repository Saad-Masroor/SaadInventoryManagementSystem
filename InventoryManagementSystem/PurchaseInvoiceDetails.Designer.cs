namespace InventoryManagementSystem
{
    partial class PurchaseInvoiceDetails
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
            label2 = new Label();
            datePicker = new DateTimePicker();
            label3 = new Label();
            purchaseInvoiceDD = new ComboBox();
            dataGridView1 = new DataGridView();
            mPIDGV = new DataGridViewTextBoxColumn();
            prodIDGV = new DataGridViewTextBoxColumn();
            prodNameGV = new DataGridViewTextBoxColumn();
            quantityGV = new DataGridViewTextBoxColumn();
            perUnitPriceGV = new DataGridViewTextBoxColumn();
            totalAmountGV = new DataGridViewTextBoxColumn();
            deleteGV = new DataGridViewButtonColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            grossTotalLabel = new Label();
            label8 = new Label();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 59);
            panel3.Margin = new Padding(1, 0, 1, 0);
            panel3.Size = new Size(1211, 40);
            // 
            // searchTxt
            // 
            searchTxt.Margin = new Padding(1, 0, 1, 0);
            searchTxt.Size = new Size(198, 21);
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
            leftPanel.Controls.Add(purchaseInvoiceDD);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(datePicker);
            leftPanel.Controls.Add(label2);
            leftPanel.Size = new Size(193, 777);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(datePicker, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(purchaseInvoiceDD, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(tableLayoutPanel2);
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Location = new Point(193, 0);
            rightPanel.Size = new Size(1211, 777);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(panel3, 0);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            rightPanel.Controls.SetChildIndex(tableLayoutPanel2, 0);
            // 
            // panel2
            // 
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Size = new Size(193, 59);
            // 
            // panel1
            // 
            panel1.Size = new Size(1211, 59);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 16);
            label2.TabIndex = 3;
            label2.Text = "Select Date";
            // 
            // datePicker
            // 
            datePicker.CalendarFont = new Font("Microsoft Sans Serif", 7F);
            datePicker.CustomFormat = "MMMM-     yyyy";
            datePicker.Font = new Font("Microsoft Sans Serif", 7F);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(11, 134);
            datePicker.Margin = new Padding(2, 1, 2, 1);
            datePicker.Name = "datePicker";
            datePicker.ShowUpDown = true;
            datePicker.Size = new Size(170, 21);
            datePicker.TabIndex = 4;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 166);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 16);
            label3.TabIndex = 5;
            label3.Text = "Select Purchase Invoice";
            label3.Click += label3_Click;
            // 
            // purchaseInvoiceDD
            // 
            purchaseInvoiceDD.DropDownStyle = ComboBoxStyle.DropDownList;
            purchaseInvoiceDD.Font = new Font("Microsoft Sans Serif", 7F);
            purchaseInvoiceDD.FormattingEnabled = true;
            purchaseInvoiceDD.Location = new Point(11, 182);
            purchaseInvoiceDD.Margin = new Padding(2, 1, 2, 1);
            purchaseInvoiceDD.Name = "purchaseInvoiceDD";
            purchaseInvoiceDD.Size = new Size(170, 23);
            purchaseInvoiceDD.TabIndex = 6;
            purchaseInvoiceDD.SelectedIndexChanged += purchaseInvoiceDD_SelectedIndexChanged;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { mPIDGV, prodIDGV, prodNameGV, quantityGV, perUnitPriceGV, totalAmountGV, deleteGV });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 99);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1211, 650);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // mPIDGV
            // 
            mPIDGV.HeaderText = "mPIDGV";
            mPIDGV.MinimumWidth = 6;
            mPIDGV.Name = "mPIDGV";
            mPIDGV.ReadOnly = true;
            mPIDGV.Visible = false;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.46342F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5365849F));
            tableLayoutPanel2.Controls.Add(grossTotalLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 749);
            tableLayoutPanel2.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1211, 28);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // grossTotalLabel
            // 
            grossTotalLabel.Dock = DockStyle.Fill;
            grossTotalLabel.Font = new Font("Microsoft Sans Serif", 10F);
            grossTotalLabel.Location = new Point(843, 0);
            grossTotalLabel.Margin = new Padding(2, 0, 2, 0);
            grossTotalLabel.Name = "grossTotalLabel";
            grossTotalLabel.Size = new Size(366, 28);
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
            label8.Size = new Size(837, 28);
            label8.TabIndex = 18;
            label8.Text = "Gross Total";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PurchaseInvoiceDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 777);
            Margin = new Padding(1, 0, 1, 0);
            Name = "PurchaseInvoiceDetails";
            Text = "Purchase Invoice Details";
            Load += PurchaseInvoiceDetails_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker datePicker;
        private Label label2;
        private ComboBox purchaseInvoiceDD;
        private Label label3;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label grossTotalLabel;
        private Label label8;
        private DataGridViewTextBoxColumn mPIDGV;
        private DataGridViewTextBoxColumn prodIDGV;
        private DataGridViewTextBoxColumn prodNameGV;
        private DataGridViewTextBoxColumn quantityGV;
        private DataGridViewTextBoxColumn perUnitPriceGV;
        private DataGridViewTextBoxColumn totalAmountGV;
        private DataGridViewButtonColumn deleteGV;
    }
}