using System;
using System.Collections.Generic;

namespace GreatBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sowmya grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats=book.GetStatistics();
            Console.WriteLine($"The lowest grade is{stats.lowgrade}");
            Console.WriteLine($"The high grade is{stats.highgrade}");
            Console.WriteLine(value: $"The average grade is{stats.Average:N1}");
            
            
            

       
    }
}
}