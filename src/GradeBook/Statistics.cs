namespace GradeBook{

    public class Statistics{

        public Statistics(){
            Highest = double.MinValue;
            Lowest = double.MaxValue;
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

        public char Letter{
            get{
                switch(Average)
                { 
                    case var d when d >=90:
                        return 'A';
                    case var d when d >=80:
                        return 'B';
                    case var d when d >=70:
                        return 'C';
                    case var d when d >=60:
                        return 'D';
                    default:
                        return 'F';
                }

            }
        }
        public double Highest;
        public double Lowest;
        
        public double Sum;

        public int count;

        
    }
}