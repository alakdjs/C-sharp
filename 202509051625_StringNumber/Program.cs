using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051625_StringNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열 숫자변환
            // 정수값을 문자열로 변환
            int a = 1000;
            string b = a.ToString();
            Console.WriteLine($"b = {b}");

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine($"d = {d}");

            // 숫자문자열을 정수값으로 변환
            string e = "13216546";
            int f = Convert.ToInt32(e);
            f = int.Parse(e);

            Console.WriteLine($"f = {f}");

            string g = "23.234";
            float h = float.Parse(g);
            h = (float)Convert.ToDouble(g);
            Console.WriteLine($"h = {h}");
        }
    }
}
