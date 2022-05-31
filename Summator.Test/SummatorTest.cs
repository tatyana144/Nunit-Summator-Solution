using NUnit.Framework;
using System;

namespace Summator.Test
{
    [TestFixture]
    public class SummatorTests
    {

        private Summator summator;

        [SetUp]
        public void SetUp()
        {
            this.summator = new Summator();
            System.Console.WriteLine($"Test started: " + DateTime.Now);
        }

        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = summator.Sum(new long[] { 5, 7 });
            long expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        [Category("Critical")]
        public void Test_Sum_OnePossitiveNumbers()
        {
            long result = summator.Sum(new long[] { 5 });

            Assert.That(result == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = summator.Sum(new long[] { -7, -9 });
            long expected = -16;
            
            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long result = summator.Sum(new long[] { });

            Assert.That(result == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = summator.Sum(new long[] {2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(actual, 6000000000);
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
           double actual = Summator.Average(new double[] { 5, 8 });

            double expected = 6.5;

            Assert.That(expected == actual);

         
        }

        [TearDown]
        public void TearDown()
        {
            summator = null;
            System.Console.WriteLine($"Test ended: " + DateTime.Now);
        }
    }
}