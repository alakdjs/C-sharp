using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509261544_CollectionArrayList
{
    class Customer
    {
        private string _name;
        private string _birth;
        private int _age;

        public Customer(string name, string birth, int age)
        {
            _name = name;
            _birth = birth;
            _age = age;
        }

        public override string ToString()
        {
            return $"이름: {_name}, 생년월일: {_birth}, 나이: {_age}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList _arrayList = new ArrayList();

            _arrayList.Add(33); // int 형
            _arrayList.Add("String"); // string 형
            _arrayList.Add(3.14f);  // float 형
            _arrayList.Add(true); // bool 형
            _arrayList.Add(new Customer("monster", "18002222", 1000)); // class Customer 형
            _arrayList.Insert(2, new Customer("monster2", "12312312", 1100));

            for(int i = 0; i < _arrayList.Count; i++)
            {
                Console.WriteLine($"{_arrayList[i]}");
            }
            Console.WriteLine();

            _arrayList.Remove(3.14f);

            for(int i = 0; i < _arrayList.Count; i++)
            {
                Console.WriteLine($"{_arrayList[i]}");
            }
            Console.WriteLine();

            _arrayList.Remove(3);

            for(int i = 0; i < _arrayList.Count; i++)
            {
                Console.WriteLine($"{_arrayList[i]}");
            }
            Console.WriteLine();

            if(_arrayList.Contains("String"))
            {
                Console.WriteLine("String 문자열이 저장되어있습니다.");
            }

            _arrayList.Clear();
        }
    }
}
