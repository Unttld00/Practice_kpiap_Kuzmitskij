namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double dividing = number % 10;
            double summ = dividing;
            dividing = Math.Floor(((number % 100) / 10));
            summ += dividing;
            dividing = Math.Floor(((number % 1000) / 100));
            summ += dividing;
            dividing = Math.Floor(((number % 10000) / 1000));
            summ += dividing;
            Console.WriteLine(summ);

        }
    }
}
