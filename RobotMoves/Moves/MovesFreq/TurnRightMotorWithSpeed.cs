using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotMovesUI.Class.MovesFreq
{
    class TurnRightMotorWithSpeed: IFreqMove
    {
        public void moveWithSpeed(int speed) =>
            Port.Send($"TRBF,{speed};");
    }
}
