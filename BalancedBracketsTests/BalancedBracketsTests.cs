using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(true, true);
        //}

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void BracketsBeforeStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.OpenBeforeClosed("[]LaunchCode"));
        }

        [TestMethod]
        public void BracketsAfterStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.OpenBeforeClosed("LaunchCode[]"));
        }

        [TestMethod]
        public void BracketsWithinStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.OpenBeforeClosed("Launch[Code]"));
        }

        [TestMethod]
        public void StringWithinBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.OpenBeforeClosed("[LaunchCode]"));
        }

        [TestMethod]
        public void BackwardsBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.OpenBeforeClosed("]["));
        }

        [TestMethod]
        public void SingleBracketReturnsFalse()
        {

            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void StringWithBackwardsBracketPairReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.OpenBeforeClosed("Launch]Code["));
        }

        [TestMethod]
        public void StringWithSingleOpenBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void StringWithSingleClosedBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("LaunchCode]"));
        }

        [TestMethod]
        public void BackwardsOuterBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.OpenBeforeClosed("][]["));
        }

        [TestMethod]
        public void BackwardsInnerBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.OpenBeforeClosed("]][["));
        }
    }
}
