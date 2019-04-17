using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
   public class AddressBookBuilder
    {
        public int ActualNumber { get; set; }  //Properties or attributes of a class.
        public string StreetName { get; set; }
        public string LocationName { get; set; }
        public override string ToString()  
        {
            return $"{LocationName} is located at {ActualNumber} {StreetName}.";
        }

    }
}
