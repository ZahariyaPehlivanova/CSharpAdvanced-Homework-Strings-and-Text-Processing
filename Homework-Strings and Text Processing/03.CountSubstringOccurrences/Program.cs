using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert your input and your searched word:");
        string input = Console.ReadLine();
        string searchedWord = Console.ReadLine();

        int count = 0;
        string word;

        for (int i = 0; i <= input.Length - searchedWord.Length; i++)
        {
            word = input.Substring(i, searchedWord.Length);

            if (string.Equals(word, searchedWord))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
