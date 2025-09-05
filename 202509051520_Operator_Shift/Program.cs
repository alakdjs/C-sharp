using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051520_Operator_Shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // shift 연산자
            // << 왼쪽 shift 연산자
            // >> 오른쪽 shift 연산자
            int a = 1;  // 00000001

            // 비트값을 왼쪽으로 1비트 민다는 것은 무슨 의미일까? x2
            a = a << 1;
            //      a:   00000001
            // a << 1:   00000010 // 2
            Console.WriteLine($"a = {Convert.ToString(a, 2)}");

            a = a << 2;
            //      a:   00000001
            // a << 2:   00001000 // 8
            Console.WriteLine($"a = {Convert.ToString(a, 2)}");

            // 오른쪽 shift
            // 오른쪽으로 1비트 민다는 것은 무슨 의미일까? /2
            a = a >> 1;
            //      a:     00001000
            // a >> 1:     00000100  // 4
            Console.WriteLine($"a = {Convert.ToString(a, 2)}");

            a = a >> 2;
            //      a:     00001000
            // a >> 2:     00000001  // 1
            Console.WriteLine($"a = {Convert.ToString(a, 2)}");
        }
    }
}
