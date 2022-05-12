using Xunit;
using System;
namespace GradeBook.Tests{
    public class NamedObjectTests{
    
    [Fact]
    public void NameTest(){
        
        var obj = new NamedObject("Furkan");

        Assert.Equal( "Furkan", obj.Name);

    }

    [Fact]
    public void setNameTest(){
        
        var obj = new NamedObject("Furkan");
        obj.Name = "new Book";
        
        Assert.Equal("new Book", obj.Name);

    }
}
}

