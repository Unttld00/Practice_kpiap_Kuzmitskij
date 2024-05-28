using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "abc#d##c";
        Console.WriteLine(ProcessString(input));
    }

    static string ProcessString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}

