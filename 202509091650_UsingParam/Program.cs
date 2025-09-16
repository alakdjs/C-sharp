using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091650_UsingParam
{
    internal class Program
    {
        // 가변길이 인수
        // 인수의 갯수를 유연하게 사용할 수 있습니다.
        // params 키워드와 배열을 이용해서 선언하면 됩니다.
        // 데이터의 형식이 같다면 가변길이 인수를 통해 오버로딩 대신 사용할 수 있음.

        static int Sum(params int[] args)
        {
            int sum = 0;
            for(int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }

            return sum;
        }

        static string Sum(params string[] args)
        {
            string sum = "";
            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i] + ", ";
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int sumValue = 0;

            sumValue = Sum(1, 2);
            Console.WriteLine($"Sum = {sumValue}");

            sumValue = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum = {sumValue}");

            string fruits = Sum("배", "사과");
            Console.WriteLine($"fruits = {fruits}");

            fruits = Sum("apple", "banana", "pineApple", "mango");
            Console.WriteLine($"fruits = {fruits}");

            string[] ff = { "potato", "apple", "banana", "pineApple", "mango" };

            fruits = Sum(ff);
            Console.WriteLine($"fruits = {fruits}");
        }

    }
}
