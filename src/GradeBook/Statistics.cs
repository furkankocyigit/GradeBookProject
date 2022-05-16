namespace GradeBook{

    public class Statistics{

        public Statistics(){
            Highest = double.MinValue;
            Lowest = double.MaxValue;
            Letter = 'F';
            Sum = 0.0;
            count = 0;
        }

        public void Add(double grade){
            Sum += grade;
            count++;
            Lowest = Math.Min(grade, Lowest);
            Highest = Math.Max(grade, Highest);
        }

        public double Average{
            get {return Sum / count;}
        }
        public double Highest;
        public double Lowest;
        public char Letter;
        public double Sum;

        public int count;

        
    }
}