/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
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


        private static uint lastOrderNumber = 0;  
        public uint OrderNumber { get { return lastOrderNumber++; } }


        private List<IOrderItem> items = new List<IOrderItem>();  //?
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }


        private List<IOrderItem> prices = new List<IOrderItem>();  //?
        public IEnumerable<IOrderItem> Prices { get { return prices.ToArray(); } }
        //public IEnumerable<IOrderItem> Items => throw new NotImplementedException();
        //public double Subtotal => 0;  //*inclass


        /// <summary>
        /// The subtotal of order
        /// </summary>
        public double Subtotal
        {
            get 
            {
                double subtotal = 0;
                foreach(IOrderItem item in items)
                {
                    subtotal += item.Price; 
                }
                return subtotal;
            }
            
        }

        /// <summary>
        /// Method to add an item to the order
        /// </summary>
        /// <param name="item">Represents the given menu item</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Method to remove and item from the order
        /// </summary>
        /// <param name="item">Represents the given menu item</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

    }
}
