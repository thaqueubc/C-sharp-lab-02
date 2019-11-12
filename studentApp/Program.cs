using System;
using System.Collections.Generic;

namespace studentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of Student 

            List<Student> Students = new List<Student>();

            Student[] studentArray = new Student[] 
            {
                new Student( "Tasnuva", "Haque","A00000001"),
                new Student("Tasnima", "Haque", "A01457865"),
                new Student("Nuayma", "Rahman","A15546321")
            };

            Students.InsertRange(0, studentArray);

            // Initialize all the classes 

            Section section = new Section("1", "sec-A", Students);
            Assignment Assignment1 = new Assignment("Lab-02");

            //Create a list of Grade for all students
            List<Grade> grades = new List<Grade>();

            Grade[] gradeArray = new Grade[]
            {
                new Grade( Assignment1, Students[1], 19),
                new Grade(Assignment1, Students[0], 20),
                new Grade(Assignment1, Students[2], 15)
            };

            grades.InsertRange(0, gradeArray);

            Assignment1.AssignmentDetails("Lab-02", 20, section, grades);
         
            Printer p = new Printer();

            //Call the methods from Printer class

            p.PrintStudentDetails(section);
            p.PrintAssignmentGrade(Assignment1);
            p.PrintAssignmentStudentGrade(grades[1]);
          
        }
    }
}
