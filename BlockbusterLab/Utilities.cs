using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Utilities
    {
        public static int GetIntInputAdjusted(string prompt, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                if (max != int.MaxValue)
                {
                    Console.Write($" (1-{max})");
                }
                Console.Write(": ");
                try
                {
                    int input = int.Parse(Console.ReadLine())-1;
                    if (input > max || input < 0)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    return input;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"That is not a valid number. Please enter a number 1-{max}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number. Please try again.");
                }
            }
        }
        public static string ByteArrayToString(List<byte> bytes)
        {
            string ret = "";
            bytes.ForEach(x => ret += (char)((x % 26)+'a')); // this ensures every letter will be between a and z
            return ret;
        }
        public static string ByteArrayToString(byte[] bytes)
        {
            string ret = "";
            foreach(byte b in bytes)
            {
                ret += (char)((b % 26) + 'a'); // this ensures every letter will be between a and z
            }
            return ret;
        }
    }
}
