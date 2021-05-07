namespace RobotMovesUI.Class.MovesFreq
{
    class TurnLeftMotorWithSpeed:IFreqMove
    {
        public void moveWithSpeed(int speed) =>
                  Port.Send($"TLBF,{speed};");
    }
}
