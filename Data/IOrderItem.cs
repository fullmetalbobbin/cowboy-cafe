/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * IOrderItem.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Interface for IOrderItems 
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing IOrderItems
    /// </summary>
    interface IOrderItem
    {
        /// <summary>
        /// Gets the price of and item
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the special instructions for an item
        /// </summary>
        public virtual IEnumerable<string> SpecialInstructions { get; }

    }
}
