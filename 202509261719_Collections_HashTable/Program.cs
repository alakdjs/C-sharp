using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509261719_Collections_HashTable
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
    }

    class Fruit
    {
        string _kindName;
        int _amount;
        Grade _grade;

        public string kindName
        {
            get => _kindName;
        }

        public Fruit(string kindName, int amount, Grade grade)
        {
            _kindName = kindName;
            _amount = amount;
            _grade = grade;
        }
        public override string ToString()
        {
            return $"과일명: {_kindName}, 보유량: {_amount}, 등급: {_grade}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable fruitTable = new Hashtable();

            Fruit[] fruits = new Fruit[]
            {
                new Fruit("apple", 100, Grade.A),
                new Fruit("banana", 200, Grade.B),
                new Fruit("mango", 300, Grade.C),
                new Fruit("strawberry", 1000, Grade.A)
            };

            for(int i = 0; i < fruits.Length; i++)
            {
                fruitTable.Add(fruits[i].kindName, fruits[i]);
            }

            Console.WriteLine("찾는 과일명을 입력하세요: ");

            string name = Console.ReadLine();

            if(fruitTable.ContainsKey(name))
            {
                Console.WriteLine($"{fruitTable[name]}");
            }

            Console.Write("삭제할 과일명을 입력하세요: ");

            name = Console.ReadLine();

            if(fruitTable.ContainsKey(name))
            {
                fruitTable.Remove(name);
            }

            if (fruitTable.ContainsKey(name))
            {
                Console.WriteLine($"{name}이 없습니다.");
            }

        }
    }
}
