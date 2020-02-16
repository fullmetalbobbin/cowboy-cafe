/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Drink.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Base class to represent drinks
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink
    {

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual List<string> Ingredients { get; set; }

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual bool Ice { get; set; }


    }
}
