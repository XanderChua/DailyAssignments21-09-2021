using System;
using System.Collections.Generic;

namespace IntegerBinaryHexdecimal
{
    class IntegerBinaryHexdecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert integer into binary and hexdecimal");
            Console.WriteLine("Enter integer:");
            int input = Int32.Parse(Console.ReadLine());
            int input1 = input;

            //Binary Conversion
            List<int> remainderList1 = new List<int>();
            int binary = input;
            int remainder1;
            while (binary != 0)
            {
                binary = input / 2;
                remainder1 = input % 2;
                remainderList1.Add(remainder1);
                input = binary;
            }
            remainderList1.Reverse();
            Console.Write("Binary Conversion: ");
            foreach (object a in remainderList1)
            {
                Console.Write(a);
            }

            //Hexdecimal Conversion
            Dictionary<int, char> hexDict = new Dictionary<int, char>()
            {
                {10,'A'},
                {11,'B'},
                {12,'C'},
                {13,'D'},
                {14,'E'},
                {15,'F'},
            };
            List<object> remainderList = new List<object>();
            int hex = input1;
            int remainder;
            while (hex != 0)
            {
                hex = input1 / 16;
                remainder = input1 % 16;
                if (hexDict.ContainsKey(remainder))
                {
                    remainderList.Add(hexDict[remainder]);
                }
                else
                {
                    remainderList.Add(remainder);
                }
                input1 = hex;
            }
            remainderList.Reverse();
            Console.Write("\nHexdecimal Conversion: ");
            foreach (object b in remainderList)
            {
                 Console.Write(b.ToString());                
            }     
        }
    }
}
