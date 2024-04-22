using System.Text.RegularExpressions;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");

            string input = Console.ReadLine();
            string pattern = @"\b\w\b"; 
            string result = Regex.Replace(input, pattern, "");

            Console.WriteLine(result);
        }

    }
}
