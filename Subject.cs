using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentRainbowSchoolOops
{
    public class Subject:Teacher
    {
     
        string SubjectName;
        string SubjectCode;

        public Subject(string TName, string Class, char sec,string SubjectName,string SubjectCode) : base(TName, Class, sec)
        {
            this.SubjectName = SubjectName;
            this.SubjectCode = SubjectCode;
        }

        public void DisplaySubjectTaught()
        {
            Console.WriteLine("Teacher Name:\t"+TName);
            Console.WriteLine("Subject Taught:\t"+SubjectName);
        }
    }
}
