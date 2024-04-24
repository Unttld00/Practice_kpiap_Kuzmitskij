namespace task3
{
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, @"\b\w+ing\b");

            Console.WriteLine("Слова, заканчивающиеся на -ing: ");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            
        }
    }
}