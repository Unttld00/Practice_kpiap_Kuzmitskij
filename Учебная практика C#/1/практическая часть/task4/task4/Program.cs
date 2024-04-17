using System.Security.Cryptography;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую операцию использовать? (1 - for, 2 - while, 3 - do while): ");
            int chose = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите число A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            int B = int.Parse(Console.ReadLine());
            if (chose == 1)
            {
                for (int i = A; i <= B; i++)
                {
                    if ((i % 2 == 0) && (i % 5 == 0))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            if (chose == 2)
            {
                while (A <= B)
                {
                    if ((A % 2 == 0) && (A % 5 == 0))
                    {
                        Console.WriteLine(A);
                    }
                    A++;

                }
            }
            if (chose == 3)
            {
                do
                {
                    if ((A % 2 == 0) && (A % 5 == 0))
                    {
                        Console.WriteLine(A);
                    }
                    A++;
                } while (A <= B);
            }
            
        }
    }
}
