using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509301439_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = new int[100];

            System.Random rand = new System.Random();

            for(int i = 0; i < numList.Length; i++)
            {
                numList[i] = rand.Next(0, 100);
            }

            Console.WriteLine($"numList = ");
            foreach(var num in numList)
            {
                Console.WriteLine($"{num}, ");
            }
            Console.WriteLine();

            //var list = numList.Where(n => n > 20 && n < 50).OrderByDescending(n => n);

            // 메서드 구문(람다 매개변수)
            var list = numList.Where(n => n > 20 && n < 50).OrderBy(n => n);

            Console.WriteLine();
            Console.WriteLine($"list = ");
            foreach(var num in list)
            {
                Console.WriteLine($"{num}, ");
            }

            // from: 어떤 데이터에서 찾을 것인지.
            // where: 조건절
            // orderby: 어떤 항목을 기준으로 정렬할 것인가.
            // select: 어떤 항목을 추출할 것인가.

            // 쿼리 구문(범위변수)
            var listQuery = from n in list
                            where n > 20 && n < 50
                            orderby n ascending
                            select n;

            Console.WriteLine();
            var list2 = list.Distinct(); // 중복된 것을 삭제하고

            Console.WriteLine($"list2 = ");
            foreach(var num in list2)
            {
                Console.WriteLine($"{num}, ");
            }

        }
    }
}
