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
                        if (!Sweet) return 18;
                        return 36;
                    case Size.Medium:
                        if (!Sweet) return 22;
                        return 22;
                    case Size.Small:
                        if (!Sweet) return 5;
                        return 10;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }

        }


        private bool ice = true;
        /// <summary>
        /// If the TexasTea has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private bool lemon = false;
        /// <summary>
        /// If the TexasTea has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        private bool sweet = true;
        /// <summary>
        /// If the TexasTea is sweetened
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        /// <summary>
        /// Special instructions for TexasTea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");
                if (!lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

    }
}
