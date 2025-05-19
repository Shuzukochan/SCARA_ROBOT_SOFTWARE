using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void OpenFormInPanel(Form childForm)
        {
            foreach (Control ctrl in groundPanel.Controls.Cast<Control>().ToList())
            {
                groundPanel.Controls.Remove(ctrl);
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            groundPanel.Controls.Add(childForm);
            groundPanel.Tag = childForm;
            childForm.Show();
            Debug.WriteLine($"Panel size: {groundPanel.Size}");
            Debug.WriteLine($"Form size: {childForm.Size}");
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Setup()); 

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Test()); 
        }
    }
}
