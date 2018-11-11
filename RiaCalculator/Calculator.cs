using System;
using System.Collections.Generic;
using System.Linq;

namespace RiaCalculator
{
    public class Calculator
    {

        public int FirstNumber { get; set; } 
        public int SecondNumber { get; set; }
        public int NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        public override string ToString()
        {
            return String.Format("First number: {0}, Second number: {1}, Number in memory: {2}", FirstNumber, SecondNumber, NumberInMemory);
        }

        public int SumNumbers(int first, int second) {

            return first + second;
        }

        public int MultiplyNumbers(int first, int second) {

            return first * second;
        }

        public int SumInBetween(int first, int second) {

            int smalestNumber;
            int diff;

            if (first < second){
                diff = (second - first) + 1;
                smalestNumber = first;
            } else {
                diff = (first - second) + 1;
                smalestNumber = second;
            }
            
            var count = 0;

            IEnumerable<int> numbers = Enumerable.Range(smalestNumber, diff);
            foreach (int n in numbers)
            {
                count += n;
            }


            return count;
        }
    }
}
