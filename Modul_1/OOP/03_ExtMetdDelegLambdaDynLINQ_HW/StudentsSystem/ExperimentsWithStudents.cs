namespace StudentsSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExperimentsWithStudents
    {
        // I know that this is anti КПК but I tried to make it easyer for review
        static void Main()
        {
            // Problem 9. Student groups
            // Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
            // Select <Student> and prss F12 to finde the class Student
            List<Student> students = AddStudents();

            // print all students as added initialy
            Console.WriteLine("All students: \n");
            PrintAllStudentInCollection(students);


            // Problem 3. First before last
            // Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            // Use LINQ query operators.
            // F12 on Problem3FirstBeforeLast
            var studentsWithFirstNamesBeforLast = Problem3FirstBeforeLast(students);

            // print selected students for problem 3
            Console.WriteLine("Problem 3. First before last: \n");
            PrintAllStudentInCollection(studentsWithFirstNamesBeforLast);


            // Problem 4. Age range
            // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            // F12 on Problem4AgeRange
            var studentsAgeRange = Problem4AgeRange(students);

            // print selected students for problem 4
            Console.WriteLine("Problem 4. Age range \n");
            PrintAllStudentInCollection(studentsAgeRange);


            // Problem 5. Order students
            // Using the extension methods OrderBy() and ThenBy() with lambda expressions 
            // sort the students by first name and last name in descending order.
            // Rewrite the same with LINQ.
            // F12 on Problem5StudentsByNameLINQ
            var sortStudentsByNameLambda = Pproblem5StudentsByNameLambda(students);

            // print selected students for problem 5 (Lambda) / F12 on Problem5StudentsByNameLINQ/
            Console.WriteLine("Problem 5. Age range - Lambda \n");
            PrintAllStudentInCollection(sortStudentsByNameLambda);

            // F12 on Problem5StudentsByNameLINQ 
            var sortStudentsByNameLinqQuery = Problem5StudentsByNameLINQ(students);

            Student[] rgkerg = sortStudentsByNameLinqQuery.ToArray();
             // print selected students for problem 5 (LINQ query)
            Console.WriteLine("Problem 5. Age range - LINQ query \n");
            PrintAllStudentInCollection(sortStudentsByNameLinqQuery);


            // Problem 9.
            // Select only the students that are from group number 2.
            // Use LINQ query. Order the students by FirstName.
            // F12 on Problem9StudentsFromGroupTwo
            var studentsFromGroupTwo = Problem9StudentsFromGroupTwo(students);

            // print selected students for problem 9
            Console.WriteLine("Problem 9. Student from group 2 \n");
            PrintAllStudentInCollection(studentsFromGroupTwo);


            // Problem 10. Student groups extensions
            // Implement the previous using the same query expressed with extension methods.

            var studentsFromGroupTwoLambda = students.
                Where(st => st.Group.GroupNumber == 2).
                ToList();

            // print selected students for problem 10
            Console.WriteLine("Problem 10. Student from group 2 (extension methods) \n");
            // other way to print all of selected students
            studentsFromGroupTwoLambda.ForEach(st => Console.WriteLine(st));


            // Problem 11. Extract students by email
            // Extract all students that have email in abv.bg.
            // Use string methods and LINQ.

            var StudentsByEmail = (
                from st in students
                where st.Email.IndexOf("abv.bg") != -1
                select st).ToList();

            // print selected students for problem 11
            Console.WriteLine("Problem 11. Student with email in abv.bg \n");
            StudentsByEmail.ForEach(st => Console.WriteLine(st));


            // Problem 12. Extract students by phone
            // Extract all students with phones in Sofia.
            // Use LINQ.

            var studentsFromSofia = (
                from st in students
                where st.Tel.IndexOf("+3592") != -1
                select st).ToList();

            // print selected students for problem 12
            Console.WriteLine("Problem 12. Student with Sofia phone numbers \n");
            studentsFromSofia.ForEach(st => Console.WriteLine(st));


            // Problem 13. Extract students by marks
            // Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            // Use LINQ.

            var excellents = (
                from st in students
                where st.Marks.Contains(6.0)
                select new { FullName = st.FirstName + " " + st.LastName, 
                    Marks = st.Marks }).ToList();

            // print selected students for problem 13
            Console.WriteLine("Problem 13. Excellents \n");
            excellents.ForEach(st => Console.WriteLine("{0}, {1}", st.FullName, string.Join(", ", st.Marks)));


            // Problem 14. Extract students with two marks
            // Write down a similar program that extracts the students with exactly two marks "2".
            // Use extension methods.

            var loosers = students.Where(st => st.Marks.FindAll(m => m == 2.0).Count() == 2).
                Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks }).
                ToList();

            // print selected students for problem 14
            Console.WriteLine("\nProblem 14. Loosers \n");
            loosers.ForEach(st => Console.WriteLine("{0}, {1}", st.FullName, string.Join(", ", st.Marks)));


            // Problem 15. Extract marks
            // Extract all Marks of the students that enrolled in 2006. 
            // (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            var marks2006 = students.
                 Where(st => st.FN.ToString().IndexOf("06", 4) == 4).
                 Select(m => m.Marks).ToList().SelectMany(x => x).ToList();

          
            Console.WriteLine("\nProblem 15. Marks 2006");
            Console.WriteLine(string.Join(", ", marks2006));

            // Problem 16.* Groups

            // Create a class Group with properties GroupNumber and DepartmentName.
            // Introduce a property GroupNumber in the Student class.
            // Extract all students from "Mathematics" department.
            // Use the Join operator

            var mathematicians = students.Where(st => st.Group.DepartmentName == Departments.Matematics).ToList();

            // printing problem 16
            Console.WriteLine("\nProblem 16. Mathematicians:\n");
            mathematicians.ForEach(st => Console.WriteLine(st));

            // Problem 18. Grouped by GroupNumber
            // Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            // Use LINQ.

            var grouedByGroupNumber = (
                from st in students
                orderby st.Group.GroupNumber
                group st by st.Group.GroupNumber
                into groups
                select new
                {
                    Group = groups.Key,
                    Students = groups.ToList()
                })
                .ToList();

            // printing prblem 18
            Console.WriteLine("\nProblem 18. Groups by number:\n");
            grouedByGroupNumber.ForEach(gr => Console.WriteLine(
                string.Format("Group {0}: \nStudents: \n{1}",
                gr.Group, string.Join("\n", gr.Students))));


            // Problem 19. Grouped by GroupName extensions
            // Rewrite the previous using extension methods.

            var groupedByGroupName = students.GroupBy(st => st.Group.DepartmentName).OrderBy(gr => gr.Key.ToString()).ToList();

            // printing prblem 19
            Console.WriteLine("\nProblem 19. Groups by name:\n");
            groupedByGroupName.ForEach(gr => Console.WriteLine(
                string.Format("Group {0}: \nStudents: \n{1}",
                gr.Key, string.Join("\n", gr))));

            

        }

        private static List<Student> Problem9StudentsFromGroupTwo(List<Student> students)
        {
            var studentsFromGroupTwo =
                (from st in students
                where st.Group.GroupNumber == 2
                orderby st.FirstName
                select st).ToList();
            return studentsFromGroupTwo;
        }

        private static IOrderedEnumerable<Student> Problem5StudentsByNameLINQ(List<Student> students)
        {
            var sortStudentsByNameLinqQuery =
                from st in students
                orderby st.FirstName descending,
                st.LastName descending
                select st;
            return sortStudentsByNameLinqQuery;
        }

        private static IOrderedEnumerable<Student> Pproblem5StudentsByNameLambda(List<Student> students)
        {
            var sortStudentsByNameLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
            return sortStudentsByNameLambda;
        }

        private static IEnumerable<Student> Problem4AgeRange(List<Student> students)
        {
            var studentsAgeRange =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st;
            return studentsAgeRange;
        }

        private static IEnumerable<Student> Problem3FirstBeforeLast(List<Student> students)
        {
            var studentsWithFirstNamesBeforLast =
                from st in students
                where st.FirstName.CompareTo(st.LastName) == -1
                select st;

            return studentsWithFirstNamesBeforLast;
        }

        static void PrintAllStudentInCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        // adding smoe students into the system
        # region AddStudents
        static List<Student> AddStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student(
                "Pesho",
                "Pesev",
                new DateTime(1987, 5, 5),
                666006,
                "+359266699",
                "pesho@pesho.ph",
                new List<double> {2.0, 3.5, 4.0, 2.0},
                2,
                Departments.Matematics),

                new Student(
                "Gosho",
                "Goshev",
                new DateTime(1990, 2, 2),
                999006,
                "+3592999555",
                "gosho@gosho.gh",
                new List<double> {3.0, 5.5, 6.0, 2.5},
                2,
                Departments.Matematics
                ),

                new Student(
                "Gosho",
                "Petrov",
                new DateTime(1995, 6, 6),
                777007,
                "+3595588888",
                "goshoAitosa@abv.bg",
                new List<double> {2.0, 2.5, 2.0, 2.5},
                3,
                Departments.Software),

                new Student(
                "Stamat",
                "Stamatov",
                new DateTime(1999, 12, 5),
                851006,
                "+35952999555",
                "stamat@ihoo.bg",
                new List<double> {6.0, 5.5, 6.0, 6.0},
                2,
                Departments.Matematics),

                new Student(
                "Zamund",
                "Arenov",
                new DateTime(1992, 3, 3),
                359005,
                "+359358417117",
                "seeder@magnet.ru",
                new List<double> {4.0, 4.5, 4.0, 6.0},
                1,
                Departments.Science),

                new Student(
                "Ancung",
                "Pernishki",
                new DateTime(2000, 2, 2),
                760008,
                "+359768888",
                "adifnas@vinkel.pk",
                new List<double> {2.0, 2.5},
                1,
                Departments.Science),
            };

            return students;
        }

        # endregion
    }
}
