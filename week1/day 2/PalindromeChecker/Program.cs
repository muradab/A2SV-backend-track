using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Enter your word:");
        string input = Console.ReadLine();
        string reversedString = new string(input.Reverse().ToArray());

        if (input ==  reversedString){
            Console.WriteLine("Word is palindrome");
        }
        else{
            Console.WriteLine("Word is not palindrome");
        }
    
    }
}
