using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static decimal result = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Insert your input:");
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in input)
        {
            char first = word.First();
            char last = word.Last();
            int number = int.Parse(Regex.Match(word, @"\d+").Value);

            CalcResult(first, last, number);
        }
        Console.WriteLine("{0:F2}", result);
    }



    static void CalcResult(char first, char last, int num)
    {
        if (char.IsUpper(first))
        {
            result += num / (decimal)(first - 'A' + 1);
        }
        else if (char.IsLower(first))
        {
            result += num * (decimal)(first - 'a' + 1);
        }
        if (char.IsUpper(last))
        {
            result -= (decimal)(last - 'A' + 1);
        }
        else if (char.IsLower(last))
        {
            result += (decimal)(last - 'a' + 1);
        }
    }
}