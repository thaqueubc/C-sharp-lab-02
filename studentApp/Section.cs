using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    class Section
    {
        public string SectionNumber { get; set; }
        public string SectionName { get; set; }

        public List<Student> Students { get; set; }

        public Section() { }

        public Section(String SectionNumber, String SectionName, List<Student> Students)
        {
            this.SectionNumber = SectionNumber;
            this.SectionName = SectionName;
            this.Students = Students;
        }


        public void PrintDetails()
        {
            foreach (Student stud in Students)
            {
                Console.WriteLine(this.SectionName + " " + this.SectionNumber + " " + stud.fName+stud.lName );
            }
                            
            
        }

    }
}
