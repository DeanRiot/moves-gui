namespace RobotMovesUI.Class.RightMoves
{
    class TurnRightPwm : ITurnRight
    {
     public void TurnRight() =>
               Port.Send("TRSP;");
    }
}
