using System.IO.Ports;

namespace RobotMovesUI.Class
{
    class SendBasicMoves
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

        public void GoForward()
        {
            serialPort.WriteLine("FR;");
        }

        public void GoBack()
        {
            serialPort.WriteLine("GB;");
        }

        public void TurnRight()
        {
            serialPort.WriteLine("TRS;");
        }

        public void TurnRightIndepended()
        {
            serialPort.WriteLine("TRI;");
        }

        public void TurnLeft()
        {
            serialPort.WriteLine("TLS;");
        }

        public void TurnLeftIndepended()
        {
            serialPort.WriteLine("TLI;");
        }

        public void Stop()
        {
            serialPort.WriteLine("STP;");
        }

    }
}
