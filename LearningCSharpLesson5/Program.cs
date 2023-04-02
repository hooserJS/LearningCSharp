using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using OOP;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jon", "Wick", 41, "LA", "Eng");
            Student student1 = new Student("Mickal", "Hosek", 38, "NY", "C#");
            Teacher techer = new Teacher("Maria", "Petrova", 28, "ZT", "Andriy");
            Teacher techer1 = new Teacher("Anna", "Ulinova", 25, "KH", "Oleg");

            var teachers = new List<Teacher>() { techer, techer1 };
            var students = new List<Student>() { student, student1 };
            
            string teacherName = "";
            string studentName = "";
            string searchChoise = "";
            
            try
            {
                Console.WriteLine("Who want you search for? Student or teacher?");
                searchChoise = (Console.ReadLine()).ToLower();
                if(searchChoise == "")
                {
                throw new Exception("You didn't choose a victim.");
                }
            }
            catch (Exception ex) { 
            Console.WriteLine(ex.Message);
            }

            if (searchChoise == "teacher")
            {
                Console.WriteLine($"Please enter the {searchChoise} name:");
                teacherName = Console.ReadLine();
                Console.WriteLine("We've found the following teacher(s):");
                FindTeacherByName(teacherName, teachers);

            }
            else if (searchChoise == "student")
            {
                Console.WriteLine($"Please enter the {searchChoise} name:");
                studentName = Console.ReadLine();
                Console.WriteLine("We've found the following student(s):");
                FindStudentByName(studentName, students);
            }

            void FindTeacherByName(string teacherName, List<Teacher> teachersList)
            {
                var teachersLinq = teachersList.Where(x => ((x.FirstName).ToLower()).Contains(teacherName));
                foreach (var teacher in teachersLinq)
                {
                    Console.WriteLine($"{teacher.FirstName}, {teacher.LastName}, {teacher.Age}");
                }
            }
            void FindStudentByName(string studentName, List<Student> studentList)
            {
                var studentsLinq = studentList.Where(x => ((x.FirstName).ToLower()).Contains(studentName));
                foreach (var student in studentsLinq)
                {
                    Console.WriteLine($"{student.FirstName}, {student.LastName}, {student.Age}");
                }
            }

        }
    }
}