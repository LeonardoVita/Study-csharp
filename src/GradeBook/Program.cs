using System;

namespace GradeBook
{
    class Program
    {        
        static void Main(string[] args)
        {   
            var book = new Book("Leonardo");
            book.addGrade(12.7);
            book.addGrade(10.3);
            book.addGrade(9.6);
            book.addGrade(4.1);
            book.addGrade(7.7);

            Statistic statistic = book.getStatistic();            
            
            Console.WriteLine($"The lowest grade is {statistic.Low:n1}\nThe highest grade is {statistic.High:n1}\nThe Average grade is {statistic.Average:n1}");
             
        }
    }
}
