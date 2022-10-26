using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyThreeAndTwoIsSix()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 6;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideNineByThreeIsThree()
        {
            // Arrange
            int a = 9;
            int b = 3;
            double expected = 3.0;
            Calculator calculator = new Calculator();

            // Act
            double actual = calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideNineByZeroIsError()
        {
            // Arrange
            int a = 5;
            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentException>(
                () => calculator.Divide(a, 0));
        }
    }
}
