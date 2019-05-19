using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Functions2.Classes
{
    public class RemoveSmallest
    {
        public List<int> Remover(List<int> numbers)   //Need help on how to output numbers in console.
        {
            numbers.Remove(numbers.Min());
            return numbers;
        }
    }


   /* public class RemoveSmallest
    {
        public List<int> Remover(List<int> numbers)
        {
            numbers.Remove(numbers.DefaultIfEmpty().Min());
            return numbers.ToList();
        }
    }*/

}
