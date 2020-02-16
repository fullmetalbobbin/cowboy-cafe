/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * TexasTea.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Class to represent the Texas Tea drink
 *              - it is sweet iced tea, oh, I do declare.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
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
                        return 36;
                    case Size.Medium:
                        return 22;
                    case Size.Small:
                        return 10;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }

        }

    }
}
