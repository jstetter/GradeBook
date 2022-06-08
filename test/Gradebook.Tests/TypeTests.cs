using System;
using Xunit;
using GradeBook;

namespace Gradebook.Tests;

public class TypeTest
{   
    [Fact]
    public void Test1()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");

        Assert.Equal("Book 1", book1.Name);
    }

    private void GetBookSetName(Book book, string name){
        book = new Book(name);
    }


    [Fact]
    public void CanSetNameFromReference()
    {
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name");

        Assert.Equal("New Name", book1.Name);
    }

    private void SetName(Book book, string name){
        book.Name = name;
    }


    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        var book1 = GetBook("Book 1");
        var book2 = book1;
        //asset book1 and book2 point to the same reference in memory
        Assert.Same(book1,book2);
        Assert.True(Object.ReferenceEquals(book1,book2));
    }

    Book GetBook(string name){
        return new Book(name);
    }

}

/*
    before being able to test the objects I create in GradeBook, I need to add a reference on the
    dotnet CLI to my GradeBook.csproj

    sample command: dotnet add reference ../../src/GradeBook/GradeBook.csproj

    to test using CLI run dotnet test on the terminal

*/