using System;

namespace GradeBook {
    class Program {
        static void Main(string[] args) {

            var book = new Book("Matvey's Grade Book");
            book.AddGrade(87.5);
            book.AddGrade(100);
            book.AddGrade(31.2);

            book.ShowStats();
        }
    }
}
