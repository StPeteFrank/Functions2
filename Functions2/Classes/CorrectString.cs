using System;
using System.Collections.Generic;
using System.Text;

namespace Functions2.Classes
{
    public class CorrectString
    {
        public string CorrectIt(string a)
        {
            return a.Replace("0", "O").Replace("1", "I").Replace("5", "S");
        }
    }

    /*public class CorrectString
    {
        public string CorrectIt(string a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == '0') a = a.Replace(a[i].ToString(), "O");
                if (a[i] == '1') a = a.Replace(a[i].ToString(), "I");
                if (a[i] == '5') a = a.Replace(a[i].ToString(), "S");
            }
            return a;
        }
    }*/

}
