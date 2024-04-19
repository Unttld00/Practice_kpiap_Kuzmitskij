namespace task4
{
    class NumberChecker
    {
        public static bool AreNegative(int a, int b)
        {
            return a < 0 && b < 0;
        }

        public static bool AreNegative(int a, int b, int c)
        {
            return a < 0 && b < 0 && c < 0;
        }

        static void Main()
        {
            Console.Write("Введите первое целое число a1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе целое число b1: ");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите первое целое число a2: ");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе целое число b2: ");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье целое число c2: ");
            int c2 = Convert.ToInt32(Console.ReadLine());

            bool result1 = AreNegative(a1, b1);
            bool result2 = AreNegative(a2, b2, c2);


            Console.WriteLine($"Результат AreNegative(AreNegative(a1, b1): {result1}, AreNegative(a2, b2, c2)): {result2}");

        }
    }
}