using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaProject1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sampleText = "Hello World";
            string firstTrimmed = TrimFirstCharacter(sampleText);
            string lastTrimmed = TrimLastCharacter(firstTrimmed);
            string uppercase = ToUpperCase(sampleText);
            string reversed = ReverseWordsOrder(sampleText);
            string replaced = ReplaceCharacter(sampleText, 'l', 'x');

            Console.WriteLine($"Original: huehueheu {sampleText}");
            Console.WriteLine($"First Character Trimmed: {firstTrimmed}");
            Console.WriteLine($"Last Character Trimmed: {lastTrimmed}");
            Console.WriteLine($"Uppercase: {uppercase}");
            Console.WriteLine($"Reversed Words Order: {reversed}");
            Console.WriteLine($"Replaced 'l' with 'x': {replaced}");
            Console.ReadKey();
        }

        public static string TrimFirstCharacter(string input)
        {
            return string.Join(" ", input.Split(' ').Select(word => word.Substring(1)));
        }

        public static string TrimLastCharacter(string input)
        {
            return string.Join(" ", input.Split(' ').Select(word => word.Substring(0, word.Length - 1)));
        }
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public static string ReverseWordsOrder(string input)
        {
            return string.Join(" ", input.Split(' ').Reverse());
        }

        public static string ReplaceCharacter(string input, char oldChar, char newChar)
        {
            return input.Replace(oldChar, newChar);
        }
    }
}
