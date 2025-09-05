using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051441
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수값을 입력하세요:");
            string inputStr = Console.ReadLine(); // 문자열을 입력
            // int inputValue = Console.Read(); // 한문자 입력

            int inputValue = int.Parse(inputStr); // 숫자문자열을 숫자값으로 변경.
            // int inputValue2 = Convert.ToInt32(inputStr);

            bool ret = (0 < inputValue) && (inputValue < 10);

            if (ret)
            {
                Console.WriteLine($"{inputValue}는 0과 10 사이에 있다.");
            }
            else
            {
                Console.WriteLine($"{inputValue}는 0과 10 사이에 없다.");
            }

            // 숙제
            // 1. 박스(0, 0) ~ (10, 10)안에 점(x,y)가 들어있는지 없는지 확인하는
            // 로직을 만드세요...
        }
    }
}
