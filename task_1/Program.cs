using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int s = 0;
            int k = 0;
            Console.WriteLine("Введите 7 чисел");
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
                k += 1;
            }
            Console.WriteLine("Среднее арифмитеческое введенных чисел: {0}", s / k);
            Console.ReadKey();
        }
    }
}
