using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
           return serialPort.IsOpen;
        }

        public void GoForward()
        {
            serialPort.WriteLine();
        }

        public void GoBack()
        {

        }

        public void TurnRight()
        {

        }

        public void TurnRightIndepended()
        {

        }

        public void TurnLeft()
        {

        }

        public void TurnLeftIndepended()
        {


        }

        public void Stop()
        {

        }

    }
}
