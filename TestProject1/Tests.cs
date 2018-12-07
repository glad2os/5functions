using System;
using ConsoleApplication1;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        /*
         * Тестируем функцию ввода дроби (числителя и знаменателя) с клавиатуры
         * Тест 1 : Допустимое значение знаменателя
         * Результат : FALSE
         */
        public void enter_fractions_with_values()
        {
            try
            {
                ConsoleApplication1.MyCalc.input(10, 30);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем функцию ввода дроби (числителя и знаменателя) с клавиатуры
         * Тест 2: Нулевое значение знаменателя
         * Результат: FALSE
         * Ошибка : System.Exception : Знаменатель не может быть = 0!
         */
        [Test]
        public void enter_fractions_with_zero_denominator()
        {
            try
            {
                ConsoleApplication1.MyCalc.input(10, 0);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем функцию ввода дроби (числителя и знаменателя) с клавиатуры
         * Тест 3: Отрицательное значение
         * Результат: FALSE
         * Ошибка : System.Exception : Отрицательное значение знаменателя
         */
        [Test]
        public void enter_fractions_with_negative_denominator()
        {
            try
            {
                ConsoleApplication1.MyCalc.input(10, -5);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем функцию Наибольший общий делитель двух целых чисел.
         * Тест 1 : Два положительных числа
         * Результат: TRUE
         */
        [Test]
        public void highest_common_factor_with_two_positive_numbers()
        {
            try
            {
                ConsoleApplication1.MyCalc.nod(50, 40);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем функцию Наибольший общий делитель двух целых чисел.
         * Тест 2 : Одно число отрицательное
         * Результат: TRUE
        */
        [Test]
        public void highest_common_factor_with_one_positive_and_one_negative_numbers()
        {
            try
            {
                ConsoleApplication1.MyCalc.nod(-60, 20);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем функцию Наибольший общий делитель двух целых чисел.
         * Тест 3 : Второе число отрицательное
         * Результат: TRUE
         */
        [Test]
        public void highest_common_factor_with_one_positive_and_second_negative_numbers()
        {
            try
            {
                ConsoleApplication1.MyCalc.nod(60,-120);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем функцию Наибольший общий делитель двух целых чисел.
         * Тест 4 : Первое число равно 0
         * Результат: TRUE
         */
        [Test]
        public void highest_common_factor_with_first_zero_and_second_positive_numbers()
        {
            try
            {
                ConsoleApplication1.MyCalc.nod(0, 10);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }    
        
        /*
         * Тестируем функцию Наибольший общий делитель двух целых чисел.
         * Тест 5 : Второе число равно 0
         * Результат: TRUE
         */
        [Test]
        public void highest_common_factor_with_first_positive_and_second_zero_numbers()
        {
            try
            {
                ConsoleApplication1.MyCalc.nod(10, 0);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }    
      
        /*
         * Тестируем функцию Наибольший общий делитель двух целых чисел.
         * Тест 6 : Оба числа равны 0
         * Результат: TRUE
         */
        [Test]
        public void highest_common_factor_with_first_zero_and_second_zero_numbers()
        {
            try
            {
                ConsoleApplication1.MyCalc.nod(0, 0);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем Сокращение дроби
         * Тест 1 : Есть общий делитель
         * Результат : TRUE
         */
        [Test]
        public void short_fraction_have_hcf()
        {
            try
            {
                ConsoleApplication1.MyCalc.makeshort(60, 120);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем Сокращение дроби
         * Тест 2 : Нет общего делителя
         * Результат : FALSE
         */
        [Test]
        public void short_fraction_do_not_have_hcf()
        {
            try
            {
                ConsoleApplication1.MyCalc.makeshort(59, 73);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем сумму двух дробей
         * Тест 1: " "
         * Результат: TRUE
         */
        [Test]
        public void summ_two_fraction_1()
        {
            try
            {
                ConsoleApplication1.MyCalc.Numerator = 10;
                ConsoleApplication1.MyCalc.Denominator = 20;
                ConsoleApplication1.MyCalc.Numerator2 = 40;
                ConsoleApplication1.MyCalc.Denominator2 = 120;
                ConsoleApplication1.MyCalc.MathDr();
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        /*
         * Тестируем сумму двух дробей
         * Тест 2: " "
         * Результат: TRUE
         */
        [Test]
        public void summ_two_fraction_2()
        {
            try
            {
                ConsoleApplication1.MyCalc.Numerator = 30;
                ConsoleApplication1.MyCalc.Denominator = 40;
                ConsoleApplication1.MyCalc.Numerator2 = 32;
                ConsoleApplication1.MyCalc.Denominator2 = 96;
                ConsoleApplication1.MyCalc.MathDr();
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем сумму двух дробей
         * Тест 3: " "
         * Результат: TRUE
         */
        [Test]
        public void summ_two_fraction_3()
        {
            try
            {
                ConsoleApplication1.MyCalc.Numerator = 90;
                ConsoleApplication1.MyCalc.Denominator = 22;
                ConsoleApplication1.MyCalc.Numerator2 = 4;
                ConsoleApplication1.MyCalc.Denominator2 = 6;
                ConsoleApplication1.MyCalc.MathDr();
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Количество цифр в числе.
         * Тест 1
         * Результат True
         */
        [Test]
        public void number_of_digits_in_positive_number()
        {
            try
            {
                ConsoleApplication1.MyCalc.kolvozifr(500);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем количество цифр в числе.
         * Тест 2
         * Результат True
         */
        [Test]
        public void number_of_digits_in_negative_number()
        {
            try
            {
                ConsoleApplication1.MyCalc.kolvozifr(-500);
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем количество цифр в числе.
         * Тест 3
         * Результат True
         */
        [Test]
        public void number_of_digits_in_zero_number()
        {
            try
            {
                Console.Write(ConsoleApplication1.MyCalc.kolvozifr(0));
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем количество цифр в числе.
         * Тест 1
         * Числитель: однозначный положительный
         * Знаменатель: однозначный
         * Результат True
         */
        [Test]
        public void output_fraction_on_the_screen_one_per_one_positive()
        {
            try
            {
                Console.WriteLine(ConsoleApplication1.MyCalc.output(5.ToString(),9.ToString()));
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }  
        
        /*
         * Тестируем количество цифр в числе.
         * Тест 2
         * Числитель: однозначный положительный
         * Знаменатель: трехзначный
         * Результат True
         */
        [Test]
        public void output_fraction_on_the_screen_one_per_three_positive()
        {
            try
            {
                Console.WriteLine(ConsoleApplication1.MyCalc.output(3.ToString(),900.ToString()));
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }
        
        /*
         * Тестируем количество цифр в числе.
         * Тест 3
         * Числитель: трехзначный положительный
         * Знаменатель: двухзначный
         * Результат True
         */
        [Test]
        public void output_fraction_on_the_screen_three_per_two_positive()
        {
            try
            {
                Console.WriteLine(ConsoleApplication1.MyCalc.output(300.ToString(),10.ToString()));
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }   
        
        /*
         * Тестируем количество цифр в числе.
         * Тест 3
         * Числитель: Числитель: трехзначный отрицательный
         * Знаменатель: двухзначный
         * Результат True
         */
        [Test]
        public void output_fraction_on_the_screen_three_negative_per_two_positive()
        {
            try
            {
                Console.WriteLine(ConsoleApplication1.MyCalc.output("-300",10.ToString()));
            }
            catch (Exception)
            {
                throw;
            }
            Assert.True(true);
        }     
    }
}