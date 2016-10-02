using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;
using Telerik.JustMock;

namespace TaskManager.Tests
{
    [TestClass]
   public class TesttaskmanagerJustMock
    {
        // Test 3 in UnitTest1
        [TestMethod]

        public void TestTaskManager_WithMoq_WhenAllTasksCalled_ShouldCallLogTasksCount()
        {
            // Arrange
            var mockedLogger = Mock.Create<ILogger>();
            var mockedIdProvider = Mock.Create<IIdProvider>();

           //  Mock.Arrange(() => mockedLogger.Log(Arg.AnyString)).Occurs(1);

            var taskManager = new Tasker(mockedLogger,mockedIdProvider);
            
            var mockedTask = Mock.Create<Models.Task>();
            // Act

            taskManager.Save(mockedTask);

            // Assert

            Mock.Assert(() => mockedLogger.Log(Arg.AnyString));
        }
    }
}
