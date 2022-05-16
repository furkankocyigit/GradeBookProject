using Xunit;
using System;
using System.Collections.Generic;

namespace GradeBook.Tests
{
    public class FileBookTests{
        
        [Fact]
        public void AddGradeTest(){
        
            var fileBook = new FileBook("test book");

            fileBook.addGrade(80);
            fileBook.addGrade(90);
            fileBook.addGrade(40);
            fileBook.addGrade(70);
            
            var statistics = fileBook.getStatistics();

            Assert.Equal( 90, statistics.Highest);
            Assert.Equal( 40, statistics.Lowest);
            Assert.Equal( 70, statistics.Average);
            Assert.Equal( 'C', statistics.Letter);

        }

        [Fact]
        public void InvalidInput(){
        
            var fileBook = new FileBook("test book");

            var ex = Assert.Throws<ArgumentException>(()=> fileBook.addGrade(-100));
            Assert.Equal("Invalid grade", ex.Message);
        }
    }

}