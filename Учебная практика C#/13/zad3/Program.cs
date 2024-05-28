using System;

class MyInfo
{
    private string name = "Кирилл";
    public event Action NameChanged;
    public event Action NameNotChanged;

    public string Name
    {
        get { return name; }
        set
        {
            if (name != value)
            {
                name = value;
                NameChanged?.Invoke();
            }
            else
            {
                NameNotChanged?.Invoke();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        MyInfo myInfo = new MyInfo();
        myInfo.NameChanged += () => Console.WriteLine("Значение поля 'name' было изменено!");
        myInfo.NameNotChanged += () => Console.WriteLine("Значение поля 'name' не было изменено!");

        Console.WriteLine($"Ваше имя: {myInfo.Name}");
        Console.WriteLine("Введите новое имя:");
        myInfo.Name = Console.ReadLine();
    }
}
