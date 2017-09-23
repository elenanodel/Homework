using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_2_another_way
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool b = true;
            char choice;
            
            Console.WriteLine("");
            Methods methods = new Methods();
            List<Student> studentsList = new List<Student>();
            FileWork fw = new FileWork();

            do
            {
                Console.WriteLine("\nPlease, choose an action: ");
                Console.WriteLine("1. Add new student to database");
                Console.WriteLine("2. Show options for database");
                Console.Write("\nYour choice is: ");
                choice = char.Parse(Console.ReadLine());                

                switch (choice)
                {
                    case '1':
                        {
                            Student student = new Student();
                            Console.Write("\nEnter surname of student: ");
                            student.surname = Console.ReadLine();

                            Console.Write("Enter year of birth of student: ");
                            student.birth = int.Parse(Console.ReadLine());

                            Console.Write("Enter group of student: ");
                            student.group = int.Parse(Console.ReadLine());

                            Console.Write("Enter faculty of student: ");
                            student.faculty = Console.ReadLine();

                            methods.AddStudent(student);

                            Console.WriteLine("\nStudent was created!");
                            student.ShowInfo();
                            Console.WriteLine("--------------------------------------------");

                            break;
                        }
                    case '2':
                        {
                            b = false;
                            continue;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong value! Try again...");
                            break;
                        }
                }
                
            } while (b);

            do
            {                                             
                Console.WriteLine("\n\tChoose an action you wanted to do:");                
                Console.WriteLine("1 - Students list");
                Console.WriteLine("2 - An average age of students");
                Console.WriteLine("3 - Minimum and maximum age of students");
                Console.WriteLine("4 - Sorting by surname");
                Console.WriteLine("5 - Sorting by year of birth");
                Console.WriteLine("6 - Sorting by group");
                Console.WriteLine("7 - Write students to file");
                Console.WriteLine("8 - Read students from file");
                Console.WriteLine("9 - Exit");
                Console.Write("\nYour choice is: ");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        {
                            
                            Student student = new Student();
                            studentsList = methods.StudentsList();
                            foreach (Student students in studentsList)
                            {
                                Console.WriteLine("--------------------------------------------");
                                Console.WriteLine("Surname: " + students.surname);
                                Console.WriteLine("Year of birth: " + students.birth);
                                Console.WriteLine("Group: " + students.group);
                                Console.WriteLine("Faculty:" + students.faculty);
                                Console.WriteLine("--------------------------------------------");
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("An average age of students is: " + methods.AverageAge(methods.StudentsList()));
                            Console.WriteLine("--------------------------------------------");
                            break;
                        }
                     case '3':
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Maximum age of students is: " + methods.MaxAge(methods.StudentsList()));
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Minimum age of students is: " + methods.MinAge(methods.StudentsList()));
                            Console.WriteLine("--------------------------------------------");
                            break;
                        }
                    case '4':
                        {
                            Console.WriteLine("--------------------------------------------");
                            methods.SortingBySurname();
                            Console.WriteLine("--------------------------------------------");
                            break;
                        }
                    case '5':
                        {
                            Console.WriteLine("--------------------------------------------");
                            methods.SortingByYearOfBirth();
                            Console.WriteLine("--------------------------------------------");
                            break;
                        }
                    case '6':
                        {
                            Console.WriteLine("--------------------------------------------");
                            methods.SortingByGroup();
                            Console.WriteLine("--------------------------------------------");
                            break;
                        }

                    case '7':
                        {
                            fw.WriteToFile(studentsList);
                            Console.WriteLine("File was written!");
                            break;
                        }

                    case '8':
                        {

                            break;
                        }
                    case '9':
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong value! Try again...");
                            break;
                        }
                }
            } while (choice != '9');
        }
    }
    public class Student
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
            Console.WriteLine("Surname: {0}. Year of birth: {1}. Group: {2}. Faculty: {3}.", surname, birth, group, faculty);
        }
    }

    public class Methods
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

        public double AverageAge(List<Student> studentsList)
        {
            double result = 0;
            const int year = 2017;

            foreach (Student stud in studentsList)
            {
                result = result + (year - stud.birth) / studentsList.Count;
            }
            return result;
        }
       
        public int MaxAge (List<Student> studentsList)
        {
            
            const int year = 2017;
            int result = year - studentsList[0].birth;

            foreach (Student stud in studentsList)
            {                
                if (result < year - stud.birth)
                {
                    result = year - stud.birth;
                }
            }
            return result;
        }

        public int MinAge(List<Student> studentsList)
        {

            const int year = 2017;
            int result = year - studentsList[0].birth;

            foreach (Student stud in studentsList)
            {
                if (result > year - stud.birth)
                {
                    result = year - stud.birth;
                }
            }
            return result;
        }

        public void SortingBySurname()
        {
            students.Sort((s1, s2) => s1.surname.CompareTo(s2.surname));

            foreach(Student stud in students)
            {
                Console.WriteLine("Student: {0}. Year of birth: {1}. Faculty: {2}. Group: {3}.", stud.surname, stud.birth, stud.faculty, stud.group);
            }
        }

        public void SortingByYearOfBirth()
        {
            students.Sort((s1, s2) => s1.birth.CompareTo(s2.birth));

            foreach(Student stud in students)
            {
                Console.WriteLine("Year of birth: {0}. Student: {1}. Faculty: {2}. Group: {3}.", stud.birth, stud.surname, stud.faculty, stud.group);
            }
        }

        public void SortingByGroup()
        {
            students.Sort((s1, s2) => s1.group.CompareTo(s2.group));

            foreach (Student stud in students)
            {
                Console.WriteLine("Group: {0}. Student: {1}. Year of birth: {2}. Faculty: {3}.", stud.group, stud.surname, stud.birth, stud.faculty);
            }
        }
       
    }

    public class FileWork
    {     
        private const string fileName = "StudentsList.txt";
        public void WriteToFile(List<Student> students)
        {
            StreamWriter sw = new StreamWriter(fileName, true);            
            foreach (Student stud in students)
            {
                sw.WriteLine(stud.surname + "\t" 
                    + stud.birth + "\t" 
                    + stud.group + "\t"
                    + stud.faculty);
            }
            sw.Close();
        }

        public List<Student> ReadFromFile()
        {
            List<Student> result = new List<Student>();
            


            return result;
        }
    }
}
