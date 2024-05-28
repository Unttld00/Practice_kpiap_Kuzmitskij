using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string filename = "lab16.txt";
            List<double> numbers = ReadNumbersFromFile(filename);
            (double min, int positiveCount) = FindMinAndCountPositives(numbers);

            Console.WriteLine($"Минимальное число в файле: {min}");
            Console.WriteLine($"Количество положительных элементов: {positiveCount}");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"Файл '{e.FileName}' не найден.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }

    static string GetInputFilename()
    {
        Console.Write("Введите имя файла: ");
        return Console.ReadLine();
    }

    static List<double> ReadNumbersFromFile(string filename)
    {
        List<double> numbers = new List<double>();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                line = line.Trim();

                if (line.Length > 0 && line.All(char.IsDigit))
                {
                    numbers.Add(double.Parse(line));
                }
            }
        }

        return numbers;
    }

    static (double min, int positiveCount) FindMinAndCountPositives(List<double> numbers)
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException("Список чисел пуст.");
        }

        double min = double.MaxValue;
        int positiveCount = 0;

        foreach (double number in numbers)
        {
            min = Math.Min(min, number);
            if (number > 0)
            {
                positiveCount++;
            }
        }

        return (min, positiveCount);
    }
}