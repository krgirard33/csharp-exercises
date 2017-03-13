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
            do 
            Console.WriteLine("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Positive numbers only");
                Console.ReadLine();
                Console.WriteLine("The radius of a circle with a radius of " + radius + " is: " + Math.PI * (radius * radius));
                Console.ReadLine();
           
        } while (radius< 0)
    }
}
