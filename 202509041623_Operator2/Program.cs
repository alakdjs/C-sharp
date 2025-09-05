using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509041623_Operator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // %: 나머지 연산자(modulate operator)
            int value = 1234;
            int remainder = value % 100; // 나머지를 구할때 사용

            Console.WriteLine($"{value} % 100 = {remainder}");
            Random random = new System.Random();

            for(int i = 0; i < 10; i++)
            {
                int randValue = random.Next(); // 난수 발생
                Console.WriteLine("randValue = {0}", randValue);

                // %(나머지 연산자) : 임의의값을 의미있는 범위의 값으로 만들때 사용
                // North: 0 , South: 1, West: 2, East: 3

                int actionValue = randValue % 4;
                Console.WriteLine($"actionValue = {actionValue}");

                switch(actionValue)
                {
                    case 0:
                        Console.WriteLine("North Move");
                        break;

                    case 1:
                        Console.WriteLine("South Move");
                        break;

                    case 2:
                        Console.WriteLine("West Move");
                        break;

                    case 3:
                        Console.WriteLine("East Move");
                        break;
                }
            }

        }
    }
}
