using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091717_Overloading
{
    // 오버로딩(Overloading)
    // 같은 이름의 메소드(함수)를 만드는 것
    // 매개변수의 데이타 타입이 달라야 합니다.
    // 리턴 타입은 함수이름에 포함되지 않습니다.
    // 오버로딩은 다형성의 도구입니다.
    class Add
    {
        public int add(int a, int b) // addXX
        {
            return a + b;
        }

        /*
        public float add(int a, int b)
        {
           return a + b;
        }
        */


        public float add(float a, float b) // addYY
        {
            return a + b;
        }

        public double add(double a, double b) // addZZ
        {
            return a + b;
        }

        public string add(string a, string b) // addSS
        {
            return a + b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            float c = 3.4f;
            float d = 4.5f;

            double e = 10.2d;
            double f = 32.3d;

            string g = "monster";
            string i = " is World!!";

            Add add = new Add();

            Console.WriteLine($"{a} + {b} = {add.add(a, b)}"); // call add.addXX
            Console.WriteLine($"{c} + {d} = {add.add(c, d)}");  // call add.addYY
            Console.WriteLine($"{e} + {f} = {add.add(e, f)}");
            Console.WriteLine($"{g} + {i} = {add.add(g, i)}");
        }
    }
}