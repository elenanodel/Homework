using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
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
            char a;
            int count;
            double average = 0;
            const int year = 2017;
            int age;
            int maxAge = 0;
            int minAge = 0;


            Console.WriteLine("There is the program when you can create a list of students. After that this program shows you information about your students from your choice: displays list of students, average age of studets, minimum and maximum age of students. Also this program can sort students by surname, year of birth, group and faculty. Enjoy!");
            Console.WriteLine();

            Console.Write("Please, enter count of students: ");
            count = int.Parse(Console.ReadLine());
            Student[] students = new Student[count];

            Console.WriteLine();
            Console.WriteLine("Enter information about  students.");

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

            do
            {
                Console.WriteLine("\nChoose an action you wanted to do:");
                Console.WriteLine("1 - Students list");
                Console.WriteLine("2 - An average age of students");
                Console.WriteLine("3 - Minimum and maximum age of students");
                Console.WriteLine("4 - Sorting by surname");
                Console.WriteLine("5 - Sorting by year of birth");
                Console.WriteLine("6 - Sorting by group");
                Console.WriteLine("7 - Exit");
                Console.Write("\nYour choise is: ");
                a = char.Parse(Console.ReadLine());

                //  List of students
                if (a == '1')
                {
                    Console.WriteLine("\nStudents list");
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.Write("\n" + (i + 1) + ". ");
                        Console.WriteLine("Surname: " + students[i].surname);
                        Console.WriteLine("Year of birth: " + students[i].birth);
                        Console.WriteLine("Group: " + students[i].group);
                        Console.WriteLine("Faculty:" + students[i].faculty);
                    }
                }

                //  Average age of students 
                if (a == '2')
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        age = year - students[i].birth;
                        average += age;
                    }
                    average = average / students.Length;
                    Console.WriteLine("An average age of students is: " + average);
                }

                //  Min and max age of students
                if (a == '3')
                {
                    maxAge = year - students[0].birth;
                    for (int i = 0; i < students.Length; i++)
                    {
                        age = year - students[i].birth;
                        if (maxAge < age)
                        {
                            maxAge = age;
                        }
                    }

                    minAge = year - students[0].birth;
                    for (int i = 0; i < students.Length; i++)
                    {
                        age = year - students[i].birth;
                        if (minAge > age)
                        {
                            minAge = age;
                        }
                    }
                    Console.WriteLine("Maximum age of students is: {0}", maxAge);
                    Console.WriteLine("Minimum age of students is: {0}", minAge);
                }

                //  Sorting students by surname
                if (a == '4')
                {
                    Array.Sort(students, (x, y) => String.Compare(x.surname, y.surname));
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.WriteLine("Student: {0}, year of birth: {1}, faculty: {2}, group: {3}", students[i].surname, students[i].birth, students[i].faculty, students[i].group);
                    }
                }

                //  Sorting students by year of birth
                if (a == '5')
                {
                    Student temp;
                    for (int i = 0; i < students.Length; i++)
                    {
                        for (int j = 0; j < students.Length - 1; j++)
                        {
                            if (students[j].birth > students[j + 1].birth)
                            {
                                temp = students[j + 1];
                                students[j + 1] = students[j];
                                students[j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Sorting by year of birth: ");
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.WriteLine("Year of birth: {0}, student: {1}, faculty: {2}, group: {3}", students[i].birth, students[i].surname, students[i].faculty, students[i].group);
                    }

                }

                //  Sorting students by group
                if (a == '6')
                {
                    Student temp;
                    for (int i = 0; i < students.Length; i++)
                    {
                        for (int j = 0; j < students.Length; j++)
                        {
                            if (students[i].group > students[j].group)
                            {
                                temp = students[i];
                                students[i] = students[j];
                                students[j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Sorting by group: ");
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.WriteLine("Group: {0}, student: {1}, year of birth: {2}, faculty: {3}, ", students[i].group, students[i].surname, students[i].birth, students[i].faculty);
                    }
                }
            } while (a != '7');
            Console.ReadLine();
        }
    }
}
