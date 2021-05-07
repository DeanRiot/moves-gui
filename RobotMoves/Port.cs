using System.IO.Ports;

namespace RobotMovesUI.Class
{
    public static class Port
    {
        public static SerialPort port = new SerialPort();

        public static void Close() =>
                             port.Close();
        public static void Send(string message)
        {
            if (port.IsOpen)
                port.WriteLine(message);
        }
        public static bool CheckStatus()
        {
            if (port.IsOpen)
            {
                port.WriteLine("BatLVL;");
                try
                {
                    if (port.ReadLine().Length > 1)
                        return true;
                }
                catch
                {
                    port.Close();
                    return false;
                }
            }
            return false;
        }
    }
}
