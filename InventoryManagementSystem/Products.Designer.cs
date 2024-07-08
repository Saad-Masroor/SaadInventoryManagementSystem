namespace InventoryManagementSystem
{
    partial class Products
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
            productTxt = new TextBox();
            prodNameErrorLabel = new Label();
            barcodeTxt = new TextBox();
            label4 = new Label();
            barcodeErrorLabel = new Label();
            label6 = new Label();
            expiryDatePicker = new DateTimePicker();
            expiryErrorLabel = new Label();
            label5 = new Label();
            categoryDD = new ComboBox();
            categoryErrorLabel = new Label();
            dataGridView1 = new DataGridView();
            prodIDGV = new DataGridViewTextBoxColumn();
            prodNameGV = new DataGridViewTextBoxColumn();
            barcodeGV = new DataGridViewTextBoxColumn();
            expiryGV = new DataGridViewTextBoxColumn();
            catGV = new DataGridViewTextBoxColumn();
            catIDGV = new DataGridViewTextBoxColumn();
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
            panel3.Size = new Size(1129, 38);
            // 
            // searchTxt
            // 
            searchTxt.Margin = new Padding(1, 0, 1, 0);
            searchTxt.Size = new Size(181, 21);
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
            leftPanel.Controls.Add(categoryDD);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(expiryDatePicker);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(barcodeTxt);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(productTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(prodNameErrorLabel);
            leftPanel.Controls.Add(barcodeErrorLabel);
            leftPanel.Controls.Add(expiryErrorLabel);
            leftPanel.Controls.Add(categoryErrorLabel);
            leftPanel.Size = new Size(193, 723);
            leftPanel.Controls.SetChildIndex(categoryErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(expiryErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(barcodeErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(prodNameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(productTxt, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(barcodeTxt, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(expiryDatePicker, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(panel2, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(categoryDD, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Location = new Point(193, 0);
            rightPanel.Size = new Size(1129, 723);
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
            panel1.Size = new Size(1129, 59);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 117);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 16);
            label3.TabIndex = 3;
            label3.Text = "Product Name";
            // 
            // productTxt
            // 
            productTxt.Font = new Font("Microsoft Sans Serif", 7F);
            productTxt.Location = new Point(11, 134);
            productTxt.Margin = new Padding(2, 1, 2, 1);
            productTxt.Name = "productTxt";
            productTxt.Size = new Size(174, 21);
            productTxt.TabIndex = 4;
            // 
            // prodNameErrorLabel
            // 
            prodNameErrorLabel.AutoSize = true;
            prodNameErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prodNameErrorLabel.ForeColor = Color.Aqua;
            prodNameErrorLabel.Location = new Point(164, 119);
            prodNameErrorLabel.Margin = new Padding(2, 0, 2, 0);
            prodNameErrorLabel.Name = "prodNameErrorLabel";
            prodNameErrorLabel.Size = new Size(20, 25);
            prodNameErrorLabel.TabIndex = 15;
            prodNameErrorLabel.Text = "*";
            prodNameErrorLabel.Visible = false;
            // 
            // barcodeTxt
            // 
            barcodeTxt.Font = new Font("Microsoft Sans Serif", 7F);
            barcodeTxt.Location = new Point(10, 172);
            barcodeTxt.Margin = new Padding(2, 1, 2, 1);
            barcodeTxt.Name = "barcodeTxt";
            barcodeTxt.Size = new Size(174, 21);
            barcodeTxt.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 156);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 16;
            label4.Text = "Barcode";
            // 
            // barcodeErrorLabel
            // 
            barcodeErrorLabel.AutoSize = true;
            barcodeErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcodeErrorLabel.ForeColor = Color.Aqua;
            barcodeErrorLabel.Location = new Point(164, 156);
            barcodeErrorLabel.Margin = new Padding(2, 0, 2, 0);
            barcodeErrorLabel.Name = "barcodeErrorLabel";
            barcodeErrorLabel.Size = new Size(20, 25);
            barcodeErrorLabel.TabIndex = 18;
            barcodeErrorLabel.Text = "*";
            barcodeErrorLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 194);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 16);
            label6.TabIndex = 19;
            label6.Text = "Expiry Date";
            // 
            // expiryDatePicker
            // 
            expiryDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiryDatePicker.CustomFormat = "dd-MMM-yyyy";
            expiryDatePicker.Font = new Font("Microsoft Sans Serif", 7F);
            expiryDatePicker.Format = DateTimePickerFormat.Custom;
            expiryDatePicker.Location = new Point(11, 210);
            expiryDatePicker.Margin = new Padding(2, 1, 2, 1);
            expiryDatePicker.Name = "expiryDatePicker";
            expiryDatePicker.Size = new Size(174, 21);
            expiryDatePicker.TabIndex = 20;
            // 
            // expiryErrorLabel
            // 
            expiryErrorLabel.AutoSize = true;
            expiryErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiryErrorLabel.ForeColor = Color.Aqua;
            expiryErrorLabel.Location = new Point(164, 194);
            expiryErrorLabel.Margin = new Padding(2, 0, 2, 0);
            expiryErrorLabel.Name = "expiryErrorLabel";
            expiryErrorLabel.Size = new Size(20, 25);
            expiryErrorLabel.TabIndex = 21;
            expiryErrorLabel.Text = "*";
            expiryErrorLabel.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 232);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 25;
            label5.Text = "Category";
            // 
            // categoryDD
            // 
            categoryDD.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryDD.Font = new Font("Microsoft Sans Serif", 7F);
            categoryDD.FormattingEnabled = true;
            categoryDD.Location = new Point(10, 248);
            categoryDD.Margin = new Padding(2, 1, 2, 1);
            categoryDD.Name = "categoryDD";
            categoryDD.Size = new Size(174, 23);
            categoryDD.TabIndex = 26;
            // 
            // categoryErrorLabel
            // 
            categoryErrorLabel.AutoSize = true;
            categoryErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryErrorLabel.ForeColor = Color.Aqua;
            categoryErrorLabel.Location = new Point(164, 232);
            categoryErrorLabel.Margin = new Padding(2, 0, 2, 0);
            categoryErrorLabel.Name = "categoryErrorLabel";
            categoryErrorLabel.Size = new Size(20, 25);
            categoryErrorLabel.TabIndex = 27;
            categoryErrorLabel.Text = "*";
            categoryErrorLabel.Visible = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { prodIDGV, prodNameGV, barcodeGV, expiryGV, catGV, catIDGV });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 97);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1129, 626);
            dataGridView1.TabIndex = 3;
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
            // catGV
            // 
            catGV.HeaderText = "Category";
            catGV.MinimumWidth = 6;
            catGV.Name = "catGV";
            catGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            catIDGV.HeaderText = "Category ID";
            catIDGV.MinimumWidth = 6;
            catIDGV.Name = "catIDGV";
            catIDGV.ReadOnly = true;
            catIDGV.Visible = false;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 723);
            Margin = new Padding(1, 0, 1, 0);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox productTxt;
        private Label label3;
        private Label prodNameErrorLabel;
        private DateTimePicker expiryDatePicker;
        private Label label6;
        private TextBox barcodeTxt;
        private Label label4;
        private Label barcodeErrorLabel;
        private Label expiryErrorLabel;
        private Label label5;
        private ComboBox categoryDD;
        private Label categoryErrorLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn prodIDGV;
        private DataGridViewTextBoxColumn prodNameGV;
        private DataGridViewTextBoxColumn barcodeGV;
        private DataGridViewTextBoxColumn expiryGV;
        private DataGridViewTextBoxColumn catGV;
        private DataGridViewTextBoxColumn catIDGV;
    }
}