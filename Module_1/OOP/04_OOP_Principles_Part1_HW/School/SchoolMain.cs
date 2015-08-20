/*
Problem 1. School classes
We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 * Each teacher teaches a set of disciplines. Students have name and unique class number. 
 * Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
 * Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields,
 * define the class hierarchy and create a class diagram with Visual Studio.
 */
namespace School
{
    using System;
    using System.Collections.Generic;

    public class SchoolMain
    {
        public static void Main(string[] args)
        {
            // creating a list of students
            List<Student> students = new List<Student>();

            // adding some students to it
            AddStudents(students);

            // craating a list of teachers
            List<Teacher> teachers = new List<Teacher>();

            // adding som teachers
            AddTeachers(teachers);

            // creating class
            Class firstClass = new Class("firstClass", students, teachers);

            // printing class with all of its stuff automatically thank to overrites ToString methods for each of the classes
            Console.WriteLine(firstClass);

            // add text ot the first student of the list
            students[0].AddFreeTextMessage("Pesho ubavetsa");

            // print the message
            Console.WriteLine(students[0].FreeTextBox[0]);

            Console.WriteLine();
        }

        public static void AddTeachers(List<Teacher> listOfTeachers)
        {
            listOfTeachers.AddRange(new Teacher[]
                {
                new Teacher("Doncho", "Minkov", new List<Discipline> { new Discipline("hard", 2, 2), new Discipline("hardeeer", 3, 3) }),
                new Teacher("Evlogi", "Hristov", new List<Discipline> { new Discipline("hardest", 4, 2), new Discipline("harderrr", 1, 3) }),
                new Teacher("Ivaylo", "Kenov", new List<Discipline> { new Discipline("harded", 2, 2), new Discipline("hhharder", 7, 3) }),
                new Teacher("Nikolay", "Kostov", new List<Discipline> { new Discipline("haaard", 2, 2), new Discipline("harddder", 3, 3) }),
                });
        }

        public static void AddStudents(List<Student> listOfStudents)
        {
            // the students are initialised only by names, their IDs are generated automatically
            listOfStudents.AddRange(new Student[]
                {
                new Student("Pesho", "Peshev", "shlqp1"),
                new Student("Pesho", "Goshev", "shlqp2"),
                new Student("Stamat", "Petrov",  "shlqp3"),
                new Student("Peguzi", "Muzorski", "shlqp9"),
                new Student("Koko", "Taisana", "shlqp5"),
                new Student("Gosho", "Ubavetsa", "shlqp6")
                });
        }
    }
}
