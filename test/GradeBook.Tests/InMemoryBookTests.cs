using Xunit;
using System;
using System.Collections.Generic;

namespace GradeBook.Tests
{
    public class InMemoryBookTests{
        
        [Fact]
        public void AddGradeTest(){
        
            var memoryBook = new InMemoryBook("test book");

            memoryBook.addGrade(100);
            memoryBook.addGrade(80);
            var grades = memoryBook.getGrades();

            Assert.Equal( 100, grades[0]);
            Assert.Equal( 80, grades[1]);
            Assert.Equal( 2, grades.Count);

        }

        [Fact]
        public void MinMaxValueTest(){
        
            var memoryBook = new InMemoryBook("test book");

            
            memoryBook.addGrade(80);
            memoryBook.addGrade(20);
            memoryBook.addGrade(90);
            var countNumber = memoryBook.getGrades().Count;
            var statistics = memoryBook.getStatistics();

            Assert.Equal( statistics.Lowest, 20);
            Assert.Equal( statistics.Highest, 90);
            Assert.Equal( statistics.count, countNumber);

        }

    }
    
}