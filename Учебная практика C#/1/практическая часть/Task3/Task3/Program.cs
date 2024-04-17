namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sportsmen_height = new int[9];
            for (int i = 0; i < sportsmen_height.Length; i++)
            {
                sportsmen_height[i] = i + 1;

            }
            foreach (int elem in sportsmen_height)
            {
                if (elem == 1 | elem == 2 | elem == 9)
                { Console.WriteLine("Игрок под номером " + elem + " - баскетболист"); }
                else if (elem == 3 | elem == 4 | elem == 5)
                { Console.WriteLine("Игрок под номером " + elem + " - футболист"); }
                else if (elem == 6 | elem == 7 | elem == 8)
                { Console.WriteLine("Игрок под номером " + elem + " - занимается штангой"); }
            }
            }
        }
    }

