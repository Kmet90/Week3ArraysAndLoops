using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] array = text.Split(' ');
            List<int> inputInt = new List<int>();
            List<int> newIntList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                inputInt.Add(int.Parse(array[i]));
            }

            for (int i = 0; i < inputInt.Count; i++)
            {
                if (inputInt[i] > 0)
                {
                    newIntList.Add(inputInt[i]);
                }
            }

            if (newIntList.Any())
            {
                newIntList.Reverse();
                foreach (var item in newIntList)
                {
                    Console.Write("{0} ",item);
                }

            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
