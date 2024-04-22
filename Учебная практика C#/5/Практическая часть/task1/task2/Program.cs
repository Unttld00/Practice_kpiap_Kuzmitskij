namespace task2
{
    using System;

    class Program
    {
        static void Main()
        {
            // Формирование массива согласно варианту
            Console.WriteLine("Введите колличество(n) элементов в последовательности: ");
            
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элемент N{i+1} в последовательности: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }


            // Сортировка массива
            Array.Sort(numbers);

            // Ввод числа k с клавиатуры
            Console.Write("Введите число k для бинарного поиска: ");
            int k = int.Parse(Console.ReadLine());

            // Бинарный поиск числа k
            int index = Array.BinarySearch(numbers, k);
            if (index >= 0)
            {
                Console.WriteLine($"Число {k} найдено в массиве на позиции {index}");
            }
            else
            {
                Console.WriteLine($"Число {k} не найдено в массиве");
            }

            // Определение количества членов последовательности кратных 3 и не кратных 5
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % 3 == 0 && number % 5 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество членов последовательности кратных 3 и не кратных 5: {count}");
        }
    }

}
