﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Functions2.Classes
{
    public class RemoveString
    {
        public string TakeOutString(string a)
        {
            return a.Replace("!", "") + "!";
        }
    }
}
