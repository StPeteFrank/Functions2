using System;
using System.Collections.Generic;
using System.Text;

namespace Functions2
{
    public class SquareSumArray
        {
            public int SquareSum(int [] a)
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i] * a[i];
                }
                return sum;
            }
        }
}
