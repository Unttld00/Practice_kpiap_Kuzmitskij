namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение альфа: ");
            int a = int.Parse(Console.ReadLine());
            double z1 = Math.Cos(a) + Math.Cos(a * 2) + Math.Cos(6 * a) + Math.Cos(7 * a);
            double z2 = 4 * Math.Cos(a / 2) * Math.Cos((5 / 2) * a) * Math.Cos(4 * a);
            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 = " + z2);
        }
    }
}
