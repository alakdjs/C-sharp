using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081454_Switch_Case_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#에서는 문자열이 가능합니다.
            Console.WriteLine("과일 이름을 영문으로 입력하세요: ");
            string kindStr = Console.ReadLine();

            switch (kindStr)
            {
                case "banana":
                    Console.WriteLine("바나나");
                    break;

                case "apple":
                    Console.WriteLine("사과");
                    break;

                case "mango":
                    Console.WriteLine("망고");
                    break;

                default:
                    Console.WriteLine("무슨 과일인지 모르겠습니다.");
                    break;

            }
        }
    }
}
