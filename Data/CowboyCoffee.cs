/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * CowboyCoffee.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Class to represent the Cowboy Coffee drink
 *              - coffee - brown bean juice
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the CowboyCoffee drink
    /// </summary>
    public class CowboyCoffee : Drink, INotifyPropertyChanged
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
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
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
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }

        }



        private bool ice = false;
        /// <summary>
        /// If the CowboyCoffee has ice
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


        private bool decaf = false;
        /// <summary>
        /// If the Cowboy Coffee is decaf and useless
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set 
            { 
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private bool roomForCream = false;
        /// <summary>
        /// If the CowboyCoffee has room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set 
            { 
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// Special instructions for CowboyCOfee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (roomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// Returns the representations of a drink
        /// </summary>
        /// <returns>The string "Cowboy Coffee" and Size and Decaf</returns>
        public override string ToString()
        {
            if (decaf)
            {
                return Size + " Decaf Cowboy Coffee";
            }
            return Size + " Cowboy Coffee";
        }

    }
}
