using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2.Classes
{
    public class SumNestedForLoop
    {
        public int NestedArray(int [][] a)
        {
            int sum = 0;
            for (int first = 0; first < a.Length; first++)
            {
                for(int j = 0; j < a[first].Length; j++)
                {
                    sum += a[first][j];
                }
            }
            return sum;
        }
    }

}

