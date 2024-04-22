namespace task3
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Введите размер N квадратной матрицы (N < 10): ");
            int N = int.Parse(Console.ReadLine());

            // Создание двумерного массива для матрицы
            int[,] matrix = new int[N, N];

            Console.WriteLine("Введите диапазон случайных чисел [a, b] (a < b): ");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            // Заполнение матрицы случайными числами
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(a, b);
                }
            }

            // Вывод исходной матрицы
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Вычисление среднего арифметического отрицательных чисел
            int countNegative = 0;
            int sumNegative = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        countNegative++;
                        sumNegative += matrix[i, j];
                    }
                }
            }
            if (countNegative == 0)
            {
                Console.WriteLine("В массиве отсутствуют отрицательные элементы!");

            }
            else
            { 
            double averageNegative = sumNegative / countNegative;
            Console.WriteLine($"Среднее арифметическое отрицательных чисел: {averageNegative}"); }

            // Вычисление суммы элементов каждой строки
            for (int i = 0; i < N; i++)
            {
                int sumRow = 0;
                for (int j = 0; j < N; j++)
                {
                    sumRow += matrix[i, j];
                }
                Console.WriteLine($"Сумма элементов в строке {i + 1}: {sumRow}");
            }
        }
    }

}
