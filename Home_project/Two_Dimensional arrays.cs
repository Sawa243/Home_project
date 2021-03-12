using System;


namespace Home_project
{
  public static  class Two_Dimensional_arrays
    {
        public static string DZ_5_1_4(double[,] array)
        {
            array = new double[3, 3];
            //{ { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            //Random random = new Random();
            double min = 100;
            double max = 0;
            int minI = 0, minJ = 0;
            int maxI = 0, maxJ = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = random.Next(0, 20);
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
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
            string answer = "";
            //Console.WriteLine("максимальное число: " + max);
            //Console.WriteLine(" Индекс минимального числа: " + maxI + "," + maxJ);
            //Console.WriteLine(" минимальное число: " + min);
            //Console.WriteLine(" Индекс минимального числа: " + minI + "," + minJ);
            answer = "MaxInt: " + max + " MaxI: " + maxI + "," + maxJ+ " MinInt: " + min+ " MinI: " + minI + "," + minJ;
            return answer;
        }
        public static int DZ_5_5(double[,] array)
        {
            //array = new double[3, 3];
            //Random random = new Random();
            int coin = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = random.Next(0, 20);
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if((i<=0 || array[i,j]>array[i-1,j])&&
                        (i>= array.GetLength(0)-1|| array[i,j]>array[i+1,j]) &&
                        (j <= 0 || array[i, j] > array[i, j-1]) &&
                        (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j+1]))
                    {
                        coin++;
                    }
                }
            }
            return coin;
        }
        public static string DZ_5_6(double[,] array, int strok, int stolbec)
        {
            /*int *//*strok = 1;*/
           /* int *//*stolbec = 1;*/
            //double[,] array = new double[strok, stolbec];
            //Random random = new Random();
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = random.Next(0, 20);
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            if (strok == 0 || stolbec == 0)
            {
                throw new ArgumentException();
            }
            string answer = "";
            double[,] arrayOtr = new double[stolbec, strok];
            for (int i = 0; i < arrayOtr.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOtr.GetLength(1); j++)
                {
                    arrayOtr[i, j] = array[j, i];
                    answer = answer + arrayOtr[i, j] + " ";
                    /*Console.Write(arrayOtr[i, j] + " "); */
                }
                //Console.WriteLine();
            }
            return answer;
        }
    }
}
