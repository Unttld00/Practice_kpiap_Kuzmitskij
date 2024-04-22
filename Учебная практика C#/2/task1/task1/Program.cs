namespace task1
{
    using System;

    class A
    {
        private double a;
        private int b;

        public A(double a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double CalculateDivide()
        {
            double result = (b - 2) / (2 - a);
            return result;
        }

        public double CalculateSqrt10()
        {
            double result = a / 10;
            return result;
        }
    }

    internal class Program
    {
        static void Main()
        {
            A obj = new A(1, 8);
            Console.WriteLine("Значение выражения (b-2)/(2-a): " + obj.CalculateDivide());
            Console.WriteLine("Значение a в степени 1/10: " + obj.CalculateSqrt10());
        }
    }
}