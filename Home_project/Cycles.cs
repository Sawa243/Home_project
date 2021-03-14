using System;
using System.Collections.Generic;
using System.Text;

namespace Home_project
{
   public class Cycles
    {
        public static int DZ_3_1(int a,int b)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            int AvB = 1;
            if (b == 0)
            {
                throw new ArgumentException();
            }
            for (int i = 0;i<b;i++)
            {
                AvB = AvB * a;
            }
            return AvB;
        }
        public static string DZ_3_2(int chislo)
        {
            string a="";
            //int chislo;
            //chislo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 1000; i++)
            {
                if (i % chislo == 0)
                {
                    Console.WriteLine(i);
                    a = a + " "+i;
                }
                
            }
            return a;
        }
        public static int DZ_3_3(int a)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            for (int i = 0; i < a; i++)
            {
                if (i < Math.Sqrt(a) && i > 0)
                    summa = summa + i;
            }
            return summa;
        }
        public static int DZ_3_4(int a)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            int c = a;
            for (int i = a; 1 < i; i--)
            {
                if (a > 1)
                {
                    c--;
                }
                else if (a < -1)
                {
                    c++;
                }
                if (a % c == 0)
                {
                    if (a == c)
                    {
                        new Exception("Нет решений");
                    }
                    return c; 
                }
            }
            return 0;
        }
        public static int DZ_3_5(int a, int b)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            int tmp = 0;
            int count = 0;
            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            for (int i = a + 1; i < b; i++)
            {
                if (i % 7 == 0)
                {
                    count += i;
                }
            }
            return count;
        }
        public static string DZ_3_6(int n, int n1,int n2)
        {
            //Console.WriteLine("Введите число n число: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите первое число ряда Фибоначи: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число ряда Фибоначи: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            string answer = "";
            if (n == 1)
            {
                Console.WriteLine(n1);
            }
            else if (n == 2)
            {
                Console.WriteLine(n2);
            }
            else if (n <= 0)
            {
                new Exception("Число отсутствует");
            }
            int summa = 0;
            for (int i = 2; i < n; i++)
            {
                summa = n1 + n2;
                n1 = n2;
                n2 = summa;
            }
            answer = ($"N - ое число ряда: {summa}");
            return answer;
        }
        public static int DZ_3_7(int a, int b)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            int tmp = 1;
            int c;
            if (b > a)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            c = a + b;
            //Console.WriteLine(a + b);
            return c;
        }
        public static int DZ_3_8(int a)
        {
            //Math.Round(Midlle / 2, 2) можно использовать для точности
            //int a = Convert.ToInt32(Console.ReadLine());
            int Left = 0;
            int Raight = a;
            int Midlle = (Left+Raight) / 2;
            while (Midlle*Midlle*Midlle != a)
            {
                if (Midlle * Midlle * Midlle > a)
                {
                    Raight = Midlle;
                }
                else
                {
                    Left = Midlle;
                }
                Midlle = (Left + Raight) / 2;
            }
            //Console.WriteLine(Midlle);
            return Midlle;
        }

        public static string Cycles_12()

        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int num1_1 = number1 / 100 % 10;
            int num1_2 = number1 / 10 % 10;
            int num1_3 = number1 % 10;
            int num2_1 = number2 / 100 % 10;
            int num2_2 = number2 / 10 % 10;
            int num2_3 = number2 % 10;
            if (num1_1 == num2_1 || num1_1 == num2_2 || num1_1 == num2_3

            || num1_2 == num2_1 || num2_1 == num2_2 || num2_1 == num2_3

            || num1_3 == num2_1 || num1_3 == num2_2 || num1_3 == num2_3)
            {
                return "ДА";
            }
            else return "нет";
        }

        public static void Cycles_11(int summaChet, int summaNeChet)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 1)
                {
                    summaNeChet = summaNeChet + i;
                }
                if (i % 2 == 0)
                {
                    summaChet = summaChet + i;
                }
            }
            if (summaChet > summaNeChet)
            {
                for (int i = 0; i < num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
        public static int Cycles_10(int reversNum)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                reversNum = reversNum * 10;

                reversNum = reversNum + num % 10;

                num = num / 10;
            }
            return reversNum;
        }
        public static int Cycles_9(int summa)

        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 1)

                {
                    summa = summa + 1;
                }
            }
            return summa;

        }
    }
}
