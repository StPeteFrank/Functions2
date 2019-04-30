using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public interface IManageHP
    {
        int HorsePower { get; set; }
        void IncreaseHP(int increase);
        void DecreaseHP(int decrease);
    }
}
