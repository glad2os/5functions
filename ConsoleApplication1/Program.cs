using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static int Numerator;
        private static int Denominator;
        private static int Numerator2;
        private static int Denominator2;

        private static void input()
        {
            Console.WriteLine("Введите числитель:");
            Numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель:");
            Denominator = Convert.ToInt32(Console.ReadLine());
            if (Denominator == 0) throw new Exception("Знаменатель не может быть = 0!");
        }

        private static void input2()
        {
            Console.WriteLine("Введите числитель второй дроби:");
            Numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель:");
            Denominator2 = Convert.ToInt32(Console.ReadLine());
            if (Denominator2 == 0) throw new Exception("Знаменатель не может быть = 0!");
        }

        private static int nod(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static string makeshort(int n, int d)
        {
            int temp1 = n / nod(n, d);
            int temp2 = d / nod(n, d);
            if (nod(n, d)==1)
            {
                throw new Exception("Дробь нельзя сократить!");
            }
            return "Numerator: " + temp1 + " : " + "Denominator: " + temp2;
        }

        static int Znamen(int y1, int y2)
        {
            int y3;
            if ((y2 >= y1) && (y2 % y1 == 0))
            {
                y3 = y2;
                return y3;
            }
            else if ((y1 > y2) && (y1 % y2 == 0))
            {
                y3 = y1;
                return y3;
            }
            else
                y3 = y2 * y1;

            return y3;
        }

        private static int kolvozifr(int n)
        {
            n = Math.Abs(n);

            return n.ToString().Length;
        }

        public static int[] MathDr()
        {
            int[] x = new int[2]; // объявляем массив на два элемента
            int x3, y3;
            y3 = Znamen(Numerator, Denominator);
            x3 = Numerator * (y3 / Denominator) + Numerator2 * (y3 / Denominator2);
            x[0] = x3 / nod(x3, y3);
            x[1] = y3 / nod(x3, y3);
            return x;
        }

        /* TODO ЗАДАНИЕ 6
          * Написать функцию вывода дроби на экран (длина 
          * черты между числителем и (знаменателем должна 
          * быть равна количеству цифр большего из выводимых чисел)
        */
        public static string output(string numerator, string denominator)
        {
            int temp;
            string str = "";
            if (numerator.Length > denominator.Length)
            {
                temp = numerator.Length;
                for (int i = 0; i < temp; i++)
                {
                    str += "-";
                }
            }

            if (denominator.Length > numerator.Length)
            {
                temp = denominator.Length;
                for (int i = 0; i < temp; i++)
                {
                    str += "-";
                }
            }

            if (numerator.Length == denominator.Length)
            {
                temp = numerator.Length;
                for (int i = 0; i < temp; i++)
                {
                    str += "-";
                }
            }

            return "\n" + numerator + "\n" + str + "\n" + denominator;
        }

        public static void Main(string[] args)
        {
            /* TODO ЗАДАНИЕ 1
              * Реализовать функцию, обеспечивающую ввод дроби 
              * (числителя и знаменателя) с клавиатуры и их проверку 
              * на корректность; самостоятельно определить действие 
              * программы, если числитель и знаменатель — отрицательные числа
            */
            try
            {
                input();
            }
            catch (Exception e)
            {
                throw;
            }

            /* TODO ЗАДАНИЕ 2
              * Написать функцию, возвращающую наибольший 
              * общий делитель двух целых чисел.
            */
            Console.WriteLine("НОД:" + nod(Numerator, Denominator));

            /* TODO ЗАДАНИЕ 3
              * Написать функцию сокращения дроби.
            */
            Console.WriteLine(makeshort(Numerator, Denominator));

            /* TODO ЗАДАНИЕ 3
              * Написать функцию, вычисляющую сумму двух дробей.
              * Возвращаемая дробь должна быть несократимой.
            */
            try
            {
                input2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.WriteLine("Результат = {0}", output(MathDr()[0].ToString(), MathDr()[1].ToString()));

            /* TODO ЗАДАНИЕ 4
              * Написать функцию подсчитывающую количество цифр в числе.
            */
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кол-во цифр в числе: {0} ", kolvozifr(a));
        }
    }
}