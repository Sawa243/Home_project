using System;
using System.Collections.Generic;
using System.Text;

namespace Home_project
{
    class Branch_structures
    {
        public static void DZ_2_1()
        {
            int a;
            int b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + b);
            }
            else
            {
                if (a == b)
                    Console.WriteLine(a * b);
            }
            if (a < b)
            {
                Console.WriteLine(a - b);
            }
        }
        public static void DZ_2_2()
        {
            int x;
            int y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Принадлежит к 1 четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Принадлежит к 2 четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Принадлежит к 3 четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Принадлежит к 4 четверти");
            }

        }
        public static void DZ_2_3()
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && b < c)
            {
                Console.WriteLine($"{a},{b},{c}");
            }
            else if (b < c && c < a)
            {
                Console.WriteLine($"{b},{c},{a}");
            }
            else if (c < a && a < b)
            {
                Console.WriteLine($"{c},{a},{b}");
            }
            else if (b < a && a < c)
            {
                Console.WriteLine($"{b},{a},{c}");
            }
            else if (c < b && b < a)
            {
                Console.WriteLine($"{c},{b},{a}");
            }
        }
        public static void DZ_2_4()
        {
            int a;
            int b;
            int c;
            int d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("Решение: корней нет!");
            }
            else if (d == 0)
            {
                int x;
                x = -b / 2 * a;
                Console.WriteLine($"Решение: X={x}");
            }
            else if (d > 0)
            {
                double x;
                double x2;
                x = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d) / 2 * a);
                Console.WriteLine($"Решение: Два корня X={x}, X2={x2}");
            }

        }
        public static void DZ_2_5()
        {
            int a;
            int num1,num2;
            string dvachisla = "";
            string desytka = "";
            string ostatok = "";
            a = Convert.ToInt32(Console.ReadLine());
            num1 = a / 10;
            num2 = a % 10;
            if (a < 20)
            {
                switch (a)
                {
                    case 11:
                        Console.WriteLine("Одинадцать");
                        break;
                    case 12:
                        Console.WriteLine("Двенадцать");
                        break;
                    case 13:
                        Console.WriteLine("Тринадцать");
                        break;
                    case 14:
                        Console.WriteLine("Четырнадцать");
                        break;
                    case 15:
                        Console.WriteLine("Пятнадцать");
                        break;
                    case 16:
                        Console.WriteLine("Шестнадцать");
                        break;
                    case 17:
                        Console.WriteLine("Семнадцать");
                        break;
                    case 18:
                        Console.WriteLine("Восемнадцать");
                        break;
                    case 19:
                        Console.WriteLine("Девятнадцать");
                        break;
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
                dvachisla = desytka + ostatok;
                Console.WriteLine(dvachisla);
            }
            else
            {
                Console.WriteLine("Число больше 60");
            }

        }
       
    }
}

