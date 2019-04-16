using Functions2.Classes;
using System;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LargestInArray().Largest(new int[] { 2, 1, 4, 7, 10, 3, -7 }));
            Console.WriteLine(new SmallestInArray().Smallest(new int[] { 12, 2, 0, -9 }));
            Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 10, 20, 30, 40 }));
            Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 2, 0, 3, 5, 7 }));

            Console.ReadLine();
        }
    }
}
