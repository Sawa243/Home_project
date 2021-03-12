using System;


namespace Home_project
{
   public  class Peremens
    {
       static void Main(string[] args)
        {
        }
        public static int DZ_1_1(int a, int b)
        {
            int c;
            //Console.WriteLine("Введите число 1 и нажмите ввод");
            //a = Convert.ToInt32(Console.ReadLine());
            //a = 5;
            //Console.WriteLine("Введите число 2 и нажмите ввод");
            //b = Convert.ToInt32(Console.ReadLine());
            //b = 3;
            if (a == 0 || b == 0 || a == b)
            {
                throw new Exception("Деление на 0");
            }
            c = ((5 * a) + (b * b)) / (b - a);
            Console.WriteLine($"Решение вашего уравнения: {c}");
            return c;
        }
        public static int[] DZ_1_2(int a,int b)
        {
           
            int tmp;
            int[] DzInput1 = new int[2];
            //Console.WriteLine("Введите число a и нажмите ввод");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите число b и нажмите ввод");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Получаем число {a} и число {b}");
            //Console.WriteLine($"меняем значения a и b местами");
            tmp = a;
            a = b;
            b = tmp;
            DzInput1[0] = a;
            DzInput1[1] = b;
            return DzInput1;
        }
        public static string DZ_1_3(int a, int b)
        {
            int Delenie;
            int Ostatok;
            //Console.WriteLine("Введите число А и нажмите Ввод");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите число Б и нажмите Ввод");
            //b = Convert.ToInt32(Console.ReadLine());
            if (a == 0 || b == 0 )
            {
                throw new Exception("Недопустимый ввод");
            }
            Delenie = a / b;
            Ostatok = a % b;
            //Console.WriteLine($"Результат деления А на Б = {Delenie}, и остаток {Ostatok}");
            string Otvet = Convert.ToString(Delenie) + "," + Convert.ToString(Ostatok);
            return Otvet;

        }
        public static int DZ_1_4(int number1, int number2, int number3)
        {
            int x;
            //Console.WriteLine("Введите первое число и нажмите ввод");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число и нажмите ввод");
            //number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите третье число и нажмите ввод");
            //number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Решение(значение X) линейного уравнения стандартного вида, где A*X+B=C");
            x = (number3 - number2) / number1;
            Console.WriteLine($"Значение Х = {x}");
            return x;

        }
        public static string DZ_1_5(int X1, int Y1, int X2, int Y2)
        {
            //int X1, Y1;
            //int X2, Y2;
            int A1, A2;
            int B1, B2;
            //Console.WriteLine("Введите кординату Х1 и нажмите ввод");
            //X1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите кординату Y1 и нажмите ввод");
            //Y1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите кординату Х2 и нажмите ввод");
            //X2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите кординату Y2 и нажмите ввод");
            //Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уравнение прямой в формате Y=AX+B");
            Console.WriteLine($"для 1 координаты {Y1}=A{X1}+B");
            Console.WriteLine($"для 2 координаты {Y2}=A{X2}+B");
            A1 = (Y1 - Y2) / (X1 - X2);
            B1 = Y1 - (A1 * X1);
            Console.WriteLine($"Уравнение прямой для первой координаты {Y1}={A1}*{X1}+{B1}");
            A2 = (Y1 - Y2) / (X1 - X2);
            B2 = Y2 - (A2 * X2);
            Console.WriteLine($"Уравнение прямой для второй координаты {Y2}={A2}*{X2}+{B2}");
            //string Otvet = Convert.ToString(Delenie) + "," + Convert.ToString(Ostatok);
            string Otvet = "Для первой координаты:"+Convert.ToString(Y1)+"="+ Convert.ToString(A1) +"*"+ Convert.ToString(X1) +"+"+ Convert.ToString(B1)+";"+"  " + "Для второй координаты:" + Convert.ToString(Y2) + "=" + Convert.ToString(A2) + "*" + Convert.ToString(X2) + "+" + Convert.ToString(B2) + ";";
            return Otvet;
        }
    }
}
