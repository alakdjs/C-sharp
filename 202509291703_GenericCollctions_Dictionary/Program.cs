using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509291703_GenericCollctions_Dictionary
{
    struct Item
    {
        public int Id;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("사과", 100);
            dic.Add("바나나", 200);
            dic.Add("딸기", 1000);
            dic.Add("망고", 2000);

            Console.Write($"과일명을 입력하세요: ");
            string keyName = Console.ReadLine();

            /*
            int value = 0;
            if(dic.TryGetValue(keyName, out value) )
            {
                Console.WriteLine($"{keyName}: {value}개");
            }
            else
            {
                Console.WriteLine($"{keyName}이 없습니다.");
            }
            */

            if(dic.ContainsKey(keyName))
            {
                Console.WriteLine($"{dic[keyName]}");
            }
            else
            {
                Console.WriteLine($"{keyName}이 없습니다.");
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.WriteLine("키값만 출력");

            foreach(var key in dic.Keys)
            {
                Console.WriteLine($"{key}");
            }

            Console.WriteLine("Value값만 출력");
            foreach(var value in dic.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
