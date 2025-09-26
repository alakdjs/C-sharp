using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _202509261437_Generic_Class_Exer
{
    class Container<T>
    {
        private T[] _datas;

        public int Length
        {
            get => _datas.Length;
        }

        public T this[int index] // indexer 사용 : 객체를 배열 형식으로 사용
        {
            get => _datas[index];

            set
            {
                if(_datas.Length >= 0 && index < _datas.Length)
                {
                    _datas[index] = value;
                }
                else
                {
                    return;
                }
            }
        }

        public Container(int count = 10)
        {
            _datas = new T[count];
        }

        public int GetSize()
        {
            return _datas.Length;
        }

        /*
        public void SetItem(int index, T item)
        {
            _datas[index] = item;
        }

        public T GetItem(int index)
        {
            return _datas[index];
        }
        */
    }
    
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Container<int> intBox = new Container<int>();

            for (int i = 0; i < intBox.GetSize(); i++)
            {
                intBox[i] = array[i];
                // intBox.SetItem(i, array[i]);
            }

            for (int i = 0; i < intBox.GetSize(); i++)
            {
                Console.WriteLine(intBox[i]);
                // Console.WriteLine(intBox.GetItem(i)); // 123
            }

            
            Container<string> strBox = new Container<string>();

            for (int i = 0;i < strBox.GetSize(); i++)
            {
                strBox[i] = $"Hello_{i}"; 
                // strBox.SetItem(i, $"Hello_{i}");
            }

            for(int i = 0; i < strBox.GetSize(); i++)
            {
                Console.WriteLine(strBox[i]);
                // Console.WriteLine(strBox.GetItem(i)); // Hello
            }

        }
    }
}
