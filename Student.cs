using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentRainbowSchoolOops
{
    public class Student
    {
        string Name;
        string Class;
        char Section;

        public Student(string Name,string Class,char Section)
        {

            this.Name = Name;
            this.Class = Class;
            this.Section = Section;
        }
        public void Display() {

            Console.WriteLine("Name : \t"+Name);
            Console.WriteLine("Class: \t" + Class);
            Console.WriteLine("Section: \t"+Section);
        }

    }
}
