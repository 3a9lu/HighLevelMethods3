using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2_
{
    class Fraction
    {
        public double c = 0;
        public double z = 0;

        public Fraction(int c, int z)
        {
            this.c = c;
            this.z = z;
        }

        // Сокращение дроби
        public static Fraction SetFormat(Fraction a)
        {
            double max = 0;

            // Выбираем что больше числитель или знаменатель
            if (a.c > a.z)
            {
                max = Math.Abs(a.z); // Берём по модулю, чтобы работало и с отрицательными
            }
            else
            {
                max = Math.Abs(a.c); // Берём по модулю, чтобы работало и с отрицательными
            }

            for (double i = max; i >= 2; --i)   // Поиск такого числа, поделив на 2, которое бы делилось без
                                                // остатка и на числитель и на знаменатель
            {
                if ((a.c % i == 0) & (a.z % i == 0))
                {
                    a.c = a.c / i;
                    a.z = a.z / i;
                }
            }
            // Определяемся со знаком, если в знаменателе минус, поднимаем его наверх
            if ((a.z < 0))
            {
                a.c = -1 * (a.c);
                a.z = Math.Abs(a.z);
            }
            return (a);
        }

        public override string ToString() // Метод для вывода
        {
            return c.ToString() + "/" + z.ToString();
        }

        public static Fraction operator +(Fraction a, Fraction b) // Сложение дробей
        {
            Fraction t = new Fraction(1, 1); // Создание и инициализация новой дроби
            t.c = (a.c * b.z + a.z * b.c); // Числитель новой дроби
            t.z = a.z * b.z; // Знаменатель новой дроби
            SetFormat(t); // Сокращаем дробь
            return t; // Возвращаем результат

        }

        public static Fraction operator -(Fraction a, Fraction b) // Вычитание дробей
        {
            Fraction t = new Fraction(1, 1);
            t.c = (a.c * b.z - a.z * b.c);
            t.z = a.z * b.z;
            SetFormat(t);
            return t;

        }
        public static Fraction operator *(Fraction a, Fraction b) // Умножение дробей
        {
            Fraction t = new Fraction(1, 1);
            t.c = (a.c * b.c);
            t.z = a.z * b.z;
            SetFormat(t);
            return t;

        }
        public static Fraction operator /(Fraction a, Fraction b) // Деление дробей
        {
            Fraction t = new Fraction(1, 1);
            t.c = (a.c / b.c);
            t.z = a.z / b.z;
            SetFormat(t);
            return t;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.c == b.c && a.z == b.z;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.c != b.c && a.z != b.z;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
