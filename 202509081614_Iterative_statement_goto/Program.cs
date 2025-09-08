using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081614_Iterative_statement_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2000;
            int j = 3000;
            int k = 4000;

            int limitValue = 0;

            int exit = 0;

            Console.Write("정수값을 입력하세요: ");
            limitValue = int.Parse(Console.ReadLine());

            while (i > 0)
            {
                // 3중 while문
                i -= 10;
                while (j > 0)
                {
                    j -= 10;
                    while (k > 0)
                    {
                        k -= 10;
                        Console.WriteLine("i = {0}, j = {1}, k = {2}", i, j, k);

                        int sum = i * j * k;

                        if (sum < limitValue)
                        {
                            Console.WriteLine("sum = {0}, limitValue = {1}\n", sum, limitValue);
                            exit = 1;
                            break;  // 반복문을 탈출할때 사용
                                    // break문이 사용된 위치에서 가장 가까운 반복문을 탈출한다.
                        }
                    }

                    if (exit == 1)
                    {
                        break;
                    }
                }

                if (exit == 1)
                {
                    break;
                }
            }

            // goto문 사용
            while (i > 0)
            {
                i -= 10;
                while (j > 0)
                {
                    j -= 10;
                    while (k > 0)
                    {
                        k -= 10;
                        Console.WriteLine("i = {0}, j = {1}, k = {2}", i, j, k);

                        int sum = i * j * k;

                        if (sum < limitValue)
                        {
                            Console.WriteLine("sum = {0}, limitValue = {1}", sum, limitValue);

                            goto LoopExit;
                            // 중첩되어있는 반복문을 한번에 탈출할때 goto문을 사용하면
                            // 코드를 간결하게 처리할 수 있습니다.
                        }
                    }
                }
            }

        LoopExit:;  // 레이블
        }
    }
}
