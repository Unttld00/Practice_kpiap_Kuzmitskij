using System;

class Program
{
    delegate string StringDelegate(string str);

    static string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string ToUpper(string str)
    {
        return str.ToUpper();
    }

    static string ToLower(string str)
    {
        return str.ToLower();
    }

    static void Main(string[] args)
    {
        StringDelegate stringDelegate;

        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        stringDelegate = Reverse;
        string result = stringDelegate(input);
        Console.WriteLine($"Перевернутая строка: {result}");

        stringDelegate = ToUpper;
        result = stringDelegate(input);
        Console.WriteLine($"Строка в верхнем регистре: {result}");

        stringDelegate = ToLower;
        result = stringDelegate(input);
        Console.WriteLine($"Строка в нижнем регистре: {result}");
    }
}

