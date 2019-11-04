using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    class Assignment
    {
        string AssignmentName { get; set; }

        Section section { get; set; }
        int total { get; set; }

        public Assignment(String AssignmentName, int total, Section section)
        {
            this.AssignmentName = AssignmentName;
            this.total = total;
            this.section = section;
        }

        public void PrintAssignmentDetails()
        {
            
           Console.WriteLine( this.AssignmentName + " "+ this.total + " " + this.section.SectionName + " " + this.section.SectionNumber );
            

        }
    }
}
