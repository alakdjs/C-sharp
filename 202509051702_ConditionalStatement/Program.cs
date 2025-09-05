using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051702_ConditionalStatement
{
    // 제어문: 프로그램의 실행흐름을 제어할때 사용
    // 조건문
    //  분기문: 분기(실행흐름을 다른쪽으로 보내버리는 것)
    //   조건 분기: if, if-else, if-else-if, switch-case(선택문)
    //   무조건 분기: goto
    // 반복문: for, while, do-while

    internal class Program
    {
        static void Main(string[] args)
        {
            int inputValue = 0;
            Console.WriteLine("정수값을 입력하세요:");

            inputValue = int.Parse(Console.ReadLine());

            // if(조건식){
            //    명령어;
            // }

            if(inputValue > 10) // 단일 조건문
            {
                Console.WriteLine($"inputValue: {inputValue}가 10보다 크다");
            }

            Console.WriteLine("정수값을 입력하세요");
            inputValue = int.Parse(Console.ReadLine());

            if(inputValue <= 10) // 이중 조건문
            {
                Console.WriteLine($"inputValue: {inputValue}가 0보다 작거나 같다.");
            }
            else
            {
                Console.WriteLine($"inputValue: {inputValue}가 0보다 크다.");
            }

        }
    }
}
