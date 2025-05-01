using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("hello", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        public void IsPalindromeTest(string input, bool expected)
        {
            //Arrange
            var tester = new WordSmith();

            //Act
            var actual = tester.IsPalindrome(input);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
