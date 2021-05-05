using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

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
            Form1 form1 = (Form1) Application.OpenForms[0];
            form1.port.BaudRate = int.Parse(SpeedConf.SelectedItem.ToString());
            form1.port.PortName = PortConf.SelectedItem.ToString();
            MessageBox.Show("Конфигурация сохранена");
            form1.port.Open();
        }
    }
}
