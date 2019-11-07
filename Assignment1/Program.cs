using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Subject objects
            Subject s1 = new Subject("Joe Smith", "Programming Vivion Kinsella", 1);
            Subject s2 = new Subject("Jane Brown", "UX Design Adrian Durcan", 2);
            Subject s3 = new Subject("John Smith", "OOP Keith McManus", 2);
            Subject s4 = new Subject("Jim Smith", "Databases Padraig Harte", 1);

            //Student objects
            Student st1 = new Student("Joe Smith", "21/10/2000");
            Student st2 = new Student("Jane Brown", "15/03/1998");

            //Display Student Details
            Console.WriteLine("Name: {0}", st1.Name);
            Console.WriteLine("Date of Birth: {0}", st1.DateOfBirth);
            Console.WriteLine("{0} Year: {1}", s1.Lecturer, s1.Year);
            Console.WriteLine("{0} Year: {1}", s4.Lecturer, s4.Year);

            Console.WriteLine();

            Console.WriteLine("Name: {0}", st2.Name);
            Console.WriteLine("Date of Birth: {0}", st2.DateOfBirth);
            Console.WriteLine("{0} Year: {1}", s2.Lecturer, s3.Year);
            Console.WriteLine("{0} Year: {1}", s2.Lecturer, s3.Year);

            //Call CalculateAge method
            //CalculateAge();

        }//main

        //Methods
    }
}
