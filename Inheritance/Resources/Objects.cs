using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Resources {
    class Element {
        /*
         * TODO: Create BaseLine of the elements, to include the type of variables to have in account are:
         *                                                                  *+- Life,
         *                                                                  *+- Armor,
         *                                                                  *+- Damage,
         *                                                                  *+- % Critical Chance,
         *                                                                  *+- Critical Damage,
         *                                                                  *+- % Dodge Chance
         *                * Rarities, should affect the element 
         *
         *          Some methods to include as well could be: Reforge, Enchant, or maybe an exchange?
         */
        protected double life;
        protected double armor;
        protected double damage;
        protected double critDamage;
        protected double critChance;
        protected double dodgChance;

        protected int rarityLevel;

        public Element() {
            Random random = new Random();
            double number = random.NextDouble();
            
            if (number <= 0.05) {
                rarityLevel = 3;
            } else {
                if (number > 0.05 && number < 0.2) {
                    rarityLevel = 2;
                } else {
                    rarityLevel = 1;
                }
            }
        }

    }

    class Sword : Element {
        /* Swords are the main element for: 
         *                          *+- Damage,
         *                          *+- % Critical Chance,
         *                          *+- Critical Damage,
         */

        public Sword() {
            Random random = new Random();
            double damageNumber = random.NextDouble();
            double critDamageNumber = random.NextDouble();
            double critChanceNumber = random.NextDouble();

            damageNumber = damageNumber * 10 + 2;
            critDamageNumber = critDamageNumber * 10 + 1;
            critChanceNumber = critChanceNumber * 100 + 5;

            this.damage = damageNumber * this.rarityLevel;
            this.critChance = critChanceNumber * this.rarityLevel;
            this.critDamage = critDamageNumber * this.rarityLevel;
        }
    }
     
    class Shield : Element {
        /* Shields are the main element for:
         *                           *+- Armor,
         *                           *+- % Dodge Chance
         */
    }

    class Armor : Element {
        /* Armors are the main element for:
         *                           *+- Life,
         *                           *+- Armor,
         *                           *+- % Dodge Chance
         */
    }
}
