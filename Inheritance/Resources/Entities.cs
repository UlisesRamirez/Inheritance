﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Resources {
    class Entity {
        protected int life;
        protected int armor;
        protected int damage;
        public void Attack(Entity target) {
            target.TakeDamage(this.damage);
        }

        public void TakeDamage(int damage) {
            this.life -= damage - this.armor;
        }

        public int GetLife() {
            return life;
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
            throw new NotImplementedException();
        }
    }

    class Player : Entity {
        public string name; // Given in-code for ease sake
        public double currency; // Dropped by the mobs when they die

        private readonly List<Element> equipment = new List<Element>();

        public Player(int InitialLife, string InitialName) {
            life = InitialLife;
            name = InitialName;
        }

        /*
         * ------------------------------------------------------------------------------------------------- *
         */

        public void Equip(Element element) {
            /* 
             * When called the function should read through the element data,
             * and add the corresponding values to the matching holders
             * 
             */
            equipment.Add(element);
        }

        public void Unequip(Element element) {
            /* 
             * When called the function should read through the element data,
             * and remove the once added to the player
             * 
             */
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