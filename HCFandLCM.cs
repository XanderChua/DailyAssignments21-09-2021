using System;

namespace HCFandLCM
{
    //Write C# program to find HCF and LCM of two numbers
    class HCFandLCM
    {
        public static int hcf(int input1, int input2)
        {
            if (input1 == 0)
            {
                return input2;
            }
            else
            {
                return hcf(input2 % input1, input1);
            }
        }

        public static int lcm(int input1, int input2)
        {
            return (input1 * input2) / hcf(input1, input2);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Find the Highest Common Factor and Lowest Common Multiple");
            Console.WriteLine("Enter 1st input:");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd input:");
            int input2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Highest common factor of input " + input1 + " and " + input2 + " is " + hcf(input1, input2));
            Console.WriteLine("Lowest common multiple of input " + input1 + " and " + input2 + " is " + lcm(input1, input2));
        }
    }
}