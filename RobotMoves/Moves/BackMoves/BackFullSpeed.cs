namespace RobotMovesUI.Class.BackMoves
{
    class BackFullSpeed:IGoBack
    {
        public void GoBack() =>
                 Port.Send("GB;");
    }
}
