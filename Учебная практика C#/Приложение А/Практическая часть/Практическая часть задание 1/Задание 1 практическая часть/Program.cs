namespace Задание_1_практическая_часть
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х : " );
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y : ");
            int y = int.Parse(Console.ReadLine());
            x = 3 * x;
            x = x / y;
            x = Math.Round(x, 4);
            Console.WriteLine("Результат, округленный до 4 знаков после запятой: (3x / y) = " + x);


        }
    }
}