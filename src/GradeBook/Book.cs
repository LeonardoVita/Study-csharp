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
            Console.WriteLine($"Construtctor This {this.name}");
        }

        public void addGrade(double grade){
            grades.Add(grade);   
            Console.WriteLine($"addGrade This {this.name}");
        }
    }
}