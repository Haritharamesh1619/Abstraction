using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
     class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of derived classes
            Animal dog = new Dog();
            Animal cat = new Cat();

            // Displaying sounds made by the animals
            dog.MakeSound();
            cat.MakeSound();

            Console.ReadKey();
        }
    }
}
