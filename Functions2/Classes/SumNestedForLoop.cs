using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2.Classes
{

    /*public long SumNested(int[][] a)
    {
        long sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; i++)
            {
                sum += a[i][j];
            }
        }
        return sum;
    }*/
    public class SumNestedForLoop
        {
            public int SumNested(int [][] a)
            {
                int sum = 0;
                for(int first = 0; first < a.Length; first++)
                {
                    for(int j = 0; j < a[first].Length; j++)
                    {
                        sum += a[first][j];
                    }
                }
                return sum;
            }
        

         /*public static int SumNested(int[][] a)
         {
             return a.Sum(x => x.Sum());
         }*/


    }
}

