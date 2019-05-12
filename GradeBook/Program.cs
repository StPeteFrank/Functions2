using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)  //Main method   //DLL dynamic link library   //cw , hit tab twice for auto
        {
            //var numbers = new[] { 10.3, 12.7, 6.11, 4.1};
            var grades = new List<double> { 10.3, 12.7, 6.11, 4.1 };
            grades.Add(12.09);
           

            var result = 0.0;
            foreach(var grade in grades)
            {
                result += grade;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}. My favorite score was {grades[0]}");  //N1 is a formatting specifier
            
           
           if (args.Length > 0) 
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello");
            }
          
            Console.ReadLine();
        }
    }
}
