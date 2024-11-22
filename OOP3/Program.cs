using OOP3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "A", 11),
                new Student(2, "B", 17),
                new Student(3, "C", 13),
                new Student(4, "D", 19),
                new Student(5, "E", 15),
            };

            Console.WriteLine("List of all students:");
            students.ForEach(x => x.Show());

            Console.WriteLine("\nStudents aged between 15 and 18:");
            var ls15to18 = students.Where(x => x.Age >= 15 && x.Age <= 18).ToList();
            ls15to18.ForEach(x => x.Show());

            Console.WriteLine("\nStudents whose names start with 'A':");
            var lsA = students.Where(x => x.Name.StartsWith("A")).ToList();
            lsA.ForEach(x => x.Show());

            int totalAge = students.Sum(x => x.Age);
            Console.WriteLine($"\nTotal age of all students: {totalAge}");

            Console.WriteLine("\nStudent with the highest age:");
            var oldestStudent = students.OrderByDescending(x => x.Age).FirstOrDefault();
            oldestStudent?.Show();

            Console.WriteLine("\nStudents sorted by age (ascending):");
            var sortedStudents = students.OrderBy(x => x.Age).ToList();
            sortedStudents.ForEach(x => x.Show());

            Console.ReadLine();
        }
    }
}
