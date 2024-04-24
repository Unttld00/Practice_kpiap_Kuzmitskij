namespace task1
{
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            Regex reg = new Regex(@"\B#\w+");
            MatchCollection matches = reg.Matches(text);
            Console.WriteLine("Слова, начинающиеся с #: ");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            Console.ReadKey();
        }
    }
}
