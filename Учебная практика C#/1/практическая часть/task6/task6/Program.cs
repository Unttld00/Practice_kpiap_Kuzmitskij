namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Math.PI / 4;
            double B = Math.PI / 2;
            int M = 15;
            double H = (B - A) / M; 
            for (double i = A; i <=B; i += H)
            {
                double result = Math.Cos(i);
                Console.WriteLine("F(" + i + ") = "+ result);
            
            }

        }
    }
}
