using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();            
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < 15; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
            }
            int sum = max + min;

            Console.WriteLine("Сумма максимального и минимального элементов: {0}",sum);
            Console.ReadKey();
        }
    }
}
