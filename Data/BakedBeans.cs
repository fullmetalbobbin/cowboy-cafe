﻿/* BakedBeans.cs
 * Author: Amanda Dreesen
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the BakedBeans side
    /// </summary>
    public class BakedBeans : Side
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
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
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
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }

        }


    }
}
