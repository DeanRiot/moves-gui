using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotMovesUI.Class.LeftMoves
{
    class TurnLeftPwm : ITurnLeft
    {
     public void TurnLeft() =>
               Port.Send("TLSP;");
    }
}
