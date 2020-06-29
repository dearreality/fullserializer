using System;
using FullSerializer;
using NUnit.Framework;

namespace FullSerializer.Tests
{
    public class DateTimeTests
    {
        [Test]
        public void StrangeFormatTests()
        {
            var serializer = new fsSerializer();
            DateTime time = DateTime.Now;
            serializer.TryDeserialize(new fsData("2016-01-22T12:06:57.503005"), ref time)
                .AssertSuccessWithoutWarnings();

            Assert.AreEqual(Convert.ToDateTime("2016-01-22T12:06:57.503005"), time);
        }
    }
}
