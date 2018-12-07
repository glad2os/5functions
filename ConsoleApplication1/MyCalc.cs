using System;

namespace ConsoleApplication1
{
    public class MyCalc
    {
        public static int Numerator;
        public static int Denominator;
        public static int Numerator2;
        public static int Denominator2;

        private static void input()
        {
            Console.WriteLine("Введите числитель:");
            Numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель:");
            Denominator = Convert.ToInt32(Console.ReadLine());
            if (Denominator == 0) throw new Exception("Знаменатель не может быть = 0!");
        }
        
        public static int input(int numerator,int denominator)
        {
            Numerator = Convert.ToInt32(numerator);
            Denominator = Convert.ToInt32(denominator);
            if (Denominator == 0) throw new Exception("Знаменатель не может быть = 0!");
            if (Denominator < 0) throw new Exception("Отрицательное значение знаменателя");
            return 0;
        }

        private static void input2()
        {
            Console.WriteLine("Введите числитель второй дроби:");
            Numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель:");
            Denominator2 = Convert.ToInt32(Console.ReadLine());
            if (Denominator2 == 0) throw new Exception("Знаменатель не может быть = 0!");
        }
        
        public static int nod(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public static string makeshort(int n, int d)
        {
            int temp1 = n / nod(n, d);
            int temp2 = d / nod(n, d);
            if (nod(n, d)==1)
            {
                throw new Exception("Дробь нельзя сократить!");
            }
            return "Numerator: " + temp1 + " : " + "Denominator: " + temp2;
        }

        public static int Znamen(int y1, int y2)
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

        public static int kolvozifr(int n)
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

    }
}