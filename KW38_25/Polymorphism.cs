using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW38_25
{
    internal class Polymorphism
    {
        static void Main(string[]args)
        {
            Animal myDog = new Dog();
            myDog.MakeSound();


            // Erstelle eine Liste und rufe mehrere Hund oder Katzenklassen auf.


            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Dog(),
                new Cat()
            };

            // Gebe mir die Liste in der Konsole aus

            foreach(var Animal in animals)
            {
                Animal.MakeSound();
            }


            foreach(Animal a in animals)
            {
                a.MakeSound();
            }


            string name = "Max";

            var name1 = "Bob";

            var number = 5;



        }
    }


    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }


    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Miau");
        }
    }


}
