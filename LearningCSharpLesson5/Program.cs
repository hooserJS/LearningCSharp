using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jon", "Wick", 41, "LA", "Eng");
            Student student1 = new Student();
            student.AddCours("C#");

            student.Print();
            student1.Print();
        
            Course eng1 = new Course("Eng begginers", "Anna Good", 12);

            eng1.AddStudents(1);
            eng1.PrintCourse();


            //Реализация получилась так себе. Пожалуйста укажите на что обратить внмание и что подтянуть. Благодарю :)
        }
    }
}