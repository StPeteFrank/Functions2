using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)    // Explicit ctor (constructor method) which is with in the class. Implicit would be when the compiler creates a default ctor.
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)  // Method.
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                result += grade;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}. My favorite score was {grades[0]}." +
                $" The highest grade was {highGrade}. Lowest was {lowGrade}.");  //N1 is a formatting specifier
        }

        private List<double> grades;    //This is a field. outside the method. No using implicit types.
        private string name;
    }
}
