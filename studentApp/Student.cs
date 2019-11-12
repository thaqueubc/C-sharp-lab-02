using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    class Student
    {
        public string fName { get; set; }
       public string lName { get; set; }

        public string student_id { get; set; }

        public Student() { }

        public Student(String fName, String lName, String student_id)
        {
            this.fName = fName;
            this.lName = lName;
            this.student_id = student_id;
        }


        private string GetFullName()
        {
            return this.fName + " " + this.lName;
        }

        public void PrintName()
        {
            if (!String.IsNullOrEmpty(this.lName))
            {
                Console.WriteLine(GetFullName());
            }
        }
    }
}
