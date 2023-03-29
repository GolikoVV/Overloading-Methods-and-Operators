using Overloading_Methods_and_Operators;
using System;

namespace Overloading_Methods_and_Operators
{
    class Program
    {
        static void Main()
        {
            // Создаем два рациональных числа
            RationalNumber x1 = new RationalNumber(5, 2);
            RationalNumber x2 = new RationalNumber(7, 9);

            // Примеры использования перегруженных операторов
            RationalNumber sum = x1 + x2;
            RationalNumber difference = x1 - x2;
            RationalNumber product = x1 * x2;
            RationalNumber quotient = x1 / x2;
            bool isEqual = x1 == x2;
            bool isNotEqual = x1 != x2;
            bool isGreater = x1 > x2;
            bool isLess = x1 < x2;

            // Вывод результатов
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
            Console.WriteLine("x1 + x2 = " + sum);
            Console.WriteLine("x1 - x2 = " + difference);
            Console.WriteLine("x1 * x2 = " + product);
            Console.WriteLine("x1 / x2 = " + quotient);
            Console.WriteLine("x1 == x2: " + isEqual);
            Console.WriteLine("x1 != x2: " + isNotEqual);
            Console.WriteLine("x1 > x2: " + isGreater);
            Console.WriteLine("x1 < x2: " + isLess);
            //Перевод строки
            Console.ReadLine();
        }
    }
}