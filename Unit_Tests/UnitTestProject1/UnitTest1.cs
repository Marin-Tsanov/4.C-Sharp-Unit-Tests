using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TaskManagerTests
    {
        [TestMethod]
        public void AddingNewTask_ShouldProperlyUpdateTheCount()
        {
            // Arrange
            var taskManager = new TaskManager.TaskManager();

            // Act
            taskManager.AddTask(new TaskManager.Task());

            // Assert
            Assert.AreEqual(1, taskManager.TasksCount, "TasksCount is {0},which is incorrect value",taskManager.TasksCount);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddingNullTask_ShouldThrowAnException()
        {
            // Arrange 
            var taskManager = new TaskManager.TaskManager();

            // Act

            taskManager.AddTask(null);
        }
        public void DoSomething()
        {   
        }
    }
}
