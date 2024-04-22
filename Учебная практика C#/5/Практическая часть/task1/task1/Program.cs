namespace task1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите колличество элементов в массиве: ");
            int arr_len = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[arr_len];
            for (int i = 0; i < arr_len; i++)
            {
                Console.WriteLine($"Введите элемент массива N{i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
           

            double minNegative = double.MaxValue;

            foreach (double number in numbers)
            {
                if (number < 0 && number < minNegative)
                {
                    minNegative = number;
                }
            }

            if (minNegative < 0)
            {
                Console.WriteLine("Минимальный отрицательный элемент: " + minNegative);
            }
            else
            {
                Console.WriteLine("В массиве нет отрицательных элементов.");
            }
        }
    }

}
