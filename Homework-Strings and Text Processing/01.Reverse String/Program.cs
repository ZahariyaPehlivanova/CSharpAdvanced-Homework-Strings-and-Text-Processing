using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Strings_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your input:");
            string input = Console.ReadLine();

            char[] inputChar = input.ToCharArray();

            Array.Reverse(inputChar);
            string reversed = new string(inputChar);
            Console.WriteLine(reversed);
        }
    }
}
