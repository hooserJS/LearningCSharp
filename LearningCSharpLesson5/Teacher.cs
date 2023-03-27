using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Teacher : DevFaculty
    {
        public override string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public List<string> Classes = new List<string>();

        public Teacher(string firstName, string lastName, int age, string city, string classes)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            Classes.Add(classes);
        }
        public Teacher(string firstName, string lastName, int age, string city) : this(firstName, lastName, age, city, "")
        {
        }
        public Teacher(string firstName, string lastName, int age) : this(firstName, lastName, age, "Not defined")
        {
        }
        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0)
        {
        }
        public Teacher(string firstName) : this(firstName, "Not defined")
        {
        }
        public Teacher() : this("Not defined")
        {
        }

        public void AddCours(string coursName)
        {
            Classes.Add(coursName);
        }

        public void Print()
        {
            string TeacherClassList = "";
            if (Classes != null)
            {
                foreach (var cour in Classes) { TeacherClassList = TeacherClassList + " " + cour; }
            }

            Console.WriteLine($"Teachers FirstName = {FirstName}, LastName = {LastName}, Age = {Age}, City = {City}, Classes :{TeacherClassList}");
        }

        public override void SubjectDescribe()
        {
            string TeacherClassList = "";
            if (Classes != null)
            {
                foreach (var cour in Classes) { TeacherClassList = TeacherClassList + " " + cour; }
            }

            Console.WriteLine($"Teachers FirstName = {FirstName}, LastName = {LastName}, Age = {Age}, City = {City}, Classes :{TeacherClassList}");
        }
    }
}

