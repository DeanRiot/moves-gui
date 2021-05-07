using System;
using System.Windows.Forms;
using RobotMovesUI.Class;

namespace RobotMovesUI.Forms
{
    public partial class PinsConfigForm : Form
    {
        public RobotSettings settings = new RobotSettings();
        public PinsConfigForm()
        {
            InitializeComponent();
        }

        private void PinsConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void Config_Click(object sender, EventArgs e)
        {
            settings.setPins(int.Parse(LeftForwardPin.Text),
                                int.Parse(LeftBack.Text),
                                int.Parse(RightForward.Text),
                                int.Parse(RightBack.Text));
        }

        private void RightForward_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
