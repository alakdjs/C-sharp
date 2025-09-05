using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051506_Operator_Bit_Complement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 컴퓨터에서의 음의 정수
            // 뺄셈..
            int a;
            int b;

            a = 2 - 2; // 뺄셈을 할 줄 모릅니다.
            a = 2 + (-2);

            // 보수연산
            // 00000010 (2)
            // 11111101 (1의 보수)
            // 11111110 (2의 보수) (-2)

            //        2:   00000010
            //       -2:   11111110
            // 2 + (-2):   00000000

            a = -2;
            Console.WriteLine("a = {0}", Convert.ToString(a, 2));
        }
    }
}
