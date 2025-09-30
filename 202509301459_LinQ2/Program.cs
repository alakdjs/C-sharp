using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509301459_LinQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "strawberry", "mango", "banana", "apple", "blueberry", "melon" };
            string[] digits = { "zero", "one", "two", "three", "four", 
                "five", "six", "seven", "eight", "nine", "a", "z" };

            var sortedfruits = from fruit in fruits
                               orderby fruit descending
                               select fruit;

            foreach(var str in sortedfruits)
            {
                Console.WriteLine($"{str}, ");
            }
            
            Console.WriteLine();

            var linqList = from fruit in fruits
                           where fruit.StartsWith("s") && fruit.Length > 3
                           select fruit;

            foreach(var str in linqList)
            {
                Console.WriteLine(str + " ");
            }

            Console.WriteLine();

            var sortedDigits = from digit in digits
                              orderby digit.Length descending
                              select digit;
            
            foreach(var data in sortedDigits)
            {
                Console.WriteLine($"[{data}] ");
            }

        }
    }
}
