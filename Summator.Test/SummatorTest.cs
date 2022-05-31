using NUnit.Framework;

namespace Summator.Test
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new long[] { 5, 7});
            long expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumbers()
        {
            long result = Summator.Sum(new long[] { 5 });

            Assert.That(result == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new long[] { -7, -9 });
            long expected = -16;
            
            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long result = Summator.Sum(new long[] { });

            Assert.That(result == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new long[] {2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(actual, 6000000000);
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
           long actual = Summator.Average(new long[] { 5,7 });

            long expected = 6;

            Assert.That(expected == actual);

         
        }
    }
}