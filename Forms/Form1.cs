using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using RobotMovesUI.Class;
using System.Collections;
using System.Collections.Generic;
using RobotMovesUI.Forms;

namespace RobotMovesUI
{
    public partial class Form1 : Form
    {

        public SerialPort port = new SerialPort();
        public GetInfo info = new GetInfo();
        public RobotMoves moves;
        
        Log logForm = new Log();
        bool showLog = false;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            asyncStatusRead();
            asyncBatteryRead();
        }

        private void PinsConfig_Click(object sender, EventArgs e)
        {
            PinsConfigForm pinsConfig = new PinsConfigForm();
            pinsConfig.ShowDialog();
        }
        async void asyncStatusRead()
        {
            await Task.Run(()=> Status());
        }
        async void asyncBatteryRead()
        {
            await Task.Run(() => BattInfo());
        }
        void BattInfo()
        {
            while(true)
            {
                if (port.IsOpen)
                {
                    BatteryLevel.GetCurrentParent().Invoke(
                    new Action(() => BatteryLevel.Text = $"{info.getBattValue()}%"));
                    Thread.Sleep(60000);
                }
            }
        }
         void Status()
         {
            Queue<string> log = new Queue<string>();
            while (true)
            {
                if (port.IsOpen)
                {
                    PortStatus.GetCurrentParent().Invoke(
                     new Action(()=> PortStatus.Text = "Подключение установленно"));
                    PortStatus.GetCurrentParent().Invoke(
                        new Action(() => PortStatus.ForeColor = System.Drawing.Color.Green));
                    if (showLog)
                    {
                        while(log.Count!=0)
                        {
                            logForm.logText.Invoke(new Action(() =>
                                logForm.logText.Text += $"{log.Dequeue()}\n"));
                        }
                        logForm.logText.Invoke(new Action(() =>
                                logForm.logText.Text += "Подключение установленно\n"));
                    }
                    else
                    {
                        log.Enqueue("Подключение установленно\n");
                    }   
                } 
                else
                {
                    PortStatus.GetCurrentParent().Invoke(
                     new Action(() => PortStatus.Text = "Устройство не подключенно"));
                    PortStatus.GetCurrentParent().Invoke(
                        new Action(() => PortStatus.ForeColor = System.Drawing.Color.Red));
                    if (showLog)
                    {
                        while (log.Count != 0)
                        {
                            logForm.logText.Invoke(new Action(() =>
                                logForm.logText.Text += $"{log.Dequeue()}\n"));
                        }
                        logForm.logText.Invoke(new Action(() =>
                                logForm.logText.Text += "Подключение не установленно\n"));
                    }
                    else
                    {
                        log.Enqueue("Подключение не установленно\n");
                    }
                }
                Thread.Sleep(1000);
            }    
         }

        private void LeftMotorTrack_Scroll(object sender, EventArgs e)
        {
            LeftMotorPB.Value = LeftMotorTrack.Value;
            moves.TurnLeftWithSpeed(LeftMotorTrack.Value);
        }

        private void RightMotorTrack_Scroll(object sender, EventArgs e)
        {
            RightMotorPB.Value = RightMotorTrack.Value;
            moves.TurnLeftWithSpeed(RightMotorTrack.Value);
        }

        private void ComMenu_Click(object sender, EventArgs e)
        {
            PortConfig portConfig = new PortConfig();
            portConfig.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(!showLog)
            { 
                logForm.Show();
                logForm.logText.Text += port.IsOpen ? "Соединение установленно" : "Соединение отсутствует";
                showLog = true;
            }
            else
            {
                Log log = (Log)Application.OpenForms["Log"];
                log.Close();
                showLog = false;
            }
        }

        private void ForwardButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (moves.CheckPortStatus())
            {
                switch (e.KeyData.ToString())
                {
                    case "W":
                        moves.GoForwardFullSpeed();
                        break;

                    case "Q":
                        moves.TurnLeftIndependedFullSpeed();
                        break;

                    case "A":
                        moves.TurnLeftFullSpeed();
                        break;

                    case "S":
                        moves.GoBackFullSpeed();
                        break;

                    case "D":
                        moves.TurnRightFullSpeed();
                        break;

                    case "E":
                        moves.TurnRightIndependedFullSpeed();
                        break;

                    case "X":
                        moves.StopMotors();
                        break;
                }
            }       

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if(moves.CheckPortStatus())
            {
                switch (((Button)sender).Tag)
                {
                    case "0":
                        moves.GoForwardFullSpeed();
                        break;
                    case "1":
                        moves.TurnLeftFullSpeed();
                        break;
                    case "2":
                        moves.StopMotors();
                        break;
                    case "3":
                        moves.TurnRightFullSpeed();
                        break;
                    case "4":
                        moves.TurnLeftIndependedFullSpeed();
                        break;
                    case "5":
                        moves.GoBackFullSpeed();
                        break;
                    case "6":
                        moves.TurnRightIndependedFullSpeed();
                        break;
                }
                moves.GoForwardFullSpeed();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(moves.CheckPortStatus())
            {
                moves.StopMotors();
                port.Close();
            }

        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        private void RightIndependedButton_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
