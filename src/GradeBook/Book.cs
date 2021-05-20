using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class  Book 
    {
        private List<double> grades;
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {                    
                    name = value;  
                }
            }
        }
        
        
        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(char letter){
            switch (letter)
            {
                case 'a' :
                    AddGrade(90.0);
                    break;
                case 'b' :
                    AddGrade(80.0);
                    break;
                case 'c' :
                    AddGrade(70.0);
                    break;    
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade){
            if (grade <=100 && grade >= 0)
            {
                grades.Add(grade);                
            }
            else
            {
                throw new ArgumentException($"Invalid value of {nameof(grade)}");
            }
        }

        public Statistic GetStatistic(){          

            double result = 0;
            double highGrade = double.MinValue; 
            double lowGrade = double.MaxValue;
            char letter = ' ';

            foreach (var item in grades)
            {
                highGrade = Math.Max(item,highGrade);
                lowGrade = Math.Min(item,lowGrade);
                result += item;    
            }
            
            result /= grades.Count;

            switch (result)
            {
                case var av when av >= 90.0:
                    letter = 'A';
                    break;
                case var av when av >= 80.0:
                    letter = 'B';
                    break;
                case var av when av >= 70.0:
                    letter = 'C';
                    break;
                case var av when av >= 60.0:
                    letter = 'D';
                    break;            
                default:
                    letter = 'F';
                    break;
            }

            Statistic statistic = new Statistic(result,highGrade,lowGrade,letter);
            return statistic;
        }
    }
}
