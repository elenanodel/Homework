using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Student student = new Student();
            Methods methods = new Methods();

            List<Student> studentList = new List<Student>();
            do
            {
                Console.WriteLine("\n\tChoose an action you wanted to do:");
                Console.WriteLine("1 - Add student");
                Console.WriteLine("2 - Students list");
                Console.WriteLine("3 - An average age of students");
                Console.WriteLine("4 - Minimum and maximum age of students");
                Console.WriteLine("5 - Sorting by surname");
                Console.WriteLine("6 - Sorting by year of birth");
                Console.WriteLine("7 - Sorting by group");
                Console.WriteLine("8 - Exit");
                Console.WriteLine("\t\t*****");
                Console.Write("\n\tYour choice is: ");
                a = char.Parse(Console.ReadLine());

                switch (a)
                {
                    case '1':
                        {
                            InputStudent();
                            methods.AddStudent(student);
                            break;
                        }
                    case '2':
                        {
                            studentList = methods.StudentsList();
                            foreach (Student stud in studentList)
                            {
                                OutputStudent(student);
                                Console.WriteLine("--------------------------------------------");
                            }
                            break;
                        }
                    case '3':
                        {
                            break;
                        }
                }
            } while (a != '8');
        }
        static Student InputStudent()
        {
            Student student = new Student();

            Console.Write("Enter surname of student: ");
            student.surname = Console.ReadLine();

            Console.Write("Enter year of birth of student: ");
            student.birth = int.Parse(Console.ReadLine());

            Console.Write("Enter group of student: ");
            student.group = int.Parse(Console.ReadLine());

            Console.Write("Enter faculty of student: ");
            student.faculty = Console.ReadLine();

            return student;
        }
        static void OutputStudent(Student student)
        {
            Console.WriteLine("Surname: " + student.surname);
            Console.WriteLine("Year of birth: " + student.birth);
            Console.WriteLine("Group: " + student.group);
            Console.WriteLine("Faculty:" + student.faculty);
        }
    }
}
