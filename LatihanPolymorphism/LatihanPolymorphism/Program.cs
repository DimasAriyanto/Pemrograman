using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Cat cat = new Cat();
            animal = cat;
            // cat.Speak();
            animal.Speak();

            Dog dog = new Dog();
            animal = dog;
            // dog.Speak();
            animal.Speak();

            Chicken chicken = new Chicken();
            animal = chicken;
            // chicken.Speak();
            animal.Speak();

            Console.ReadKey();
        }
    }
}
