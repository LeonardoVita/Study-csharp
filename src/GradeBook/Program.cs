using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {        
        static void Main(string[] args)
        {   
            var book = new Book("Leonardo");
            book.addGrade(99.1);

            List<double> grades = new List<double>() {12.7, 10.3, 9.6, 4.1};

            grades.Add(50);
            grades[0]= 10.1;

            double result = 0.0;
            foreach (var item in grades)
            {
                result += item;    
            }
            
            result /= grades.Count;
            Console.WriteLine($"The average is {result:n1}");
             
        }
    }
}
