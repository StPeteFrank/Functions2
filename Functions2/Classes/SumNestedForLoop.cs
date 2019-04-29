using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2.Classes
{
    public class SumNestedForLoop
    {
        public int NestedLoop(int [][] a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    
                    
                        sum += a[i][j];
                    
                }
            }
            return sum;
        }
    }

}

