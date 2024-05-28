using System;
using System.Collections.Generic;

public class MyList<T>
{
    private List<T> _items = new List<T>();

    public T this[int index] => _items[index];

    public int Count => _items.Count;

    public void Add(T item)
    {
        _items.Add(item);
    }
}

public static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
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

        int[] array = myList.GetArray();
        Console.Write("Элементы массива:  ");
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }
    }
}
