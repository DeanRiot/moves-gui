namespace RobotMovesUI.Class.BackMoves
{
    class BackPwm:IGoBack
    {
        public void GoBack()=>
            Port.Send("GBP;");   
    }
}
