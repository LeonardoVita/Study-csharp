using System;

namespace GradeBook
{
    class Program
    {        
        static void Main(string[] args)
        {   
            var book = new Book("Leonardo");
            book.GradeAdded += OnGradeAdded;

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
            
            book.Name = "TESTANDO";
            book.Name = "";
            Console.WriteLine(Book.CONSTANT);
            Console.WriteLine($"For The book named { book.Name}");
            Console.WriteLine($"The lowest grade is {statistic.Low:n1}\nThe highest grade is {statistic.High:n1}\nThe Average grade is {statistic.Average:n1}");
            Console.WriteLine($"The letter is {statistic.Letter}");
             
        }

        static void OnGradeAdded(object sender, EventArgs a)
        {
            Console.WriteLine("A Grade was added");
        }
    }
}

// dotnet run --project src/GradeBook/GradeBook.csproj    -- EXECUTE EM POWERSHELL
// dotnet teste                                           -- EXECUTE TESTE
