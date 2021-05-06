using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace RobotMovesUI.Class
{
    public class RobotMoves
    {
        private SendBasicMoves moves = new SendBasicMoves();
        private SendPWMMoves pwmMoves = new SendPWMMoves();
        public RobotMoves(SerialPort serialPort)
        {
            moves.SetPort(serialPort);
            pwmMoves.SetPort(serialPort);
        }

        public void SetPort(SerialPort serialPort)
        {
            moves.SetPort(serialPort);
            pwmMoves.SetPort(serialPort);
        }

        public bool CheckPortStatus()
        {
            return moves.PortStatus() && moves.PortStatus();
        }
    
        public void GoForwardFullSpeed()=>
                            moves.GoForward();
        public void GoForwardSetedSpeed() =>
                            pwmMoves.GoForward();
        public void GoBackFullSpeed() =>
                            moves.GoBack();
        public void GoBackSetedSpeed() =>
                            pwmMoves.GoBack();
        public void TurnLeftFullSpeed() =>
                            moves.TurnLeft();
        public void TurnLeftSetedSpeed() =>
                            pwmMoves.TurnLeft();
        public void TurnLeftWithSpeed(int speed) =>
                             pwmMoves.TurnLeftByFreq(speed);
        public void TurnLeftIndependedFullSpeed() =>
                            moves.TurnLeftIndepended();
        public void TurnLeftIndependedSetedSpeed() =>
                            pwmMoves.TurnLeftIndepended();
        public void TurnRightFullSpeed() =>
                            moves.TurnRight();
        public void TurnRightSetedSpeed() =>
                            pwmMoves.TurnRight();
        public void TurnRightWithSpeed(int speed) =>
                            pwmMoves.TurnRightByFreq(speed);
        public void TurnRightIndependedFullSpeed() =>
                            moves.TurnRightIndepended();
        public void TurnRightIndependedSetedSpeed() =>
                                pwmMoves.TurnRightIndepended();
        public void StopMotors() =>
                            moves.Stop();

        public void SetSpeed(int speed) =>
                            pwmMoves.SetPWMFreq(speed);
    }
}
