using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            if (radius < 0)
                {
                Console.WriteLine("Positive numbers only");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The radius of a circle with a radius of " + radius + " is: " + Math.PI * (radius * radius));
                Console.ReadLine();
            }
        }
    }
}
