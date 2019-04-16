using System;
using System.Collections.Generic;
using System.Text;

namespace Functions2.Classes
{
    public class LargestInArray
    {
        public int Largest(int[] a)
        {
            int b = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (b < a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }
    }
}
