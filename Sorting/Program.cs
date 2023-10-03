using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            Console.WriteLine("Введите {0} чисел:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число {0}: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                array[i] = number;

            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            double average = sum / n;
                        
            Console.WriteLine("Среднее арифметическое: {0}", average);

            Console.ReadKey();
        }
    }
}
