using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051710_Conditional_Statement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("용돈을 입력하세요");
            string money = Console.ReadLine();

            int moneyValue = Convert.ToInt32(money);

            if (moneyValue <= 40000 && moneyValue > 20000)
            {
                Console.WriteLine("짜장면");
            }
            else if (moneyValue > 100000) // 다중조건문
            {
                Console.WriteLine("친구만남");
            }
            else if (moneyValue <= 100000 && moneyValue > 80000)
            {
                Console.WriteLine("볼링장");
            }
            else if (moneyValue <= 80000 && moneyValue > 60000)
            {
                Console.WriteLine("노래방");
            }
            else if (moneyValue <= 60000 && moneyValue > 40000)
            {
                Console.WriteLine("커피숍");
            }
            else
            {
                Console.WriteLine("낮잠");
            }
        }
    }
}
