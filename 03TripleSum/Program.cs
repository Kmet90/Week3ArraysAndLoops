using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(s => int.Parse(s))
                            .ToArray();
            bool isSum = false;

            for (int i = 0; i < numbers.Length; i++) 
            {
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    int a = numbers[i];
                    int b = numbers[j];
                    int sum = a + b;
                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        isSum = true;
                    }
                }
            }
            if (!isSum)
                Console.WriteLine("No");

        }
    }
}
