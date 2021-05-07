namespace RobotMovesUI.Class.ForwardMoves
{
    class ForwardFullSpeed: IGoForward
    {
        public void GoForward()
        {
            Port.Send("FR;");
        }
    }
}
