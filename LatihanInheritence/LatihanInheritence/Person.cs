using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritence
{
    internal class Person
    {
        // deklarasi properti name dengan visibility protected dan tipe data string
        protected string Name { get; set; }
        // deklarasi properti age dengan visibility protected dan tipe data int
        protected int Age { get; set; }
        // deklarasi constraction Person dengan visibility public dan parameter dari proeprti name dan age
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Age = age;
        }
        // deklarasi method getNameAndAge dengan visibility public untuk menampilkan name dan age dari constractor
        public void GetNameAndAge()
        {
            Console.WriteLine($"The person has name : {Name} and age : {Age}");
        }
    }
}
