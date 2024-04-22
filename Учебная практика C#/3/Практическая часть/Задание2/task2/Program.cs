namespace task2
{
    using System;

    internal class Program
    {
        static void Mean(double X, double Y, out double AMean, out double GMean)
        {
            AMean = (X + Y) / 2;
            GMean = Math.Sqrt(X * Y);
        }

        static void Main()
        {
            Console.WriteLine("Введите значение A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение C: ");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение D: ");
            double D = Convert.ToDouble(Console.ReadLine());

            double AMean_AB, GMean_AB;
            Mean(A, B, out AMean_AB, out GMean_AB);

            double AMean_AC, GMean_AC;
            Mean(A, C, out AMean_AC, out GMean_AC);

            double AMean_AD, GMean_AD;
            Mean(A, D, out AMean_AD, out GMean_AD);

            Console.WriteLine("Среднее арифметическое и среднее геометрическое для пар (A, B): {0}, {1}", AMean_AB, GMean_AB);
            Console.WriteLine("Среднее арифметическое и среднее геометрическое для пар (A, C): {0}, {1}", AMean_AC, GMean_AC);
            Console.WriteLine("Среднее арифметическое и среднее геометрическое для пар (A, D): {0}, {1}", AMean_AD, GMean_AD);
        }
    }

}