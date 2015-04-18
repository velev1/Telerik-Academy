/*
Problem 2. Students and workers
Define abstract class Human with first name and last name. 
 * Define new class Student which is derived from Human and has new field – grade. 
 * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
 * and method MoneyPerHour() that returns money earned by hour by the worker. 
 * Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order 
 * (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
*/
namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsAndWorkersMain
    {
        public static void Main()
        {
            // initialise list of students and sort them by grade, the print all of them
            List<Student> students = new List<Student>();
            AddStudents(students);
            students = students.OrderBy(st => st.Grade).ToList();
            Console.WriteLine("Sorted students:\n");
            Console.WriteLine(string.Join("\n", students.Select(s => string.Format("{0} {1} - {2} {3}", s.FirstName, s.LastName, s.Grade, "grade"))));

            // initialise list of workers and sort them by money per hour, the print all of them
            List<Worker> workers = new List<Worker>();
            AddWOrkers(workers);
            workers = workers.OrderByDescending(wr => wr.MoneyPerHour()).ToList();
            Console.WriteLine("\n\nWorkers sorted by money per hour:\n");
            Console.WriteLine(string.Join("\n", workers.Select(w => string.Format("{0} {1}: {2:C2}/hour", w.FirstName, w.LastName, w.MoneyPerHour()))));
            
            // merge the two list in one List of Human
            var allHumans = new List<Human>();
            allHumans.AddRange(students);
            allHumans.AddRange(workers);

            // order all humans by name and prit them
            allHumans = allHumans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();
            Console.WriteLine("\n\nAll humans sorted by name:\n");
            Console.WriteLine(string.Join("\n", allHumans.Select(a => string.Format("{0} {1}", a.FirstName, a.LastName))));
            Console.WriteLine();
        }

        // method for adding workers
        private static void AddWOrkers(List<Worker> workers)
        {
            workers.Add(new Worker("Stamat", "Stamatov", 300m, 8m));
            workers.Add(new Worker("Izomrud", "Petrov", 200m, 6m));
            workers.Add(new Worker("Kotio", "Zaspalski", 500m, 4m));
            workers.Add(new Worker("Pesho", "Kratunov", 300m, 4m)); 
            workers.Add(new Worker("Todorka", "Polegnalova", 200m, 6m));
            workers.Add(new Worker("Kapka", "Hristova", 200m, 8m));
            workers.Add(new Worker("Kiko", "Hulk", 600m, 4m));
            workers.Add(new Worker("Stamat", "Goshev", 200m, 4.5m));
            workers.Add(new Worker("Pantera", "Kukuvsa", 300m, 2.5m));
            workers.Add(new Worker("Bat", "Sali", 1000m, 0.5m));
        }

        // method for adding students
        private static void AddStudents(List<Student> students)
        {
            students.Add(new Student("Haralampii", "Obretenov", Grade.First));
            students.Add(new Student("Penio", "Penev", Grade.Seventh));
            students.Add(new Student("Pecho", "Ivanov", Grade.Fifth));
            students.Add(new Student("Tencho", "Mencho", Grade.Second));
            students.Add(new Student("Gosho", "Ubavetsa", Grade.Tenth));
            students.Add(new Student("Temenug", "Petrov", Grade.Eight));
            students.Add(new Student("Radka", "Piratka", Grade.Eight));
            students.Add(new Student("Pena", "Gosheva", Grade.Eleventh));
            students.Add(new Student("Sirma", "Mastikova", Grade.Third));
            students.Add(new Student("Petranka", "Tetkova", Grade.Tenth));
        }
    }
}
