using System;
using System.Collections.Generic;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int num)
        {
            var result = string.Empty;

            if (num % 3 == 0) result += "Foo";

            if (num % 5 == 0) result += "Bar";

            if (num % 7 == 0) result += "Qix";

            if (result.Length == 0) return num.ToString();

            return result.ToString();
        }
    }
}