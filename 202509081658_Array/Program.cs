using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081658_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 동일한 DataType의 공간이 여러개 필요할때 사용하는 편리한 기능이 있습니다.
            // 배열이라고 합니다.
            // C#에서 배열은 객체입니다.

            int[] array = new int[100]; // 일차원 배열

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            // 이차원 배열
            Console.WriteLine();

            int[,] array2 = new int[10, 10]; // 이차원 배열

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    array2[i, j] = i * 10 + j;
                }
            }

            // GetLength(0) : 행의 요소의 개수
            // GetLength(1) : 열의 요소의 개수
            for(int i = 0; i < array2.GetLength(0); i++)
            {
                for(int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.WriteLine($"arrays[{i}, {j}] = {array2[i, j]}");
                }
            }

            int[,,] array3 = new int[10, 10, 10];

            /*
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"arrays[{i}] = {array2[i, j]}");
                }
            }
            */
        }
    }
}
