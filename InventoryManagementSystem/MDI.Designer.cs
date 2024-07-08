namespace InventoryManagementSystem
{
    partial class MDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            menuStrip1 = new MenuStrip();
            fILEToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fILEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1400, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "myMenu";
            // 
            // fILEToolStripMenuItem
            // 
            fILEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, eXITToolStripMenuItem, logOutToolStripMenuItem });
            fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            fILEToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
            fILEToolStripMenuItem.Size = new Size(49, 24);
            fILEToolStripMenuItem.Text = "FILE";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            settingsToolStripMenuItem.Size = new Size(191, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            eXITToolStripMenuItem.Size = new Size(191, 26);
            eXITToolStripMenuItem.Text = "Exit";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Enabled = false;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
            logOutToolStripMenuItem.Size = new Size(191, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 832);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MDI";
            Text = "Welcome";
            WindowState = FormWindowState.Maximized;
            Load += MDI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem fILEToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem logOutToolStripMenuItem;
    }
}
