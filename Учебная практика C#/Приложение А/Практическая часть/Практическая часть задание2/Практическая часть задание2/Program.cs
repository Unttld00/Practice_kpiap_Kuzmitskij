namespace Практическая_часть_задание2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 1000;
            int lastDigit = number % 10;

            int newNumber = lastDigit * 1000 + (number % 1000) - (number % 10) + firstDigit;

            Console.WriteLine("Число после перестановки: " + newNumber);
        }
    }
}