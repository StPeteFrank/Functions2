using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    //RacingPackage, TowingPackage, EconomyPackage

    public interface ICustomParts  //Give it method(s).
    {
        int HorsePower { get; set; }             //DOES CUSTOM PARTS NEED THESE PROPERTIES??
        int CarValue { get; set; }

        void IncreaseHP(int icrease);      
        void DecreaseHP(int decrease);      
        void IncreaseValue(int increase);   
        void DecreaseValue(int decrease);   
    }

    public class RacingPackage : ICustomParts
    {
        public int HorsePower { get; set; }
        public int CarValue { get; set; }

        public void DecreaseHP(int decrease)
        {
            this.HorsePower -= decrease;
        }

        public void DecreaseValue(int decrease)
        {
            this.CarValue -= decrease;
        }

        public void IncreaseHP(int increase)
        {
            this.HorsePower += increase;
        }

        public void IncreaseValue(int increase)
        {
            this.CarValue += increase;
        }
    }


}
