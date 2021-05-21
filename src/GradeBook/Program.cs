using System;

namespace GradeBook
{
    class Program
    {        
        static void Main(string[] args)
        {
            var inMemoryBook = new InMemoryBook("Leonardo");
            inMemoryBook.GradeAdded += OnGradeAdded;

            EnterGrades(inMemoryBook);

            Statistic statistic = inMemoryBook.GetStatistic();

            inMemoryBook.Name = "TESTANDO";
            inMemoryBook.Name = "";
            Console.WriteLine(InMemoryBook.CONSTANT);
            Console.WriteLine($"For The book named { inMemoryBook.Name}");
            Console.WriteLine($"The lowest grade is {statistic.Low:n1}\nThe highest grade is {statistic.High:n1}\nThe Average grade is {statistic.Average:n1}");
            Console.WriteLine($"The letter is {statistic.Letter}");

        }

        private static void EnterGrades(Book book)
        {
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
        }

        static void OnGradeAdded(object sender, EventArgs a)
        {
            Console.WriteLine("A Grade was added");
        }
    }
}

// dotnet run --project src/GradeBook/GradeBook.csproj    -- EXECUTE EM POWERSHELL
// dotnet teste                                           -- EXECUTE TESTE
