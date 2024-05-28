using System;

class Program
{
    delegate void Message();

    static void Main(string[] args)
    {
        Message msg1 = FirstMessage;
        Message msg2 = SecondMessage;
        Message msg3 = ThirdMessage;

        Message combinedMsg = msg1 + msg2 + msg3;

        ExecuteMessage(combinedMsg);
    }

    static void ExecuteMessage(Message msg)
    {
        msg();
    }

    static void FirstMessage()
    {
        Console.WriteLine("Это первое сообщение.");
    }

    static void SecondMessage()
    {
        Console.WriteLine("Это второе сообщение.");
    }

    static void ThirdMessage()
    {
        Console.WriteLine("Это третье сообщение.");
    }
}
