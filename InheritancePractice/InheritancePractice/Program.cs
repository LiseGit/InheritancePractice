using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            Console.WriteLine("Name a dog");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Lets feed "+dog.Name);
            dog.Eat();
        }
    }
}
