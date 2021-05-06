using System;
using System.Diagnostics;
using System.IO.Ports;

namespace RobotMovesUI.Class
{
    public class GetInfo
      {
        private SerialPort port;

        public void SetPort(SerialPort port)
        {
            this.port = port;
        }
        public int GetPWMFreq()
        {
            port.WriteLine("GF;");
            var answer = port.ReadTo(":");
            var strings = answer.Split();
            var index = strings.Length - 2;
            Console.WriteLine($"{strings[index]}");
            return int.Parse(strings[index]);
        }
        public string getInfo()
        {
            port.WriteLine("Info;");
            var answer = port.ReadTo(":");
            Console.WriteLine(answer);
            return "null";
        }

        public string getBattValue()
        {
            port.WriteLine("BatLVL;");
            var answer = port.ReadTo(":");
            var str = answer.Split();
            var index = str.Length - 2;
            Console.WriteLine($"{str[index]}");
            return str[index];
        }
    }
}
