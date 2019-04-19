﻿using Functions2.Classes;
using System;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LargestInArray().Largest(new int[] { 5, 0, -3, 9, 4, 12, -20 }));
            Console.WriteLine(new SmallestInArray().Smallest(new int[] { 10, 0, -4, 16, 10, 12, -9, -7 }));
            Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 100, 200, 300, 400 }));
            //Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 10, 6, 3, -3, 12, 5, 7, 0, 1 }));
            Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 9, 0, -3, 3, 12, 10, 5, 7, 100 }));
            Console.WriteLine(new SumArrayForEach().SumForEach(new int[] { 200, 400, 600, 800 }));
            Console.WriteLine(new SquareSumArray().SquareSum(new int[] { 2, 4, 5 }));
            Console.WriteLine(new RemoveString().Remove(new string("Fra!nk is! gett!ing s!tronger!!!")));
            Console.WriteLine(new SumNestedForLoop().SumNested(new int[][] { new int[] { 2, 4, 6, 8 }, new int[] { 3, 5, 7, 9 } }));



            Console.ReadLine();
        }
    }
}
