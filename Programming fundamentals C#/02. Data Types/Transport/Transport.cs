using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    //Calculate how many courses will be needed to transport n persons by using 3 vehicles of capacity 4, 8 and 12 respectively. 
    //The input holds one line: the number of people n. The vehicles can travel at the same time.
    class Transport
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            var capacity = 4 + 8 + 12;
            var courses = 0;
            if (persons % capacity == 0)
            {
                courses = persons / capacity;
            }
            else
            {
                courses = (persons / capacity) + 1;
            }
            Console.WriteLine(courses);
        }
    }
}
