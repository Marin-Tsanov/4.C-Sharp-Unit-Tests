using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        int count = 0;

        public string courseName;

        ICollection<Student> studentsInCourse = new List<Student>();

        public Course(string courseName)
        {
            this.CourseName = courseName;
        }

        // Property

        public int CourseCount
        {
            get
            {
                return this.count;
            }
        }

        public string CourseName
        {
            get { return this.courseName; }
            set
            {
                if (value == "" | value == null)
                {
                    throw new NotImplementedException("Course's name has to be entered in the system");
                }
                this.courseName = value;
            }
        }

        // Method

        public void AddStudent(Student student)
        {
            if (this.CourseCount >= 30)
            {
                throw new ArgumentOutOfRangeException("Course is full, students can not be added.");
            }

            this.studentsInCourse.Add(student);
            count++;
        }

        public void RemoveStudent(Student student)/*.number)*/
        {
            if (this.CourseCount == 0)
            {
                throw new ArgumentOutOfRangeException("Course is empty, there are no students to be removed from it.");
            }
            else
            {
                bool exist = false;

                foreach (var item in studentsInCourse)
                {
                    if (item.number == student.number)
                    {
                        exist = true;
                        break;
                    }
                }

                if (exist)
                {
                    var itemToRemove = studentsInCourse.Single(r => r.number == student.number);
                    studentsInCourse.Remove(itemToRemove);
                    count--;
                }
         
                else
                {
                    throw new ArgumentOutOfRangeException("Student was not found in this course");
                }
            }
        }
    }
}
