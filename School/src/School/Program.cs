using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }


    public class Student
    {
        private int studentID;
        public int StudentID
        {
            get { return studentID; }
            internal set { studentID = value; }
        }
        string name;
        int numberOfCredits = 0;
        double gpa = 0;
    }

    /* TODO
     * In the School project, create a class named Course with at least three properties. 
     * Before diving into Visual Studio, use pen and paper to work through what these might 
     * be, including the data type, access level, and whether it makes sense for any of 
     * them to be readonly or constants. At least one of your fields should be a List or 
     * Dictionary, and you should use your Student class.
     */
    public class Course
    {
        Dictionary<int, string> classId = new Dictionary<int, string>();
        Dictionary<int, string> classRoster = new Dictionary<int, string>();
        
    }
}
