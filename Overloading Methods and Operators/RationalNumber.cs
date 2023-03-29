using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Methods_and_Operators
{
    internal class RationalNumber
    {
        private long numerator; // Числитель
        private long denominator; // Знаменатель

        // Конструктор класса
        public RationalNumber(long numerator, long denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }

            // Сокращаем дробь до несократимого вида
            long gcd = GCD(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;

            // Приводим знаменатель к положительному значению
            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;             /*
                                                               Здесь определяется класс RationalNumber. Он имеет два поля: numerator (числитель) 
                                                               и denominator (знаменатель), оба являются типом long. Конструктор класса принимает два 
                                                               параметра: numerator и denominator и сначала проверяет, что denominator не равен нулю, 
                                                               чтобы не было деления на ноль в дальнейшем. Затем он сокращает дробь до несократимого вида, 
                                                               находя их наибольший общий делитель (НОД) при помощи вспомогательного метода GCD. Затем знак
                                                               знаменателя проверяется и, если он отрицательный, то знак переносится на числитель и 
                                                               знаменатель становится положительным.
                                                               */
                this.denominator = -this.denominator;
            }
            // Перегрузка метода ToString(), возвращающего строку в формате "numerator/denominator"
        }

        private static long GCD(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b > 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;  /* Метод GCD - это вспомогательный метод, используемый для нахождения наибольшего общего делителя (НОД) двух чисел.
                       Он принимает два параметра типа long - a и b, находит их модули и затем использует алгоритм Евклида для нахождения НОД.
                       Он возвращает наибольший общий делитель в виде целого числа типа long. */
        }
        public override string ToString()
          {
            return numerator + "/" + denominator;
        }
        // Перегрузка оператора сложения
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            long numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            long denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
        }

        // Перегрузка оператора вычитания
        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            long numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            long denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
        }

        // Перегрузка оператора умножения
        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            long numerator = a.numerator * b.numerator;
            long denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
        }

        // Перегрузка оператора деления
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            long numerator = a.numerator * b.denominator;
            long denominator = a.denominator * b.numerator;
            return new RationalNumber(numerator, denominator);
        }
        // Перегрузка оператора равенства
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.numerator == b.numerator && a.denominator == b.denominator;
        }

        // Перегрузка оператора неравенства
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        // Перегрузка оператора меньше
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator < b.numerator * a.denominator;
        }

        // Перегрузка оператора меньше или равно
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a == b || a < b;
        }

        // Перегрузка оператора больше
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return !(a <= b);
        }

        // Перегрузка оператора больше или равно
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return !(a < b);
        }
 /*Здесь происходит перегрузка операторов сравнения для класса RationalNumber. Операторы сравнения
позволяют сравнивать объекты класса RationalNumber между собой и получать результат в виде логических значений (true или false).
Для каждого оператора определена логика сравнения чисел. Например, в операторе < определяется,
что число a меньше числа b, если произведение числителя a на знаменатель b меньше произведения
числителя b на знаменатель a. Операторы сравнения используются для сортировки и поиска элементов
в коллекциях, а также для других операций, где необходимо сравнивать числа. */
        // Метод, возвращающий информацию об экземпляре класса
        public string GetInfo()
        {
            return $"RationalNumber: numerator = {numerator}, denominator = {denominator}";
        }
    }
}
/*
 Здесь перегружается метод ToString(), который используется для 
вывода значения объекта класса RationalNumber на печать в виде строки. 
В методе используется интерполяция строк для формирования строки вида "числитель/знаменатель".
Также в классе определен метод GetInfo(), который возвращает строку, с
одержащую информацию о числе (значения числителя и знаменателя). 
Этот метод может быть полезен для отладки и тестирования кода.
 */
