using System;
using System.Collections.Generic;

namespace studentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student tasnuva = new Student("A01128765", "tasnuva", "haque");
            List<Student> Students = new List<Student>();

            Student[] studentArray = new Student[] 
            {
                new Student("A00000001", "Tasnuva", "Haque"),
                new Student("A01457865", "Tasnima", "Haque"),
                new Student("A15546321", "Nuayma", "Rahman")
            };

            Students.InsertRange(0, studentArray);

            Section section = new Section("1", "sec-A", Students);

           // section.PrintDetails();

            Assignment Assignment1 = new Assignment("Lab-02", 20, section);

           // Assignment1.PrintAssignmentDetails();

            Printer p = new Printer();

            p.PrintStudentDetails(section);
            

        }
    }
}
