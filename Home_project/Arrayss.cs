using System;


namespace Home_project
{
   public class Arrayss
    {
        public static string DZ_4_1_4(int[] array)
        {
           
            //Random ramdom = new Random();
            string Otvet = "";
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = ramdom.Next(0, 101);
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
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
            //Console.WriteLine(min);
            //Console.WriteLine(minIndex);
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
            //Console.WriteLine(max);
            //Console.WriteLine(maxIndex);
            Otvet = "МинЧисло: " + min + " МинИндекс: " + minIndex + " МаксЧисло: " + max + " МаксИндекс: " + maxIndex;
            return Otvet;
        }
        public static int DZ_4_5(int[] array)
        {
            //int[] array = new int[15];
            //Random randomChisla = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = randomChisla.Next(0, 10);
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Cумма элементов массива с нечетными индексами: ");
            int summa = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    summa = array[i] + summa;
                }
            }
            return (summa - 1);
        }
        public static string DZ_4_6(int[] array)
        {
            //int[] array = new int[5];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(0, 10);
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            string Otvet = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                //Console.Write(array[i] + " ");
                Otvet = Otvet + array[i] + " ";
            }
            return Otvet;
        }
        public static int DZ_4_7(int[] array)
        {
            //int[] array = new int[10];
            //Random random = new Random();
            int summa = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = random.Next(0, 10);
                if (array[i] % 2 > 0)
                    summa = summa + 1;
                //Console.Write(array[i] + " ");
            }
            //Console.WriteLine();
            return summa;
        }
        public static string DZ_4_8(int[] array)
        {
            string Answer = "";
            string FirstPart = "";
            string TwoPart = "";
            //int[] array = new int[8];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(0, 10);
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                //Console.Write(array[i] + " ");
                FirstPart =FirstPart + array[i] + " ";
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                //Console.Write(array[i] + " ");
                TwoPart = TwoPart + array[i] + " ";
            }
            Answer = FirstPart + TwoPart;
            return Answer;
        }
       public static int[] DZ_4_9(int[] array)
        {
            //int[] array = new int[6];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(0, 10);
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
                //Console.Write(array[i] + " ");
            }
            return array;
        }
        public static string DZ_4_10(int[] array)
        {
            //int[] array = new int[8];
            int temp;
            string answer = "";
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(0, 10);
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                //Console.Write(array[i] + " ");
                answer = answer + array[i] + " ";
            }
            return answer;
        }

    }
}
