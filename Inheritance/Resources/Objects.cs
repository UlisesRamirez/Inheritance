using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Resources {
    class Element {
        protected double life = 0;
        protected double armor = 0;
        protected double damage = 0;
        protected double critMult = 0;
        protected double critChance = 0;
        protected double dodgeChance = 0;

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

        public void Equipping(Entity target) {
            target.life += this.life;
            target.armor += this.armor;
            target.damage += this.damage;
            target.critMult += this.critMult;
            target.critChance += this.critChance;
            target.dodgeChance += this.dodgeChance;
        }

        public void Unequipping(Entity target) {
            target.life -= this.life;
            target.armor -= this.armor;
            target.damage -= this.damage;
            target.critMult -= this.critMult;
            target.critChance -= this.critChance;
            target.dodgeChance -= this.dodgeChance;
        }
    }

    class Sword : Element {
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
        public Shield() {
            Random random = new Random();
            double armorNumber = random.NextDouble() * 10 + 5;
            double dodgChanceNumber = random.NextDouble() * 100 + 5;

            this.armor = armorNumber * this.rarityLevel;
            this.dodgeChance = dodgChanceNumber * this.rarityLevel;
        }
    }

    class Armor : Element {
         public Armor() {
            Random random = new Random();
            double lifeNumber = random.NextDouble() * 10 + 10;
            double armorNumber = random.NextDouble() * 10 + 5;
            double dodgChanceNumber = random.NextDouble() * 100 + 3;

            this.life = lifeNumber * this.rarityLevel;
            this.armor = armorNumber * this.rarityLevel;
            this.dodgeChance = dodgChanceNumber * this.rarityLevel;
        }
    }
}
