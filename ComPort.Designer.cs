namespace SCARA_ROBOT_SOFTWARE
{
    partial class ComPort
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
        private Label lblTitle;
        private Label lblSelectDevice;
        private Label lblBaudrate;
        private ComboBox cbComPorts;
        private ComboBox cbBaudrate;
        private Button btnRefresh;
        private Button btnConnect;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSelectDevice = new Label();
            cbComPorts = new ComboBox();
            lblBaudrate = new Label();
            cbBaudrate = new ComboBox();
            btnRefresh = new Button();
            btnConnect = new Button();
            shuzukoPanel1 = new ShuzukoPanel();
            btnDisconnect = new Button();
            shuzukoPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(651, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Device Manager";
            // 
            // lblSelectDevice
            // 
            lblSelectDevice.AutoSize = true;
            lblSelectDevice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectDevice.Location = new Point(545, 216);
            lblSelectDevice.Name = "lblSelectDevice";
            lblSelectDevice.Size = new Size(130, 25);
            lblSelectDevice.TabIndex = 1;
            lblSelectDevice.Text = "Select device:";
            // 
            // cbComPorts
            // 
            cbComPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbComPorts.Font = new Font("Segoe UI", 14F);
            cbComPorts.Location = new Point(545, 246);
            cbComPorts.Name = "cbComPorts";
            cbComPorts.Size = new Size(500, 33);
            cbComPorts.TabIndex = 2;
            cbComPorts.TabStop = false;
            // 
            // lblBaudrate
            // 
            lblBaudrate.AutoSize = true;
            lblBaudrate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaudrate.Location = new Point(545, 306);
            lblBaudrate.Name = "lblBaudrate";
            lblBaudrate.Size = new Size(98, 25);
            lblBaudrate.TabIndex = 3;
            lblBaudrate.Text = "Baudrate:";
            // 
            // cbBaudrate
            // 
            cbBaudrate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBaudrate.Font = new Font("Segoe UI", 14F);
            cbBaudrate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200", "256000" });
            cbBaudrate.Location = new Point(545, 336);
            cbBaudrate.Name = "cbBaudrate";
            cbBaudrate.Size = new Size(500, 33);
            cbBaudrate.TabIndex = 4;
            cbBaudrate.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(76, 175, 80);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(545, 416);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(500, 50);
            btnRefresh.TabIndex = 5;
            btnRefresh.TabStop = false;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(76, 175, 80);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(545, 486);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(500, 50);
            btnConnect.TabIndex = 6;
            btnConnect.TabStop = false;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // shuzukoPanel1
            // 
            shuzukoPanel1.BackColor = Color.White;
            shuzukoPanel1.BorderColor = Color.Silver;
            shuzukoPanel1.BorderRadius = 10;
            shuzukoPanel1.Controls.Add(btnDisconnect);
            shuzukoPanel1.Controls.Add(lblTitle);
            shuzukoPanel1.Controls.Add(btnConnect);
            shuzukoPanel1.Controls.Add(lblSelectDevice);
            shuzukoPanel1.Controls.Add(btnRefresh);
            shuzukoPanel1.Controls.Add(cbComPorts);
            shuzukoPanel1.Controls.Add(cbBaudrate);
            shuzukoPanel1.Controls.Add(lblBaudrate);
            shuzukoPanel1.ForeColor = Color.Black;
            shuzukoPanel1.GradientAngle = 90F;
            shuzukoPanel1.GradientBottomColor = Color.White;
            shuzukoPanel1.GradientTopColor = Color.White;
            shuzukoPanel1.Location = new Point(15, 15);
            shuzukoPanel1.Name = "shuzukoPanel1";
            shuzukoPanel1.Size = new Size(1590, 979);
            shuzukoPanel1.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.Red;
            btnDisconnect.FlatStyle = FlatStyle.Flat;
            btnDisconnect.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDisconnect.ForeColor = Color.White;
            btnDisconnect.Location = new Point(545, 556);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(500, 50);
            btnDisconnect.TabIndex = 7;
            btnDisconnect.TabStop = false;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // ComPort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 192, 252);
            ClientSize = new Size(1620, 1009);
            Controls.Add(shuzukoPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComPort";
            Text = "ComPort";
            shuzukoPanel1.ResumeLayout(false);
            shuzukoPanel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private ShuzukoPanel shuzukoPanel1;
        private Button btnDisconnect;
    }
}