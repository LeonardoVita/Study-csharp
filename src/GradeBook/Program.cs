using System;
using System.Collections.Generic;

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

            book.showStatistic();
            
             
        }
    }
}
