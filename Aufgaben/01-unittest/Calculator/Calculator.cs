﻿using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int factorA, int factorB)
        {
            return factorA * factorB;
        }

        public double Divide(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("Divisor must not be zero");
            return dividend / divisor;
        }
    }
}
