using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert your input:");
        string[] words = Console.ReadLine().Split(new[] { ',', ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> equals = new List<string>();

        foreach (var word in words)
        {
            if (word != "")
            {
                if (word.Equals(ReversedWord(word)))
                {
                    equals.Add(word);
                }
            }
        }
        equals.Sort();
        Console.WriteLine(string.Join(", ", equals));
    }

    static string ReversedWord(string word)
    {
        char[] inputChar = word.ToCharArray();

        Array.Reverse(inputChar);
        string reversed = new string(inputChar);
        return reversed;
    }
}
