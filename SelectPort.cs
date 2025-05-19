using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;

namespace SCARA_ROBOT_SOFTWARE
{
    public partial class SelectPort : Form
    {
        private System.Timers.Timer checkTimer;
        private bool isExiting = false;

        public SelectPort()
        {
            InitializeComponent();


            LoadComPorts();

            checkTimer = new System.Timers.Timer(1000);
            checkTimer.Elapsed += ComPortTimer;
            checkTimer.AutoReset = true;
            checkTimer.Start();

        }

        private void ComPortTimer(object? sender, EventArgs e)
        {
            LoadComPorts();
        }

        private void LoadComPorts()
        {
            if (this.IsDisposed || !this.IsHandleCreated)
                return;

            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new MethodInvoker(LoadComPorts));
                }
                catch (ObjectDisposedException)
                {
                    return;
                }
                return;
            }

            string[] ports = SerialPort.GetPortNames();

            if (!comboBoxComPorts.Items.Cast<string>().SequenceEqual(ports))
            {
                string selectedPort = comboBoxComPorts.SelectedItem as string ?? string.Empty;

                comboBoxComPorts.Items.Clear();
                comboBoxComPorts.Items.AddRange(ports);

                if (!string.IsNullOrEmpty(selectedPort) && ports.Contains(selectedPort))
                {
                    comboBoxComPorts.SelectedItem = selectedPort;
                }
                else if (ports.Length > 0)
                {
                    comboBoxComPorts.SelectedIndex = 0;
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxComPorts.SelectedItem != null)
            {
                GlobalVariables.selectedPort = comboBoxComPorts.SelectedItem.ToString();
                GlobalVariables.isSelect = true;

                try
                {
                    if (!UartManager.Instance.SerialPort.IsOpen)
                    {
                        UartManager.Instance.Open();
                    }

                    MessageBox.Show($"{GlobalVariables.selectedPort} port opened successfully!",
                                    "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to open {GlobalVariables.selectedPort} port: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                    Environment.Exit(0);
                }

                
            }
            else
            {
                MessageBox.Show("Please select a COM port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(GlobalVariables.selectedPort) && !isExiting)
            {
                DialogResult result = MessageBox.Show(
                    "Please select a COM port before exiting!\nDo you want to exit anyway?",
                    "Notification",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    isExiting = true;
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            base.OnFormClosing(e);
        }

        private void SelectPort_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.Refresh();

            });
        }
    }
}
