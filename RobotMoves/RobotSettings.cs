using System.IO.Ports;

namespace RobotMovesUI.Class
{
    public class RobotSettings
    {

        public void setPins(int leftForward, int leftBack,
                            int rightForward, int rightBack)
        {
            if(Port.port.IsOpen)
                Port.Send($"CPI,{leftForward}," +
                                    $"{leftBack}," +
                                    $"{rightForward}," +
                                    $"{rightBack};") ; 
        }

        public void SetPWMFreq(int value)
        {
            if (value < 0 || value > 250)
                return;
            else
                Port.Send($"SF,{value};");
        }
    }
}
