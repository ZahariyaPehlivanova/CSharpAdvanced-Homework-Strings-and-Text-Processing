using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Insert your input:");
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        foreach (var character in input)
        {
            sb.Append("\\");
            sb.Append(String.Format("{0:x4}", (int)character));
        }
        Console.WriteLine(sb.ToString());
    }
}