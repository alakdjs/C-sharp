using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509291652_GenericCollctions_Queue
{
    struct Animal
    {
        string _name;
        int _age;
        int _weight;

        public Animal(string name, int age, int weight)
        {
            _name = name;
            _age = age;
            _weight = weight;
        }

        public override string ToString()
        {
            return $"이름: {_name}, 나이: {_age}, 무게:{_weight}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] animalName = { "사자", "호랑이", "캥거루", "사슴", "늑대", "오리" };
            Queue<Animal> queue = new Queue<Animal>();

            for(int i = 0; i < animalName.Length; i++)
            {
                queue.Enqueue(new Animal(animalName[i], i % 10 + 5, i + 100 % 50 + 40));
            }

            Console.WriteLine($"{queue.Peek()}");
            Console.WriteLine();

            foreach(var data in queue)
            {
                Console.WriteLine($"{data}");
            }

            Console.WriteLine();

            while (queue.Count > 0)
            {
                Console.WriteLine($"{queue.Dequeue()}");
            }
        }
    }
}
