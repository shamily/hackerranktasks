using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCharacters
{
    public class Program
    {

        public static int Process(string s)
        {
            int cnt = 0;
            for (int i = 1; i < s.Length; i++)
                if (s[i] == s[i - 1]) cnt++;

            return cnt;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // # tests
            while ((s = Console.ReadLine()) != null)
            {
                Console.WriteLine(Process(s));
            }
        }
    }
}
