using NUnit.Framework;
using RuralSourcing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Transactions;

namespace TestRuralSourcing
{
    [TestFixture]
    public class Tests
    {
        [TestCase("1 minute(s) ago")]
        [Test]
        public void Test1MinuteAgo(string expected)
        {
            var bg = new DateTimeToHumanReadableFormFormatter();
            Assert.AreEqual(expected,bg.Format(DateTime.Now.AddMinutes(-1), DateTime.Now));
        }

        [TestCase("5 minute(s) ago")]
        [Test]
        public void Test5MinuteAgo(string expected)
        {
            var bg = new DateTimeToHumanReadableFormFormatter();
            Assert.AreEqual(expected, bg.Format(DateTime.Now.AddMinutes(-5), DateTime.Now));
        }
        [TestCase("1 hour(s) ago")]
        [Test]
        public void TestOneHourAgo(string expected)
        {
            var bg = new DateTimeToHumanReadableFormFormatter();
            Assert.AreEqual(expected, bg.Format(DateTime.Now.AddHours(-1), DateTime.Now));
        }
        [TestCase("7 day(s) ago")]
        [Test]
        public void TestSevenDaysAgo(string expected)
        {
            var bg = new DateTimeToHumanReadableFormFormatter();
            Assert.AreEqual(expected, bg.Format(DateTime.Now.AddDays(-7), DateTime.Now));
        }
        [TestCase("2020-8-31 10:0:0")]
        [Test]
        public void TestEightDaysAgo(string expected)
        {
            DateTime referenceDateTime = new DateTime(2020, 9, 8, 10,0,0);
            var bg = new DateTimeToHumanReadableFormFormatter();
            Assert.AreEqual(expected, bg.Format(referenceDateTime.AddDays(-8), referenceDateTime));
        }

        [TestCase("5 day(s) ago")]
        [Test]
        public void TestFiveDaysAgo(string expected)
        {
            var bg = new DateTimeToHumanReadableFormFormatter();
            Assert.AreEqual(expected, bg.Format(DateTime.Now.AddDays(-5), DateTime.Now));
        }




        [TestCase("137 \xA -104 \xA 2 58 \xA +0 \xA ++3 \xA +1 \xA 23.9 \xA 2000000000 \xA -0 \xA five  \xA -1",
                  137, -104, 0, 1, 0, -1)]
        [Test]
        public void TestSolution2(string  input, params int[] expectedValue)
        {
            byte[] bytArr = Encoding.UTF8.GetBytes(input);
            var bg = new SolutionIter(new MemoryStream(bytArr));
            int i = 0;
            foreach (int n in bg)
            {
                Assert.AreEqual(expectedValue[i++], n);
            }
        }     
    }
}