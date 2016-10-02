using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School/* : Student*/
    {
        public string schoolName;
        public int numberOfCourses;

        public School(/*string name, int number, */string schoolName, int numberOfCourses)/* : base(name,number)*/
        {
            this.SchoolName = schoolName;
            this.NumberOfCourses = numberOfCourses;
        }

        public string SchoolName
        {
            get { return this.schoolName; }
            set
            {
                if (value == "" | value == null)
                {
                    throw new NotImplementedException("");
                }
                this.schoolName = value; }
        }

        public int NumberOfCourses
        {
            get { return this.numberOfCourses; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of courses can not be null");
                }
                this.numberOfCourses = value;
                }
        }
    }
}
