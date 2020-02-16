﻿/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
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
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual List<string> SpecialInstructions { get; set; }

    }
}