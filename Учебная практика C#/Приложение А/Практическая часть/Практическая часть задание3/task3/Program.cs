namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            double y = (7 * Math.Pow(Math.Atan(Math.Sqrt(Math.Pow(Math.E, x) + 1)), 2)) + Math.Abs(x);
            Console.WriteLine("Значение функции при x = " + x + ":  y = " + y);
        }
    }
}