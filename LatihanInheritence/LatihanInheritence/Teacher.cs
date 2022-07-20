using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritence
{
    // membuat class teacher yang merupakan turunan dari class person
    internal class Teacher : Person
    {
        // deklarasi properti teacherId dengan visibility private dan tipe data string
        private string TeacherId { get; set; }
        // deklarasi properti subject dengan visibility private dan tipe data string
        private string Subject { get; set; }
        /* 
         * deklarasi constraction techer dengan visibility public dan parameter name, age, teacherId, subject 
         * yang merupakan deklrasi ulang dari constrction di clas person
         */
        public Teacher(string name, int age, string teacherId, string subject) : base(name, age)
        {
            TeacherId = teacherId;
            Subject = subject;
        }
        /*
         * deklarasi new void getNameAndAge dengan visibility public untuk 
         * menampilkan name, age, teacherId dan subject dari constractor
         */
        public new void GetNameAndAge()
        {
            Console.WriteLine($"The teacher has name : {Name} ,age : {Age} ,teacher ID : {TeacherId} and subject :  {Subject}");
        }
    }
}
