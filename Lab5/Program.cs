using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N: ");
            int N = int.Parse(Console.ReadLine());

            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {                    
                    array[j, i] = (i + j) % 2 == 0 ? 1 : 0;
                }
            }
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
    }
}