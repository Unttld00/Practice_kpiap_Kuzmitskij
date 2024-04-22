namespace task1
{
    using System;

    class Program
    {
        static double CalculateExpressionA(double x)
        {
            try
            {
                double numerator = Math.Pow(x, 2) - 3;
                double denominator = Math.Pow(x, 3) - 4;

                if (denominator == 0)
                {
                    throw new DivideByZeroException("Деление на ноль!.");
                }

                return numerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return double.NaN; 
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return double.NaN;
            }
        }

        static double CalculateExpressionB(double x)
        {
            try
            {
                if (x <= 0)
                {
                    throw new FormatException("Натуральный логорифм не может быть меньше или равен нулю.");
                }

                return Math.Log(x) / (x - 1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return double.NaN;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return double.NaN;
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double resultA = CalculateExpressionA(x);
            Console.WriteLine($"Результат выражения А для Х = {resultA}");

            double resultB = CalculateExpressionB(x);
            Console.WriteLine($"Результат выражения B для Х = {resultB}");
        }
    }

}