namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            double numb = Convert.ToDouble(Console.ReadLine());
            double numb1 = numb % 10;
            double numb2 = Math.Floor((numb % 100) / 10);
            double numb3 = Math.Floor(numb / 100);
            if ((numb1 == numb2) & (numb2 == numb3))
                {
                Console.WriteLine("Все три цифры в числе равны");


            }
            else
            {
                Console.WriteLine("Три цифры в числе не равны");

            }
        }
    }
}
