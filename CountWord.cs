using System;

namespace CountWord
{
    //Write a C# program to create a function to input a string and count number of words are present  in the string , then  print them separately
    class CountWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Count Words--");
            Console.WriteLine("Input string:");
            string input = Console.ReadLine();
            string[] split = input.Split(' '); 
            int wordCount = 0;
            foreach(var stringSplit in split) //loop each word and print 
            {
                Console.WriteLine(stringSplit);
                wordCount++;
            }
            Console.WriteLine("Total wordcount: " + wordCount);
        }
    }
}
