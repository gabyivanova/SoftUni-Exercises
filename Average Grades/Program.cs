using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrades { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var name = input[0];
                var grades = input.Skip(1).Select(double.Parse).ToList();
                Student student = new Student();

                student.Name = name;
                student.Grades = grades;

                students.Add(student);

                var avgGrades = grades.Average();

                if (avgGrades >= 5.00)
                {
                    student.AverageGrades = avgGrades;
                }
                else
                {
                    students.Remove(student);
                }
            }

            students = students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrades).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrades:f2}");
            }
        }
    }
}
