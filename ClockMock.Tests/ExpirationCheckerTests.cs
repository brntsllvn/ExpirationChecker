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
            var result = subject.HasExpired(DateTime.Now);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void HasExpiredReturnsTrueForPastDates()
        {
            // Arrange
            var subject = new ExpirationChecker();

            // Act
            var result = subject.HasExpired(new DateTime(1999,12,31));

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void HasExpiredReturnsFalseForFutureDates()
        {
            // Arrange
            var subject = new ExpirationChecker();

            // Act
            var result = subject.HasExpired(new DateTime(2099, 12, 31));

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void HasExpiredReturnsTrueForTimeEqualsNow()
        {
            // Arrange
            var subject = new ExpirationChecker();

            // Act
            var result = subject.HasExpired(DateTime.Now);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}
