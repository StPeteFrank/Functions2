using System;
using System.Collections.Generic;
using System.Linq;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)  //Main method   //DLL dynamic link library   //cw , hit tab twice for auto
        {


            var book = new Book("Frank's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(14.02);
            book.AddGrade(65.07);
            book.ShowStatistics();
           
          /* if (args.Length > 0) 
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello");
            }*/
          
            Console.ReadLine();
        }
    }
}
