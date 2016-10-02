using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
   public class Student:School
    {
        public string name;
        public int number;

        public Student(string schoolName, int numberOfCourses,string name, int number):base(schoolName,numberOfCourses)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == "" | value == null)
                {
                    throw new NotImplementedException("Student's name has to be entered in the system");
                }
                this.name = value;
            }
        }
        
        public int Number
        {
            get { return this.number; }
            set
            {
                if ( (value < 10000) | (value > 99999) )
                {
                    throw new ArgumentOutOfRangeException("The unique number has to be between 10000 and 99999.");
                }
                this.number = value;
            }
        }
    }
}
