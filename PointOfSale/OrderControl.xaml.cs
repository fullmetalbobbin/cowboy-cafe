/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * OrderControl.xaml.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */


using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using Size = CowboyCafe.Data.Size;
using SodaFlavor = CowboyCafe.Data.SodaFlavor;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// 
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Initializes Order Control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            var order = new Order();
            this.DataContext = order;
        }

        /// <summary>
        /// Button click event for ItemSelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Button click event for CancelOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var order = new Order();
            this.DataContext = new Order();
        }

        /// <summary>
        /// Button click event for CompleteOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var order = new Order();
            this.DataContext = new Order();
        }



    }
}
