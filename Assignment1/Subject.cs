using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Subject
    {
        //Prpoerties
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year { get; set; }

        //Constructors
        public Subject(string name, string lecturer, int year)
        {
            Name = name;
            Lecturer = lecturer;
            Year = year;
        }

        public Subject(string name, string lecturer) : this(name, lecturer, 1)
        {

        }

        public Subject() : this("", "", 1) { }

        //Methods
        public override string ToString()
        {
            return string.Format("Name: {0} Lecturer: {1} Year: {2}", Name, Lecturer, Year);
        }
    }
}
