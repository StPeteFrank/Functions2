using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public interface IManageCarValue
    {
        int CarValue { get; set; }
        void IncreaseValue(int increase);
        void DecreaseValue(int decrease);
    }
}
