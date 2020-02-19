/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * PecosPulledPork.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Class to represent the Pecos Pulled Pork Entree
 *              - BBQ pulled pork sandwich
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the PecosPulledPork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {

        private bool bread = true;
        /// <summary>
        /// If the PecosPulledPork sammich has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the PecosPulledPork sammich has pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// The price of the PecosPulledPork sammich
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the PecosPulledPork sammich
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the PecosPulledPork sammich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }


        /// <summary>
        /// Converts the object to a string
        /// Returns the representations of an entree
        /// </summary>
        /// <returns>The string "Pecos Pulled Pork"</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

    }
}
