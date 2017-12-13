using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int index = int.Parse(Console.ReadLine());
            index--;
            if (index < 0 || index >= days.Length)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            string weekday = days[index];
            Console.WriteLine(weekday);
        }
    }
}
