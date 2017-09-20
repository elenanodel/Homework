using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Methods
    {
        public List<Student> _students = new List<Student>();     

        public bool AddStudent(Student student)
        {
            try
            {
                _students.Add(new Student(student));
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<Student> StudentsList()
        {
            return _students;
        }
    }
}
