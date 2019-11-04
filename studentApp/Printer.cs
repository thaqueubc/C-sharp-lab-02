using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    class Printer
    {
       public void PrintStudentDetails(Section section)
        {
            foreach(Student stud in section.Students)
            {
                Console.WriteLine( stud.fName + stud.lName);
            }
        }


        
    }
}
