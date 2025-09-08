using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081550_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputValue = 0;

        Start:
            Console.WriteLine("값을 입력하세요: ");
            inputValue = int.Parse(Console.ReadLine());

            if(inputValue < 10)
            {
                goto Exit;  // 하향식분기
            }

            Console.WriteLine($"{inputValue} 값이 10보다 크거나 같아서 다시");

            goto Start;     // 상향식 분기

            Console.WriteLine("절대실행안됨");

        Exit: // 레이블
            Console.WriteLine($"{inputValue} 값이 10보다 작아서 탈출");
        }
    }
}
