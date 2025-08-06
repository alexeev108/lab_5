using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            int min = array[0];
            int max = array[0];
            for (int j = 0; j < n; j++)
            {
                if (array[j] > max)
                    max = array[j];
                else if (array[j] < min)
                    min = array[j];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма максимального и минимального элементов: {0}", min + max);
            Console.ReadKey();
        }
    }
}
