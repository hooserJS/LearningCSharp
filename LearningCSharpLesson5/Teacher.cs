using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Teacher : DevFaculty
    {
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public List<string> Students = new List<string>();
        public List<string> CoursesAttended = new List<string>();

        public Teacher(string firstName, string lastName, int age, string city, string students)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
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

        public void AddStudent(string students)
        {
            Students.Add((students));
        }
        public void RemoveStudent(int studentId)
        {
            int removeIndex = studentId + 1;
            Students.RemoveAt(removeIndex);
        }

        public void GetListOfStudents()
        {
            int i = 1;
            foreach (var student in  Students)
            {
                Console.WriteLine($"Id {i}  {student}");
                Console.WriteLine();
                i++;
            }
        }
        public void GetTotalStudentsNumber()
        {
            Console.WriteLine($"{FirstName} {LastName} has {Students.Count} students.");
        }

        public void AddCours(string coursName)
        {
            CoursesAttended.Add(coursName);
        }
        public void RemoveCourse(int courseId)
        {
            int removeIndex = courseId + 1;
            CoursesAttended.RemoveAt(removeIndex);
        }

        public void GetListOfCourseds()
        {
            int i = 1;
            foreach (var cour in CoursesAttended)
            {
                Console.WriteLine($"Id {i}  {cour}");
                Console.WriteLine();
                i++;
            }
        }
        public void GetTotalCoursesNumber()
        {
            Console.WriteLine($"Teacher has {CoursesAttended.Count} courses.");
        }

            public void Print()
        {
            string TeachersStudentList = "";
            if (Students != null)
            {
                foreach (var cour in Students) { TeachersStudentList = TeachersStudentList + " " + cour; }
            }

            Console.WriteLine($"Teachers FirstName = {FirstName}, LastName = {LastName}, Age = {Age}, City = {City}, Classes :{TeachersStudentList}");
        }

        public override void SubjectDescribe()
        {
            string TeachersStudentList = "";
            if (Students != null)
            {
                foreach (var cour in Students) { TeachersStudentList = TeachersStudentList + " " + cour; }
            }

            Console.WriteLine($"Teachers FirstName = {FirstName}, LastName = {LastName}, Age = {Age}, City = {City}, Classes :{TeachersStudentList}");
        }
    }
}

