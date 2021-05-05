using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using RobotMovesUI.Class;

namespace RobotMovesUI
{
    public partial class Form1 : Form
    {
        public SerialPort port = new SerialPort();
        public SendBasicMoves moves = new SendBasicMoves();
        bool showLog = false;
        
        public Form1()
        {
            InitializeComponent();
            asyncStatusRead();
        }
        async void asyncStatusRead()
        {
            await Task.Run(()=> Status());
        }
        
         void Status()
         {
            while(true)
            {
                if (port.IsOpen)
                {
                    PortStatus.GetCurrentParent().Invoke(
                     new Action(()=> PortStatus.Text = "Подключение установленно"));
                    PortStatus.GetCurrentParent().Invoke(
                        new Action(() => PortStatus.ForeColor = System.Drawing.Color.Green));
                } 
                else
                {
                    PortStatus.GetCurrentParent().Invoke(
                     new Action(() => PortStatus.Text = "Устройство не подключенно"));
                    PortStatus.GetCurrentParent().Invoke(
                        new Action(() => PortStatus.ForeColor = System.Drawing.Color.Red));
                }
                Thread.Sleep(1000);
            }    
         }

        private void LeftMotorTrack_Scroll(object sender, EventArgs e)
        {
            LeftMotorPB.Value = LeftMotorTrack.Value;
        }

        private void RightMotorTrack_Scroll(object sender, EventArgs e)
        {
            RightMotorPB.Value = RightMotorTrack.Value;
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
                Log logForm = new Log();
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
            if (moves.PortStatus())
            {
                switch (e.KeyData.ToString())
                {
                    case "W":
                        moves.GoForward();
                        break;

                    case "Q":
                        moves.TurnLeftIndepended();
                        break;

                    case "A":
                        moves.TurnLeft();
                        break;

                    case "S":
                        moves.GoBack();
                        break;

                    case "D":
                        moves.TurnRight();
                        break;

                    case "E":
                        moves.TurnRightIndepended();
                        break;
                }
            }       

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if(moves.PortStatus())
            {
                moves.GoForward();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(moves.PortStatus())
            {
                moves.Stop();
                port.Close();
            }

        }
    }
}
