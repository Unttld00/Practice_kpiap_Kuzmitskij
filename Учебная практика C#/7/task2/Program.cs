namespace task2
{
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            Regex reg = new Regex(@"\d+");
            MatchCollection matches = reg.Matches(text);
            Console.WriteLine("Числа, извлеченные из строки: ");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}

