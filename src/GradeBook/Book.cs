
namespace GradeBook
{
    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate gradeAdded;

        public abstract void addGrade(double grade);

        public abstract Statistics getStatistics();
    }
}