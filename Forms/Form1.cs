using System;
using System.Windows.Forms;
using RobotMovesUI.Class;
using RobotMovesUI.Forms;
using RobotMovesUI.Class.BackMoves;
using RobotMovesUI.Class.ForwardMoves;
using RobotMovesUI.Class.LeftMoves;
using RobotMovesUI.Class.RightMoves;
using RobotMovesUI.Class.MovesFreq;
using System.Threading;

namespace RobotMovesUI
{
    public partial class Form1 : Form
    {
        private GetInfo info = new GetInfo();
        private CalcPwm calcPwm = new CalcPwm();
        private SendMove moveSet = new SendMove(new BackFullSpeed(),
                                                new ForwardFullSpeed(),
                                                new TurnLeftFullSpeed(),
                                                new TurnRightFullSpeed(),
                                                new TurnRightMotorWithSpeed());
        
        
        public Form1()=>
            InitializeComponent();
        
        public void setPortConfig()
        {
             ChangeUIEnable(Port.CheckStatus()); 
        }
        public void closePort()
        {
            if (Port.CheckStatus())
            {
                moveSet.SendStop();
                ChangeUIEnable(false);
                Port.Close();
            }
            else return;
        }
        //______Moves methods_________
        private void LeftMotorTrack_Scroll(object sender, EventArgs e)
        {
            LeftMotorPB.Value = LeftMotorTrack.Value;
            moveSet.setFreqMove(new TurnLeftMotorWithSpeed());
            moveSet.SendFreqMove(calcPwm.Calc(LeftMotorTrack.Value));  
        }

        private void RightMotorTrack_Scroll(object sender, EventArgs e)
        {
            RightMotorPB.Value = RightMotorTrack.Value;
            moveSet.setFreqMove(new TurnRightMotorWithSpeed());
            moveSet.SendFreqMove(calcPwm.Calc(RightMotorTrack.Value));
        }

        void ButtonsMoves(int moveNum, bool withSpeed)
        {
            if (moveNum >= 0 || moveNum <= 6)
            {
                if (withSpeed)
                {
                    switch (moveNum)
                    {
                        case 0:
                            moveSet.setForwardMove(new GoForwardPwm());
                            moveSet.SendGoForward();
                            break;
                        case 1:
                            moveSet.setLeftMove(new TurnLeftPwm());
                            moveSet.SendTurnLeft();
                            break;
                        case 2:
                            moveSet.SendStop();
                            break;
                        case 3:
                            moveSet.setRightMove(new TurnRightPwm());
                            moveSet.SendTurnRight();
                            break;
                        case 4:
                            moveSet.setLeftMove(new TurnLeftMotorPwm());
                            moveSet.SendTurnLeft();
                            break;
                        case 5:
                            moveSet.setBackMove(new BackPwm());
                            moveSet.SendGoBack();
                            break;
                        case 6:
                            moveSet.setRightMove(new TurnRightMotorPwm());
                            moveSet.SendTurnRight();
                            break;
                    }
                }
                else
                {
                    switch (moveNum)
                    {
                        case 0:
                            moveSet.setForwardMove(new ForwardFullSpeed());
                            moveSet.SendGoForward();
                            break;
                        case 1:
                            moveSet.setLeftMove(new TurnLeftFullSpeed());
                            moveSet.SendTurnLeft();
                            break;
                        case 2:
                            moveSet.SendStop();
                            break;
                        case 3:
                            moveSet.setRightMove(new TurnRightFullSpeed());
                            moveSet.SendTurnRight();
                            break;
                        case 4:
                            moveSet.setLeftMove(new TurnLeftMotor());
                            moveSet.SendTurnLeft();
                            break;
                        case 5:
                            moveSet.setBackMove(new BackFullSpeed());
                            moveSet.SendGoBack();
                            break;
                        case 6:
                            moveSet.setRightMove(new TurnRightMotor());
                            moveSet.SendTurnRight();
                            break;
                    }
                }
            }
            else Console.WriteLine("No move in moveSet");
        }

        //__________Buttons and keyboard methods_____________
        private void Buttons_Click(object sender, EventArgs e)
        {
            if(Port.port.IsOpen)
            {
                Console.WriteLine(((Button)sender).Tag);
                var state = int.Parse(((Button)sender).Tag.ToString());
                MotorsPB(state);
                ButtonsMoves(state, SpeedCheck.Checked);
            }
        }
        private void Button_KeyUp(object sender, KeyEventArgs e)
        {
            if (Port.port.IsOpen)
            {
                bool withSpeed = SpeedCheck.Checked;
            switch (e.KeyData.ToString())
            {
                case "W":
                        MotorsPB(0);
                        ButtonsMoves(0, withSpeed);
                        break;

                case "Q":
                        MotorsPB(4);
                        ButtonsMoves(4, withSpeed);
                        break;

                case "A":
                        MotorsPB(1);
                        ButtonsMoves(1, withSpeed);
                        break;

                case "S":
                        MotorsPB(5);
                        ButtonsMoves(5, withSpeed);
                        break;

                case "D":
                        MotorsPB(3);
                        ButtonsMoves(3, withSpeed);
                        break;

                case "E":
                        MotorsPB(6);
                        ButtonsMoves(6, withSpeed);
                        break;

                case "X":
                        MotorsPB(2);
                        ButtonsMoves(2, withSpeed);
                        break;
            }
            }
        }
        //___Status Check Timers___
        private void batteryTimer_Tick(object sender, EventArgs e)
        {
            if (Port.port.IsOpen)
                if (int.TryParse(info.getBattValue(), out int level))
                {
                    BatteryLevel.Text = $"{level}%";
                    Console.WriteLine(level);
                }

        }
        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            if (Port.port.IsOpen)
            {
                PortStatus.Text = "Подключение установленно";
                PortStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                PortStatus.Text = "Устройство не подключенно";
                PortStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            batteryTimer.Enabled = true;
            batteryTimer.Start();
            StatusTimer.Enabled = true;
            StatusTimer.Start();
        }
        //_____Menu methods______
        private void CloseMenu_Click(object sender, EventArgs e) =>
             closePort();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) =>
             closePort(); 

        private void ComMenu_Click(object sender, EventArgs e)
        {
            PortConfig portConfig = new PortConfig();
            portConfig.ShowDialog();
        }
        private void PinsConfig_Click(object sender, EventArgs e)
        {
            if (Port.CheckStatus())
            {
                PinsConfigForm pinsConfig = new PinsConfigForm();
                pinsConfig.ShowDialog();
            }
            else
            {
                MessageBox.Show("Порт не сконфигурирован", "Ошибка");
            }
        }

        //______UI Methods_______
        public void ChangeUIEnable(bool status)
        {
            ForwardButton.Enabled = status;
            LeftIndependedButton.Enabled = status;
            StopButton.Enabled = status;
            RightIndependedButton.Enabled = status;
            LeftButton.Enabled = status;
            BackButton.Enabled = status;
            RightButton.Enabled = status;
            LeftMotorTrack.Enabled = status;
            RightMotorTrack.Enabled = status;
        }
        public void MotorsPB(int state)
        {
            switch (state)
            {
                case 0:
                    LeftMotorPB.Value = 250;
                    RightMotorPB.Value = 250;
                    break;
                case 1:
                    LeftMotorPB.Value = 250;
                    RightMotorPB.Value = 0;
                    break;
                case 2:
                    LeftMotorPB.Value = 125;
                    RightMotorPB.Value = 125;
                    break;
                case 3:
                    LeftMotorPB.Value = 0;
                    RightMotorPB.Value = 250;
                    break;
                case 4:
                    LeftMotorPB.Value = 250;
                    RightMotorPB.Value = 125;
                    break;
                case 5:
                    LeftMotorPB.Value = 0;
                    RightMotorPB.Value = 0;
                    break;
                case 6:
                    LeftMotorPB.Value = 125;
                    RightMotorPB.Value = 250;
                    break;
            }
        }

        private void SpeedTrack_Scroll(object sender, EventArgs e)
        {
            if(SpeedCheck.Checked)
                moveSet.SendSpeed(SpeedTrack.Value);
        }
    }
}