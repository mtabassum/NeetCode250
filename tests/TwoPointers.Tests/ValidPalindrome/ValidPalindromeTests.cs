using System;
using System.Collections.Generic;
using System.Text;
using TwoPointers.ValidPalindrome;

namespace TwoPointers.Tests.ValidPalindrome
{
    [TestFixture]
    public class ValidPalindromeTests
    {     
       private Solution _solution;

        [SetUp]    
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        [TestCase("A man, a plan, a canal: Panama", ExpectedResult = true)]
        [TestCase("race a car", ExpectedResult = false)]
        [TestCase(" ", ExpectedResult = true)]
        [TestCase("Was it a car or a cat I saw?", ExpectedResult = true)]
        [TestCase("12321", ExpectedResult = true)]
        [TestCase("12345", ExpectedResult = false)]

        public bool IsPalindrome_Tests(string input)
        {
             return _solution.IsPalindrome(input);
        }
    }
}
