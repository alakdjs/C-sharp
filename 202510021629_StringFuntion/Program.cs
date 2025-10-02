using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021629_StringFuntion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Split(), ToCharArray(), Join()
            string myCities = "seoul,deajeon,busan,jeju";

            // 문자열을 ,(delemeter)구분자를 기준으로 문자열 배열로 분리
            string[] cities = myCities.Split(','); 

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            char[] charArray = myCities.ToCharArray(); // 문자열을 문자배열로 분리
            foreach (char c in charArray)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            // 배열에 있는 문자열을 //(구분자)를 추가해서 병합
            string result3 = String.Join(" // ", cities);
            Console.WriteLine(result3);
        }
    }
}
