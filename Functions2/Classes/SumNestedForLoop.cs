using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2.Classes
{
    public class SumNestedForLoop
    {
        public int SumNestedArray(int [][] a)
        {
            int sum = 0;
            for(int j = 0; j < a.Length; j++)
            {
                for(int k = 0; k < a[j].Length; k++)
                {
                    sum += a[j][k];
                }
            }
            return sum; 
        }
    }

}

