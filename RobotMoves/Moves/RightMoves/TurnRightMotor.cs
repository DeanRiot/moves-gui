namespace RobotMovesUI.Class.RightMoves
{
    class TurnRightMotor : ITurnRight
    {
    public void TurnRight() =>
            Port.Send("TRI;");
    }
}
