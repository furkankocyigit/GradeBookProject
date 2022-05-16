using Xunit;
using System;
namespace GradeBook.Tests{
    public class StatisticsTests{
    
    [Fact]
    public void StatisticDefaultConstructorTests(){
        
        var obj = new Statistics();

        var expectedHigh = double.MinValue;
        var expectedLow = double.MaxValue;
        var expectedSum = 0.0;
        var expectedLetter = 'F';

        Assert.Equal( expectedHigh, obj.Highest);
        Assert.Equal( expectedLow, obj.Lowest);
        Assert.Equal( expectedSum, obj.Sum);
        Assert.Equal( expectedLetter, obj.Letter);
    }

    [Fact]
    public void AddNumberToStatisticsTests(){
        
        var obj = new Statistics();
        var expectedLow = 10;
        var expectedHigh = 80;
        
        obj.Add(15);
        obj.Add(expectedHigh);
        obj.Add(expectedLow);

        Assert.Equal( 3, obj.count);
        Assert.Equal( expectedLow, obj.Lowest);
        Assert.Equal( expectedHigh, obj.Highest);
    }

    [Fact]
    public void AverageTest(){
        
        var obj = new Statistics();
        var expectedLow = 10;
        var expectedHigh = 80;

        obj.Add(expectedHigh);
        obj.Add(expectedLow);

        Assert.Equal( 2, obj.count);
        Assert.Equal( 45, obj.Average);
    }

    [Fact]
    public void LetterTest(){
        
        var obj = new Statistics();
        var expectedLow = 10;
        var expectedHigh = 80;

        obj.Add(expectedHigh);
        obj.Add(expectedLow);

        Assert.Equal( 2, obj.count);
        Assert.Equal( 'F', obj.Letter);

        obj.Add(100);
        obj.Add(100);

        Assert.Equal( 4, obj.count);
        Assert.Equal( 'C', obj.Letter);
    }
}
}

