using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Models;
using NUnit.Framework;
using Moq;


namespace TaskManager.Tests.Unit
{
    [TestFixture]

    public class Class1
    {
        [Test]
        public void WhenNullTaskIsAdded_ArgumentNullException_ShouldBeThrown()
        {
            // Arrange
            Task task = new Task(null);
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();
            Tasker tasker = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedLogger.Setup(x => x.Log(It.IsAny<string>())).Throws<ArgumentNullException>();
            
            // Act
            tasker.Save(task);

            //tasker.Save(task);
            // Assert.Throws(typeof(ArgumentNullException), x => x.Log(It.IsAny<string>()));

            // Assert
            mockedLogger.Verify();
        }

        [Test]
        public void WhenNewTaskIsAdded_LogMethod_ShouldBeCalled()
        {
            Task task = new Task("Kupi hlqb");
            var mockedLogger = new Mock<ILogger>();
            var idprovider = new Mock<IIdProvider>();
            Tasker tasker = new Tasker(mockedLogger.Object,idprovider.Object);

            tasker.Save(task);
            mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            mockedLogger.Verify();
        }

        [Test]
        public void WhenNewTaskIsAdded_CorrectId_ShouldBeGivenToIt()
        {
            // Arrange
            Task task = new Task("Kupi bira"); 
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();
            Tasker tasker = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedIdProvider.Setup(x => x.Id);

            // Act
            tasker.Save(task);

            // Assert

            mockedIdProvider.Verify();
        }

        [Test]
        public void WhenTaskIsDeleted_TasksCount_ShouldReturnCorrectValue()
        {
            // Arrange
            var mockedIlogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();
            Tasker tasker = new Tasker(mockedIlogger.Object, mockedIdProvider.Object);

            Task task0 = new Task("Kupi hlqb");
            Task task1 = new Task("Kupi bira");
            Task task2 = new Task("Yaj i pii");

            tasker.Save(task0);
            tasker.Save(task1);
            tasker.Save(task2);
            
            // Act
            tasker.Delete(0);

            // Assert
            Assert.AreEqual(2, tasker.Tasks.Count);




        }
    }
}
