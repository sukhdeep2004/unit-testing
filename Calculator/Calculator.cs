using System;
namespace Calculator.service
{
    public class Calculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return (double)a / b;
        }
        public int Modulus(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return a % b;
        }
        public double Power(int a, int b)
        {
            return Math.Pow(a, b);
        }
        public double SquareRoot(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot compute square root of a negative number.");
            }
            return Math.Sqrt(a);
        }
        public double Factorial(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot compute factorial of a negative number.");
            }
            if (a == 0 || a == 1)
            {
                return 1;
            }
            double result = 1;
            for (int i = 2; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}


