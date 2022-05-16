
namespace GradeBook
{   
    public delegate void GradeAddedDelegate(object sender,EventArgs args);
    
    public interface IBook{
        
        void addGrade(double grade);
        Statistics getStatistics();
        event GradeAddedDelegate gradeAdded;
    }
}