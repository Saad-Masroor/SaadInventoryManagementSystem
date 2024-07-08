namespace InventoryManagementSystem
{
    partial class Sample
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
            leftPanel = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            rightPanel = new Panel();
            panel1 = new Panel();
            userLabel = new Label();
            leftPanel.SuspendLayout();
            panel2.SuspendLayout();
            rightPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.DarkOrange;
            leftPanel.Controls.Add(panel2);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.ForeColor = Color.White;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(300, 832);
            leftPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 60);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 60);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.Bisque;
            rightPanel.Controls.Add(panel1);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(300, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1100, 832);
            rightPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(userLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 60);
            panel1.TabIndex = 0;
            // 
            // userLabel
            // 
            userLabel.Dock = DockStyle.Left;
            userLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(0, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(370, 60);
            userLabel.TabIndex = 0;
            userLabel.Text = "User";
            userLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 832);
            ControlBox = false;
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Sample";
            leftPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel leftPanel;
        protected Panel rightPanel;
        protected Panel panel2;
        protected Panel panel1;
        protected Label label1;
        protected Label userLabel;
    }
}