using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();
            student.Name = name;

            Console.Write("Enter Student Roll number : ");
            int rollNumber = int.Parse(Console.ReadLine());
            student.RollNumber = rollNumber;

            Console.Write("Enter Student's CGPA : ");
            double cgpa = double.Parse(Console.ReadLine());
            student.Cgpa = cgpa;

            Console.WriteLine($"The Percentage from {cgpa} CGPA is {student.CalculatePercentage()}%");


        }
    }
}
