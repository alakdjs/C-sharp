using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021550_StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "01x3456x89";
            int index = str1.IndexOf("x"); // 0부터시작해서 x 문자의 index 위치를 리턴한다.
            Console.WriteLine(index);

            index = str1.LastIndexOf("x"); // 뒤에서 부터 앞쪽으로 이동하면서 x 문자의 index 위치를 리턴한다.
            Console.WriteLine(index);

            string str2 = "aaa (1234) cccc [5678] {ee}";

            char[] checkChar = { '(', '{', '[' };

            int endPosition = 0;

            while (true)
            {
                int startPosition = str2.IndexOfAny(checkChar, endPosition);
                // checkChar 배열에 저장되어있는 문자중에 아무거나 찾은 위치를 리턴한다.

                if (startPosition == -1) break; // checkChar배열에 있는 문자가 비교하는 문자열에 없는 경우

                string startChar = str2.Substring(startPosition, 1); // 찾은 문자가 뭔지 확인

                char endChar = ' ';

                switch (startChar)
                {
                    case "(":
                        endChar = ')';
                        break;
                    case "{":
                        endChar = '}';
                        break;
                    case "[":
                        endChar = ']';
                        break;
                }

                startPosition++;
                endPosition = str2.IndexOf(endChar, startPosition); // endChar에 등록된 문자의 위치를 찾는다.

                int length = endPosition - startPosition; // 찾은 괄호 사이에 있는 문자열의 길이를 계산

                Console.WriteLine(str2.Substring(startPosition, length)); // 괄호안에 문자열을 잘라서 출력한다.

            }
        }
    }
}
