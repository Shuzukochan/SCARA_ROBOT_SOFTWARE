using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public partial class ComPort : Form
    {
        public ComPort()
        {
            InitializeComponent();

            cbComPorts.Items.AddRange(SerialPort.GetPortNames());
            //cbComPorts.SelectedIndex = -1;
            cbBaudrate.SelectedIndex = 4;

            UpdateDisconnectButtonState();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                Array.Sort(ports);

                cbComPorts.Items.Clear();
                cbComPorts.Items.AddRange(ports);
                cbComPorts.SelectedIndex = -1;
                cbBaudrate.SelectedIndex = -1;

                GlobalVariables.selectedPort = string.Empty;

                UpdateDisconnectButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading COM ports: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cbComPorts.SelectedItem == null || cbBaudrate.SelectedItem == null)
            {
                MessageBox.Show("Please select both COM port and baudrate.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? selectedPort = cbComPorts.SelectedItem.ToString();
            int selectedBaudrate = int.Parse(cbBaudrate.SelectedItem?.ToString() ?? "0");

            try
            {
                GlobalVariables.selectedPort = selectedPort;
                GlobalVariables.selectedBaudrate = selectedBaudrate;

                UartManager.Instance.Open();
                ((Home)this.TopLevelControl).UpdateConnectionStatus();

                MessageBox.Show($"Connected to {selectedPort} at {selectedBaudrate} baud.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateDisconnectButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message,
                                "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                UartManager.Instance.Close();
                GlobalVariables.selectedPort = string.Empty;
                GlobalVariables.selectedBaudrate = 0;

                ((Home)this.TopLevelControl).UpdateConnectionStatus();

                MessageBox.Show("Disconnected from UART.",
                                "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateDisconnectButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to disconnect: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDisconnectButtonState()
        {
            btnDisconnect.Enabled = UartManager.Instance.SerialPort != null &&
                                    UartManager.Instance.SerialPort.IsOpen;
        }
    }
}
