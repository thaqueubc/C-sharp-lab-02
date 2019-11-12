using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    class Printer
    {
       public void PrintStudentDetails(Section section)
        {
            Console.WriteLine("The list of Student is : ");
            foreach (Student stud in section.Students)
            {
                Console.WriteLine( "Name :" + stud.fName +" " + stud.lName + "ID: "+ stud.student_id);
            }
            Console.WriteLine("\n\n");
        }

        //"Lab-02", 20, section
        public void PrintAssignmentGrade(Assignment assignment)
        {
            //foreach Grade g in assingment.grades){
            //each grade.student, grade.studTotal, "/" assignment.total
            //}
            Console.WriteLine("List of Grades for " + assignment.AssignmentName+ " of "+assignment.section.SectionName+ " is:\n");
            foreach (Grade g in assignment.grades)
            {
                Console.WriteLine(g.student.fName + " has got "+ g.StudentTotal+"/"+assignment.total );
            }

        }

        public void PrintAssignmentStudentGrade(Grade grade)
        {
            Console.WriteLine("\nThe Grade for " + " "+ grade.assignment.AssignmentName + " of "+ grade.student.fName+" "+ grade.student.lName+" is " +
                grade.StudentTotal+"/" + grade.assignment.total);
        }
    }
}
