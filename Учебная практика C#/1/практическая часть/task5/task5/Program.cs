namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            while (A >= 5 | A <= -5)
            {
                Console.WriteLine("А должно соответствовать условию -5 <= A <= 5. Введите A: ");
                A = Convert.ToDouble(Console.ReadLine());
            }
                
            Console.Write("Введите значение N: ");
            int N = int.Parse(Console.ReadLine());
            while (N >= 10 | N <= 1)
            {
                Console.WriteLine("N должно соответствовать условию 1 <= N <= 10. Введите A: ");
                A = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("А в степени N = " + Math.Pow(A, N));
        }
    }
}
