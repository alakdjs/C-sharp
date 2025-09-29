using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509291558_IEnumerator_IEnumerable
{
    class Array : IEnumerable<int>, IEnumerator<int>
    {
        private int[] _array;
        private int _position;

        public int Size { get => _array.Length; }

        // 제너릭
        public int Current
        {
            get
            {
                if(_position < _array.Length)
                {
                    return _array[_position];
                }

                return -1;
            }
        }

        // 비제너릭
        object IEnumerator.Current => Current;

        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public Array(int size)
        {
            _position = -1;
            _array = new int[size];
        }

        public IEnumerator<int> GetEnumerator()
        {
            _position = -1;
            return this as IEnumerator<int>;
        }

        // 비제너릭
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            _position++;

            if(_position < _array.Length)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(10);

            for(int i = 0; i < array.Size; i++)
            {
                array[i] = i;
            }

            foreach(var obj in array)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine();

            IEnumerator<int> enumerator = array.GetEnumerator();
            enumerator.MoveNext();

            Console.WriteLine(enumerator.Current.ToString());

            enumerator.MoveNext();

            Console.WriteLine(enumerator.Current.ToString());

            enumerator.MoveNext();

            Console.WriteLine(enumerator.Current.ToString());

            Console.WriteLine();

            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            }
        }
    }
}
