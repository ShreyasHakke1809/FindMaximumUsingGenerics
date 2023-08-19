﻿namespace FindMaximumUsingGenerics
{
    public class FindMaximum<T> where T : IComparable
    {
        public T num1, num2, num3;

        public FindMaximum(T num1, T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public static T GetMaxOfThree<T>(T a, T b, T c) where T : IComparable
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }
            else if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            else if (c.CompareTo(a) >= 0 && c.CompareTo(b) >= 0)
            {
                return c;
            }
            return default;
        }
        public T GetMax()
        {
            T maxValue = FindMaximum<T>.GetMaxOfThree(this.num1, this.num2, this.num3);
            return maxValue;
        }



    }
}

