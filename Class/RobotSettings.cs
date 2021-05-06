using System.IO.Ports;

namespace RobotMovesUI.Class
{
    class RobotSettings
    {
        private SerialPort serialPort;

        public void SetPort(SerialPort port)
        {
            serialPort = port;
        }

        public bool PortStatus()
        {
            if (serialPort != null)
                return serialPort.IsOpen;
            else return false;
        }

        public void setPins(int leftForward, int leftBack,
                            int rightForward, int rightBack)
        {
            serialPort.WriteLine($"CPI,{leftForward}," +
                                    $"{leftBack}," +
                                    $"{rightForward}," +
                                    $"{rightBack};") ; 
        }
    }
}
