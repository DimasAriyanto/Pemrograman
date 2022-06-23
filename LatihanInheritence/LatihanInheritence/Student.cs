using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritence
{
    internal class Student : Person
    {
        public String StudentId { get; set; }
        public string Email { get; set; }
        public Student(string name, int age, string studentId, string email) : base(name, age)
        {
            StudentId = studentId;
            Email = email;
        }

        public new void GetNameAndAge()
        {
            Console.WriteLine($"The student has name : {Name} ,age : {Age} ,student ID :  {StudentId} and email :  {Email}");
        }
    }
}
