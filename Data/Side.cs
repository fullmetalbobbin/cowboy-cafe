/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Side.cs
 * Author: CIS308 - Given
 * Modified by: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Base class to represent sides
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */


﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for the side
        /// </summary>
        public virtual List<string> SpecialInstructions { get; set; }
    }
}
