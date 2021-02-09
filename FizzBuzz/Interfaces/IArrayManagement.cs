using System;
using System.Collections.Generic;

namespace FizzBuzz.Interfaces
{
    public interface IArrayManagement
    {
        void Add(int userInput);

        int Size();

        List<int> Get();
    }
}
