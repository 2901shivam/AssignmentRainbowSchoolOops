using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentRainbowSchoolOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Subject> subjects = new List<Subject>();

            List<Student> students = new List<Student>();

            Console.WriteLine("Enter\n 1.Entering and Displaying Student Data \n 2.Entering Teacher Details and Displaying ");


            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{i + 1} Enter Student Name");
                    string studentname = Console.ReadLine();
                    Console.WriteLine($"{i + 1} Enter Student Class");
                    string studenclass = Console.ReadLine();
                    Console.WriteLine($"{i + 1} Enter Studen Section");
                    char studensection = char.Parse(Console.ReadLine());

                    Student student = new Student(studentname, studenclass, studensection);

                    students.Add(student);
                }
                Console.WriteLine("Students Details as follow");
                foreach (Student student in students)
                {
                    student.Display();
                }

            }
            else if (num == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"{i + 1} Enter Teacher Name");
                    string teacherName = Console.ReadLine();
                    Console.WriteLine($"{i + 1} Enter Teacher Class");
                    string teacherClass = Console.ReadLine();
                    Console.WriteLine($"{i + 1} Enter Teacher Section");
                    char teacherSection = char.Parse(Console.ReadLine());
                    Console.WriteLine($"{i + 1} Enter Subject Name");
                    string subjectName = Console.ReadLine();
                    Console.WriteLine($"{i + 1} Enter Subject Code");
                    string subjectCode = Console.ReadLine();


                    Subject subject = new Subject(teacherName, teacherClass, teacherSection, subjectName, subjectCode);


                    subjects.Add(subject);
                }

                Console.WriteLine("Teachers Details as follws");
                foreach (Subject subject in subjects)
                {

                    subject.DisplaySubjectTaught();

                }







            }
            else {

                Console.WriteLine("Ivalid Operations");
            }







            Console.ReadLine();



        }
    }
}
