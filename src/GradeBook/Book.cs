using System;
using System.Collections.Generic;

namespace GradeBook {
    class Book {

        private List<double> grades;
        private string name; 

        // constructor:
        public Book(string name) {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade) {
            grades.Add(grade);
        }

        public void ShowStats() {
            var lowestGrade = double.MaxValue;
            var highestGrade = double.MinValue;
            var averageGrade = 0.0;

            foreach(var grade in grades) {
                lowestGrade = Math.Min(grade, lowestGrade);
                highestGrade = Math.Max(grade, highestGrade);
                averageGrade += grade;
            }

            averageGrade /= grades.Count;

            Console.WriteLine($"The lowest grade is: {lowestGrade}");
            Console.WriteLine($"The highest grade is: {highestGrade}");
            Console.WriteLine($"The average grade is: {averageGrade}");
        }
        
    }
}