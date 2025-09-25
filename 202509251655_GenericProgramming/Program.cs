using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509251655_GenericProgramming
{
    class Test
    {
        private int _num1;
        private int _num2;

        public Test(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public override string ToString()
        {
            return $"_num1 = {_num1}, _num2 = {_num2}";
        }
    }

    class ArrayStack<T>
    {
        private int _index = 0;
        private int _size;
        private T[] _array;

        public int Size { get => _size; }

        public ArrayStack(int size)
        {
            _index = 0;
            _size = size;
            _array = new T[size];
        }

        public void Push(T data) // 스택 저장
        {
            if (_index >= _size)
            {
                return;
            }

            _array[_index++] = data;
        }

        public T Pop() // 스택 가지고 올 때
        {
            if (_index > 0)
            {
                return _array[--_index];
            }
            else
            {
                return default(T);
            }
        }

        public T Top() // 맨 위에 저장된 값을 살짝 들여다 볼 때
        {
            if (_index > 0)
            {
                return _array[_index - 1];
            }
            else
            {
                return default(T);
            }
        }
    }

    /*
    class ArrayStackFloat
    {
        private int _index = 0;
        private int _size;
        private float[] _array;

        public int Size { get => _size; }

        public ArrayStackFloat(int size)
        {
            _index = 0;
            _size = size;
            _array = new float[size];
        }

        public void Push(float data) // 스택 저장
        {
            if(_index >= _size)
            {
                return;
            }

            _array[_index++] = data;
        }

        public float Pop() // 스택 가지고 올 때
        {
            if (_index > 0)
            {
                return _array[--_index];
            }
            else
            {
                return -1;
            }
        }

        public float Top() // 맨 위에 저장된 값을 살짝 들여다 볼 때
        {
            if (_index > 0)
            {
                return _array[_index - 1];
            }
            else
            {
                return -1;
            }
        }
    }

    class ArrayStackInt
    {
        private int _index = 0;
        private int _size;
        private int[] _array;

        public int Size { get => _size; }

        public ArrayStackInt(int size)
        {
            _index = 0;
            _size = size;
            _array = new int[size];
        }

        public void Push(int data) // 스택 저장
        {
            if (_index >= _size)
            {
                return;
            }

            _array[_index++] = data;
        }

        public float Pop() // 스택 가지고 올 때
        {
            if (_index > 0)
            {
                return _array[--_index];
            }
            else
            {
                return -1;
            }
        }

        public float Top() // 맨 위에 저장된 값을 살짝 들여다 볼 때
        {
            if (_index > 0)
            {
                return _array[_index - 1];
            }
            else
            {
                return -1;
            }
        }
    }
    */

    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<float> fstack = new ArrayStack<float>(10);

            fstack.Push(1.2f);
            fstack.Push(2.2f);
            fstack.Push(3.2f);

            Console.WriteLine($"{fstack.Pop()}");
            Console.WriteLine($"{fstack.Pop()}");
            Console.WriteLine($"{fstack.Pop()}");

            Console.WriteLine();

            ArrayStack<int> iStack = new ArrayStack<int>(10);

            iStack.Push(1);
            iStack.Push(2);
            iStack.Push(3);

            Console.WriteLine($"{iStack.Pop()}");
            Console.WriteLine($"{iStack.Pop()}");
            Console.WriteLine($"{iStack.Pop()}");

            ArrayStack<Test> testStack = new ArrayStack<Test>(10);

            for(int i = 0; i < testStack.Size; i++)
            {
                testStack.Push(new Test(i, i * 2));
            }

            for(int i = 0; i <testStack.Size; i++)
            {
                Console.WriteLine($"{testStack.Pop()}");
            }
        }
    }
}
