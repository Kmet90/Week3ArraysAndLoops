using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] seq = new long[n];
            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int firstIndex = Math.Max(0, i - k);

                for (int j = firstIndex; j < i; j++)
                {
                    sum += seq[j];
                }
                seq[i] = sum;
            }

            Console.WriteLine(string.Join(" ",seq));
        }
    }
}
