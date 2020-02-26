﻿/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Order.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              Base class to represent Orders of Nom
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent food/drink/nom orders 
    /// </summary>
    public class Order : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged; //*approvedinclass 
        //(saying that any of the public properties, we will tell the event listeners about this change!)


        private static uint lastOrderNumber;

        private List<IOrderItem> items;


        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();
    


        public double Subtotal => 0;  //*inclass
        /*private double subtotal; 
        /// <summary>
        /// The subtotal of order
        /// </summary>
        public double Subtotal
        {

            get { return subtotal; }
            set { subtotal = value; }
        }*/



        /// <summary>
        /// Method to add an item to the order
        /// </summary>
        /// <param name="item">Represents the given menu item</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// Method to remove and item from the order
        /// </summary>
        /// <param name="item">Represents the given menu item</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

    }
}
