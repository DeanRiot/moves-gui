using System;
using System.Windows.Forms;
using System.IO.Ports;
using RobotMovesUI.Class;

namespace RobotMovesUI
{
    public partial class PortConfig : Form
    {
        public PortConfig()
        {
            InitializeComponent();
            PortConf.Items.AddRange(SerialPort.GetPortNames());
        }

        private void ChangeConfig_Click(object sender, EventArgs e)
        {
            if(PortConf.Text!="" && SpeedConf.Text != "")
            {
                Form1 form1 = (Form1)Application.OpenForms[0];

                    Port.port.BaudRate = int.Parse(SpeedConf.Text);
                    Port.port.PortName = PortConf.Text;
                    Port.port.ReadTimeout = 1000;
                try
                {
                    Port.port.Open();
                }
                catch
                {
                    MessageBox.Show("Порт Закрыт");
                }
                    
                    
                    if (Port.CheckStatus())
                    {
                        MessageBox.Show("Конфигурация сохранена");
                        form1.setPortConfig();
                    }
                else
                {
                    MessageBox.Show("Порт не доступен!", "Ошибка конфигурации");
                }
            }
        }
    }
}
