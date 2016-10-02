using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Moq;
using Cosmetics.Common;

namespace Cosmetics.Tests
{
    [TestFixture]

    public class Tests0
    {
        [Test]
        public void CheckIfNull_ShouldThrowNullReferenceException()
        {
            // Arrange
            object obj = null;

            // Assert
            Assert.Throws(typeof(NullReferenceException), () => Validator.CheckIfNull(obj));
        }

        [Test]
        public void CheckIfNull_ShouldNOTThrowAnyExceptions()
        {
            // Arrange
            object obj = 1;

            // Assert
            Assert.DoesNotThrow(/*typeof(NullReferenceException),*/ () => Validator.CheckIfNull(obj));
        }
            
        [Test]
        [TestCase (null)]
        [TestCase ("")]
        public void CheckIfStringIsNullOrEmpty_Should_ThrowNullReferenceException(string test)
        {
            // Assert

            Assert.Throws(typeof(NullReferenceException), () => Validator.CheckIfStringIsNullOrEmpty(test));
        }

        [Test]
        [TestCase("Marin")]
        [TestCase("123456")]
        public void CheckIfStringIsNullOrEmpty_ShouldNOT_ThrowNullReferenceException(string test)
        {
            // Assert

            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty(test));
        }

        [Test]
        [TestCase("m")]
        [TestCase("mama mia")]
        public void CheckIfStringLengthIsValid_Should_ThrowIndexOutOfRangeException(string test)
        {
            // Assert

            Assert.Throws(typeof(IndexOutOfRangeException), () => Validator.CheckIfStringLengthIsValid(test,4,2));
        }

        [Test]
        [TestCase("mama")]
        [TestCase("pap")]
        public void CheckIfStringLengthIsValid_Should_NOT_ThrowAnyExceptions(string test)
        {
            // Assert

            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(test, 8, 1));
        }
    }
}
