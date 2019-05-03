using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2
{
    /*public class SumArrayForLoop
    {
        public int SumArray(int [] a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }*/
    public class SumArrayForLoop
    {
        public int SumArray(int [] a)
        {
            return a.Sum();
        }
    }
    
}
