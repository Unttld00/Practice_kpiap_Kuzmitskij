using System.Text.RegularExpressions;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            Regex reg = new Regex(@"#{1}\w+");
            MatchCollection cock = reg.Matches(text);
            foreach (Match match in cock)
            {
                Console.WriteLine(match.Value);            
            }
            Console.ReadKey();
        }
    }
}
