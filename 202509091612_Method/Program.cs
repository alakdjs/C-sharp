using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091612_Method
{
    // C#언어는 완벽한 객체지향 언어로 모든 것이 다 객체로 이루어져 있습니다. 
    // 객체는 멤버필드(속성)과 메소드(액션, 행위)로 구성되어있습니다.
    // 속성(attribute): 다른 객체와 구별되어지는 데이타를 말합니다.
    // 액션(behaviour): 객체의 행동을 구성합니다.

    // 액션은 메소드로 표현됩니다.

    // 메소드는
    // returnType 메소드명(매개변수){
    //      명령어들;
    // }

    // returnType 메소드가 묶어놓은 명령어들을 처리하고 결과값을
    // return 값이 없는경우에는 void로 지정하면됩니다.
    // returnType이 있는 경우에는 메소드의 블럭 안에 return문이 있어야 합니다.
    // 어떤 DataType으로 전달할 건지.
    // 메소드명 메소드를 호출할때 사용할 이름
    // 매개변수(parameter): 메소드를 호출할때 전달할 인자값(argument)을 받는 변수



    class Calculator
    {
        public int add(int a, int b)
        {
            int temp = a + b;
            return temp;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public void printName()
        {
            Console.WriteLine("Calculator");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;



            Calculator cal = new Calculator();

            int ret = cal.add(a, b); // 메소드는 객체를 통해서만 호출할 수 있습니다.
            Console.WriteLine($"{a} + {b} = {ret}");

            ret = cal.sub(a, b);
            Console.WriteLine($"{a} - {b} = {ret}");

            cal.printName();
        }
    }
}
