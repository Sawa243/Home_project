using System;


namespace Home_project
{
    class Two_Dimensional_arrays
    {
        public static void DZ_5_1_4()
        {
            double[,] array = new double[2, 5];
            Random random = new Random();
            double min = 100;
            double max = 0;
            int minI = 0, minJ = 0;
            int maxI = 0, maxJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 20);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minI = i + 1;
                        minJ = j + 1;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxI = i + 1;
                        maxJ = j + 1;
                    }
                }
            }
            Console.WriteLine("максимальное число: " + max);
            Console.WriteLine("Индекс минимального числа: " + maxI + "," + maxJ);
            Console.WriteLine("минимальное число: " + min);
            Console.WriteLine("Индекс минимального числа: " + minI + "," + minJ);
        }
        public static void DZ_5_5()
        {
            double[,] array = new double[3, 3];
            Random random = new Random();
            double coin = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 20);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == array[0, 0])
                    {
                        if (array[0, 0] > array[0, 1] && array[0, 0] > array[1, 1] && array[0, 0] > array[1, 0])
                        {
                            coin++;
                        }
                    }
                    if (array[i, j] == array[0, 1])
                    {
                        if (array[0, 1] > array[0, 0] && array[0, 1] > array[0, 2] && array[0, 1] > array[1, 0]
                            && array[0, 1] > array[1, 1] && array[0, 1] > array[1, 2])
                        {
                            coin++;
                        }
                    }
                    if (array[i, j] == array[0, 2])
                    {
                        if (array[0, 2] > array[0, 1] && array[0, 2] > array[1, 1] && array[0, 2] > array[1, 2])
                        {
                            coin++;
                        }
                    }
                    if (array[i, j] == array[1, 0])
                    {
                        if (array[1, 0] > array[0, 0] && array[1, 0] > array[0, 1] && array[1, 0] > array[1, 1]
                            && array[1, 0] > array[2, 1] && array[1, 0] > array[2, 0])
                        {
                            coin++;
                        }
                    }
                    if (array[i, j] == array[1, 1])
                    {
                        if (array[1, 1] > array[0, 0] && array[1, 1] > array[0, 1] && array[1, 1] > array[0, 2] &&
                            array[1, 1] > array[1, 0] && array[1, 1] > array[1, 2] && array[1, 1] > array[2, 0] &&
                            array[1, 1] > array[2, 1] && array[1, 1] > array[2, 2])
                        {
                            coin++;
                        }
                    }
                    if (array[i, j] == array[1, 2])
                    {
                        if (array[1, 2] > array[0, 2] && array[1, 2] > array[1, 1] && array[1, 2] > array[0, 1]
                            && array[1, 2] > array[2, 1] && array[1, 2] > array[2, 2])
                        {
                            coin++;
                        }
                    }
                    if (array[i, j] == array[2, 0])
                    {
                        if (array[2, 0] > array[1, 0] && array[2, 0] > array[1, 1] && array[2, 0] > array[2, 1])
                        {
                            coin++;
                        }
                    }
                    if (array[i, j] == array[2, 1])
                    {
                        if (array[2, 1] > array[2, 0] && array[2, 1] > array[1, 0] && array[2, 1] > array[1, 1]
                            && array[2, 1] > array[1, 2] && array[2, 1] > array[2, 2])
                        {
                            coin++;
                        }
                    }
                    if (array[i, j] == array[2, 2])
                    {
                        if (array[2, 2] > array[2, 1] && array[2, 2] > array[1, 1] && array[2, 2] > array[1, 2])
                        {
                            coin++;
                        }
                    }
                }
            }
            Console.WriteLine(coin);
        }
        public static void DZ_5_6()
        {
            int strok = 2;
            int stolbec = 5;
            double[,] array = new double[strok, stolbec];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 20);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            double[,] arrayOtr = new double[stolbec, strok];
            for (int i = 0; i < arrayOtr.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOtr.GetLength(1); j++)
                {
                    arrayOtr[i, j] = array[j, i];
                    Console.Write(arrayOtr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
