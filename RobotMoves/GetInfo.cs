using System;
using System.Diagnostics;
using System.IO.Ports;

namespace RobotMovesUI.Class
{
    public class GetInfo
      {
        public int GetPWMFreq()
        {
            Port.Send("GF;");
            var answer = Port.port.ReadTo(":");
            var strings = answer.Split();
            var index = strings.Length - 2;
            Console.WriteLine($"{strings[index]}");
            return int.Parse(strings[index]);
        }
        public string getInfo()
        {
            Port.Send("Info;");
            var answer = Port.port.ReadTo(":");
            Console.WriteLine(answer);
            return "null";
        }

        public string getBattValue()
        {
            if(!Port.port.IsOpen)
                return "0";
            try
            {
                Port.Send("BatLVL;");
                var answer = Port.port.ReadTo(":");
                var str = answer.Split();
                var index = str.Length - 2;
                Console.WriteLine($"{str[index]}");
                return str[index];
            }
            catch
            {
                return "0";
            }
        }
    }
}
