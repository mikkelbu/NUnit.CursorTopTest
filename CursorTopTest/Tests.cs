using NUnit.Framework;
using System;

namespace CursorTopTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestWithCursorTop()
        {
            Assert.That(Console.CursorTop, Is.EqualTo(0));
        }
    }
}
