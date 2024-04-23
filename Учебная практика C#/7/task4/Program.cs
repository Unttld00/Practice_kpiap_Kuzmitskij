
using System.Text.RegularExpressions;
namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            Regex reg = new Regex(@"[0-9]\w+");
            MatchCollection cock = reg.Matches(text);
            Console.WriteLine("Слова, начинающиеся с цифры: ");
            foreach (Match match in cock)
            {
                Console.WriteLine(match.Value);            
            }
            Console.ReadKey();
        }
    }
}
        
