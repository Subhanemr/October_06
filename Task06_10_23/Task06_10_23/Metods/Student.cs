using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_10_23.Metods
{
    public class Student
    {
        //Task 1
        public string Name { get; }
        public string Surname { get; }
        public string Group { get; }
        public int Point { get; }
        public bool isGraduated { get; }

        public Student(string name)
        {
            Name = name;
        }

        public Student(string name, string surname): this(name)
        {
            Surname = surname;
        }
        public Student(string name, string surname, string group): this(name, surname)
        {
            Group = group;
        }
        public Student(string name, string surname, string group, int point): this(name, surname, group)
        {
            Point = point;
            isGraduated = (point >= 65);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Group: {Group}");
            Console.WriteLine($"Point: {Point}");
            Console.WriteLine($"isGraduated: {isGraduated}");
        }

        public void CheckGraduation()
        {
            if (isGraduated)
            {
                Console.WriteLine($"{Name} {Surname} has graduated.");
            }
            else
            {
                Console.WriteLine($"{Name} {Surname} has not graduated.");
            }
        }

        public void GetDiplomaDegree()
        {
            string diplomaDegree;
            if (Point < 65)
            {
                diplomaDegree = "Absent";
            }
            else if (Point >= 65 && Point < 80)
            {
                diplomaDegree = "Ordinary";
            }
            else if (Point >= 80 && Point < 90)
            {
                diplomaDegree = "Honor";
            }
            else
            {
                diplomaDegree = "High Honor";
            }

            Console.WriteLine($"{Name} {Surname} has a {diplomaDegree} diploma.");
        }
    }


}

