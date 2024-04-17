namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите объем первой жидкости: ");
            double V1 = double.Parse(Console.ReadLine());

            Console.Write("Введите температуру первой жидкости: ");
            double T1 = double.Parse(Console.ReadLine());

            Console.Write("Введите объем второй жидкости: ");
            double V2 = double.Parse(Console.ReadLine());

            Console.Write("Введите температуру второй жидкости: ");
            double T2 = double.Parse(Console.ReadLine());

            double V = V1 + V2;
            double T = (V1 * T1 + V2 * T2) / (V1 + V2);

            Console.WriteLine("Объем смеси: " + V);
            Console.WriteLine("Температура смеси: " + T);
        }
    }
}