using System;
using System.Collections.Generic;
using System.Text;

namespace Home_project
{
    class Arrayss
    {
        public static void DZ_4_1_4()
        {
            int[] array = new int[10];
            Random ramdom = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ramdom.Next(0, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int min = array[0];
            int minIndex = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i + 1;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(minIndex);
            int max = array[0];
            int maxIndex = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i + 1;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(maxIndex);
        }
        public static void DZ_4_5()
        {
            int[] array = new int[15];
            Random randomChisla = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomChisla.Next(0, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Cумма элементов массива с нечетными индексами: ");
            int summa = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    summa = array[i] + summa;
                }
            }
            Console.WriteLine(summa - 1);
        }
        public static void DZ_4_6()
        {

        }
    }
}
