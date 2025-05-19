namespace SCARA_ROBOT_SOFTWARE  
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            leftPanel = new Panel();
            manualButton = new Button();
            homeButton = new Button();
            groundPanel = new Panel();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(38, 50, 56);
            leftPanel.Controls.Add(manualButton);
            leftPanel.Controls.Add(homeButton);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(300, 1041);
            leftPanel.TabIndex = 0;
            // 
            // manualButton
            // 
            manualButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            manualButton.ForeColor = Color.FromArgb(38, 50, 56);
            manualButton.Location = new Point(0, 253);
            manualButton.Name = "manualButton";
            manualButton.Size = new Size(300, 92);
            manualButton.TabIndex = 1;
            manualButton.Text = "Manual Mode";
            manualButton.UseVisualStyleBackColor = true;
            manualButton.Click += manualButton_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(236, 239, 241);
            homeButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            homeButton.ForeColor = Color.FromArgb(38, 50, 56);
            homeButton.Location = new Point(0, 155);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(300, 92);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // groundPanel
            // 
            groundPanel.BackColor = Color.WhiteSmoke;
            groundPanel.Dock = DockStyle.Fill;
            groundPanel.Location = new Point(300, 0);
            groundPanel.Name = "groundPanel";
            groundPanel.Size = new Size(1604, 1041);
            groundPanel.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1041);
            Controls.Add(groundPanel);
            Controls.Add(leftPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Robot Vặn Nắp";
            WindowState = FormWindowState.Maximized;
            leftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Button homeButton;
        private Button manualButton;
        private Panel groundPanel;
    }
}
