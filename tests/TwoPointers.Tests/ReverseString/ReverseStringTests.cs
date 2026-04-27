using System;
using System.Collections.Generic;
using System.Text;
using TwoPointers.ReverseString;

namespace TwoPointers.Tests.ReverseString
{
    [TestFixture]
    public class ReverseStringTests
    {
        private Solution _solution;
        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        [TestCase(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
        [TestCase(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
        [TestCase(new char[] { 'a' }, new char[] { 'a' })]
        [TestCase(new char[] { }, new char[] { })]

        public void ReverseString_ShouldReverseString(char[] input, char[] expected)
        {
            //Act
            _solution.ReverseString(input);
            //Assert
            Assert.That(input, Is.EqualTo(expected));
        }
    }
}
