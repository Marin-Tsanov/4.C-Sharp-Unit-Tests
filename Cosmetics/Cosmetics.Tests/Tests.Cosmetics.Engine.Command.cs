using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Cosmetics.Engine;

namespace Cosmetics.Tests
{
	[TestFixture]
   public class Tests1
    {
		[Test]
		public void Parse_Should_ReturnNewCommand()
        {
            // Arrange
            string input = "Follow me please";

            // Act
            var objectReal = Command.Parse(input);
        }

        [Test]
        // [TestCase("Bitte")]
        [TestCase("Folgen Sie mich")]
        public void Parse_Should_SetCorrectValuesToTheProperties_NameAndParameters(string input)
        {
            // Act
            var command = Command.Parse(input);
            string[] parametes = new string[]
            {
                "Sie",
                "mich"
            };

            // Arrange
            //Assert.AreEqual("Bitte", Command.Parse(input).Name);
            Assert.AreEqual("Folgen", Command.Parse(input).Name);
            Assert.AreEqual(parametes, Command.Parse(input).Parameters);
        }

        [Test]
        public void Parse_Should_ThrowNullReferenceException_WhenTheInputStringIsNull()
        {
            // Arrange
            string input = null;

            // Assert
            Assert.Throws(typeof(NullReferenceException), () => Command.Parse(input));
        }

        // Not finished 
        [Test]
        [TestCase(" ForMale Cool")]
        [TestCase("")]
        public void Name_Parse_Should_ThrowArgumentNullException_WithAMessageThatContainsTheString(string input)
        {
            // Assert
          Assert.That(() => Command.Parse(input), Throws.ArgumentNullException.With.Message.Contains("Name"));
        }

        [Test]
        [TestCase("Hello  ")]
        public void List_Parse_Should_ThrowArgumentNullException_WithAMessageThatContainsTheString(string input)
        {
            // Assert
         Assert.That(() => Command.Parse(input),Throws.ArgumentNullException.With.Message.Contains("List"));
        }
    }
}
