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
            container = new FlowLayoutPanel();
            xyPanel = new Panel();
            lblXY = new Label();
            btnUp = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            btnDown = new Button();
            zPanel = new Panel();
            lblZ = new Label();
            btnZUp = new Button();
            btnZDown = new Button();
            capPanel = new Panel();
            lblCap = new Label();
            btnTighten = new Button();
            btnLoosen = new Button();
            btnSetHome = new Button();
            container.SuspendLayout();
            xyPanel.SuspendLayout();
            zPanel.SuspendLayout();
            capPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblStepSize
            // 
            lblStepSize.AutoSize = true;
            lblStepSize.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStepSize.Location = new Point(722, 48);
            lblStepSize.Name = "lblStepSize";
            lblStepSize.Size = new Size(122, 32);
            lblStepSize.TabIndex = 0;
            lblStepSize.Text = "Step Size:";
            // 
            // cbStepSize
            // 
            cbStepSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStepSize.Items.AddRange(new object[] { "1mm", "5mm", "10mm" });
            cbStepSize.Location = new Point(850, 55);
            cbStepSize.Name = "cbStepSize";
            cbStepSize.Size = new Size(86, 23);
            cbStepSize.TabIndex = 1;
            // 
            // container
            // 
            container.BackColor = Color.Transparent;
            container.Controls.Add(xyPanel);
            container.Controls.Add(zPanel);
            container.Controls.Add(capPanel);
            container.Location = new Point(162, 167);
            container.Name = "container";
            container.Size = new Size(1368, 504);
            container.TabIndex = 2;
            // 
            // xyPanel
            // 
            xyPanel.BackColor = Color.White;
            xyPanel.BorderStyle = BorderStyle.FixedSingle;
            xyPanel.Controls.Add(lblXY);
            xyPanel.Controls.Add(btnUp);
            xyPanel.Controls.Add(btnLeft);
            xyPanel.Controls.Add(btnRight);
            xyPanel.Controls.Add(btnDown);
            xyPanel.Location = new Point(3, 3);
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
            lblXY.Text = "XY Control";
            // 
            // btnUp
            // 
            btnUp.BackColor = Color.FromArgb(125, 165, 255);
            btnUp.FlatStyle = FlatStyle.Flat;
            btnUp.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnUp.ForeColor = Color.White;
            btnUp.Location = new Point(176, 50);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(90, 90);
            btnUp.TabIndex = 1;
            btnUp.Text = "↑";
            btnUp.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.FromArgb(125, 165, 255);
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnLeft.ForeColor = Color.White;
            btnLeft.Location = new Point(86, 160);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(90, 90);
            btnLeft.TabIndex = 2;
            btnLeft.Text = "←";
            btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.FromArgb(125, 165, 255);
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnRight.ForeColor = Color.White;
            btnRight.Location = new Point(266, 160);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(90, 90);
            btnRight.TabIndex = 3;
            btnRight.Text = "→";
            btnRight.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            btnDown.BackColor = Color.FromArgb(125, 165, 255);
            btnDown.FlatStyle = FlatStyle.Flat;
            btnDown.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnDown.ForeColor = Color.White;
            btnDown.Location = new Point(176, 270);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(90, 90);
            btnDown.TabIndex = 4;
            btnDown.Text = "↓";
            btnDown.UseVisualStyleBackColor = false;
            // 
            // zPanel
            // 
            zPanel.BackColor = Color.White;
            zPanel.BorderStyle = BorderStyle.FixedSingle;
            zPanel.Controls.Add(lblZ);
            zPanel.Controls.Add(btnZUp);
            zPanel.Controls.Add(btnZDown);
            zPanel.Location = new Point(451, 3);
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
            lblZ.Text = "Z Control";
            // 
            // btnZUp
            // 
            btnZUp.BackColor = Color.FromArgb(125, 165, 255);
            btnZUp.FlatStyle = FlatStyle.Flat;
            btnZUp.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnZUp.ForeColor = Color.White;
            btnZUp.Location = new Point(176, 110);
            btnZUp.Name = "btnZUp";
            btnZUp.Size = new Size(90, 90);
            btnZUp.TabIndex = 1;
            btnZUp.Text = "↑";
            btnZUp.UseVisualStyleBackColor = false;
            // 
            // btnZDown
            // 
            btnZDown.BackColor = Color.FromArgb(125, 165, 255);
            btnZDown.FlatStyle = FlatStyle.Flat;
            btnZDown.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnZDown.ForeColor = Color.White;
            btnZDown.Location = new Point(176, 220);
            btnZDown.Name = "btnZDown";
            btnZDown.Size = new Size(90, 90);
            btnZDown.TabIndex = 2;
            btnZDown.Text = "↓";
            btnZDown.UseVisualStyleBackColor = false;
            // 
            // capPanel
            // 
            capPanel.BackColor = Color.White;
            capPanel.BorderStyle = BorderStyle.FixedSingle;
            capPanel.Controls.Add(lblCap);
            capPanel.Controls.Add(btnTighten);
            capPanel.Controls.Add(btnLoosen);
            capPanel.Location = new Point(899, 3);
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
            btnTighten.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTighten.ForeColor = Color.White;
            btnTighten.Location = new Point(91, 162);
            btnTighten.Name = "btnTighten";
            btnTighten.Size = new Size(90, 90);
            btnTighten.TabIndex = 1;
            btnTighten.Text = "Tighten ↻";
            btnTighten.UseVisualStyleBackColor = false;
            // 
            // btnLoosen
            // 
            btnLoosen.BackColor = Color.FromArgb(125, 165, 255);
            btnLoosen.FlatStyle = FlatStyle.Flat;
            btnLoosen.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLoosen.ForeColor = Color.White;
            btnLoosen.Location = new Point(261, 162);
            btnLoosen.Name = "btnLoosen";
            btnLoosen.Size = new Size(90, 90);
            btnLoosen.TabIndex = 2;
            btnLoosen.Text = "Loosen ↺";
            btnLoosen.UseVisualStyleBackColor = false;
            // 
            // btnSetHome
            // 
            btnSetHome.BackColor = Color.DodgerBlue;
            btnSetHome.FlatStyle = FlatStyle.Flat;
            btnSetHome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnSetHome.ForeColor = Color.White;
            btnSetHome.Location = new Point(743, 800);
            btnSetHome.Name = "btnSetHome";
            btnSetHome.Size = new Size(179, 67);
            btnSetHome.TabIndex = 3;
            btnSetHome.Text = "Set Home";
            btnSetHome.UseVisualStyleBackColor = false;
            // 
            // ManualControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 192, 252);
            ClientSize = new Size(1620, 1009);
            Controls.Add(lblStepSize);
            Controls.Add(cbStepSize);
            Controls.Add(container);
            Controls.Add(btnSetHome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManualControl";
            Text = "ManualMode";
            container.ResumeLayout(false);
            xyPanel.ResumeLayout(false);
            xyPanel.PerformLayout();
            zPanel.ResumeLayout(false);
            zPanel.PerformLayout();
            capPanel.ResumeLayout(false);
            capPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStepSize;
        private ComboBox cbStepSize;
        private FlowLayoutPanel container;
        private Panel xyPanel;
        private Label lblXY;
        private Button btnUp;
        private Button btnLeft;
        private Button btnRight;
        private Button btnDown;
        private Panel zPanel;
        private Label lblZ;
        private Button btnZUp;
        private Button btnZDown;
        private Panel capPanel;
        private Label lblCap;
        private Button btnTighten;
        private Button btnLoosen;
        private Button btnSetHome;
    }
}