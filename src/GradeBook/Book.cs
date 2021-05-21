using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name { get; set;}

        
    }

    public abstract class Book : NamedObject
    {
        protected Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
    }

    public class  InMemoryBook : Book 
    {
        readonly string category = "Science";
        public const string CONSTANT = "um exemplo de constante";  
        public event GradeAddedDelegate GradeAdded;
        private List<double> grades;


        public InMemoryBook(string name) : base( name )
        {
            grades = new List<double>();
            Name = name;
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

        public override void AddGrade(double grade){
            if (grade <=100 && grade >= 0)
            {
                grades.Add(grade);  
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());    
                }              
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
