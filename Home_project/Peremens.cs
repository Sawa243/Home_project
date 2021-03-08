using System;


namespace Home_project
{
    class Peremens
    {
        static void Main(string[] args)
        {

        }
        public static int DZ_1_1()
        {
            //int[] DzInput1;
            //DzInput1 = DZ_1_2();
            //Console.WriteLine($"a={DzInput1[0]} , b={DzInput1[1]}");
            int a, b, c;
            Console.WriteLine("Введите число 1 и нажмите ввод");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2 и нажмите ввод");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0 && b == 0 || a == b)
            {
                throw new Exception("Деление на 0");
            }
            c = ((5 * a) + (b * b)) / (b - a);
            Console.WriteLine($"Решение вашего уравнения: {c}");
            return c;
        }
        public static int[] DZ_1_2()
        {
            int a,b;
            int tmp;
            int[] DzInput1 = new int[2];
            Console.WriteLine("Введите число a и нажмите ввод");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b и нажмите ввод");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Получаем число {a} и число {b}");
            Console.WriteLine($"меняем значения a и b местами");
            tmp = a;
            a = b;
            b = tmp;
            DzInput1[0] = a;
            DzInput1[1] = b;
            return DzInput1;
        }
        public static void DZ_1_3()
        {
            int a,b;
            int Delenie;
            int Ostatok;
            Console.WriteLine("Введите число А и нажмите Ввод");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число Б и нажмите Ввод");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0 || b == 0 )
            {
                throw new Exception("Недопустимый ввод");
            }
            Delenie = a / b;
            Ostatok = a % b;
            Console.WriteLine($"Результат деления А на Б = {Delenie}, и остаток {Ostatok}");
        }
        public static int DZ_1_4()
        {
            int number1;
            int number2;
            int number3;
            int x;
            Console.WriteLine("Введите первое число и нажмите ввод");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число и нажмите ввод");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число и нажмите ввод");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Решение(значение X) линейного уравнения стандартного вида, где A*X+B=C");
            x = (number3 - number2) / number1;
            Console.WriteLine($"Значение Х = {x}");
            return x;

        }
        public static void DZ_1_5()
        {
            int X1, Y1;
            int X2, Y2;
            int A1, A2;
            int B1, B2;

            Console.WriteLine("Введите кординату Х1 и нажмите ввод");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кординату Y1 и нажмите ввод");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кординату Х2 и нажмите ввод");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кординату Y2 и нажмите ввод");
            Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уравнение прямой в формате Y=AX+B");
            Console.WriteLine($"для 1 координаты {Y1}=A{X1}+B");
            Console.WriteLine($"для 2 координаты {Y2}=A{X2}+B");
            A1 = (Y1 - Y2) / (X1 - X2);
            B1 = Y1 - (A1 * X1);
            Console.WriteLine($"Уравнение прямой для первой координаты {Y1}={A1}*{X1}+{B1}");
            A2 = (Y1 - Y2) / (X1 - X2);
            B2 = Y2 - (A2 * X2);
            Console.WriteLine($"Уравнение прямой для второй координаты {Y2}={A2}*{X2}+{B2}");

        }
    }
}
