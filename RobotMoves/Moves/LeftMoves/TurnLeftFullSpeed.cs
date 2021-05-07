namespace RobotMovesUI.Class.LeftMoves
{
    class TurnLeftFullSpeed:ITurnLeft
    {
        public void TurnLeft() =>
            Port.Send("TLS;");

    }
}
