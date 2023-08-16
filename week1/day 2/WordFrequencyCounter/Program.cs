using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        Console.WriteLine("Enter your paragraph:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        Console.WriteLine("Iterating over words:");
        foreach (string word in words)
        {
            string cleanedWord = word.ToLower();

            if (dictionary.ContainsKey(cleanedWord))
            {
                dictionary[cleanedWord]++;
            }
            else
            {
                dictionary[cleanedWord] = 1;
            }
        }

        Console.WriteLine("Word frequencies:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Word: {kvp.Key}, Frequency: {kvp.Value}");
        }
    }
}
