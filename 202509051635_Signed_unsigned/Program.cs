using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051635_Signed_unsigned
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 음수와 양수
            int a = 500;
            Console.WriteLine($"a = {a}");

            uint b = (uint)a;
            Console.WriteLine($"b = {b}");

            int x = -30;
            Console.WriteLine(Convert.ToString(x, 2));
            Console.WriteLine($"x = {x}");

            uint y = (uint)x;
            Console.WriteLine($"y = {y}");

            sbyte i = -1;   // 11111111 // -128 ~ 127
            Console.WriteLine($"i = {i}");

            byte ii = (byte)i;  // 0 ~ 255
            Console.WriteLine($"ii = {ii}");

        }
    }
}
