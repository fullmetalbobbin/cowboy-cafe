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
    public interface IOrderItem
    {

        /// <summary>
        /// Gets the price of an item
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Gets the calories of an item
        /// </summary>
        public uint Calories { get; }


        /// <summary>
        /// Gets the special instructions for an item
        /// </summary>
        public List<string> SpecialInstructions { get; }
      
    }
}
