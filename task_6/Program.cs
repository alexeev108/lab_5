using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int lines = 0;
            int columns = 0;
            int diagonal_main = 0;
            int diagonal_not_main = 0;            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите [{0}, {1}]: ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());                                     
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4} ", array[i, j]);                    
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    lines += array[i, j];
                    columns += array[j, i];                                      
                }            
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        diagonal_main += array[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                    
                    if (i + j == n - 1)
                        diagonal_not_main += array[i, j];
                }
            }

            //Console.WriteLine("{0}, {1}, {2}, {3}", lines / n, columns / n, diagonal_main, diagonal_not_main);
            if (lines / n == columns / n && lines / n == diagonal_main && diagonal_main == diagonal_not_main)
                Console.WriteLine("Матрица является магическим квадратом");
            else
                Console.WriteLine("Матрица НЕ является магическим квадратом");

            Console.ReadKey();
        }
    }
}
