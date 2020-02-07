/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Side.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Base class to represent entrees
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree
    {
        //It should define properties for Price (double), Calories (uint),
        //and SpecialInstructions (List of strings) that can be overridden in any derived classes.
        //Refactor the CowpokeChili, RustlersRibs, PecosPulledPork, TrailBurger, DakotaDouble,
        //TexasTriple, and Angry Chicken to derive from this Entree base class.

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

    }
}
