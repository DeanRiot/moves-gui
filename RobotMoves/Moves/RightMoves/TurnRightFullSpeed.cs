namespace RobotMovesUI.Class.RightMoves
{
    class TurnRightFullSpeed:ITurnRight
    {
        public void TurnRight() =>
            Port.Send("TRS;");

    }
}
