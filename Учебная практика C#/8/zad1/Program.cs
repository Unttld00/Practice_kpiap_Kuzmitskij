namespace zad1
{
    using System;


    class Program
    {
        static void Main(string[] args)
        {

            
            ZNAK[] znaks = new ZNAK[2];

            // Ввод данных в массив
            for (int i = 0; i < znaks.Length; i++)
            {
                Console.WriteLine($"Введите данные для {i + 1}-го человека:");
                Console.Write("Фамилия: ");
                znaks[i].LastName = Console.ReadLine();
                Console.Write("Имя: ");
                znaks[i].FirstName = Console.ReadLine();
                Console.Write("Знак Зодиака: ");
                znaks[i].ZodiacSign = Console.ReadLine();
                Console.Write("Дата рождения (день, месяц, год): ");
                znaks[i].BirthDate = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            }

           
          

            
            Console.Write("Введите название знака Зодиака: ");
            string zodiacSignToFind = Console.ReadLine();

            
            bool found = false;
            foreach (ZNAK znak in znaks)
            {
                if (znak.ZodiacSign == zodiacSignToFind)
                {
                    Console.WriteLine($"--- {znak.LastName} {znak.FirstName} ({znak.ZodiacSign}) ---");
                    Console.WriteLine($"Дата рождения: {znak.BirthDate[0]}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Люди, родившиеся под знаком {zodiacSignToFind}, не найдены.");
            }
        }
        struct ZNAK
        {
            public string LastName; 
            public string FirstName; 
            public string ZodiacSign; 
            public int[] BirthDate; 
        }


    }
}