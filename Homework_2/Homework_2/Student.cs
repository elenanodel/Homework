using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Student
    {
        public string surname;
        public int birth;
        public int group;
        public string faculty;

        public Student()
        {
            surname = "";
            birth = 0;
            group = 0;
            faculty = "";
        }

        public Student(Student student)
        {
            surname = student.surname;
            birth = student.birth;
            group = student.group;
            faculty = student.faculty;
        }

        public Student(string surname, int birth, int group, string faculty)
        {
            this.surname = surname;
            this.birth = birth;
            this.group = group;
            this.faculty = faculty;
        }                
    }
}
