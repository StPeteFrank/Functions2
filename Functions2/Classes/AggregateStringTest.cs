using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2.Classes
{
    public class AggregateStringTest
    {
        public string AggregateString(string [] mySkills)
        {
            return mySkills.Aggregate((s1, s2) => s1 + ", " + s2);
        }
    }
}
