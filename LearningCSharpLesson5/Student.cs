using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{   
    class Student : DevFaculty
    {
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public List<string> CoursesAttended = new List<string>();

        public Student(string firstName, string lastName, int age, string city, string coursesAttended)
        {  
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            CoursesAttended.Add(coursesAttended);
        }
        public Student(string firstName, string lastName, int age, string city) : this(firstName, lastName, age, city, "")
        {
        }
        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, "Not defined")
        {
        }
        public Student(string firstName, string lastName) : this(firstName, lastName, 0)
        {
        }
        public Student(string firstName) : this(firstName, "Not defined")
        {
        }
        public Student() : this("Not defined")
        {
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
            Console.WriteLine($"Student has {CoursesAttended.Count} courses.");
        }
        public void Print()
        {
            string StudentCoursList = "";
            if(CoursesAttended != null)
            {
                foreach (var cour in CoursesAttended) { StudentCoursList = StudentCoursList + " " + cour; }
            }

            Console.WriteLine($"Students FirstName = {FirstName}, LastName = {LastName}, Age = {Age}, City = {City}, CoursesAttended :{StudentCoursList}");
        }

        public override void SubjectDescribe()
        {
            string StudentCoursList = "";
            if (CoursesAttended != null)
            {
                foreach (var cour in CoursesAttended) { StudentCoursList = StudentCoursList + " " + cour; }
            }

            Console.WriteLine($"Students FirstName = {FirstName}, LastName = {LastName}, Age = {Age}, City = {City}, CoursesAttended :{StudentCoursList}");
        }
    }
}
