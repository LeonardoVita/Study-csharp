using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            double[] numbers = new[] {12.7, 10.3, 9.6, 4.1};

            double result = 0.0;
            foreach (var item in numbers)
            {
                result += item;    
            }
            Console.WriteLine(result);
             
        }
    }
}
