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
    public class PecosPulledPork
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
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the PecosPulledPork sammich
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the PecosPulledPork sammich
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

    }
}
