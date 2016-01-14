using System;

    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Insert your input:");
        string input = Console.ReadLine();
        if (input.Length == 20)
        {
            Console.WriteLine(input);
        }
        else if (input.Length < 20)
        {
            Console.WriteLine(input.PadRight(20, '*'));
        }

    }