using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public interface ICarBuilder
    {
        void IncreaseHP();      //int increase
        void DecreaseHP();      //int decrease
        void IncreaseValue();   //int increase
        void DecreaseValue();   //int decrease
    }
}
