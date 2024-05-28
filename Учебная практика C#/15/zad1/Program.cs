using System;

public class MyList<T>
{
    private T[] _items;

    public MyList()
    {
        _items = new T[0];
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            return _items[index];
        }
    }

    public int Count
    {
        get
        {
            return _items.Length;
        }
    }

    public void Add(T item)
    {
        T[] newItems = new T[Count + 1];
        for (int i = 0; i < Count; i++)
        {
            newItems[i] = _items[i];
        }
        newItems[Count] = item;
        _items = newItems;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        Console.WriteLine("Количество элементов: " + myList.Count);
        Console.WriteLine("Элемент по индексу 1: " + myList[1]);
    }
}
