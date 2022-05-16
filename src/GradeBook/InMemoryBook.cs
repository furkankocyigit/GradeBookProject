namespace GradeBook
{
    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) : base(name)
        {
            _grades = new List<double>();
        }

        public override event GradeAddedDelegate gradeAdded;

        public override void addGrade(double grade)
        {
            if(grade <= 100 && grade >=0) {
                _grades.Add(grade);
                if(gradeAdded != null){
                    gradeAdded(this, new EventArgs());
                }
            }
            else{
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public override Statistics getStatistics()
        {
            var statistics = new Statistics();

            for(var index = 0; index < _grades.Count; index++){
                statistics.Add(_grades[index]);
            }
            return statistics;
        }
        
        public List<double> getGrades(){ return this._grades;}
        private List<double> _grades;
    }
}