using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CodeSignal13
{
    internal class Program
    {
         delegate void Some(string inpi);

        static void Main(string[] args)
        {
            string inputString = "foo(bar(baz(bar)ggg))blim";
            Some some =new Some(solution);
            some(inputString);
        }
        public static void solution(string inputString)
        {
            string word = "+";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    for (int j = i + 1; j < inputString.Length; j++)
                    {
                        if (inputString[j] != ')' && inputString[j] != '(')
                            word = word + inputString[j];
                        else
                            break;
                        i = j;
                    }
                }
                if (i != inputString.Length - 1)
                    word = word + "+";
            }

            string[] words = word.Split('+');
            for (int i = 1; i < words.Length - 1; i++)
            {
                if (words[i] != "")
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }
            string outputString = string.Join("+", words);

            string some = "";
            for (int i = 0; i < outputString.Length; i++)
            {
                if (outputString[i] != '+')
                {
                    some = some + outputString[i];
                }
                else if (inputString[i] != '(' && inputString[i] != ')')
                {
                    some = some + inputString[i];
                }
            }
            Console.WriteLine(some);
        }
    }


}