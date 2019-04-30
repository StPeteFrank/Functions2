using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2.Classes
{
   /* public class MultiplyArrayForLoop
    {
        public int MultiplyArray(int [] a)
        {
            int b = 1;
            for(int i = 0; i < a.Length; i++)
            {
                b *= a[i];
            }
            return b;
        }
    }*/
    public class MultiplyArrayForLoop
    {
        public int MultiplyArray(int [] a)
        {
            return a.Aggregate((b, c) => b * c);
        }
    }
}
