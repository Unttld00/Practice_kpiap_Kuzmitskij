/// <summary>
/// Эта программа демонстрирует использование делегатов и анонимных методов для вычисления среднего значения случайных чисел, генерируемых несколькими методами.
/// </summary>
using System;

class Program
{
    /// <summary>
    /// Тип делегата, представляющий метод, генерирующий случайное целое число от 1 до 100 (включительно).
    /// </summary>
    delegate int RandomNumberMethod();

    static void Main()
    {
        /// <summary>
        /// Массив для хранения экземпляров делегатов, представляющих методы генерации случайных чисел.
        /// </summary>
        RandomNumberMethod[] methods = new RandomNumberMethod[5];

        /// <summary>
        /// Экземпляр класса Random для генерации случайных чисел.
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Инициализация массива методов анонимными методами, которые используют Random.Next() для генерации случайных чисел.
        /// </summary>
        for (int i = 0; i < methods.Length; i++)
        {
            methods[i] = delegate () { return random.Next(1, 100); };
        }

        /// <summary>
        /// Вычисляет среднее значение случайных чисел, генерируемых методами в массиве.
        /// </summary>
        double average = CalculateAverage(methods);

        Console.WriteLine("Среднее значение (Average value): " + average);
    }

    /// <summary>
    /// Вычисляет среднее значение случайных чисел, генерируемых методами делегатов в предоставленном массиве.
    /// </summary>
    /// <param name="methods">Массив экземпляров делегатов, представляющих методы генерации случайных чисел.</param>
    /// <returns>Среднее значение в виде double.</returns>
    static double CalculateAverage(RandomNumberMethod[] methods)
    {
        int sum = 0;
        foreach (var method in methods)
        {
            sum += method();
        }
        return (double)sum / methods.Length;
    }
}