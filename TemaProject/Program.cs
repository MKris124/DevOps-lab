using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sampleText = "Hello World";
            string firstTrimmed = TrimFirstCharacter(sampleText);
            string lastTrimmed = TrimLastCharacter(firstTrimmed);

            Console.WriteLine($"Original: {sampleText}");
            Console.WriteLine($"First Character Trimmed: {firstTrimmed}");
            Console.WriteLine($"Last Character Trimmed: {lastTrimmed}");
        }

        static string TrimFirstCharacter(string input)
        {
            return string.Join(" ", input.Split(' ').Select(word => word.Substring(1)));
        }

        static string TrimLastCharacter(string input)
        {
            return string.Join(" ", input.Split(' ').Select(word => word.Substring(0, word.Length - 1)));
        }
    }
    }
}
