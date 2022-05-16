namespace GradeBook
{
    public class FileBook : Book{
        public FileBook(string name) : base(name){}

        public override event GradeAddedDelegate gradeAdded;
        public override void addGrade(double grade)
        {
            if(grade <= 100 && grade >=0) {
                
                using(var writer = File.AppendText($"{Name}.txt")){
                    writer.WriteLine(grade);

                    if(gradeAdded != null){
                        gradeAdded(this,new EventArgs());
                    }
                }
            }
            else{
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }

        }

        public override Statistics getStatistics()
        {
            var statistics = new Statistics();
            
            using (var reader = File.OpenText($"{Name}.txt")){
                var line = reader.ReadLine();
                while(line != null){
                    var number = double.Parse(line);
                    statistics.Add(number);
                    line = reader.ReadLine();
                }
            }

            return statistics;
        }
    }
}