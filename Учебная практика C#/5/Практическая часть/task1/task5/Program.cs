namespace task5
{
    using System;

    class Program
    {
        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static double CalculateF(int n)
        {
            if (n <= 2)
            {
                return 0;
            }
            else
            {
                return Factorial(n - 2) / Factorial(n);
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите значение n:");
            int n = int.Parse(Console.ReadLine());

            double result = CalculateF(n);

            Console.WriteLine($"Значение f({n}) = {result}");
        }
    }

}
