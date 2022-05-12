using Xunit;
using System;
namespace GradeBook.Tests{
    public class StatisticsTests{
    
    [Fact]
    public void StatisticDefaultConstructorTests(){
        
        var obj = new Statistics();

        var expectedHigh = double.MaxValue;
        var expectedLow = double.MinValue;
        var expectedAvg = 0.0;
        var expectedLetter = 'F';

        Assert.Equal( expectedHigh, obj.Highest);
        Assert.Equal( expectedLow, obj.Lowest);
        Assert.Equal( expectedAvg, obj.Average);
        Assert.Equal( expectedLetter, obj.Letter);
    }
}
}

