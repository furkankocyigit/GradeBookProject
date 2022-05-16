using System;

namespace  GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {   
            IBook memoryBook = new InMemoryBook("Furkan's In Memory Book");
            IBook fileBook = new FileBook("Furkan's File Book");

            var done = false;

            while(!done){
                Console.WriteLine("Choose where to record ('Q' for exit): \n 1- In memory \n 2- In Txt File");
                var input = Console.ReadLine();
                if (input != "1" || input != "2")
                {
                    Console.WriteLine("Please make an apropriate choose!!!");
                }

                if (input == "Q" || input == "q")
                {
                    done = true;
                    continue;
                }
            }

            Console.WriteLine("Furkan!!!");
        }
    }
    
}