using RobotMovesUI.Class.BackMoves;
using RobotMovesUI.Class.ForwardMoves;
using RobotMovesUI.Class.LeftMoves;
using RobotMovesUI.Class.RightMoves;
using RobotMovesUI.Class.MovesFreq;

namespace RobotMovesUI.Class
{
    class SendMove
    {
        public SendMove(IGoBack backMove,IGoForward forwardMove,
                   ITurnLeft leftMove, ITurnRight rightMove,
                   IFreqMove turnFreqMoves)
        {
            this.backMove = backMove;
            this.forwardMove = forwardMove;
            this.leftMove = leftMove;
            this.rightMove = rightMove;
            this.turnFreqMoves = turnFreqMoves;
        }
        IGoBack backMove;
        IGoForward forwardMove;
        ITurnLeft leftMove;
        ITurnRight rightMove;
        IFreqMove turnFreqMoves;

        public void setBackMove(IGoBack GoBackMove) =>
            backMove = GoBackMove;
        public void setForwardMove(IGoForward GoForwardMove) =>
            forwardMove = GoForwardMove;
        public void setLeftMove(ITurnLeft TurnLeftMove) =>
            leftMove = TurnLeftMove;
        public void setRightMove(ITurnRight TurnRightMove) =>
            rightMove = TurnRightMove;
        public void setFreqMove(IFreqMove TurnFreqMoves) =>
                turnFreqMoves = TurnFreqMoves;

        public void SendGoForward() =>
            forwardMove.GoForward();
        public void SendGoBack() =>
            backMove.GoBack();
        public void SendTurnLeft() =>
            leftMove.TurnLeft();
        public void SendTurnRight() =>
            rightMove.TurnRight();
        public void SendFreqMove(int freq) =>
            turnFreqMoves.moveWithSpeed(freq);
        public void SendStop()=>
            Port.Send("STP;");
        public void SendSpeed(int speed)=>
               Port.Send($"SF,{speed};");
    }
}
