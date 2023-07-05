using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    abstract public class Animal
    {
        public string Name { set; get; }

        public abstract void Eat();
    }
}
