using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritence
{
    // membuat class student yang merupakan turunan dari class person
    internal class Student : Person
    {
        // deklarasi properti studentID dengan visibility private dan tipe data string
        private string StudentId { get; set; }
        // deklarasi properti email dengan visibility private dan tipe data string
        private string Email { get; set; }
        /* 
         * deklarasi constraction student dengan visibility public dan parameter name, age, studentId, email 
         * yang merupakan deklrasi ulang dari constrction di clas person
         */
        public Student(string name, int age, string studentId, string email) : base(name, age)
        {
            StudentId = studentId;
            Email = email;
        }
        /*
         * deklarasi new void getNameAndAge dengan visibility public untuk 
         * menampilkan name, age, studentId dan email dari constractor
         */
        public new void GetNameAndAge()
        {
            Console.WriteLine($"The student has name : {Name} ,age : {Age} ,student ID :  {StudentId} and email :  {Email}");
        }
    }
}
