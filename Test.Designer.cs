namespace SCARA_ROBOT_SOFTWARE
{
    partial class Test
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
            shuzukoButton1 = new ShuzukoButton();
            programCard1 = new ProgramCard();
            shuzukoButton2 = new ShuzukoButton();
            SuspendLayout();
            // 
            // shuzukoButton1
            // 
            shuzukoButton1.BackColor = Color.MediumSlateBlue;
            shuzukoButton1.BackgroundColor = Color.MediumSlateBlue;
            shuzukoButton1.BorderColor = Color.PaleVioletRed;
            shuzukoButton1.BorderRadius = 20;
            shuzukoButton1.BorderSize = 0;
            shuzukoButton1.FlatAppearance.BorderSize = 0;
            shuzukoButton1.FlatAppearance.MouseDownBackColor = Color.MediumSlateBlue;
            shuzukoButton1.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            shuzukoButton1.FlatStyle = FlatStyle.Flat;
            shuzukoButton1.ForeColor = Color.White;
            shuzukoButton1.Location = new Point(114, 104);
            shuzukoButton1.Name = "shuzukoButton1";
            shuzukoButton1.Size = new Size(245, 106);
            shuzukoButton1.TabIndex = 0;
            shuzukoButton1.Text = "shuzukoButton1";
            shuzukoButton1.TextColor = Color.White;
            shuzukoButton1.TextOffsetX = 0;
            shuzukoButton1.TextOffsetY = 0;
            shuzukoButton1.UseVisualStyleBackColor = false;
            // 
            // shuzukoButton2
            // 
            shuzukoButton2.BackColor = Color.MediumSlateBlue;
            shuzukoButton2.BackgroundColor = Color.MediumSlateBlue;
            shuzukoButton2.BorderColor = Color.PaleVioletRed;
            shuzukoButton2.BorderRadius = 20;
            shuzukoButton2.BorderSize = 0;
            shuzukoButton2.FlatAppearance.BorderSize = 0;
            shuzukoButton2.FlatAppearance.MouseDownBackColor = Color.MediumSlateBlue;
            shuzukoButton2.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            shuzukoButton2.FlatStyle = FlatStyle.Flat;
            shuzukoButton2.ForeColor = Color.White;
            shuzukoButton2.Location = new Point(392, 186);
            shuzukoButton2.Name = "shuzukoButton2";
            shuzukoButton2.Size = new Size(198, 70);
            shuzukoButton2.TabIndex = 2;
            shuzukoButton2.Text = "shuzukoButton2";
            shuzukoButton2.TextColor = Color.White;
            shuzukoButton2.TextOffsetX = 0;
            shuzukoButton2.TextOffsetY = 0;
            shuzukoButton2.UseVisualStyleBackColor = false;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(shuzukoButton2);
            Controls.Add(programCard1);
            Controls.Add(shuzukoButton1);
            Name = "Test";
            Text = "Test";
            ResumeLayout(false);
        }

        #endregion

        private ShuzukoButton shuzukoButton1;
        private ProgramCard programCard1;
        private ShuzukoButton shuzukoButton2;
    }
}