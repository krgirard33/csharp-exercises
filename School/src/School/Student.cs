using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private readonly GradesList grades = new GradesList;
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
}
}
