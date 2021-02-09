using System;
using System.Collections;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new ArrayManagement();

            var userInput = Convert.ToInt32(Console.ReadLine());

            array.Add(userInput);

            ProcessInput.SortInput(array.Get());
        }
    }
}
