using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotMovesUI.Class.LeftMoves
{
    class TurnLeftMotor : ITurnLeft
    {
    public void TurnLeft() =>
            Port.Send("TLI;");
    }
}
