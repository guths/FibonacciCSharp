using System;
using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> fibonacci = new List<int>() { 0,1 };

            for (int i = 2; fibonacci.Last() <= 350; i++)
            {
                int result = fibonacci[i - 1] + fibonacci[i - 2];
                fibonacci.Add(result);

            }

            return fibonacci;
            throw new NotImplementedException();
        }

        public bool IsFibonacci(int numberToTest)
        {
            var sequencia = Fibonacci();
            return sequencia.Contains(numberToTest);

            throw new NotImplementedException();
        }
    }
}
