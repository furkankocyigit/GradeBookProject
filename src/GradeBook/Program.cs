using System;

namespace  GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {   
            
            IBook fileBook = new FileBook("Furkan's File Book");
            IBook memoryBook = new InMemoryBook("Furkan's In Memory Book");

            var done = false;

            while(!done)
            {
                Console.WriteLine("Choose where to record ('Q' for exit): \n 1- In memory \n 2- In Txt File");
                var input = Console.ReadLine();
                if (input != "1" && input != "2")
                {
                    Console.WriteLine("Please make an apropriate choose!!!");
                }

                if (input == "Q" || input == "q")
                {
                    done = true;
                    continue;
                }

                if (input == "1")
                {
                    done = RecordGrades(done,memoryBook, input);
                    var inMemoryBookStatistics = memoryBook.getStatistics();
                    ShowStatistics(inMemoryBookStatistics);
                }

                if(input == "2"){
                    done = RecordGrades(done,fileBook,input);
                    var fileBookStatistics = fileBook.getStatistics();
                    ShowStatistics(fileBookStatistics);
                }
            }

            Console.WriteLine("Furkan!!!");
        }

        private static void ShowStatistics(Statistics statistics)
        {
            System.Console.WriteLine($"The average grade is: {statistics.Average:N1}");
            System.Console.WriteLine($"The lowest grade is: {statistics.Lowest:N1}");
            System.Console.WriteLine($"The highest grade is: {statistics.Highest:N1}");
            System.Console.WriteLine($"The Letter grade is: {statistics.Letter:N1}");
        }

        private static bool RecordGrades(bool done, IBook book, string? input)
        {
                          
                while (true)
                {
                    Console.WriteLine("Enter a grade('Q' for exit):");
                    var gradeInput = Console.ReadLine();

                    if (gradeInput == "Q" || gradeInput == "q")
                    {
                        done = true;
                        break;
                    }
                    else
                    {
                        try
                        {
                            var grade = double.Parse(gradeInput);
                            book.addGrade(grade);
                            Console.WriteLine("added succesfully!");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("***");
                        }
                    }
                
            }

            return done;
        }
    }
    
}