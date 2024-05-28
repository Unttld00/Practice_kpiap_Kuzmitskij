using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread t1 = new Thread(SumNumbers);
        Thread t2 = new Thread(SumNumbers);

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        t1.Start();
        t1.Join();
        stopwatch.Stop();
        Console.WriteLine($"Время выполнения первого потока: {stopwatch.ElapsedMilliseconds} мс");

        stopwatch.Reset();

        stopwatch.Start();
        t2.Start();
        t2.Join();
        stopwatch.Stop();
        Console.WriteLine($"Время выполнения второго потока: {stopwatch.ElapsedMilliseconds} мс");

        Console.ReadLine();
    }

    static void SumNumbers()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сумма чисел от 1 до 10: {sum}");
    }
}
