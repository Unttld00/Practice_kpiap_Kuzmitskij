namespace task3
{
    using System;

    class Program
    {
        static double CalculateFunction(double x)
        {
            try
            {
                if (x > -1 && x <= 5)
                {
                    if (x == -1)
                    {
                        throw new DivideByZeroException("Деление на ноль!.");
                    }

                    return x / (5 * x + 5);
                }
                else if (x > -5 && x < -1)
                {
                    return Math.Pow(x, 3);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение Х вышло за пределы.");
                }
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
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return double.NaN;
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите значение Х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = CalculateFunction(x);
            Console.WriteLine($"Значения функции для x = {x}: {result}");
        }
    }

}