using System;
using Inheritance.Resources;

namespace Inheritance {
    class Program {
        static void Main() {
            Player Ulises = new Player(10, "ulises", 10);
            Player Jhonny = new Player(20, "jhonny", 5);
            Console.WriteLine(Ulises.GetLife());
            Ulises.Attack(Jhonny);
            Console.WriteLine(Jhonny.GetLife());
            Sword elekid = new Sword();
            Shield caros = new Shield();

            Ulises.Equip(elekid);
            Jhonny.Equip(caros);
        }
    }
}
