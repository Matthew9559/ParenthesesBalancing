using System;
using NUnit.Framework;
using Balancing;

namespace BalancingTests
{
    [TestFixture]
    public class ParandBalancerTests
    {
        [Test]
        public void CheckEvenOperands()
        {
            var checkEven = new ParandBalancer();

            var result = checkEven.CheckParands("(jumble(words)more)");

            Assert.AreEqual(result, true);
        }

        [Test]
        public void CheckMoreOpenOperands()
        {
            var checkEven = new ParandBalancer();

            var result = checkEven.CheckParands("(jumble(words.more)");

            Assert.AreEqual(result, false);
        }

        [Test]
        public void CheckMoreCloseOperands()
        {
            var checkEven = new ParandBalancer();

            var result = checkEven.CheckParands("(jumble(words)more)))");

            Assert.AreEqual(result, false);
        }

        [Test]
        public void CheckNullInput()
        {
            var checkEven = new ParandBalancer();

            var result = checkEven.CheckParands(null);

            Assert.AreEqual(result, false);
        }
    }
}
