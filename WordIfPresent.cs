using System;

namespace WordIfPresent
{
    class Program
    {
        //write a C# program to find out if  a given word is present in given line , if yes then find out its occurrence
        static void Main(string[] args)
        {
            Console.WriteLine("--Check if word is present--");
            Console.WriteLine("Input a sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Check a word:");
            string word = Console.ReadLine();
            int wordCount = 0; //count word occurances
            int temp = 0; //initialise default value to store value
            if (sentence.ToUpper().Contains(word.ToUpper()))
            {
                while ((temp = sentence.ToUpper().IndexOf(word.ToUpper(), temp)) != -1) //loop all word to check for occurances
                {
                    temp += word.Length;
                    wordCount++;
                }
                int wordCount1 = wordCount;
                Console.WriteLine(word + " exist in the given sentence.");
                Console.WriteLine("Amount of " + word + " present: " + wordCount1);
            }
            else
            {
                Console.WriteLine(word + " does not exist in the given sentence.");
            }

        }
    }
}
