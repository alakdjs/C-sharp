using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081606_for_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 반복문
            // for, while, do-while

            // for(초기식; 조건식; 증감식){
            //       명령어;
            // }

            // 반복횟수를 아는 경우에 사용하기 좋은 구조입니다.
            for (int i = 0; i < 10; i++) // 단일 for문
            {
                Console.WriteLine($"i = {i}");
            }

            for (int i = 0, j = 10; i < 10 && j > 0; i += 2, j -= 2)
            {
                Console.WriteLine($"i = {i}, j = {j}");
            }

            for(int i = 0; i < 10; i++) // 이중 for문
            {
                for(int j = 0; j < 10; i++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }

            // while문은 반복횟수는 모르겠지만
            // while문의 조건식이 참인 동안에는 얼마든지 반복해도 괜찮을때.

            float a = 1234.234f;
            
            while(a > 0)
            {
                a -= 123.34f;
                Console.WriteLine($"a = {a}");
            }

            a = 12312341.1234f;

            do
            {
                a -= 123.234f;
                Console.WriteLine($"a = {a}");
            } while(a > 0);

        }
    }
}
