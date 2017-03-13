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
<<<<<<< HEAD
            
                Console.WriteLine("Positive numbers only");
                Console.ReadLine();
=======
            if (radius < 1)
            {
                Console.WriteLine("Positive numbers only");
                Console.ReadLine();
            }

            else
            {
>>>>>>> d1b7c6e1477da93ad43b80d0bda4141ef347214f
                Console.WriteLine("The radius of a circle with a radius of " + radius + " is: " + Math.PI * (radius * radius));
                Console.ReadLine();
           
        } while (radius< 0)
    }
}
