using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        struct Student
        {
            public string surname;
            public int birth;
            public int group;
            public string faculty;
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            Console.WriteLine("Enter information about 5 students.");

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("\nEnter surname of {0} student: ", i + 1);
                students[i].surname = Console.ReadLine();

                Console.Write("Enter year of birth of {0} student: ", i + 1);
                students[i].birth = int.Parse(Console.ReadLine());

                Console.Write("Enter group of {0} student: ", i + 1);
                students[i].group = int.Parse(Console.ReadLine());

                Console.Write("Enter faculty of {0} student: ", i + 1);
                students[i].faculty = Console.ReadLine();
            }

            Console.WriteLine("\nChoose an action you wanted to do:");
            Console.WriteLine("1 - Students list");
            Console.WriteLine("2 - An average age of students");
            Console.WriteLine("3 - Minimum and maximum age of students");
            Console.WriteLine("4 - Sorting by surname");
            Console.WriteLine("5 - Sorting by year of birth");
            Console.WriteLine("6 - Sorting by group");
            Console.WriteLine("7 - Exit");
            Console.Write("\nYour choise is: ");
            char a = char.Parse(Console.ReadLine());

            if(a == '1')
            {
                Console.WriteLine("\nStudents list");
                for (int i = 0; i < students.Length; i++)
                {
                    Console.Write("\n" + (i + 1) + ". ");
                    Console.WriteLine("Surname: "+ students[i].surname);
                    Console.WriteLine("Year of birth: " + students[i].birth);
                    Console.WriteLine("Group: " + students[i].group);
                    Console.WriteLine("Faculty:" + students[i].faculty);
                }
            }
            if (a == '2')
            {
                for (int i = 0; i < students.Length; i++)
                {
                    const int year = 2017;
                    int age = year - students[i].birth;
                    double average = 
                }                        
                Console.WriteLine("An average age of students is: " + );
            }

            Console.ReadLine();
        }
    }
}
