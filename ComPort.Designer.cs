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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(641, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Device Manager";
            // 
            // lblSelectDevice
            // 
            lblSelectDevice.AutoSize = true;
            lblSelectDevice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectDevice.Location = new Point(538, 278);
            lblSelectDevice.Name = "lblSelectDevice";
            lblSelectDevice.Size = new Size(130, 25);
            lblSelectDevice.TabIndex = 1;
            lblSelectDevice.Text = "Select device:";
            // 
            // cbComPorts
            // 
            cbComPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbComPorts.Font = new Font("Segoe UI", 14F);
            cbComPorts.Location = new Point(538, 308);
            cbComPorts.Name = "cbComPorts";
            cbComPorts.Size = new Size(500, 33);
            cbComPorts.TabIndex = 2;
            // 
            // lblBaudrate
            // 
            lblBaudrate.AutoSize = true;
            lblBaudrate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaudrate.Location = new Point(538, 368);
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
            cbBaudrate.Location = new Point(538, 398);
            cbBaudrate.Name = "cbBaudrate";
            cbBaudrate.Size = new Size(500, 33);
            cbBaudrate.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(76, 175, 80);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(538, 478);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(500, 50);
            btnRefresh.TabIndex = 5;
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
            btnConnect.Location = new Point(538, 548);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(500, 50);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // ComPort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 192, 252);
            ClientSize = new Size(1620, 1009);
            Controls.Add(lblTitle);
            Controls.Add(lblSelectDevice);
            Controls.Add(cbComPorts);
            Controls.Add(lblBaudrate);
            Controls.Add(cbBaudrate);
            Controls.Add(btnRefresh);
            Controls.Add(btnConnect);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComPort";
            Text = "ComPort";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}