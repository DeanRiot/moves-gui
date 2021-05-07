namespace RobotMovesUI.Class.RightMoves
{
    class TurnRightMotorPwm:ITurnRight
    {
    public void TurnRight() =>
            Port.Send("TRIP;");
    }
}
