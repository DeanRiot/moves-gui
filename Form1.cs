using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace RobotMovesUI
{
    public partial class Form1 : Form
    {
        public SerialPort port = new SerialPort();
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
                switch(e.KeyData.ToString())
                {
                    case "W":
                    Console.WriteLine("go forward");
                    break;

                    case "Q":
                    Console.WriteLine("go left independed");
                    break;

                    case "A":
                    Console.WriteLine("go left");
                    break;

                    case "S":
                    Console.WriteLine("go back");
                    break;

                    case "D":
                    Console.WriteLine("go right");
                    break;

                    case "E":
                    Console.WriteLine("go right independed");
                    break;
            }
                

        }
    }
}
