using System;
using Xunit;
using GradeBook;

namespace Gradebook.Tests;

public class BookTests
{
    [Fact]
    public void Test1()
    {
        //arrange
        var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(71.2);

        //act
        var result = book.GetStatistics();

        //assert
        Assert.Equal(83.6, result.Average, 1);
        Assert.Equal(90.5, result.High, 1);
        Assert.Equal(71.2, result.Low, 1);

    }

}

/*
    before being able to test the objects I create in GradeBook, I need to add a reference on the
    dotnet CLI to my GradeBook.csproj

    sample command: dotnet add reference ../../src/GradeBook/GradeBook.csproj


*/