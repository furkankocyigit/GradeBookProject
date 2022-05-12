using Xunit;
using System;
namespace GradeBook.Tests{
    public class NamedObjectTests{
    
    [Fact]
    public void NameTest(){
        
        var obj = new NamedObject("Furkan");

        Assert.Equal( "Furkan", obj.Name);

    }
}
}

