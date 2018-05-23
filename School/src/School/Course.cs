using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        /* TODO
     * In the School project, create a class named Course with at least three properties. 
     * Before diving into Visual Studio, use pen and paper to work through what these might 
     * be, including the data type, access level, and whether it makes sense for any of 
     * them to be readonly or constants. At least one of your fields should be a List or 
     * Dictionary, and you should use your Student class.
     */
        private static int nextStudent = 1;
        public int CourseID { get; private set; } = 0;
        public string Name { get; private set; } = "";
        public DateTime StartsAt { get; private set; } = DateTime.Today;
        public List<Students> Students { get; set; } = new List<Students>();

    }
}
