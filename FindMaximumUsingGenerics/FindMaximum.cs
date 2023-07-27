using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class FindMaximum <T> where T : IComparable
    {
        public T[] genValue;

        public FindMaximum(T[] genValue)                      
        {
            this.genValue = genValue;
        }

        public T[] Sorting(T[] genValue)
        {
            Array.Sort(genValue);
            Array.Reverse(genValue);
            return genValue;
        }

        public T GetMaxOfThree(T[] genValue)
        {
            var sortedArray = Sorting(genValue);
            return sortedArray.ElementAt(0);
        }
        public T GetMax()
        {
            T maxValue = GetMaxOfThree(this.genValue);
            return maxValue;
        }

    }
}

