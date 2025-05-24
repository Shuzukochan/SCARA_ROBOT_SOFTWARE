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
            OpenFormInPanel(new ComPort());
        }
        public void UpdateConnectionStatus()
        {
            if (UartManager.Instance.SerialPort != null && UartManager.Instance.SerialPort.IsOpen)
            {
                statusLabel.Text = "Status: Connected";
                statusPanel.BackColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                statusLabel.Text = "Status: Disconnected";
                statusPanel.BackColor = System.Drawing.Color.Red;
            }
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
            if (UartManager.Instance.SerialPort == null || !UartManager.Instance.SerialPort.IsOpen)
            {
                MessageBox.Show("UART is not connected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                OpenFormInPanel(new ManualControl());
            }
        }
        private void setupButton_Click(object sender, EventArgs e)
        {
            if (UartManager.Instance.SerialPort == null || !UartManager.Instance.SerialPort.IsOpen)
            {
                MessageBox.Show("UART is not connected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                OpenFormInPanel(new Setup());
            }
        }

        private void comPortButton_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new ComPort());
        }

        private void runProgramButton_Click(object sender, EventArgs e)
        {
            if (UartManager.Instance.SerialPort == null || !UartManager.Instance.SerialPort.IsOpen)
            {
                MessageBox.Show("UART is not connected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                OpenFormInPanel(new RunProgram());
            }
        }
    }
}
