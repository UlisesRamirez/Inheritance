using System;
using Inheritance.Resources;

namespace Inheritance {
    class Program {
        static void Main() {
            Entity Ulises = new Player(10, "ulises");
            Console.WriteLine(Ulises.GetLife());
        }
    }
}
