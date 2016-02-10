using System;
using System.Collections.Generic;
using System.IO;

namespace Solution
{
    public class Solution
    {

        public static UInt32 Process (UInt32 x)
        {
            return ~x;
        }

        public static void Main(String[] args)
        {
            string s = Console.ReadLine(); // Tests
            while ((s = Console.ReadLine()) != null)
                Console.WriteLine(Process(UInt32.Parse(s)));
        }
    }

}