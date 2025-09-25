using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509251607_GenericMethod_Exer
{
 
    internal class Program
    {
        // PrintAll 메소드가 아래의 타입에 작동하도록 
        // 일반화 메소드로 만들고 실행 시켜보세요.

        static void PrintAll<T>(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            float[] fnumbers = { 3.4f, 7.4f, 8.9f, 10.8f, 12.7f, 13.8f };
            string[] fruits = { "Apple", "Banana", "Cherry"};

            Console.WriteLine("=== Numbers ===");
            PrintAll(numbers);

            Console.WriteLine("=== Numbers ===");
            PrintAll(fnumbers);

            Console.WriteLine("=== Numbers ===");
            PrintAll(fruits);
        }
    }
}
