using System;

namespace ReplaceEachLetterWithNext
{
    //Write a C# program that would takes a string and replaces each letter with its appropriate next position in the alphabet. "a" is  "b" is  "c" , etc, etc.
    class ReplaceEachLetterWithNext
    {
        static String replaceAlphabet(char[] stringArr)
        {
            for (int i = 0; i < stringArr.Length; i++)
            {
                if (stringArr[i] == 'z')
                {
                    stringArr[i] = 'a';
                }
                else
                {
                    stringArr[i] = (char)(stringArr[i] + 1);
                }

            }
            return String.Join("", stringArr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input alphabets:");
            string input = Console.ReadLine();
            Console.WriteLine(replaceAlphabet(input.ToCharArray()));
        }
    }
}
