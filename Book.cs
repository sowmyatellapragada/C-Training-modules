using System;
using System.Collections.Generic;
namespace GreatBook
{
    public class Book{
        public Book(string name){
            grades=new List<double>();
            this.name=name;
        }

         public void AddGrade(double grade){
            grades.Add(item: grade);
        }
        

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average=0.0;
            result.highgrade = double.MinValue;
            result.lowgrade = double.MaxValue;
            foreach (var grade in grades)
            {
                
                result.lowgrade = Math.Min(grade, result.lowgrade);
                result.highgrade = Math.Max(grade,result. highgrade);
                result.Average+= grade;
            }
           result.Average /= grades.Count;
           return result;

        }
        private List<double> grades;
        private string name;
    }
}

    