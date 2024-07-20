using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulationProject
{
    internal class Student
    {
        private int _rollNumber;
        private string _name;
        private double _cgpa;
        public const double CGPA_CONVERTER = 9.5;

        public int RollNumber
        {
            get { return _rollNumber; }

            set
            {
                if (value > 0)
                {
                    _rollNumber = value;
                }
                else
                {
                    Console.WriteLine("Roll number should be positive only.");
                }
            }
        }

        public string Name
        {
            get { return _name; }

            set
            {
                if (value.Length <= 5)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name should be only of 5 characters only");
                }
            }
        }

        public double Cgpa
        {
            get { return _cgpa; }
            set
            {
                if (value > 0 && value < 10)
                {
                    _cgpa = value;
                }
                else
                {
                    Console.WriteLine("CGPA must be between 1 to 10");
                }

            }
        }

        public double CalculatePercentage()
        {
            double percentage = this._cgpa * CGPA_CONVERTER;
            return percentage;
        }
    }
}
