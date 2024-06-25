using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
  // Abstract class
    abstract class Animal
    {
 // Abstract method (does not have a body)
        public abstract void MakeSound();
    }

  // Derived class (inherits from Animal)
    class Dog : Animal
    {
        // Implementation of abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    // Derived class (inherits from Animal)
    class Cat : Animal
    {
        // Implementation of abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }
}



