using System;
using System.Collections.Generic;

namespace GradeBook{
class Program{
    static void Main(string[] args)
    {
        //initializing a book Object which is defined in Book.cs
        var book1 = new Book("Jake's Grade Book");
        book1.AddGrade(88.5);
        book1.AddGrade(79);
        book1.AddGrade(99.2);

        var book2 = new Book("Zoe's Grade Book");
        book2.AddGrade(67.9);
        book2.AddGrade(76.2);
        book2.AddGrade(85.4);

    
        //get lowest grades using getLowGrade method
        Console.WriteLine(book2.GetLowGrade());
        Console.WriteLine(book1.GetHighGrade());
        
        Console.WriteLine();
        //get summary statistics
        book1.ShowStatistics();
        book2.ShowStatistics();
    }
}
}