using System.Collections.Generic;

namespace GradeBook{
    public class Book{
        //Constructor method (needs to have the same name as the class)
        public Book(string name){
            grades = new List<double>();
            //this is optional it just indicates we are using a field from the class and not the parameter
            this.Name = name;
        }

        //methods
        public void AddGrade(double grade){
            if(grade <= 100 && grade >=0){
                grades.Add(grade);
            }
            else{
                //Console.WriteLine("Invalid value");
                //throw exceptioni
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
            
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

        //Statistics return type is a type that I created
        public Statistics GetStatistics(){
            var result = new Statistics();
            result.Average = this.GetAverageGrade();
            result.High = this.GetHighGrade();
            result.Low = this.GetLowGrade();
            return result;
        }

        //this method is faster because it only loops through the list of grades once
        public Statistics GetStatisticsAlternate(){
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;

            //do while loop
            do{
                //break; breaks you out of the whole loop next line is 92
                //continue; skips rest of loop and continues iteration
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                index++;
            }while(index < grades.Count);

            //while loop
            //while(index < grades.Count){};
            //for loop
            //for(var index = 0; index < grades.Count; index++){};
            //foreach is most common loop

            result.Average /= grades.Count;

            return result;
        }

        //Using switch statements
        public void AddLetterGrade(char letter){
            switch(letter){
                //single quotes denote chars
                //C# compiler makes you manually control breaks for switch statements
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                case 'F':
                    AddGrade(50);
                    break;
                
                default:
                    AddGrade(0);
                    break;
            }
        }

        //FIELDS
        //initialize a grades field, the field is a List data structure
        private List<double> grades;
        public string Name;

    }
}