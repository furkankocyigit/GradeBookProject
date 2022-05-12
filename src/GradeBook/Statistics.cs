namespace GradeBook{

    public class Statistics{

        public Statistics(){
            Average = 0.0;
            Highest = double.MaxValue;
            Lowest = double.MinValue;
            Letter = 'F';
        }

        public double Average;
        public double Highest;
        public double Lowest;
        public char Letter;

        
    }
}