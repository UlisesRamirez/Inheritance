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
    }

    class Sword : Element {
        /* Swords are the main element for: 
         *                          *+- Damage,
         *                          *+- % Critical Chance,
         *                          *+- Critical Damage,
         */
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
