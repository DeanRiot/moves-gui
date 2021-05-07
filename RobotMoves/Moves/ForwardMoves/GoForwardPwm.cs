namespace RobotMovesUI.Class.ForwardMoves
{
    class GoForwardPwm:IGoForward
    {
        public void GoForward()
        {
            Port.Send("FRP;");
        }
    }
}
