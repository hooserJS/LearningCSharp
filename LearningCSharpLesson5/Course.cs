using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDurationM { get; set; }
        public static int NumberOfStudents = 0;

        public Course(string courseName, string teacherName, int courseDurationM)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDurationM = courseDurationM;
        }

        public Course(string courseName, string teacherName) : this(courseName, teacherName, 0)
        {
        }
        public Course(string courseName) : this(courseName, "Default teacher name")
        {
        }
        public Course() : this("Default course name")
        {
        }

        public void AddStudents(int numOfSrudents)
        {
            NumberOfStudents += numOfSrudents;
        }

        public void PrintCourse()
        {
            Console.WriteLine($"Course name = {CourseName}, Teacher name = {TeacherName}, Course duration in Months = {CourseDurationM}, Number of students = {NumberOfStudents}");
        }
    }
}
