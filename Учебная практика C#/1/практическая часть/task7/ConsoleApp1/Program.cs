namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное число N: ");
            int N = int.Parse(Console.ReadLine());

            int steps = 0;

            while (N != 1)
            {
                if (N % 2 == 0)
                {
                    N /= 2;
                }
                else
                {
                    N = 3 * N + 1;
                }

                steps++;
            }

            Console.WriteLine($"Сиракузская последовательность достигла единицы за {steps} шагов.");
        }
    }
}