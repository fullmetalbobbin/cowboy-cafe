/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * CornDodgers.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Class to represent the Corn Dodgers side
 *              - a traditional trail treat of fried cornbread
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the CornDodgers side
    /// </summary>
    public class CornDodgers : Side
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
                            return 717;
                        case Size.Medium:
                            return 685;
                        case Size.Small:
                            return 512;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }

            }

        /// <summary>
        /// Converts the object to a string
        /// Returns the representations of a side
        /// </summary>
        /// <returns>The string "Corn Dodgers" </returns>
        public override string ToString()
        {
            return "Corn Dodgers - " + Size;
        }

    }
}
