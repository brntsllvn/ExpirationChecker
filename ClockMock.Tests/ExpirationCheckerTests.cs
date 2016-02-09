using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClockMock.Tests
{
    [TestFixture]
    class ExpirationCheckerTests
    {
        [Test]
        public void HasExpiredReturnsNotNull()
        {
            // Arrange
            var subject = new ExpirationChecker();

            // Act
            var result = subject.HasExpired();

            // Assert
            Assert.That(result, Is.Not.Null);
        }

    }
}
