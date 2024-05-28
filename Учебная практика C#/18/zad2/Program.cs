using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        int a = 10, b = 20; 
        Queue<int> lessThanA = new Queue<int>();
        Queue<int> betweenAB = new Queue<int>();
        Queue<int> greaterThanB = new Queue<int>();

        string[] lines = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_18\\zad2\\numbers.txt"); 
        foreach (var line in lines)
        {
            int number = int.Parse(line);
            if (number < a)
            {
                lessThanA.Enqueue(number);
            }
            else if (number > b)
            {
                greaterThanB.Enqueue(number);
            }
            else
            {
                betweenAB.Enqueue(number);
            }
        }

        PrintQueue(betweenAB);
        PrintQueue(lessThanA);
        PrintQueue(greaterThanB);
    }

    static void PrintQueue(Queue<int> queue)
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
