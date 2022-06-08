using System.Collections.Generic;

namespace GradeBook{
    public class Book{
        //Constructor method (needs to have the same name as the class)
        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }

        //methods
        public void AddGrade(double grade){
            grades.Add(grade);
        }

        //Method to get the lowest grade added to the gradebook
        public double GetLowGrade(){
            double lowGrade = double.MaxValue;
            foreach(double grade in grades){
                if(grade < lowGrade){
                    lowGrade = grade;
                }
            }
            return lowGrade;
        }
        //method to get the highest grade added to the gradebook
        public double GetHighGrade(){
            double highGrade = double.MinValue;
            foreach(double grade in grades){
                if(grade > highGrade){
                    highGrade = grade;
                }
            }
            return highGrade;
        }

        public double GetAverageGrade(){
            double averageGrade = 0;
            foreach(double grade in grades){
                averageGrade += grade;
            }
            averageGrade /= grades.Count;
            return averageGrade;
        }

        public void ShowStatistics(){
            Console.WriteLine($"The lowest grade is {this.GetLowGrade()}");
            Console.WriteLine($"The highest grade is {this.GetHighGrade()}");
            Console.WriteLine($"The average grade is {this.GetAverageGrade()}");
        }

        public Statistics GetStatistics(){
            var result = new Statistics();
            result.Average = this.GetAverageGrade();
            result.High = this.GetHighGrade();
            result.Low = this.GetLowGrade();
            return result;
        }

        //FIELDS
        //initialize a grades field, the field is a List data structure
        private List<double> grades;
        private string name;

    }
}