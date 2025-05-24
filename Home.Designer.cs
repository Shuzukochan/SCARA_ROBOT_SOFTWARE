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
            pictureBox1 = new PictureBox();
            comPortButton = new Button();
            setupButton = new Button();
            manualButton = new Button();
            groundPanel = new Panel();
            shuzukoPanel1 = new ShuzukoPanel();
            runProgramButton = new Button();
            statusLabel = new Label();
            statusPanel = new ShuzukoPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            shuzukoPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_LABone_png;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(24, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // comPortButton
            // 
            comPortButton.BackColor = Color.Transparent;
            comPortButton.BackgroundImageLayout = ImageLayout.None;
            comPortButton.Cursor = Cursors.Hand;
            comPortButton.FlatAppearance.BorderSize = 0;
            comPortButton.FlatStyle = FlatStyle.Flat;
            comPortButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            comPortButton.ForeColor = Color.FromArgb(38, 50, 56);
            comPortButton.Location = new Point(0, 160);
            comPortButton.Name = "comPortButton";
            comPortButton.Size = new Size(285, 90);
            comPortButton.TabIndex = 3;
            comPortButton.Text = "Connect";
            comPortButton.UseVisualStyleBackColor = false;
            comPortButton.Click += comPortButton_Click;
            // 
            // setupButton
            // 
            setupButton.Cursor = Cursors.Hand;
            setupButton.FlatAppearance.BorderSize = 0;
            setupButton.FlatStyle = FlatStyle.Flat;
            setupButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            setupButton.ForeColor = Color.FromArgb(38, 50, 56);
            setupButton.Location = new Point(0, 350);
            setupButton.Name = "setupButton";
            setupButton.Size = new Size(285, 90);
            setupButton.TabIndex = 2;
            setupButton.Text = "Setup Program";
            setupButton.UseVisualStyleBackColor = true;
            setupButton.Click += setupButton_Click;
            // 
            // manualButton
            // 
            manualButton.Cursor = Cursors.Hand;
            manualButton.FlatAppearance.BorderSize = 0;
            manualButton.FlatStyle = FlatStyle.Flat;
            manualButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            manualButton.ForeColor = Color.FromArgb(38, 50, 56);
            manualButton.Location = new Point(0, 255);
            manualButton.Name = "manualButton";
            manualButton.Size = new Size(285, 90);
            manualButton.TabIndex = 1;
            manualButton.Text = "Manual Control";
            manualButton.UseVisualStyleBackColor = true;
            manualButton.Click += manualButton_Click;
            // 
            // groundPanel
            // 
            groundPanel.BackColor = Color.FromArgb(140, 192, 252);
            groundPanel.Location = new Point(300, 0);
            groundPanel.Name = "groundPanel";
            groundPanel.Size = new Size(1604, 1041);
            groundPanel.TabIndex = 1;
            // 
            // shuzukoPanel1
            // 
            shuzukoPanel1.BackColor = Color.White;
            shuzukoPanel1.BorderColor = Color.Silver;
            shuzukoPanel1.BorderRadius = 10;
            shuzukoPanel1.Controls.Add(runProgramButton);
            shuzukoPanel1.Controls.Add(statusLabel);
            shuzukoPanel1.Controls.Add(statusPanel);
            shuzukoPanel1.Controls.Add(pictureBox1);
            shuzukoPanel1.Controls.Add(setupButton);
            shuzukoPanel1.Controls.Add(comPortButton);
            shuzukoPanel1.Controls.Add(manualButton);
            shuzukoPanel1.ForeColor = Color.Black;
            shuzukoPanel1.GradientAngle = 90F;
            shuzukoPanel1.GradientBottomColor = Color.White;
            shuzukoPanel1.GradientTopColor = Color.White;
            shuzukoPanel1.Location = new Point(15, 15);
            shuzukoPanel1.Name = "shuzukoPanel1";
            shuzukoPanel1.Size = new Size(285, 979);
            shuzukoPanel1.TabIndex = 5;
            // 
            // runProgramButton
            // 
            runProgramButton.Cursor = Cursors.Hand;
            runProgramButton.FlatAppearance.BorderSize = 0;
            runProgramButton.FlatStyle = FlatStyle.Flat;
            runProgramButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            runProgramButton.ForeColor = Color.FromArgb(38, 50, 56);
            runProgramButton.Location = new Point(0, 444);
            runProgramButton.Name = "runProgramButton";
            runProgramButton.Size = new Size(285, 90);
            runProgramButton.TabIndex = 5;
            runProgramButton.Text = "Run Program";
            runProgramButton.UseVisualStyleBackColor = true;
            runProgramButton.Click += runProgramButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            statusLabel.Location = new Point(52, 937);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(190, 25);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Status: Disconnected";
            // 
            // statusPanel
            // 
            statusPanel.BackColor = Color.Red;
            statusPanel.BorderColor = Color.Silver;
            statusPanel.BorderRadius = 10;
            statusPanel.ForeColor = Color.Black;
            statusPanel.GradientAngle = 90F;
            statusPanel.GradientBottomColor = Color.Transparent;
            statusPanel.GradientTopColor = Color.Transparent;
            statusPanel.Location = new Point(25, 940);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(20, 20);
            statusPanel.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(140, 192, 252);
            ClientSize = new Size(1904, 1041);
            Controls.Add(shuzukoPanel1);
            Controls.Add(groundPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "RobotVanNapSoftware";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            shuzukoPanel1.ResumeLayout(false);
            shuzukoPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button manualButton;
        private Panel groundPanel;
        private Button setupButton;
        private Button comPortButton;
        private PictureBox pictureBox1;
        private ShuzukoPanel shuzukoPanel1;
        private Label statusLabel;
        private ShuzukoPanel statusPanel;
        private Button runProgramButton;
    }
}
