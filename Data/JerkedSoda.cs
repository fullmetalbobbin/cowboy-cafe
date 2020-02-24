/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * JerkedSoda.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Class to represent the Jerked Soda drink
 *              - old-fashioned sodas
 *              - from back in the day when they walked up hill both ways
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {

        /// <summary>
        /// Override method with switch case to return price given size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
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
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }

        }


        private SodaFlavor flavor;
        /// <summary>
        /// Which Jerked Soda flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        

        private bool ice = true;
        /// <summary>
        /// If the JerkedSoda has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Special instructions for JerkedSoda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// Returns the representations of a drink
        /// </summary>
        /// <returns>The string "Jerked Soda" and size and flavor </returns>
        public override string ToString()
        {
           switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    return Size + " Cream Soda Jerked Soda";    
                case SodaFlavor.OrangeSoda:
                    return Size + " Orange Soda Jerked Soda";                   
                case SodaFlavor.Sarsparilla:
                    return Size + " Sarsparilla Jerked Soda";                   
                case SodaFlavor.BirchBeer:
                    return Size + " Birch Beer Jerked Soda";                
                case SodaFlavor.RootBeer:
                    return Size + " Root Beer Jerked Soda";
                default:
                    throw new NotImplementedException("Unknown flavor");

            }

        }

    }
}
