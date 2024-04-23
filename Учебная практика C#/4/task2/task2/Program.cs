namespace task2
{
    using System;

    class Program
    {
        static void SortInc3(ref double A, ref double B, ref double C)
        {
            if (A > B)
            {
                double temp = A;
                A = B;
                B = temp;
            }
            if (B > C)
            {
                double temp = B;
                B = C;
                C = temp;

                if (A > B)
                {
                    temp = A;
                    A = B;
                    B = temp;
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите значение А1: ");
            double A1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение B1: ");
            double B1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение C1: ");
            double C1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение A2: ");
            double A2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение B2: ");
            double B2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение C2: ");
            double C2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Начальные значения:");
            Console.WriteLine($"Набор 1: A={A1}, B={B1}, C={C1}");
            Console.WriteLine($"Набор 2: A={A2}, B={B2}, C={C2}");

            SortInc3(ref A1, ref B1, ref C1);
            SortInc3(ref A2, ref B2, ref C2);

            Console.WriteLine("\nСортированные значения:");
            Console.WriteLine($"Набор 1: A={A1}, B={B1}, C={C1}");
            Console.WriteLine($"Набор 2: A={A2}, B={B2}, C={C2}");
        }
    }

}