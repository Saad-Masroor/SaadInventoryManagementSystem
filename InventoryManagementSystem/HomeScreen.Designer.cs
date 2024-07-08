namespace InventoryManagementSystem
{
    partial class HomeScreen
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
            tableLayoutPanel1 = new TableLayoutPanel();
            salesBtn = new Button();
            purchaseInvoiceBtn = new Button();
            stockBtn = new Button();
            productBtn = new Button();
            userBtn = new Button();
            prodCategoriesBtn = new Button();
            supplierBtn = new Button();
            prodPricingBtn = new Button();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Margin = new Padding(1, 0, 1, 0);
            leftPanel.Size = new Size(193, 830);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(tableLayoutPanel1);
            rightPanel.Location = new Point(193, 0);
            rightPanel.Margin = new Padding(1, 0, 1, 0);
            rightPanel.Size = new Size(1301, 830);
            rightPanel.Controls.SetChildIndex(panel1, 0);
            rightPanel.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(193, 60);
            // 
            // panel1
            // 
            panel1.Margin = new Padding(1, 0, 1, 0);
            panel1.Size = new Size(1301, 59);
            // 
            // label1
            // 
            label1.Location = new Point(-95, 0);
            // 
            // userLabel
            // 
            userLabel.Size = new Size(370, 59);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(salesBtn, 4, 0);
            tableLayoutPanel1.Controls.Add(purchaseInvoiceBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(stockBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(productBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(userBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(prodCategoriesBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(supplierBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(prodPricingBtn, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 59);
            tableLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1301, 771);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // salesBtn
            // 
            salesBtn.Cursor = Cursors.Hand;
            salesBtn.Dock = DockStyle.Fill;
            salesBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            salesBtn.FlatAppearance.BorderSize = 2;
            salesBtn.FlatStyle = FlatStyle.Flat;
            salesBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesBtn.Image = Properties.Resources.SalesIcon_removebg_preview;
            salesBtn.Location = new Point(1042, 1);
            salesBtn.Margin = new Padding(2, 1, 2, 1);
            salesBtn.Name = "salesBtn";
            salesBtn.Size = new Size(257, 152);
            salesBtn.TabIndex = 4;
            salesBtn.Text = "Sales";
            salesBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            salesBtn.UseVisualStyleBackColor = true;
            salesBtn.Click += salesBtn_Click;
            // 
            // purchaseInvoiceBtn
            // 
            purchaseInvoiceBtn.Cursor = Cursors.Hand;
            purchaseInvoiceBtn.Dock = DockStyle.Fill;
            purchaseInvoiceBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            purchaseInvoiceBtn.FlatAppearance.BorderSize = 2;
            purchaseInvoiceBtn.FlatStyle = FlatStyle.Flat;
            purchaseInvoiceBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchaseInvoiceBtn.Image = Properties.Resources.InvoiceIcon_removebg_preview;
            purchaseInvoiceBtn.Location = new Point(782, 1);
            purchaseInvoiceBtn.Margin = new Padding(2, 1, 2, 1);
            purchaseInvoiceBtn.Name = "purchaseInvoiceBtn";
            purchaseInvoiceBtn.Size = new Size(256, 152);
            purchaseInvoiceBtn.TabIndex = 3;
            purchaseInvoiceBtn.Text = "Product Invoice";
            purchaseInvoiceBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            purchaseInvoiceBtn.UseVisualStyleBackColor = true;
            purchaseInvoiceBtn.Click += purchaseInvoiceBtn_Click;
            // 
            // stockBtn
            // 
            stockBtn.Cursor = Cursors.Hand;
            stockBtn.Dock = DockStyle.Fill;
            stockBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            stockBtn.FlatAppearance.BorderSize = 2;
            stockBtn.FlatStyle = FlatStyle.Flat;
            stockBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockBtn.Image = Properties.Resources.StockIcon_removebg_preview;
            stockBtn.Location = new Point(522, 1);
            stockBtn.Margin = new Padding(2, 1, 2, 1);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(256, 152);
            stockBtn.TabIndex = 2;
            stockBtn.Text = "Stock";
            stockBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            stockBtn.UseVisualStyleBackColor = true;
            stockBtn.Click += stockBtn_Click;
            // 
            // productBtn
            // 
            productBtn.Cursor = Cursors.Hand;
            productBtn.Dock = DockStyle.Fill;
            productBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            productBtn.FlatAppearance.BorderSize = 2;
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productBtn.Image = Properties.Resources.ProductIcon_removebg_preview;
            productBtn.Location = new Point(262, 1);
            productBtn.Margin = new Padding(2, 1, 2, 1);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(256, 152);
            productBtn.TabIndex = 1;
            productBtn.Text = "Products";
            productBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            productBtn.UseVisualStyleBackColor = true;
            productBtn.Click += productBtn_Click;
            // 
            // userBtn
            // 
            userBtn.Cursor = Cursors.Hand;
            userBtn.Dock = DockStyle.Fill;
            userBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            userBtn.FlatAppearance.BorderSize = 2;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userBtn.Image = Properties.Resources.UserIcon1;
            userBtn.Location = new Point(2, 1);
            userBtn.Margin = new Padding(2, 1, 2, 1);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(256, 152);
            userBtn.TabIndex = 0;
            userBtn.Text = "Users";
            userBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Click += userBtn_Click;
            // 
            // prodCategoriesBtn
            // 
            prodCategoriesBtn.Cursor = Cursors.Hand;
            prodCategoriesBtn.Dock = DockStyle.Fill;
            prodCategoriesBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            prodCategoriesBtn.FlatAppearance.BorderSize = 2;
            prodCategoriesBtn.FlatStyle = FlatStyle.Flat;
            prodCategoriesBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prodCategoriesBtn.Image = Properties.Resources.CategoriesIcon_removebg_preview;
            prodCategoriesBtn.Location = new Point(2, 155);
            prodCategoriesBtn.Margin = new Padding(2, 1, 2, 1);
            prodCategoriesBtn.Name = "prodCategoriesBtn";
            prodCategoriesBtn.Size = new Size(256, 152);
            prodCategoriesBtn.TabIndex = 5;
            prodCategoriesBtn.Text = "Product Categories";
            prodCategoriesBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            prodCategoriesBtn.UseVisualStyleBackColor = true;
            prodCategoriesBtn.Click += prodCategoriesBtn_Click;
            // 
            // supplierBtn
            // 
            supplierBtn.Cursor = Cursors.Hand;
            supplierBtn.Dock = DockStyle.Fill;
            supplierBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            supplierBtn.FlatAppearance.BorderSize = 2;
            supplierBtn.FlatStyle = FlatStyle.Flat;
            supplierBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierBtn.Image = Properties.Resources.SuppliersIcon_removebg_preview;
            supplierBtn.Location = new Point(262, 155);
            supplierBtn.Margin = new Padding(2, 1, 2, 1);
            supplierBtn.Name = "supplierBtn";
            supplierBtn.Size = new Size(256, 152);
            supplierBtn.TabIndex = 6;
            supplierBtn.Text = "Suppliers";
            supplierBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            supplierBtn.UseVisualStyleBackColor = true;
            supplierBtn.Click += supplierBtn_Click;
            // 
            // prodPricingBtn
            // 
            prodPricingBtn.Cursor = Cursors.Hand;
            prodPricingBtn.Dock = DockStyle.Fill;
            prodPricingBtn.FlatAppearance.BorderColor = Color.DarkOrange;
            prodPricingBtn.FlatAppearance.BorderSize = 2;
            prodPricingBtn.FlatStyle = FlatStyle.Flat;
            prodPricingBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prodPricingBtn.Image = Properties.Resources.PricingIcon_removebg_preview;
            prodPricingBtn.Location = new Point(522, 155);
            prodPricingBtn.Margin = new Padding(2, 1, 2, 1);
            prodPricingBtn.Name = "prodPricingBtn";
            prodPricingBtn.Size = new Size(256, 152);
            prodPricingBtn.TabIndex = 7;
            prodPricingBtn.Text = "Product Pricing";
            prodPricingBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            prodPricingBtn.UseVisualStyleBackColor = true;
            prodPricingBtn.Click += prodPricingBtn_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 830);
            Margin = new Padding(2, 1, 2, 1);
            Name = "HomeScreen";
            Text = "Home Screen";
            Load += HomeScreen_Load;
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button userBtn;
        private Button salesBtn;
        private Button purchaseInvoiceBtn;
        private Button stockBtn;
        private Button productBtn;
        private Button prodCategoriesBtn;
        private Button supplierBtn;
        private Button prodPricingBtn;
    }
}