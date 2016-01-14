using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert your banned words and your input");
        string[] bannedWords = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string input = Console.ReadLine();

        foreach (var word in bannedWords)
        {
            input = input.Replace(word, new string('*', word.Length));
        }
        Console.WriteLine(input);
    }
}