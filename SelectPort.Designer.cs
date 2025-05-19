namespace SCARA_ROBOT_SOFTWARE
{
    partial class SelectPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPort));
            comboBoxComPorts = new ComboBox();
            shuzukoPanel1 = new ShuzukoPanel();
            buttonSelect = new Button();
            label1 = new Label();
            shuzukoPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxComPorts
            // 
            comboBoxComPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComPorts.ForeColor = Color.FromArgb(45, 48, 129);
            comboBoxComPorts.FormattingEnabled = true;
            comboBoxComPorts.Location = new Point(120, 30);
            comboBoxComPorts.Name = "comboBoxComPorts";
            comboBoxComPorts.Size = new Size(150, 23);
            comboBoxComPorts.TabIndex = 0;
            // 
            // shuzukoPanel1
            // 
            shuzukoPanel1.BackColor = Color.Transparent;
            shuzukoPanel1.BorderRadius = 0;
            shuzukoPanel1.Controls.Add(buttonSelect);
            shuzukoPanel1.Controls.Add(label1);
            shuzukoPanel1.Controls.Add(comboBoxComPorts);
            shuzukoPanel1.Dock = DockStyle.Fill;
            shuzukoPanel1.ForeColor = Color.Black;
            shuzukoPanel1.GradientAngle = 180F;
            shuzukoPanel1.GradientBottomColor = Color.FromArgb(20, 116, 252);
            shuzukoPanel1.GradientTopColor = Color.FromArgb(68, 198, 255);
            shuzukoPanel1.Location = new Point(0, 0);
            shuzukoPanel1.Name = "shuzukoPanel1";
            shuzukoPanel1.Size = new Size(320, 130);
            shuzukoPanel1.TabIndex = 3;
            // 
            // buttonSelect
            // 
            buttonSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSelect.ForeColor = Color.FromArgb(45, 48, 129);
            buttonSelect.Location = new Point(120, 70);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(150, 30);
            buttonSelect.TabIndex = 1;
            buttonSelect.Text = "Select Port";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 48, 129);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 2;
            label1.Text = "Port Selection:";
            // 
            // SelectPort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 130);
            Controls.Add(shuzukoPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectPort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COM Port Selection";
            shuzukoPanel1.ResumeLayout(false);
            shuzukoPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComPorts;
        private ShuzukoPanel shuzukoPanel1;
        private Label label1;
        private Button buttonSelect;
    }
}
