﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < (n / 2) - 1; i++)
            {
                for (int j = i + 1; j < n / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int r = array[i];
                        array[i] = array[j];
                        array[j] = r;
                    }
                }
            }

            for (int i = (n / 2) + 1; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int r = array[i];
                        array[i] = array[j];
                        array[j] = r;
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
