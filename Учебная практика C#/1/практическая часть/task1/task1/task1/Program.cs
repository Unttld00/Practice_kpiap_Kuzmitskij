
using System.Runtime.Serialization.Formatters;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг x: ");
            double Change = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начальное значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечное значение x: ");
            double x_end = Convert.ToDouble(Console.ReadLine());
            for (double i = x; i < x_end; i += Change)
            {
                if (i < 0.5)
                {
                    double y = (Math.Pow(Math.Log(i), 3) + (i * i)) / (Math.Sqrt((i + 2)));
                    Console.WriteLine("Значение функиции y = " + y + " при значении x = " + i);

                }
                else if (i > 0.5)
                {
                    double y = Math.Cos(i) + (2 * Math.Pow(Math.Sin(i), 2));
                    Console.WriteLine("Значение функиции y = " + y + " при значении x = " + i);

                }
                else
                {
                    double y = 0;
                    Console.WriteLine("Значение функиции y = " + y + " при значении x = " + i);
                }
               


            }
        }
    }
}

