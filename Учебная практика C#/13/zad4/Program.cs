using System;

public class EventPublisher
{
    public delegate void MyEventHandler(string message);
    public event MyEventHandler MyEvent;

    public void RaiseEvent(string message)
    {
        MyEvent?.Invoke(message);
    }
}

public class Observer1
{
    public void HandleEvent(string message)
    {
        Console.WriteLine($"Наблюдатель #1 получил сообщение: {message}");
    }
}

public class Observer2
{
    public void HandleEvent(string message)
    {
        Console.WriteLine($"Наблюдатель #2 получил сообщение: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();
        Observer1 observer1 = new Observer1();
        Observer2 observer2 = new Observer2();

        publisher.MyEvent += observer1.HandleEvent;
        publisher.MyEvent += observer1.HandleEvent;
        publisher.MyEvent += observer2.HandleEvent;

        publisher.RaiseEvent("Привет, Наблюдатели!!!!");

        publisher.MyEvent -= observer1.HandleEvent;

        publisher.RaiseEvent("Привет, наблюдатели после удаления!");
    }
}
