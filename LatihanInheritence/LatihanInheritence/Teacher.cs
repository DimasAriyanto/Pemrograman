using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritence
{
    internal class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }
        public Teacher(string name, int age, string teacherId, string subject) : base(name, age)
        {
            TeacherId = teacherId;
            Subject = subject;
        }

        public new void GetNameAndAge()
        {
            Console.WriteLine($"The teacher has name : {Name} ,age : {Age} ,teacher ID : {TeacherId} and subject :  {Subject}");
        }
    }
}
