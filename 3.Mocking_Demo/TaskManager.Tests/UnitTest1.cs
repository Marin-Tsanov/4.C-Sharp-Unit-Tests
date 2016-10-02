using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.Models;
using Moq;
using System.Collections;
using System.Collections.Generic;

namespace TaskManager.Tests
{
    [TestClass]
    public class TestTaskManager
    {
        // Test 1
        [TestMethod] // Test is done without installing Moq framework
        public void TestTaskManager_WhenAddTask_ShouldCallLog()
        {
            // Arrange
            var mockedLogger = new MockedLogger();
            var mockedIdProvider = new MockedIdProvider();

            var taskmanager = new Tasker(mockedLogger, mockedIdProvider);

            var task = new Task("");

            // Act
            taskmanager.Save(task);

            // Assert

            Assert.IsTrue(mockedLogger.IsLogCalled);
        }

        // Test 2
        [TestMethod] // Test is done with installed Moq and JustMock frameworks and we chose Moq
        public void TestTaskManager_WithMoq_WhenAddTask_ShouldCallLog()
        {
            // Arrange
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskmanager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            //var mockedTask = new Mock<Task>();
            var task = new Task("");

            // Act
            taskmanager.Save(task);

            // Assert
            mockedLogger.Verify();
        }

        // Test 3
        [TestMethod] // Test is done with installed Moq and JustMock frameworks and we chose Moq
        public void TestTaskManager_WithMoq_WhenAllTasksCalled_ShouldCallLogTasksCount()
        {
            ICollection<Task> tasks = new List<Task>()
            {
                new Task("stsa"),
                new Task("stsa1"),
                new Task("stsa2"),
                new Task("stsa3")
            };
            // Arrange
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskmanager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);
            taskmanager.Tasks = tasks;

            //mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            //var mockedTask = new Mock<Task>();

            // Act
            taskmanager.AllTasks();

            // Assert
            mockedLogger.Verify(x => x.Log(It.IsAny<string>()), Times.Exactly(taskmanager.Tasks.Count));
        }

        // Test 4
        [TestMethod] // Test is done with installed Moq and JustMock frameworks and we chose Moq
        public void TestTaskManager_WithMoq_WhenNullAdded_ShouldThrowsArgumentNullException()
        {
            // Arrange
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskmanager = new Tasker(
                mockedLogger.Object,
                mockedIdProvider.Object);

            mockedLogger.Setup(x => x.Log(It.IsAny<string>())).Throws<ArgumentNullException>();

            var task = new Task("");

            // Act
            taskmanager.Save(task);

            // Assert
            mockedLogger.Verify();
        }

        // Test 5
        [TestMethod] // Test is done with installed Moq and JustMock frameworks and we chose Moq
        public void TestTaskManager_WithMoq_WhenSaved_ShouldCallIdProvider()
        {
            // Arrange
            var mockedlogger = new Mock<ILogger>();
            var mockedidprovider = new Mock<IIdProvider>();

            var task = new Task("papa");
            var taskmanager = new Tasker(mockedlogger.Object, mockedidprovider.Object);
            mockedidprovider.Setup(x => x.Id).Returns(1);
            // Act
            taskmanager.Save(task);

            // Assert        
            mockedidprovider.Verify();
        }

        public class MockedLogger : ILogger
        {
            public bool IsLogCalled;

            public void Log(string msg)
            {
                this.IsLogCalled = true;
            }
        }

        public class MockedIdProvider : IIdProvider
        {
            public int Id
            {
                get
                {
                    return 1;
                }
            }
        }
    }
}

