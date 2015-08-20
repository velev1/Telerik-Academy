/*
Problem 1. Student class
Define a class Student, which contains data about a student – first, middle and last name, 
 SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
 Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

Problem 2. IClonable
Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's 
 fields into a new object of type Student.
 
Problem 3. IComparable
Implement the IComparable<Student> interface to compare students by names (as first criteria, 
 in lexicographic order) and by social security number (as second criteria, in increasing order).
*/

namespace StudentClass
{
    using System;

    public class StudentClassMain
    {
        public static void Main()
        {
            // initaialise two students - the ususal suspects - Pesho and Gosho
            Student pesho = new Student("Pesho", "Peshev", "Peshev", "2036984", "15 Peshova dolina str., Peshov Dol", 
                "+35988800800", "pesho@pesho.ph", "Nekaf kurs", Specialty.SomeSPecialityOne, University.SomeUniversityOne, Faculty.SomeFacultyOne);

            Student gosho = new Student("Gosho", "Goshev", "Goshev", "3058520", "10 Goshova livada str, Gohotown", 
                "+35989900900", "gosho@gosho.com", "Drug kurs", Specialty.SomeSpecialityTwo, University.SomeUniversityTwo, Faculty.SOmeFacultyTwo);

            // Print them to consol to check override of ToString() method
            Console.WriteLine("Pesho");
            Console.WriteLine(pesho);
            Console.WriteLine("\nGosho");
            Console.WriteLine(gosho);

            // Make a deep copy of Gosho
            Student clonedGosho = (Student)gosho.Clone();
            Console.WriteLine("\nCloned gosho:");
            Console.WriteLine(clonedGosho);

            // Change the first name og Cloned Gosho and print it and the original one
            clonedGosho.FirstName = "Izomrud";
            Console.WriteLine("\nCloned gosho with changed first name:");
            Console.WriteLine(clonedGosho);
            Console.WriteLine("\nGosho again to check if the clone is deep:");
            Console.WriteLine(gosho);

            // chesk the overridin of Equal()
            Console.WriteLine("\nCheck Equal gosho ang pesho");
            Console.WriteLine(pesho.Equals(gosho));

            // Print hash codes 
            Console.WriteLine("\nPrint hach codes of gosho and pesho:");
            Console.WriteLine(pesho.GetHashCode());
            Console.WriteLine(gosho.GetHashCode());
            Console.WriteLine(clonedGosho.GetHashCode());

            // Compare Gosho to Pesho
            Console.WriteLine("\nPrint result of compare gosho to pesho: ");
            Console.WriteLine(gosho.CompareTo(pesho));
        }
    }
}
