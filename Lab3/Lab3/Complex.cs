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

        public static Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return Complex.Sum(a, b);
        }

        public static Complex Difference(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return Complex.Difference(a, b);
        }

        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r * b.r - a.i * b.i;
            res.i = a.i * b.r + a.r * b.i;
            return res;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return Complex.Multiplication(a, b);
        }

        public static Complex Division(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = (a.r * b.r + a.i * b.i) / (b.r * b.r + b.i * b.i);
            res.i = (a.i * b.r - a.r * b.i) / (b.r * b.r + b.i * b.i);
            return res;
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return Complex.Division(a, b);
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return a.r == b.r && a.i == b.i;
        }
        public static bool operator !=(Complex first, Complex second)
        {
            return !(first == second);
        }
    }
}
