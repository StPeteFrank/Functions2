using Functions2.Classes;
using System;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new LargestInArray().Largest(new int[] { 5, 0, -3, 11, 9, -14 }));
            Console.WriteLine(new LargestInArray().Largest(new int[] { 10, 7, -3, 0, 12, 9 }));
            Console.WriteLine(new SmallestInArray().Smallest(new int[] { 2, 10, -9, -10, 12 }));
            Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 100, 200, 300, 400 }));
            Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 2, 0, 5, 10, 7, 3, -9 }));
            Console.WriteLine(new SumArrayForEach().SumForEach(new int[] { 200, 400, 600, 800 }));
            Console.WriteLine(new SquareSumArray().SquareSum(new int[] { 2, 4, 5 }));
            Console.WriteLine(new RemoveString().RemoveIt(new string("!Th!is !is! a! te!!!st")));
            Console.WriteLine(new SumNestedForLoop().SumNested(new int[][] { new int[] { 2, 4, 6 }, new int[] { 3, 5, 7 } }));
                

            Console.ReadLine();
        }
    }
}
