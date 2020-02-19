/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * RustlersRibs.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Class to represent the Rustlers Ribs Entree
 *              - BBQ spare ribs
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the RustlersRibs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the RustlersRibs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the RustlersRibs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the RustlersRibs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }


        /// <summary>
        /// Converts the object to a string
        /// Returns the representations of an entree
        /// </summary>
        /// <returns>The string "Rustler's Ribs"</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }

    }
}
