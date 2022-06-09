using System;
using System.Collections.Generic;

namespace GradeBook{
class Program{
    static void Main(string[] args)
    {
        //initializing a book Object which is defined in Book.cs
        //manually create gradebooks, faster for testing
        /*
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

        */

        //get user input from console
        Console.WriteLine("Please provide your name");
        var name = Console.ReadLine();
        var book = new Book(name);
        while(true){
            Console.WriteLine("Enter a grade or 'q' to quit");
            var input = Console.ReadLine();

            if(input == "q"){
                break;
            }
            //catching exceptions that gets thrown prevents the program from crashing
            try{
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

        var stats = book.GetStatisticsAlternate();
        Console.WriteLine($"The highest grade is {stats.High}.");
        Console.WriteLine($"The average grade is {stats.Average}");
    }
}
}

