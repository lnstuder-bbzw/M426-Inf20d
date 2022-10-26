using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 20, 30 };
            double expected = 25;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 20, 30, 7, 40, 60 };
            double expected = 31.4;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbers()
        {
            List<int> numbers = new List<int>();
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Mean(numbers));
        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            List<int> numbers = new List<int> { 3, 5, 2, 8, 9, 2, 3 };
            float expected = 3;
            Average average = new Average();

            float actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            List<int> numbers = new List<int> { 3, 5, 2, 9, 2, 3 };
            float expected = 3;
            Average average = new Average();

            float actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianOfNoNumbers()
        {
            List<int> numbers = new List<int>();
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Median(numbers));
        }
    }
}
