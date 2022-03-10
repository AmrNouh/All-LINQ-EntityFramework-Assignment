using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLAb
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] subjects { get; set; }
    }

    class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            //Query01
            //var query01 = numbers.Where(i => numbers.FindAll(x => x == i).ToList().Count() == 1).OrderBy(x => x);
            var query01 = numbers.Distinct().OrderBy(x => x);

            Console.WriteLine("----- Query01 -----");
            foreach (var number in query01)
            {
                Console.WriteLine(number);
            }

            //Query02
            var query02 = numbers.Distinct().OrderBy(x => x).Select(x => new { Number = x, Multiply = x * x });
            Console.WriteLine("----- Query02 -----");
            foreach (var number in query02)
            {
                Console.WriteLine(number);

            }
            // -----------------------------
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //Query03
            var query03 = names.Where(x => x.Length == 3);
            var query03Q = from x in names
                           where x.Length == 3
                           select x;
            Console.WriteLine("----- Query03 -----");
            foreach (var number in query03Q)
            {
                Console.WriteLine(number);
            }
            //Query04
            var query04 = names.Where(x => x.ToLower().Contains("a")).OrderBy(x => x.Length);
            var query04Q = from x in names
                           where x.ToLower().Contains("a")
                           orderby x.Length
                           select x;

            Console.WriteLine("----- Query04 -----");
            foreach (var number in query04Q)
            {
                Console.WriteLine(number);
            }
            // Query05
            var query05 = names.Take(2);
            var query05Q = (from x in names
                            select x).Take(2);
            Console.WriteLine("----- Query05 -----");
            foreach (var number in query05Q)
            {
                Console.WriteLine(number);
            }

            // -----------------------------------
            List<Student> students = new List<Student>(){new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){Code=33,Name="UML"}}},
              new Student(){ ID=2, FirstName="Mona", LastName="Gala",subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}}, new Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new Subject[]{ new Subject (){ Code=22,Name="EF"}, new Subject (){Code=25,Name="JS"}}},new Student(){ ID=1, FirstName="Ali", LastName="Ali",subjects=new Subject []{ new Subject (){ Code=33,Name="UML"}}}};
            // Query06
            var query06 = students.Select(student => new {FullName = $"{student.FirstName} {student.LastName}",NoOfSubjects = student.subjects.Length});
            Console.WriteLine("----- Query06 -----");
            foreach (var number in query06)
            {
                Console.WriteLine(number);
            }
            // Query07
            var query07 = students.OrderByDescending(student => student.FirstName).ThenBy(student => student.LastName).Select(student => $"{student.FirstName} {student.LastName}");
            Console.WriteLine("----- Query07 -----");
            foreach (var number in query07)
            {
                Console.WriteLine(number);
            }

            // Query08
            var query08 = students.SelectMany(student => student.subjects, (stud,subj) => new { StudentName = $"{stud.FirstName} {stud.LastName}",SubjectName = $"{subj.Name}"});
            Console.WriteLine("----- Query08 -----");
            foreach (var number in query08)
            {
                Console.WriteLine(number);
            }
            // Query09 (Bonus)
            var query09 = students.SelectMany(s => s.subjects.Select(sub => new {StudentName = $"{s.FirstName} {s.LastName}", subjectName = sub.Name
        })).ToList().GroupBy(n => n.StudentName).ToList().Select(g => new
        {
            StudentName = g.First().StudentName,
            subjects = g.Select(o=> o.subjectName).ToList()
        });

            Console.WriteLine("----- Query09 (Bonus)-----");
            foreach (var number in query09)
            {
                Console.WriteLine(number.StudentName);
                foreach (var subject in number.subjects)
                {
                    Console.WriteLine($"\t{subject}");

                }
            }


        }
    }
}
