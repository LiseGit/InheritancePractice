using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Um-num-num");
        }
    }
}
