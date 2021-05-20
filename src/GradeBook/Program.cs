using System;

namespace GradeBook
{
    class Program
    {        
        static void Main(string[] args)
        {   
            var book = new Book("Leonardo");
            

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");               
                var input = Console.ReadLine();

                if (input == "q")
                {                    
                    break;    
                }
                
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);         
                }
                catch (ArgumentException ex)
                {                    
                    Console.WriteLine(ex.Message);                    
                }
                catch (FormatException ex)
                {                    
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
                              
            }

            Statistic statistic = book.GetStatistic();            
            
            Console.WriteLine($"The lowest grade is {statistic.Low:n1}\nThe highest grade is {statistic.High:n1}\nThe Average grade is {statistic.Average:n1}");
            Console.WriteLine($"The letter is {statistic.Letter}");
             
        }
    }
}
