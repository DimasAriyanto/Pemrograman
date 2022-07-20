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
            // deklarasi object person dari class person dengan parameter dari constractor
            Person person = new Person("Mike", 20);
            // deklarasi void untuk menampilkan constrctor
            person.GetNameAndAge();

            // deklarasi object person dari class teacher dengan parameter dari constractor
            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            // deklarasi void untuk menampilkan constrctor
            teacher.GetNameAndAge();

            // deklarasi object person dari class teacher dengan parameter dari constractor
            Student student = new Student("Sara", 19, "10506", "sara123@amikom.ac.id");
            // deklarasi void untuk menampilkan constrctor
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
