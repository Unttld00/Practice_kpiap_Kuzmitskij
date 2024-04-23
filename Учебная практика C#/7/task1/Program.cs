namespace task1
{
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            Regex reg = new Regex(@"\d+");
            MatchCollection cock = reg.Matches(text);
            foreach(Match match in cock)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
