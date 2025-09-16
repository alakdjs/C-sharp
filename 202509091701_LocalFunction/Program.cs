using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091701_LocalFunction
{
    internal class Program
    {
        // 로컬함수(Local Function)
        static string ToLowerString(string input)
        {
            // 대문자 문자열이 들어오면 문자형 배열로 바꿔준 뒤,
            // 인덱스 전달받아 만약 대문자라면 +32를 return해서 소문자로 출력
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            // 지역함수
            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // a~z의 ASCII 값 : 65 : 90
                    return arr[i];
                else // a~z의 ASCII 값 : 97 : 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
        }
    }
}
