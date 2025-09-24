using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    class Test
    {
        public int _intNum;
        public float _floatNum;

        public Test(int intNum, float floatNum)
        {
            _intNum = intNum;
            _floatNum = floatNum;
        }

        public override string ToString()
        {
            return $"_intNum = {_intNum}, _floatNum = {_floatNum}";
        }
    }

    class Number
    {
        int _intNum;
        float _floatNum;
        double _doubleNum;
        string _stringNum;

        public Number(int intNum, float floatNum, double doubleNum, string stringNum)
        {
            _intNum = intNum;
            _floatNum = floatNum;
            _doubleNum = doubleNum;
            _stringNum = stringNum;
        }

        // 아래 Main 함수의 코드가 작동하도록 형변환 연산자를 만들어 넣으세요.
        // 명시적 형변환을 하세요....
        public static explicit operator int(Number number)
        {
            return number._intNum;
        }

        public static explicit operator float(Number number)
        {
            return number._floatNum;
        }

        public static explicit operator double(Number number)
        {
            return number._doubleNum;
        }

        public static explicit operator string(Number number)
        {
            return number._stringNum;
        }

        public static explicit operator Test(Number number)
        {
            Test test = new Test(number._intNum, number._floatNum);
            return test;
        }
    }
}

namespace _202509241537_OperatorOverloading3
{
    class Program
    {
        static void Main(string[] args)
        {
            Custom.Number number = new Custom.Number(100, 12.23f, 1234.45, "일백만원");

            int num = (int)number;
            float fnum = (float)number;
            double dnum = (double)number;
            string snum = (string)number;
            Custom.Test test = (Custom.Test)number;

            Console.WriteLine($"num = {num}, fnum = {fnum}, dnum = {dnum}, snum = {snum}");
            Console.WriteLine($"Custom.Test = {test}");
        }
    }
}