using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509171536_Indexer
{
    // indexer
    // indexer(인덱서)는 C#에서 클래스나 구조체 타입의 객체를 배열처럼 접근할 수 있게 해주는
    // 일종의 property입니다.
    // 인덱서를 사용하면 객체 내부의 Data collection을 배열 구문을 사용해서 접근할 수 있게 해주는 기능...
    // 사용성 좋아지고 코드의 가독성이 좋아집니다.
    class NumArray
    {
        private List<int> datas = new List<int>(10);

        public int Length
        {
            get { return datas.Count; }
        }

        public int this[int index]
        {
            get { return datas[index]; }
            set
            {
                if (datas.Count <= 0)
                {
                    datas.Add(value);
                }
                else if (datas.Count <= index)
                {
                    datas.Add(value);
                }
                else
                {
                    datas[index] = value;
                }

            }
        }
    }

    class NumArray2
    {
        private int[] datas = new int[10]; // Container

        public int Length
        {
            get { return datas.Length; }
        }

        public int this[int index] // 인덱서
        {
            get { return datas[index]; }
            set
            {
                if(datas.Length <= index)
                {
                    int[] datas2 = new int[index + 1];
                    
                    for(int i = 0; i < datas.Length; i++)
                    {
                        datas2[i] = datas[i];
                    }
                    datas = datas2;

                    datas[index] = value;
                }
                else
                {
                    datas[index] = value;
                }

            }
        }
    }

    class NumArray3
    {
        private int[] datas = new int[10];

        public int this[int index] // index
        {
            get { return datas[index]; }
            set { datas[index] = value; }
        }

        public void SetArray(int index, int value)
        {
            datas[index] = value;
        }

        public int GetArray(int index)
        {
            return datas[index];
        }

        public int GetSize()
        {
            return datas.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumArray3 numArray3 = new NumArray3();

            /*
            numArray3.SetArray(0, 10);
            numArray3.SetArray(5, 200);

            for (int i = 0; i < numArray3.GetSize(); i++)
            {
                Console.WriteLine($"numArray3[{i}] = {numArray3.GetArray(i)}");
            }
            */

            numArray3[0] = 10;
            numArray3[5] = 200;
            //numArray3[11] = 400;

            for (int i = 0; i < numArray3.GetSize(); i++)
            {
                Console.WriteLine($"numArray3[{i}] = {numArray3[i]}");
            }

            /*
            NumArray numArray = new NumArray();

            numArray[0] = 1; // 인덱서를 사용해서 객체를 배열 형식으로 접근하고 있음
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = i;
            }

            for(int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine($"numArray[{i}] = {numArray[i]}");
            }


            NumArray2 numArray2 = new NumArray2();

            for(int i = 0; i < numArray2.Length; i++)
            {
                numArray2[i] = i;
            }

            for(int i = 0; i < numArray2.Length; i++)
            {
                Console.WriteLine($"numArray2[{i}] = {numArray2[i]}");
            }

            numArray2[11] = 2;

            Console.WriteLine();

            for(int i = 0; i < numArray2.Length; i++)
            {
                Console.WriteLine($"numArray2[{i}] = {numArray2[i]}");
            }
            */
        }
    }
}
