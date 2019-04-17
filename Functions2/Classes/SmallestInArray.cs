using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2.Classes
{
    public class SmallestInArray
    {
        public int Smallest(int [] a)
        {
            int b = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if(b > a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }
    }

    /*public class SmallestInArray
    {
        public int Smallest(int [] a)
        {
            return a.Min();
        }
    }*/

}
