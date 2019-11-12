using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            string value = string.Empty;
            if (input % 3 == 0)
                value += "Fizz";
            if (input % 5 == 0)
                value += "Buzz";
            if (string.IsNullOrEmpty(value))
                value = input.ToString();

            return value;
        }
    }
}
