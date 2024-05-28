using System;

class Task
{
    private int number;

    public Task(int number)
    {
        this.number = number;
    }

    public int RearrangeFirstAndLastDigits()
    {
        if (number < 1000 || number >= 10000)
        {
            throw new ArgumentOutOfRangeException("number", "The number must be a four-digit number.");
        }

        int firstDigit = number / 1000;
        int lastDigit = number % 10;

        return (lastDigit * 1000) + (number % 1000);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Task task1 = new Task(1234);
        Task task2 = new Task(task1.RearrangeFirstAndLastDigits()); 
        int inputNumber = 4321;
        Task task3 = new Task(inputNumber); 

      
        int rearrangedNumber1 = task1.RearrangeFirstAndLastDigits();
        int rearrangedNumber2 = task2.RearrangeFirstAndLastDigits();
        int rearrangedNumber3 = task3.RearrangeFirstAndLastDigits();

        // Print the results
        Console.WriteLine($"Rearranged number for Task1: {rearrangedNumber1}");
        Console.WriteLine($"Rearranged number for Task2: {rearrangedNumber2}");
        Console.WriteLine($"Rearranged number for Task3: {rearrangedNumber3}");
    }
}