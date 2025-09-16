using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091621_NamedParam
{
    class Program
    {
        // Named Parameter (명명된 인수)
        // 메소드 호출시 매개변수의 이름을 명시하여 매개변수에 데이터를 바인딩하는 기능

        static void PrintInfo(string name, string phone, int age)
        {
            Console.WriteLine("이름: {0}, 전화번호: {1}, 나이: {2}", name, phone, age);
        }

        static void Main(string[] args)
        {
            PrintInfo(name: "손흥민", phone: "1111- 1111", 32);
            PrintInfo(phone: "1111 - 1111", name: "손흥민", age: 32);
            PrintInfo("손흥민", "1111-1111", age: 32);
        }
    }
}
