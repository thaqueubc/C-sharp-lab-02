using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    class Grade
    {
        Assignment assignment { get; set; }

        Student student { get; set; }

        int StudentTotal { get; set; }

        public Grade() { }

        public Grade(Assignment assignment, Student student, int StudentTotal)
        {
            this.assignment = assignment;
            this.student = student;
            this.StudentTotal = StudentTotal;

        }
    }
}
