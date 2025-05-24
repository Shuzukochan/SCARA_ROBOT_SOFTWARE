using SCARA_ROBOT_SOFTWARE;
using System.IO.Ports;
using System.Text;

public class UartManager
{
    private static readonly UartManager _instance = new();
    public static UartManager Instance => _instance;

    public SerialPort SerialPort { get; private set; }

    private UartManager()
    {
    }

    public void Open()
    {
        if (SerialPort != null && SerialPort.IsOpen)
            return;

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

        SerialPort.Open();
    }

    public void Close()
    {
        if (SerialPort != null && SerialPort.IsOpen)
            SerialPort.Close();
    }

    public void SendCommand(string command)
    {
        if (SerialPort != null && SerialPort.IsOpen && !string.IsNullOrEmpty(command))
        {
            SerialPort.Write(command);
        }
    }

    public string ReceiveResponse()
    {
        return SerialPort != null && SerialPort.IsOpen
            ? SerialPort.ReadExisting()
            : string.Empty;
    }
}
