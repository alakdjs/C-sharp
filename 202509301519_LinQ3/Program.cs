using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509301519_LinQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var Digits = from digit in digits
                         where digit[1] == 'i' || digit[1] == 'n'
                         select digit;

            foreach(var data in Digits)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
            var reversedDigis = (from digit in digits
                                 where digit[1] == 'i' || digit[1] == 'n'
                                 select digit).Reverse();

            foreach(var data in reversedDigis)
            {
                Console.WriteLine($"{data}");
            }

        }
    }
}
