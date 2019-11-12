using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    class Grade
    {
        public Assignment assignment { get; set; }

        public Student student { get; set; }

        public int StudentTotal { get; set; }

        public Grade() { }

        public Grade(Assignment assignment, Student student, int StudentTotal)
        {
            this.assignment = assignment;
            this.student = student;
            this.StudentTotal = StudentTotal;
        }
    }
}
