using Functions2.Classes;
using System;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LargestInArray().Largest(new int[] { 5, 0, -3, 11, 9, -14 }));
            Console.WriteLine(new SmallestInArray().Smallest(new int[] { 2, 0, 9, 12, -3, 16, -9, 100 }));
            Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 100, 200, 300, 400}));
            Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 9, 0, -3, 3, 12, 10, 5, 7, 100 }));
            Console.WriteLine(new SumArrayForEach().SumForEach(new int[] { 200, 400, 600, 800 }));
            Console.WriteLine(new SquareSumArray().SquareSum(new int[] { 2, 4, 5 }));
            //Console.WriteLine(new RemoveString().RemoveIt(new string("Tod!ay i!s going!! to !be a! !good day!!!")));
            Console.WriteLine(new RemoveString().RemoveIt(new string("!After th!is w!e! wil!l pract!ice s!ome r!e!a!c!t!!!!")));
            Console.WriteLine(new SumNestedForLoop().NestedForLoop(new int[][] { new int[] { 2, 4, 6 }, new int[] { 3, 5, 7 } }));



            Console.ReadLine();
        }
    }
}
