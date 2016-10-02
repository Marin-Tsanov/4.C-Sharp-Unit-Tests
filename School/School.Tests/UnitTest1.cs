using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // Test class Student

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void CreatingNewStudent_ShouldNotAcceptEmptyStringOrNullForStudentName()
        {
            // Arrange
            var student = new Student("Hristo Botev",3,"", 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingNewStudent_ShouldNotAcceptNumbersOutsideOfTheGivenRangeForStudentNumber()
        {
            // Arrange
            var student = new Student("Hristo Botev", 3, "Ivan", 999);
        }

        // Test class School

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void CreatingSchool_ShouldNotAcceptEmptyStringOrNullForSchoolName()
        {
            // Arrange
            var school = new School(null, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingSchool_ShouldNotAcceptNegativeNumberForNumberOfSchoolCourses()
        {
            // Arrange
            var school = new School("Hristo Botev", -5);
        }
        
        // Test class Course    

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void CreatingCourse_ShouldNotAcceptEmptyStringOrNullForCourseName()
        {
            // Arrange
            var course = new Course("");
        }

        [TestMethod]
        public void AddingNewStudent_ShouldProperlyUpdateTheCount()
        {
            // Arrange
            var course = new Course("C# OOP");
            //Act
            course.AddStudent(new Student("Hristo Botev", 3, "Ivan", 55555));
            course.AddStudent(new Student("Hristo Botev", 3, "I", 55551));
            course.AddStudent(new Student("Hristo Botev", 3, "Iv", 55552));
            course.AddStudent(new Student("Hristo Botev", 3, "Iva", 55553));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivan", 55554));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivana", 55550));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivane", 55555));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivani", 55556));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivano", 55557));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivanu", 55558));
            // Assert
            Assert.AreEqual(10, course.CourseCount, "Invalid number of students {0},the correct number is 1.", course.CourseCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddingMoreThan30Students_ShouldThrowAnException()
        {
            // Arrange
            var course = new Course("C# OOP");
            // Act adding 32 students
            course.AddStudent(new Student("Hristo Botev", 3, "I",  55551));
            course.AddStudent(new Student("Hristo Botev", 3, "Iv",  55552));
            course.AddStudent(new Student("Hristo Botev", 3, "Iva",   55553));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivan", 55554));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivana", 55550));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivane", 55555));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivani", 55556));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivano", 55557));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivanu", 55558));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivanei", 55559));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivaie", 55561));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivaz", 55562));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivu", 55563));
            course.AddStudent(new Student("Hristo Botev", 3, "Ive", 55564));
            course.AddStudent(new Student("Hristo Botev", 3, "Ivo", 55560));
            course.AddStudent(new Student("Hristo Botev", 3, "P", 55565));
            course.AddStudent(new Student("Hristo Botev", 3, "Pe", 55566));
            course.AddStudent(new Student("Hristo Botev", 3, "Pes", 55567));
            course.AddStudent(new Student("Hristo Botev", 3, "Pesh", 55568));
            course.AddStudent(new Student("Hristo Botev", 3, "Pesho", 55569));
            course.AddStudent(new Student("Hristo Botev", 3, "Peshi", 55571));
            course.AddStudent(new Student("Hristo Botev", 3, "Pesha", 55572));
            course.AddStudent(new Student("Hristo Botev", 3, "Peshu", 55573));
            course.AddStudent(new Student("Hristo Botev", 3, "Peshie", 55574));
            course.AddStudent(new Student("Hristo Botev", 3, "Peshei", 55570));
            course.AddStudent(new Student("Hristo Botev", 3, "Pep", 55575));
            course.AddStudent(new Student("Hristo Botev", 3, "Pepi", 55576));
            course.AddStudent(new Student("Hristo Botev", 3, "Pepsi", 55577));
            course.AddStudent(new Student("Hristo Botev", 3, "Pepsic", 55578));
            course.AddStudent(new Student("Hristo Botev", 3, "Pepsoc", 55579));
            course.AddStudent(new Student("Hristo Botev", 3, "Pepsoca", 55580));
            course.AddStudent(new Student("Hristo Botev", 3, "Pepsocap", 55590));   
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemovingStudentsFromCourseWithNoStudents_ShouldThrowAnException()
        {
            // Arrange
            var course = new Course("C# OOP");

            // Act
            course.RemoveStudent(new Student("Hristo Botev", 3, "Ivcho", 55599));
        }

        [TestMethod]
        public void AddingAndRemovingStudentsFromCourse_ShouldGiveCorrectNumberOfStudentsInCourse()
        {
            // Arrange
            var course = new Course("C# OOP");
            var student1 = new Student("Hristo Botev", 3, "Pepsoc", 55579);
            var student2 = new Student("Hristo Botev", 3, "Pepsoca", 55580);

            // Act
            course.AddStudent(student1);
            course.AddStudent(student2);
            course.RemoveStudent(student2);

            // Assert
            Assert.AreEqual(1, course.CourseCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemovingUnexistingStudentFromCourse_ShouldThrowAnException()
        {
            // Arrange
            var course = new Course("C# OOP");

            // Act
            course.AddStudent(new Student("Hristo Botev", 3, "Pepsoc", 55579));
            course.AddStudent(new Student("Hristo Botev", 3, "Pepsoca", 55580));
            course.RemoveStudent(new Student("Hristo Botev", 3, "Pepsocap", 55590));
        } 
    }
}
