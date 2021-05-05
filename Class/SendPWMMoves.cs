using System.IO.Ports;

namespace RobotMovesUI.Class
{
    class SendPWMMoves
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
            serialPort.WriteLine("FRP;");
        }

        public void GoBack()
        {
            serialPort.WriteLine("GBP;");
        }

        public void TurnRight()
        {
            serialPort.WriteLine("TRSP;");
        }

        public void TurnRightIndepended()
        {
            serialPort.WriteLine("TRIP;");
        }

        public void TurnLeft()
        {
            serialPort.WriteLine("TLSP;");
        }

        public void TurnLeftIndepended()
        {
            serialPort.WriteLine("TLIP;");
        }

        public void Stop()
        {
            serialPort.WriteLine("STP;");
        }

        public void SetPWMFreq(int value)
        {
            if (value < 0 || value > 250)
                return;
            else
                serialPort.WriteLine($"SF,{value};");
        }
        public int GetPWMFreq()
        {
            //add parser
            return 250;
        }

    }
}

