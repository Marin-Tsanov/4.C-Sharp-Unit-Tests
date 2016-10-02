using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TaskManager.NUnitDemo
{
    [TestFixture]

    public class TaskmanagerTests
    {
        [Test]
         public void AddingNewNullTask_ShouldThrowAnException()
        {
            // Arrange
            var taskManager = new TaskManager();

            // Act
            //taskManager.AddTask(new Task());

            // Assert
            Assert.Throws(typeof(ArgumentNullException),
                () => { taskManager.AddTask(null); });
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(13)]

        public void AddingNewTasks_ShouldProperlyUpdateTheCount(int count)
        {
            // Arrange
            var taskManager = new TaskManager();

            // Act
            for (int i = 0; i < count; i++)
            {
                taskManager.AddTask(new Task());
            }

            // Assert
            Assert.AreEqual(count, taskManager.TasksCount,
                string.Format("TasksCount is {0},which is incorrect value", taskManager.TasksCount));
        }

    }
}
