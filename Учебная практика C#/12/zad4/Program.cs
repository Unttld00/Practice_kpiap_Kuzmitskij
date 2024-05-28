using System;

class Program
{
    delegate int RandomNumberMethod();

    static void Main()
    {
        RandomNumberMethod[] methods = new RandomNumberMethod[5];
        Random random = new Random();

        for (int i = 0; i < methods.Length; i++)
        {
            methods[i] = delegate () { return random.Next(1, 100); };
        }

        double average = CalculateAverage(methods);
        Console.WriteLine("Среднее значение: " + average);
    }

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
