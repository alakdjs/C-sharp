using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091644_OptionalParam
{
    internal class Program
    {
        // Optional parameter(선택적 매개변수)
        // 메소드 선언시 매개변수에 기본값을 할당
        // 호출자가 인수를 입력하지 않은 경우 메소드는 기본값이 할당된 매개변수를 사용
        // 호출자는 해당 매개변수에[ 대한 인수 입력여부를 선택하여 호출할 수 있습니다.

        static void PrintMergeName(string name, string nickName = "바보")
        {
            Console.WriteLine("{0}은 {1}이다", name, nickName);
        }

        static void Main(string[] args)
        {
            PrintMergeName("몬스터");
            PrintMergeName("몬스터", "천재");
            PrintMergeName(name: "몬스터");
            PrintMergeName(name: "몬스터", nickName: "천재");
        }
    }
}
