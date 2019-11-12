using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.Pass();
        }

        [Test]
        public void Return_One()
        {
            // Arrange
            int input = 1;
            // Act
            string value = FizzBuzzer.GetValue(input);
            // Assert
            Assert.AreEqual("1", value);
        }

        [Test]
        public void DivBy3_ReturnsFizz([Values(3,6,9)]int input)
        {            
            string value = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", value);
        }

        [Test]
        public void DivBy5_ReturnsBuzz([Values(5,10,25)] int input)
        {
            string value = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", value);
        }

        [Test]
        public void DivBy3_DivBy5_ReturnsFizzBuzz([Values(15)]int input)
        {
            string value = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", value);
        }
    }
}
