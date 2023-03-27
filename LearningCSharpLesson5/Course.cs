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
        public List<string> Students = new List<string>();
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

        public void AddStudentToList(string studentName)
        {
            Students.Add(studentName);
        }

        public void RemoveStudent(int studentId)
        {
            int removeIndex = studentId + 1;
            Students.RemoveAt(removeIndex);
        }

        public void GetListOfStudents()
        {
            int i = 1;
            foreach (var student in Students)
            {
                Console.WriteLine($"Id {i}  {student}");
                Console.WriteLine();
                i++;
            }
        }
        public void GetTotalStudentsNumber()
        {
            Console.WriteLine($"Courde {CourseName} where teacher is {TeacherName} has {Students.Count} students.");
        }

        public void PrintCourse()
        {
            string StudentList = "";
            if (Students.Count != 0)
            {
                foreach (var stud in Students) { StudentList = StudentList + " " + stud; }
            }
            Console.WriteLine($"Course name = {CourseName}, Teacher name = {TeacherName}, Course duration in Months = {CourseDurationM}, Number of students = {NumberOfStudents}, List of students : {StudentList}");
        }
    }
}