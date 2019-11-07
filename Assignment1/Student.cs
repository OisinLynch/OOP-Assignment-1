using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Student
    {
        //Properties
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public List<Subject> Subjects { get; set; }

        //Constructors
        public Student(string name, string dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Name: {0} Date of Birth: {1} Subjects: {2}", Name, DateOfBirth, Subjects);
        }

    }
}
