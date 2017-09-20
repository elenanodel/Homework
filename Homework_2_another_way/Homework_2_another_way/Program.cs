using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_another_way
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool b = true;
            char choice;
            
            Console.WriteLine("\tPlease, add students");
            Student student = new Student();
            Methods methods = new Methods();
            List<Student> studentsList = new List<Student>();

            Console.Write("\nEnter surname of student: ");
            student.surname = Console.ReadLine();

            Console.Write("Enter year of birth of student: ");
            student.birth = int.Parse(Console.ReadLine());

            Console.Write("Enter group of student: ");
            student.group = int.Parse(Console.ReadLine());

            Console.Write("Enter faculty of student: ");
            student.faculty = Console.ReadLine();

            methods.AddStudent(student);

            Console.WriteLine("\nStudent was created: ");
            student.ShowInfo();
            
            do
            {
                Console.WriteLine("\n\tDo you want to create another student?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("\nYour choice is: ");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        {
                            Console.Write("\nEnter surname of student: ");
                            student.surname = Console.ReadLine();

                            Console.Write("Enter year of birth of student: ");
                            student.birth = int.Parse(Console.ReadLine());

                            Console.Write("Enter group of student: ");
                            student.group = int.Parse(Console.ReadLine());

                            Console.Write("Enter faculty of student: ");
                            student.faculty = Console.ReadLine();

                            methods.AddStudent(student);

                            Console.WriteLine("\nStudent was created: ");
                            student.ShowInfo();
                            break;
                        }
                    case '2':
                        {
                            b = false;
                            continue;
                        }
                    default:
                        {
                            Console.WriteLine("\n\tYou entered wrong symbol!");
                            break;
                        }
                }
                
            } while (b);

            do
            {
                b = false;
                Console.WriteLine("\n\tChoose an action you wanted to do:");                
                Console.WriteLine("1 - Students list");
                Console.WriteLine("2 - An average age of students");
                Console.WriteLine("3 - Minimum and maximum age of students");
                Console.WriteLine("4 - Sorting by surname");
                Console.WriteLine("5 - Sorting by year of birth");
                Console.WriteLine("6 - Sorting by group");
                Console.WriteLine("7 - Exit");
                Console.Write("\nYour choice is: ");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        {
                            studentsList = methods.StudentsList();
                            foreach (Student students in studentsList)
                            {
                                Console.WriteLine("Surname: " + student.surname);
                                Console.WriteLine("Year of birth: " + student.birth);
                                Console.WriteLine("Group: " + student.group);
                                Console.WriteLine("Faculty:" + student.faculty);
                                Console.WriteLine("--------------------------------------------");
                            }
                            break;
                        }
                    case '2':
                        {
                            break;
                        }
                    case '3':
                        {
                            break;
                        }
                    case '4':
                        {
                            break;
                        }
                    case '5':
                        {
                            break;
                        }
                    case '6':
                        {
                            break;
                        }
                }
            } while (b);

            Console.ReadLine();
        }
    }
    class Student
    {
        protected string _surname;
        protected int _birth;
        protected int _group;
        protected string _faculty;

        public Student()
        {
            surname = "";
            birth = 0;
            group = 0;
            faculty = "";
        }

        public Student(string surname, int birth, int group, string faculty)
        {
            this.surname = surname;
            this.birth = birth;
            this.group = group;
            this.faculty = faculty;
        }

        public string surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int birth
        {
            get { return _birth; }
            set { _birth = value; }
        }

        public int group
        {
            get { return _group; }
            set { _group = value; }
        }

        public string faculty
        {
            get { return _faculty; }
            set { _faculty = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2} {3}", surname, birth, group, faculty);
        }
    }

    class Methods
    {
        List<Student> students = new List<Student>();

        public void AddStudent (Student student)
        {
            students.Add(student);
        }

        public List<Student> StudentsList()
        {
            return students;
        }
    }
}
