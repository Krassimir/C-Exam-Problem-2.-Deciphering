using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02Problem2Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string[] inputTextSecondLine = Console.ReadLine().Split().ToArray();
            string pattern = @"(?>^)[d-z{},|#]+(?>$)";
            bool isMatched = Regex.IsMatch(inputText, pattern);
            var newString = new StringBuilder();

            if (isMatched)
            {
                for (int i = 0; i < inputText.Length; i++)
                {
                    char replaceChar = inputText[i];
                    replaceChar -= (char)3;
                    newString.Append(replaceChar);
                }                
                newString.Replace(inputTextSecondLine[0],inputTextSecondLine[1]);
                Console.WriteLine(newString);
            }
            else
            {
                Console.WriteLine($"This is not the book you are looking for.");
            }
        }
    }
}
