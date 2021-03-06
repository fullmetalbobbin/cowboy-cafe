﻿/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * ChiliCheeseFries.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Class to represent the Chili Cheese Fries side
 *              - sliced potatoes slathered with chili and cheese
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the ChiliCheeseFries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Override method with switch case to return price given a size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }

        }


        /// <summary>
        /// Override method with switch case to return calories given size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
            
        }

        /// <summary>
        /// Converts the object to a string
        /// Returns the representations of a side
        /// </summary>
        /// <returns>The string "Chili Cheese Fries" </returns>
        public override string ToString()
        {
            return Size + " Chili Cheese Fries";
        }


    }
}
