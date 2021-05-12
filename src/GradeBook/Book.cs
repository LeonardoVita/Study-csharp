using System;
using System.Collections.Generic;

namespace GradeBook
{
    class  Book 
    {
        private List<double> grades;
        private string name;
        
        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }

        public void addGrade(double grade){
            grades.Add(grade);
        }

        public void showStatistic(){          

            double result = 0;
            double highGrade = double.MinValue; 
            double lowGrade = double.MaxValue;

            foreach (var item in grades)
            {
                highGrade = Math.Max(item,highGrade);
                lowGrade = Math.Min(item,lowGrade);
                result += item;    
            }
            
            result /= grades.Count;
            Console.WriteLine($"The average is {result:n1}\nthe highgrade is {highGrade:n1}\nthe low is {lowGrade:n1}");
        }
    }
}