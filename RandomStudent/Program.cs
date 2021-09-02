using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>(16);
            StudentList.Add(new Student("David Antolin", StudentType.Junior));
            StudentList.Add(new Student("Selene Arias", StudentType.Junior));
            StudentList.Add(new Student("Pablo Blanco", StudentType.Dual));
            StudentList.Add(new Student("Cristian Bozal", StudentType.Dual));
            StudentList.Add(new Student("Santiago Comeras", StudentType.Junior));
            StudentList.Add(new Student("Nacho De Haro", StudentType.Junior));
            StudentList.Add(new Student("Pablo Giner", StudentType.Junior));
            StudentList.Add(new Student("Sergio Hervás", StudentType.Junior));
            StudentList.Add(new Student("Ana Izquierdo", StudentType.Junior));
            StudentList.Add(new Student("Conchita Lafuente", StudentType.Junior));
            StudentList.Add(new Student("Daniel Lores", StudentType.Dual));
            StudentList.Add(new Student("Maria Navarro", StudentType.Dual));
            StudentList.Add(new Student("Jesus Salas", StudentType.Junior));
            StudentList.Add(new Student("Javier Sañudo", StudentType.Dual));
            StudentList.Add(new Student("Alberto Vicente", StudentType.Dual));
            StudentList.Add(new Student("Pablo Viturro", StudentType.Dual));
            StudentList.Add(new Student("Ángel Gómez", StudentType.Junior));

            Random random = new Random();
            Console.WriteLine(StudentList[random.Next(0, StudentList.Count)].Name);

            Console.ReadLine();
        }

        enum StudentType
        {
            Dual,
            Junior
        }
        class Student
        {
            public String Name { get; set; }
            public StudentType StudentType { get; set; }

            public Student(String name, StudentType st)
            {
                Name = name;
                StudentType = st;
            }

        }


    }
}
