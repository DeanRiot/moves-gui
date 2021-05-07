using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotMovesUI.Class
{
    class CalcPwm
    {
        private int map(int x, int in_min, int in_max, int out_min, int out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }
        public int Calc(int value)
        {
            if (value > 125 && value < 251)
            {
                return map(value, 125, 250, 125, 250);
            }
            else if (value < 125 && value > 0)
            {
                return  map(value, 0, 125, 125, 0);
            }

            return value;
        }
    }
}
