using System;
using System.IO.Ports;
using System.Text;

namespace SCARA_ROBOT_SOFTWARE
{
    public class UartManager
    {
        private static readonly UartManager _instance = new();
        public static UartManager Instance => _instance;

        public SerialPort SerialPort { get; private set; }

        private UartManager()
        {
            SerialPort = new SerialPort
            {
                PortName = GlobalVariables.selectedPort,
                BaudRate = GlobalVariables.selectedBaudrate,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                Encoding = Encoding.ASCII
            };
        }

        public void Open()
        {
            if (!SerialPort.IsOpen)
            {
                SerialPort.Open();
            }
        }

        public void Close()
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
            }
        }

        public void SendCommand(string command)
        {
            if (SerialPort.IsOpen && !string.IsNullOrEmpty(command))
            {
                SerialPort.Write(command);
            }
        }
        public string ReceiveResponse()
        {
            if (SerialPort.IsOpen)
            {
                return SerialPort.ReadExisting();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
