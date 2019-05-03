using Functions2.Classes;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LargestInArray().Largest(new int[] { 10, 7, -3, 0, 12, 9 }));
            Console.WriteLine(new SmallestInArray().Smallest(new int[] { 2, -10, 10, 0, -9, 16, -7 }));
            Console.WriteLine(new RemoveSmallest().Remover(new List<int> { 5, 3, 2, 1, 4 }));
            Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 100, 200, 300, 400 }));
            Console.WriteLine(new MultiplyArrayForLoop().MultiplyArray(new int[] { 1, 2, 3, 4, }));
            Console.WriteLine(new AggregateStringTest().AggregateString(new string[] { "Bring", "these", "words", "together" }));
            Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 2, 0, 5, 10, 7, 3, -7 }));
            Console.WriteLine(new SumArrayForEach().SumForEach(new int[] { 200, 400, 600, 800 }));
            Console.WriteLine(new SquareSumArray().SquareSum(new int[] { 2, 4, 5 }));
            Console.WriteLine(new RemoveString().RemoveIt(new string("!Remov!ing th!e exclamation poi!nts!!!!")));
            Console.WriteLine(new CorrectString().CorrectIt(new string ("1 HAVE S0 MANY 515TERS.")));
            Console.WriteLine(new SumNestedForLoop().NestedLoop(new int[][] { new int[] { 2, 4, 6 }, new int[] { 3, 5, 7 } }));
                

            Console.ReadLine();
        }
    }
}
