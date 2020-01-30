using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the RustlersRibs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the RustlersRibs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the RustlersRibs
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

    }
}
