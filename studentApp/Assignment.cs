using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    class Assignment
    {
        public string AssignmentName { get; set; }

        public Section section { get; set; }
        public int total { get; set; }

        public List<Grade> grades { get; set; }

        public Assignment() { }

        public Assignment(String AssignmentName)
        {
            this.AssignmentName = AssignmentName;
        }
        public void AssignmentDetails(String AssignmentName, int total, Section section, List<Grade> grades)
        {
            this.AssignmentName = AssignmentName;
            this.total = total;
            this.section = section;
            this.grades = grades;
        }

        public void PrintAssignmentDetails()
        {
           
           //foreach (Grade g in grades) {
           //     Console.WriteLine("Grade: " + g.StudentTotal);
           //}
            
          Console.WriteLine( this.AssignmentName + " "+ this.total + " " + this.section.SectionName + " " + this.section.SectionNumber );

        }
    }
}
