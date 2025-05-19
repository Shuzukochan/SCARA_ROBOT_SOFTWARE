using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;
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
                BaudRate = 115200,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None
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

        public void Send(byte[] data)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Write(data, 0, data.Length);
            }
        }
        
        public byte[] ReceiveBytes()
        {
            if (SerialPort.IsOpen)
            {
                int bytesToRead = SerialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                SerialPort.Read(buffer, 0, bytesToRead);
                return buffer;
            }
            else
            {
                return new byte[0];
            }
        }

        public string Receive()
        {
            if (SerialPort.IsOpen)
            {
                return SerialPort.ReadExisting();
            }
            else
            {
                return "";
            }
        }
    }
}
