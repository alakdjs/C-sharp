using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021543_StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "12";
            string name = "hamberger";
            string price = "$4000";

            // 공백 넣기
            var stringLine = num.PadRight(5);
            stringLine += name.PadRight(10);
            stringLine += price.PadLeft(10);

            Console.WriteLine(stringLine);

            num = "1234";
            name = "pizza";
            price = "$10000";

            stringLine = num.PadRight(5);
            stringLine += name.PadRight(10);
            stringLine += price.PadLeft(10);
            Console.WriteLine(stringLine);
        }
    }
}
