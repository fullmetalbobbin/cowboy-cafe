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
        /// <summary>
        /// Event handle to enable listeners to be aware of a property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged; //*approvedinclass 
        //(saying that any of the public properties, we will tell the event listeners about this change!)


        private static uint lastOrderNumber = 0;  
        /// <summary>
        /// Gets the last oder number and retuns the next order number to be used
        /// </summary>
        public uint OrderNumber { get { return lastOrderNumber++; } }


        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Gets IOrderItem item and adds it to a list of items
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }


        private List<IOrderItem> prices = new List<IOrderItem>();
        /// <summary>
        /// Gets IOrderItem price and adds it to a list of prices
        /// </summary>
        public IEnumerable<IOrderItem> Prices { get { return prices.ToArray(); } }


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
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
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
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

    }
}
