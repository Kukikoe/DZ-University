using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityClassLibrary;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Yana", "Bondareva");
            Student student2 = new Student("Anna", "Ivanova");
            Student student3 = new Student("Maksim", "Oancha");
            Student student4 = new Student("Masha", "Popova");

            Subject subject1 = new Subject("Math");
            Subject subject2 = new Subject("Physics");
            Subject subject3 = new Subject("Philosophy");
            Subject subject4 = new Subject("Programming");

            Group group = new Group("K13-2");
            group.ListOfStudents.Add(student1);
            group.ListOfStudents.Add(student2);
            group.ListOfStudents.Add(student3);
            group.ListOfStudents.Add(student4);

            Specialty specialty = new Specialty("ITST");
            specialty.ListOfGroups.Add(group);
           

            Audience audience1 = new Audience("322", 20);
            Audience audience2 = new Audience("118", 45);

            Teacher teacher1 = new Teacher("Masha", "Franko");
            teacher1.ListOfSubjects.Add(subject1);
            teacher1.ListOfSubjects.Add(subject3);
            teacher1.ListOfAudiences.Add(audience1);
            Teacher teacher2 = new Teacher("Evgeniy", "Stepanov");
            teacher2.ListOfSubjects.Add(subject2);
            teacher2.ListOfSubjects.Add(subject1);
            teacher2.ListOfSubjects.Add(subject4);
            teacher2.ListOfAudiences.Add(audience2);

            Random rnd = new Random();
            foreach (var mark in group.ListOfStudents)
            {
                mark.ListOfMarks.Add(new Mark(subject1, rnd.Next(0, 100)));
                mark.ListOfMarks.Add(new Mark(subject2, rnd.Next(0, 100)));
                mark.ListOfMarks.Add(new Mark(subject3, rnd.Next(0, 100)));
                mark.ListOfMarks.Add(new Mark(subject4, rnd.Next(0, 100)));
            }
            Console.WriteLine("Specialty " + specialty.ToString() + ":\n" + specialty.ShowListOfGroups().PadLeft(24) + "\n" + group.ShowListOfStudents());
            Console.WriteLine();
            foreach (var stud in group.ListOfStudents)
            {
                Console.WriteLine("Student: " + stud.ToString());
                Console.WriteLine("Rating: " + stud.GradeToString());
                Console.WriteLine();
            }
            Console.WriteLine("Teacher " + teacher1.ToString() + " leads this subjects:\n" + teacher1.ShowListOfSubjects() + " in audience №" + teacher1.ShowListOfAudiences());
            Console.WriteLine("\nTeacher " + teacher2.ToString() + " leads this subjects:\n" + teacher2.ShowListOfSubjects() + " in audience №" + teacher2.ShowListOfAudiences());

            Console.ReadKey();
        }
    }
}
