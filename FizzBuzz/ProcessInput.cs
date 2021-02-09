using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public static class ProcessInput
    {
        public static void SortInput(List<int> values)
        {
            foreach (int value in values)
            {
                if (value % 3 == 0 && value % 5 == 0)
                {
                    PrintOutput("FizzBuzz");
                }
                else if (value % 3 == 0)
                {
                    PrintOutput("Fizz");
                }
                else if (value % 5 == 0)
                {
                    PrintOutput("Buzz");
                }
                else
                {
                    PrintOutput(value.ToString());
                }
            }
        }

        private static void PrintOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}
