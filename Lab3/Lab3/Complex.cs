using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Complex
    {
        public double r, i;

        public  Complex()
        {
            this.r = 0.0;
            this.i = 0.0;
        }

        public static Complex Sum(Complex first, Complex second)
        {
            Complex res = new Complex();
            res.r = first.r + second.r;
            res.i = first.i + second.i;
            return res;
        }

        public static Complex operator +(Complex first, Complex second)
        {
            return Complex.Sum(first, second);
        }

        public static Complex Difference(Complex first, Complex second)
        {
            Complex res = new Complex();
            res.r = first.r - second.r;
            res.i = first.i - second.i;
            return res;
        }

        public static Complex operator -(Complex first, Complex second)
        {
            return Complex.Difference(first, second);
        }

        public static Complex Multiplication(Complex first, Complex second)
        {
            Complex res = new Complex();
            res.r = first.r * second.r - first.i * second.i;
            res.i = first.i * second.r + first.r * second.i;
            return res;
        }

        public static Complex operator *(Complex first, Complex second)
        {
            return Complex.Multiplication(first, second);
        }

        public static Complex Division(Complex first, Complex second)
        {
            Complex res = new Complex();
            res.r = (first.r * second.r + first.i * second.i) / 
                (second.r * second.r + second.i * second.i);
            res.i = (first.i * second.r - first.r * second.i) / 
                (second.r * second.r + second.i * second.i);
            return res;
        }

        public static Complex operator /(Complex first, Complex second)
        {
            return Complex.Division(first, second);
        }

        public static bool operator ==(Complex first, Complex second)
        {
            return first.r == second.r && first.i == second.i;
        }

        public static bool operator !=(Complex first, Complex second)
        {
            return first.r != second.r || first.i != second.i;
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
