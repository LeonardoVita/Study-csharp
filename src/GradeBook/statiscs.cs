namespace GradeBook
{
    public class Statistic 
    {
        public double Average;
        public double High;
        public double Low;
        public char Letter;

        public Statistic(double Average,double High,double Low,char Letter) {
            this.Average = Average;
            this.High = High;
            this.Low = Low;
            this.Letter = Letter;
        }
    }
}