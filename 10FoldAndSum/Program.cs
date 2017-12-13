using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] firstRow = new int[k * 2];
            int[] secondRow = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = array[k - i - 1];
                firstRow[firstRow.Length - i - 1] = array[array.Length - k + i];
                secondRow[2 * i] = array[2 * i + k];
                secondRow[2 * i + 1] = array[2 * i + k + 1];
            }
            int[] sum = new int[k * 2];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
