using System;
using System.Collections.Generic;
using System.Text;
using TwoPointers.ValidPalindromeII;

namespace TwoPointers.Tests.ValidPalindromeII
{
    [TestFixture]
    public class ValidPalindromeIITests
    {
        private Solution _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        [TestCase("aca", ExpectedResult = true)]
        [TestCase("abbadc", ExpectedResult = false)]
        [TestCase("abbda", ExpectedResult = true)]

        public bool IsPalindrome_Tests(string input)
        {
           return _solution.ValidPalindrome(input);
        }
    }
}
