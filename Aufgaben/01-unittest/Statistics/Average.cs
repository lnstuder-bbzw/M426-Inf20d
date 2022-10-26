using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            if (numbers.Count() == 0)
                throw new ArgumentException("List of numbers is empty");

            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public float Median(List<int> numbers)
        {
            numbers.Sort();
            int count = numbers.Count();

            if (count == 0)
                throw new ArgumentException("List of numbers is empty");

            if (count % 2 != 0)
            {
                int medianIndex = (count - 1) / 2;
                return numbers[medianIndex];
            }

            int pivot = count / 2;
            return (numbers[pivot] + numbers[pivot - 1]) / 2;
        }
    }
}

// { 2, 2, 3, 3, 5, 8, 9 }