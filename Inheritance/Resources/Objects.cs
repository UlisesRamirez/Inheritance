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
        protected double life = 0;
        protected double armor = 0;
        protected double damage = 0;
        protected double critMult = 0;
        protected double critChance = 0;
        protected double dodgChance = 0;

        protected int rarityLevel = 0;

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
            double damageNumber = random.NextDouble() * 10 + 2;
            double critMultNumber = random.NextDouble() * 10 + 1;
            double critChanceNumber = random.NextDouble() * 100 + 5;

            this.damage = damageNumber * this.rarityLevel;
            this.critChance = critChanceNumber * this.rarityLevel;
            this.critMult = critMultNumber * this.rarityLevel;
        }

    }
     
    class Shield : Element {
        /* Shields are the main element for:
         *                           *+- Armor,
         *                           *+- % Dodge Chance
         */

        public Shield() {
            Random random = new Random();
            double armorNumber = random.NextDouble() * 10 + 5;
            double dodgChanceNumber = random.NextDouble() * 100 + 5;

            this.armor = armorNumber * this.rarityLevel;
            this.dodgChance = dodgChanceNumber * this.rarityLevel;
        }
    }

    class Armor : Element {
        /* Armors are the main element for:
         *                           *+- Life,
         *                           *+- Armor,
         *                           *+- % Dodge Chance
         */
         public Armor() {
            Random random = new Random();
            double lifeNumber = random.NextDouble() * 10 + 10;
            double armorNumber = random.NextDouble() * 10 + 5;
            double dodgChanceNumber = random.NextDouble() * 100 + 3;

            this.life = lifeNumber * this.rarityLevel;
            this.armor = armorNumber * this.rarityLevel;
            this.dodgChance = dodgChanceNumber * this.rarityLevel;
        }
    }
}
