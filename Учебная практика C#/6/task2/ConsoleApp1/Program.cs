namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] sentences = input.Split('.');

            string commonWord = FindCommonWord(sentences);

            if (!string.IsNullOrEmpty(commonWord))
            {
                Console.WriteLine($"Общее слово в каждом предложении: {commonWord}");
            }
            else
            {
                Console.WriteLine("В каждом предложении нет общего слова.");
            }
            Console.ReadKey();
        }

        static string FindCommonWord(string[] sentences)
        {
            string commonWord = null;
            foreach (var sentence in sentences)
            {
                
                string[] words = sentence.Trim().Split(' ');
                if (commonWord == null)
                {
                    commonWord = words[0];
                }
                else
                {
                    commonWord = words.Intersect(commonWord.Split(' ')).FirstOrDefault();
                   
                }
            }
            return commonWord;
        }
    }

}
