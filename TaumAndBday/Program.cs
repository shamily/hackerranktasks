using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaumAndBday
{
    public class Program
    {
        public static long Process(long b, long w, long x, long y, long z)
        {
            x = Math.Min(x, y + z);
            y = Math.Min(y, x + z);
            return b*x + w*y;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_b = Console.ReadLine().Split(' ');
                long b = Convert.ToInt32(tokens_b[0]);
                long w = Convert.ToInt32(tokens_b[1]);
                string[] tokens_x = Console.ReadLine().Split(' ');
                long x = Convert.ToInt32(tokens_x[0]);
                long y = Convert.ToInt32(tokens_x[1]);
                long z = Convert.ToInt32(tokens_x[2]);

                Console.WriteLine(Process(b, w, x, y, z));
            }
        }
    }
}
