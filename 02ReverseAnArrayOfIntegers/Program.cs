using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++) 
            {
                int readNumber = int.Parse(Console.ReadLine());
                array[i] = readNumber;
            }
            for (int j = array.Length - 1; j >= 0; j--) 
            {
                int currentNumber = array[j];
                Console.Write(currentNumber + " ");
            }
           
        }
    }
}
