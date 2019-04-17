using Functions2.Classes;
using System;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LargestInArray().Largest(new int[] { 5, 1, -2, 12, 9, 0 }));
            // Console.WriteLine(new SmallestInArray().Smallest(new int[] { 12, 2, 0, -9 }));
            Console.WriteLine(new SmallestInArray().Smallest(new int[] { 9, 3, 0, -10, 8, -7, 12 }));
            Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 10, 20, 30, 40 }));
            Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 2, 0, 3, 5, 7 }));
            Console.WriteLine(new SumArrayForEach().SumForEach(new int[] { 20, 40, 60, 80 }));
            Console.WriteLine(new SquareSumArray().SquareSum(new int[] { 2, 4, 5 }));

            //Console.WriteLine(new SumNestedForLoop().SumNested(new int [][] { new int[] { 2, 4, 6, 8, 9, 10, 11 }, new int[] { 1, 3, 5 } })); 

            Console.WriteLine(new RemoveString().TakeOutString(new string ("H!iii!!!")));

            Console.ReadLine();
        }
    }
}
