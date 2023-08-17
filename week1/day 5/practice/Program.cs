using System;

public static class MyExtensions
{
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' },
                         StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

class Program
{
    static void Main()
    {
        string s = "Hello Extension Methods";
        int i = s.WordCount(); // Use the extension method on the string instance

        Console.WriteLine($"Word count: {i}");
    }
}
