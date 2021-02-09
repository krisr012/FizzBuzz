using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class ArrayManagement
    {
        private List<int> _values = new List<int>();

        public ArrayManagement()
        {
        }

        public void Add(int userInput)
        {
            for (int i = 0; i <= userInput; i++)
            {
                _values.Add(i);
            }
        }

        public int Size()// for testing
        {
            return _values.Count;
        }

        public List<int> Get()
        {
            return _values;
        }
    }
}
