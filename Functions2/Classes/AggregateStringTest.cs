﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2.Classes
{
    public class AggregateStringTest
    {
        public string AggregateString(string [] a)
        {
            return a.Aggregate((e, f) => e + " " + f);
        }
    }
}
