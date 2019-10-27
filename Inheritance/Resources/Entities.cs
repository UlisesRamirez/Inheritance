using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Resources {
    class Entity {
        public double life;
        public double armor;
        public double damage;
        public double critMult;
        public double critChance = 5;
        public double dodgeChance = 5;
        public double currency;

        public void Attack(Entity target) {
            Random random = new Random();
            double chance = random.Next(0, 100);

            if (chance < this.critChance) {
                target.TakeDamage(this.damage * this.critMult, this);
            } else {
                target.TakeDamage(this.damage, this);
            }            
        }

        public void TakeDamage(double damage, Entity attacker) {
            Random random = new Random();
            double chance = random.Next(0, 100);

            if (chance < this.dodgeChance) {
                Console.WriteLine("dodged.");
            } else {
                this.life -= damage - this.armor;
            }
            
            if (this.life - damage <= 0) {
                attacker.currency += this.currency;
            }
        }

        public string Interact(Entity target) {
            try {
                return target.Respond(this);
            }
            catch (Exception e) {
                string output = "an error " + Convert.ToString(e) + " ocurred";
                return output;
            }
        }

        public string Respond(Entity target) {
            string output = "Hi" + target.life;
            return output;
        }
    }

    class Player : Entity {
        public string name; // Given in-code for ease sake        

        private readonly List<Element> equipment = new List<Element>();

        public Player(double InitialLife, string InitialName, double InitialDamage) {
            armor = 0;
            critMult = 2;
            life = InitialLife;
            name = InitialName;
            damage = InitialDamage;
        }

        /*
         * ------------------------------------------------------------------------------------------------- *
         */

        public void Equip(Element element) {
            element.Equipping(this);           
            equipment.Add(element);
        }

        public void Unequip(Element element) {
            element.Unequipping(this);
            equipment.Remove(element);
        }

        /*
         * ------------------------------------------------------------------------------------------------- *
         */

        ~Player() {
            Console.WriteLine("You\'re dead.");
        }
    }

    class Mob : Entity {

    }
}
