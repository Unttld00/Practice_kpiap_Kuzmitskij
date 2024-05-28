namespace zad2
{
    public enum Positions
    {
        Director = 160, 
        Manager = 150, 
        Specialist = 140, 
        Intern = 120 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Positions myPosition = Positions.Specialist;

            int requiredHours = (int)myPosition; 

            Console.WriteLine($"Должность: {myPosition}");
            Console.WriteLine($"Норма рабочего времени: {requiredHours} часов");
        }
    }
}