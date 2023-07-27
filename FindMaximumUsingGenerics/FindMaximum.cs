﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class FindMaximum
    {
        public int MaxOfThree(int a, int b, int c)
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
        public float MaxOfThreeFloat (float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            return default;
        }
    }
}
