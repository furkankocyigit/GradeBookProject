namespace GradeBook
{
    public class FileBook : Book{
        public FileBook(string name) : base(name){}

        public override event GradeAddedDelegate gradeAdded;
        public override void addGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics getStatistics()
        {
            throw new NotImplementedException();
        }
    }
}