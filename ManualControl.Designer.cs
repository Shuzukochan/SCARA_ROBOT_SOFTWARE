namespace SCARA_ROBOT_SOFTWARE
{
    partial class ManualControl
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
            lblStepSize = new Label();
            cbStepSize = new ComboBox();
            xyPanel = new Panel();
            lblXY = new Label();
            btnZUp = new Button();
            btnXLeft = new Button();
            btnXRight = new Button();
            btnZDown = new Button();
            zPanel = new Panel();
            lblZ = new Label();
            btnYUp = new Button();
            btnYDown = new Button();
            capPanel = new Panel();
            lblCap = new Label();
            btnTighten = new Button();
            btnLoosen = new Button();
            btnSetHome = new Button();
            shuzukoPanel1 = new ShuzukoPanel();
            runButton = new Button();
            testTB = new TextBox();
            xyPanel.SuspendLayout();
            zPanel.SuspendLayout();
            capPanel.SuspendLayout();
            shuzukoPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStepSize
            // 
            lblStepSize.AutoSize = true;
            lblStepSize.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStepSize.Location = new Point(688, 42);
            lblStepSize.Name = "lblStepSize";
            lblStepSize.Size = new Size(122, 32);
            lblStepSize.TabIndex = 0;
            lblStepSize.Text = "Step Size:";
            // 
            // cbStepSize
            // 
            cbStepSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStepSize.Items.AddRange(new object[] { "1mm", "5mm", "10mm" });
            cbStepSize.Location = new Point(815, 49);
            cbStepSize.Name = "cbStepSize";
            cbStepSize.Size = new Size(86, 23);
            cbStepSize.TabIndex = 1;
            cbStepSize.SelectedIndexChanged += cbStepSize_SelectedIndexChanged;
            // 
            // xyPanel
            // 
            xyPanel.BackColor = Color.White;
            xyPanel.BorderStyle = BorderStyle.FixedSingle;
            xyPanel.Controls.Add(lblXY);
            xyPanel.Controls.Add(btnZUp);
            xyPanel.Controls.Add(btnXLeft);
            xyPanel.Controls.Add(btnXRight);
            xyPanel.Controls.Add(btnZDown);
            xyPanel.Location = new Point(142, 217);
            xyPanel.Name = "xyPanel";
            xyPanel.Size = new Size(442, 442);
            xyPanel.TabIndex = 0;
            // 
            // lblXY
            // 
            lblXY.AutoSize = true;
            lblXY.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblXY.Location = new Point(10, 10);
            lblXY.Name = "lblXY";
            lblXY.Size = new Size(138, 32);
            lblXY.TabIndex = 0;
            lblXY.Text = "XZ Control";
            // 
            // btnZUp
            // 
            btnZUp.BackColor = Color.FromArgb(125, 165, 255);
            btnZUp.FlatStyle = FlatStyle.Flat;
            btnZUp.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnZUp.ForeColor = Color.White;
            btnZUp.Location = new Point(176, 50);
            btnZUp.Name = "btnZUp";
            btnZUp.Size = new Size(90, 90);
            btnZUp.TabIndex = 1;
            btnZUp.Text = "↑";
            btnZUp.UseVisualStyleBackColor = false;
            btnZUp.MouseDown += btnZUp_MouseDown;
            btnZUp.MouseUp += btnZUp_MouseUp;
            // 
            // btnXLeft
            // 
            btnXLeft.BackColor = Color.FromArgb(125, 165, 255);
            btnXLeft.FlatStyle = FlatStyle.Flat;
            btnXLeft.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnXLeft.ForeColor = Color.White;
            btnXLeft.Location = new Point(86, 160);
            btnXLeft.Name = "btnXLeft";
            btnXLeft.Size = new Size(90, 90);
            btnXLeft.TabIndex = 2;
            btnXLeft.Text = "↻";
            btnXLeft.UseVisualStyleBackColor = false;
            btnXLeft.MouseDown += btnXLeft_MouseDown;
            btnXLeft.MouseUp += btnXLeft_MouseUp;
            // 
            // btnXRight
            // 
            btnXRight.BackColor = Color.FromArgb(125, 165, 255);
            btnXRight.FlatStyle = FlatStyle.Flat;
            btnXRight.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnXRight.ForeColor = Color.White;
            btnXRight.Location = new Point(266, 160);
            btnXRight.Name = "btnXRight";
            btnXRight.Size = new Size(90, 90);
            btnXRight.TabIndex = 3;
            btnXRight.Text = "↺";
            btnXRight.UseVisualStyleBackColor = false;
            btnXRight.MouseDown += btnXRight_MouseDown;
            btnXRight.MouseUp += btnXRight_MouseUp;
            // 
            // btnZDown
            // 
            btnZDown.BackColor = Color.FromArgb(125, 165, 255);
            btnZDown.FlatStyle = FlatStyle.Flat;
            btnZDown.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnZDown.ForeColor = Color.White;
            btnZDown.Location = new Point(176, 270);
            btnZDown.Name = "btnZDown";
            btnZDown.Size = new Size(90, 90);
            btnZDown.TabIndex = 4;
            btnZDown.Text = "↓";
            btnZDown.UseVisualStyleBackColor = false;
            btnZDown.MouseDown += btnZDown_MouseDown;
            btnZDown.MouseUp += btnZDown_MouseUp;
            // 
            // zPanel
            // 
            zPanel.BackColor = Color.White;
            zPanel.BorderStyle = BorderStyle.FixedSingle;
            zPanel.Controls.Add(lblZ);
            zPanel.Controls.Add(btnYUp);
            zPanel.Controls.Add(btnYDown);
            zPanel.Location = new Point(594, 217);
            zPanel.Name = "zPanel";
            zPanel.Size = new Size(442, 442);
            zPanel.TabIndex = 1;
            // 
            // lblZ
            // 
            lblZ.AutoSize = true;
            lblZ.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblZ.Location = new Point(10, 10);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(122, 32);
            lblZ.TabIndex = 0;
            lblZ.Text = "Y Control";
            // 
            // btnYUp
            // 
            btnYUp.BackColor = Color.FromArgb(125, 165, 255);
            btnYUp.FlatStyle = FlatStyle.Flat;
            btnYUp.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnYUp.ForeColor = Color.White;
            btnYUp.Location = new Point(176, 110);
            btnYUp.Name = "btnYUp";
            btnYUp.Size = new Size(90, 90);
            btnYUp.TabIndex = 1;
            btnYUp.Text = "↑";
            btnYUp.UseVisualStyleBackColor = false;
            btnYUp.MouseDown += btnYUp_MouseDown;
            btnYUp.MouseUp += btnYUp_MouseUp;
            // 
            // btnYDown
            // 
            btnYDown.BackColor = Color.FromArgb(125, 165, 255);
            btnYDown.FlatStyle = FlatStyle.Flat;
            btnYDown.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnYDown.ForeColor = Color.White;
            btnYDown.Location = new Point(176, 220);
            btnYDown.Name = "btnYDown";
            btnYDown.Size = new Size(90, 90);
            btnYDown.TabIndex = 2;
            btnYDown.Text = "↓";
            btnYDown.UseVisualStyleBackColor = false;
            btnYDown.MouseDown += btnYDown_MouseDown;
            btnYDown.MouseUp += btnYDown_MouseUp;
            // 
            // capPanel
            // 
            capPanel.BackColor = Color.White;
            capPanel.BorderStyle = BorderStyle.FixedSingle;
            capPanel.Controls.Add(lblCap);
            capPanel.Controls.Add(btnTighten);
            capPanel.Controls.Add(btnLoosen);
            capPanel.Location = new Point(1046, 217);
            capPanel.Name = "capPanel";
            capPanel.Size = new Size(442, 442);
            capPanel.TabIndex = 2;
            // 
            // lblCap
            // 
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCap.Location = new Point(10, 10);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(150, 32);
            lblCap.TabIndex = 0;
            lblCap.Text = "Cap Control";
            // 
            // btnTighten
            // 
            btnTighten.BackColor = Color.FromArgb(125, 165, 255);
            btnTighten.FlatStyle = FlatStyle.Flat;
            btnTighten.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnTighten.ForeColor = Color.White;
            btnTighten.Location = new Point(91, 162);
            btnTighten.Name = "btnTighten";
            btnTighten.Size = new Size(90, 90);
            btnTighten.TabIndex = 1;
            btnTighten.Text = "↻";
            btnTighten.UseVisualStyleBackColor = false;
            btnTighten.MouseDown += btnBLeft_MouseDown;
            btnTighten.MouseUp += btnBLeft_MouseUp;
            // 
            // btnLoosen
            // 
            btnLoosen.BackColor = Color.FromArgb(125, 165, 255);
            btnLoosen.FlatStyle = FlatStyle.Flat;
            btnLoosen.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnLoosen.ForeColor = Color.White;
            btnLoosen.Location = new Point(261, 162);
            btnLoosen.Name = "btnLoosen";
            btnLoosen.Size = new Size(90, 90);
            btnLoosen.TabIndex = 2;
            btnLoosen.Text = "↺";
            btnLoosen.UseVisualStyleBackColor = false;
            btnLoosen.MouseDown += btnBRight_MouseDown;
            btnLoosen.MouseUp += btnBRight_MouseUp;
            // 
            // btnSetHome
            // 
            btnSetHome.BackColor = Color.DodgerBlue;
            btnSetHome.FlatStyle = FlatStyle.Flat;
            btnSetHome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnSetHome.ForeColor = Color.White;
            btnSetHome.Location = new Point(706, 765);
            btnSetHome.Name = "btnSetHome";
            btnSetHome.Size = new Size(178, 67);
            btnSetHome.TabIndex = 3;
            btnSetHome.Text = "Home";
            btnSetHome.UseVisualStyleBackColor = false;
            btnSetHome.Click += btnSetHome_Click;
            // 
            // shuzukoPanel1
            // 
            shuzukoPanel1.BackColor = Color.White;
            shuzukoPanel1.BorderColor = Color.Silver;
            shuzukoPanel1.BorderRadius = 10;
            shuzukoPanel1.Controls.Add(runButton);
            shuzukoPanel1.Controls.Add(testTB);
            shuzukoPanel1.Controls.Add(capPanel);
            shuzukoPanel1.Controls.Add(zPanel);
            shuzukoPanel1.Controls.Add(xyPanel);
            shuzukoPanel1.Controls.Add(lblStepSize);
            shuzukoPanel1.Controls.Add(cbStepSize);
            shuzukoPanel1.Controls.Add(btnSetHome);
            shuzukoPanel1.ForeColor = Color.Black;
            shuzukoPanel1.GradientAngle = 90F;
            shuzukoPanel1.GradientBottomColor = Color.White;
            shuzukoPanel1.GradientTopColor = Color.White;
            shuzukoPanel1.Location = new Point(15, 15);
            shuzukoPanel1.Name = "shuzukoPanel1";
            shuzukoPanel1.Size = new Size(1590, 979);
            shuzukoPanel1.TabIndex = 4;
            // 
            // runButton
            // 
            runButton.BackColor = Color.DodgerBlue;
            runButton.FlatStyle = FlatStyle.Flat;
            runButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            runButton.ForeColor = Color.White;
            runButton.Location = new Point(142, 800);
            runButton.Name = "runButton";
            runButton.Size = new Size(178, 67);
            runButton.TabIndex = 5;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = false;
            runButton.Click += runButton_Click;
            // 
            // testTB
            // 
            testTB.BackColor = Color.WhiteSmoke;
            testTB.Font = new Font("Segoe UI", 20F);
            testTB.Location = new Point(142, 726);
            testTB.Name = "testTB";
            testTB.Size = new Size(235, 43);
            testTB.TabIndex = 4;
            // 
            // ManualControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 192, 252);
            ClientSize = new Size(1620, 1009);
            Controls.Add(shuzukoPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManualControl";
            Text = "ManualMode";
            xyPanel.ResumeLayout(false);
            xyPanel.PerformLayout();
            zPanel.ResumeLayout(false);
            zPanel.PerformLayout();
            capPanel.ResumeLayout(false);
            capPanel.PerformLayout();
            shuzukoPanel1.ResumeLayout(false);
            shuzukoPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStepSize;
        private ComboBox cbStepSize;
        private Panel xyPanel;
        private Label lblXY;
        private Button btnZUp;
        private Button btnXLeft;
        private Button btnXRight;
        private Button btnZDown;
        private Panel zPanel;
        private Label lblZ;
        private Button btnYUp;
        private Button btnYDown;
        private Panel capPanel;
        private Label lblCap;
        private Button btnTighten;
        private Button btnLoosen;
        private Button btnSetHome;
        private ShuzukoPanel shuzukoPanel1;
        private TextBox testTB;
        private Button runButton;
    }
}