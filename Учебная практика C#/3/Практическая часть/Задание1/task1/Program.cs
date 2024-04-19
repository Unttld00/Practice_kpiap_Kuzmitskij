namespace task1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            double b = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Введите шаг h:");
            double step = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x | y");
            Console.WriteLine("---------");

            for (double x = a; x <= b; x += step)
            {
                double y;
                if (x <= 3)
                {
                    y = Math.Sqrt(b * x);
                }
                else if (x <= 10 && x>3)
                {
                    y = b * x * x;
                }
                else 
                {
                    y = (2 * x * x * x) + (4 * x * x) - (a * x);
                }

                Console.WriteLine($"{x} | {y}");
            }
        }
    }
}