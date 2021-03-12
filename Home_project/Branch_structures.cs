using System;
using System.Collections.Generic;
using System.Text;

namespace Home_project
{
   public static class Branch_structures
    {
        public static int DZ_2_1(int a, int b)
        {
            //int a;
            //int b;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                return(a + b);
            }
            if (a < b)
            {
                return(a - b);
            }
            if (a == b)
            {
                return (a * b);
            }
            if (a==0 || b == 0)
            {
                throw new ArgumentException();
            }
            return 0;
        }
        public static string DZ_2_2(int x, int y)
        {
            //int x;
            //int y;
            //x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                return("Принадлежит к 1 четверти");
            }
            else if (x < 0 && y > 0)
            {
                return("Принадлежит к 2 четверти");
            }
            else if (x < 0 && y < 0)
            {
                return("Принадлежит к 3 четверти");
            }
            else if (x > 0 && y < 0)
            {
                return("Принадлежит к 4 четверти");
            }
            return "0";
        }
        public static int[] DZ_2_3(int a, int b, int c)
        {
            //int a, b, c;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());
            if (a < b && b < c)
            {
                //Console.WriteLine($"{a},{b},{c}");
                return new int[] { a, b, c };
            }
            else if (b < c && c < a)
            {
                //Console.WriteLine($"{b},{c},{a}");
                return new int[] { b, c, a };
            }
            else if (c < a && a < b)
            {
                //Console.WriteLine($"{c},{a},{b}");
                return new int[] { c, a, b };
            }
            else if (b < a && a < c)
            {
                //Console.WriteLine($"{b},{a},{c}");
                return new int[] { b, a, c };
            }
            else if (c < b && b < a)
            {
                //Console.WriteLine($"{c},{b},{a}");
                return new int[] { c, b, a };
            }
            return new int[] { a, b, c };
        }
        public static string DZ_2_4(int a, int b, int c)
        {
            //int a;
            //int b;
            //int c;
            int d;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());
            d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                return("Решение: корней нет!");
            }
            else if (d == 0)
            {
                int x;
                x = -b / 2 * a;
                return($"Решение: X={x}");
            }
            else if (d > 0)
            {
                double x;
                double x2;
                x = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d) / 2 * a);
                return($"Решение: Два корня X={x}, X2={x2}");
            }
            return "";
        }
        public static string DZ_2_5(int a)
        {
            //int a;
            int num1,num2;
            string TwoNumbers = "";
            string desytka = "";
            string ostatok = "";
            //a = Convert.ToInt32(Console.ReadLine());
            num1 = a / 10;
            num2 = a % 10;
            if (a < 20)
            {
                switch (a)
                {
                    case 11:
                        return "Одинадцать";
                    case 12:
                        return "Двенадцать";
                    case 13:
                        return "Тринадцать";
                    case 14:
                        return "Четырнадцать";
                    case 15:
                        return "Пятнадцать";
                    case 16:
                        return "Шестнадцать";
                    case 17:
                        return "Семнадцать";
                    case 18:
                        return "Восемнадцать";
                    case 19:
                        return "Девятнадцать";
                }
            }
            else if (a >= 20 && a < 60)
            {
                switch (num1)
                {
                    case 2:
                        desytka = "Двадцать ";
                        break;
                    case 3:
                        desytka = "Тридцать ";
                        break;
                    case 4:
                        desytka = "Сорок ";
                        break;
                    case 5:
                        desytka = "Пятьдесят ";
                        break;
                }
                switch (num2)
                {
                    case 1:
                        ostatok = "один";
                        break;
                    case 2:
                        ostatok = "два";
                        break;
                    case 3:
                        ostatok = "три";
                        break;
                    case 4:
                        ostatok = "четыре";
                        break;
                    case 5:
                        ostatok = "пять";
                        break;
                    case 6:
                        ostatok = "шесть";
                        break;
                    case 7:
                        ostatok = "семь";
                        break;
                    case 8:
                        ostatok = "восемь";
                        break;
                    case 9:
                        ostatok = "девять";
                        break;
                }
                TwoNumbers = desytka + ostatok;
                return TwoNumbers;
            }
            else
            {
                return "Число больше 60";
            }
            return "";
        }
       
    }
}

