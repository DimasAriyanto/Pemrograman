using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            // codingan latihan
            // person.Name = "Mike";
            // person.Age = 20;
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            // codingan latihan
            // teacher.Name = "Thomas";
            // teacher.Age = 35;
            // teacher.TeacherId = "190302";
            // teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Student student = new Student("Sara", 19, "10506", "sara123@amikom.ac.id");
            // codingan latihan
            // student.Name = "Sara";
            // student.Age = 19;
            // student.StudentId = "10506";
            // student.Email = "sara123@amikom.ac.id";
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
