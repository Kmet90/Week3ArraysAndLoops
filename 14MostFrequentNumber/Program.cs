using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] count = new int[65536];

            foreach (ushort num in array)
            {
                count[num]++;
            }
            int maxValue = count.Max();

            for (int i = 0; i < array.Length; i++)
            {
                if (count[array[i]] == maxValue)
                {
                    Console.WriteLine(array[i]);
                    return;
                }
            }
        }
    }
}
