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
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the TexasTea drink
    /// </summary>
    public class TexasTea : Drink, INotifyPropertyChanged
    {
        /// <summary>
        ///  Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


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
                        if (!Sweet) return 11;
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
            set 
            { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the TexasTea has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set 
            { 
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool sweet = true;
        /// <summary>
        /// If the TexasTea is sweetened
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set 
            { 
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// Returns the representations of a drink
        /// </summary>
        /// <returns>The string "Texas Tea" and Size and Sweet presence</returns>
        public override string ToString()
        {
            if (!Sweet)
            {
                return Size + " Texas Plain Tea";
            }
            return Size +" Texas Sweet Tea";
        }

    }
}
