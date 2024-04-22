namespace task4
{
    using System;

    class Program
    {
        static void Main()
        {
            
            int[,] tickets = new int[20, 36];

           
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 36; j++)
                {
                    tickets[i, j] = random.Next(0, 2); 
                }
            }

            
            bool hasFreeSeats = false;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 36; j++)
                {
                    if (tickets[i, j] == 0)
                    {
                        hasFreeSeats = true;
                        break;
                    }
                }
                if (hasFreeSeats)
                {
                    break;
                }
            }

            if (hasFreeSeats)
            {
                Console.WriteLine("В поезде имеются свободные места.");
            }
            else
            {
                Console.WriteLine("В поезде нет свободных мест.");
            }
        }
    }
}
