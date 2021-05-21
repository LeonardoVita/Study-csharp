using System;

namespace GradeBook
{
    public class Statistic 
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var av when av >= 90.0:
                        return 'A';                        
                    case var av when av >= 80.0:
                        return 'B';                        
                    case var av when av >= 70.0:
                        return 'C';                        
                    case var av when av >= 60.0:
                        return 'D';                                    
                    default:
                        return 'F';                        
                }
            }
        }
        public double Sum;
        public int Count;

        public Statistic() 
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue; 
            Low = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            Count++;  
            High = Math.Max(number,High);
            Low = Math.Min(number,Low);
        }
    }
}