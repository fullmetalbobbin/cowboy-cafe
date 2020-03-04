/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * MainWindow.xaml.cs
 * Author: Amanda Dreesen
 * Description: CIS308 Cowboy Cafe
 *              
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes MainWindow
        /// </summary>
        public MainWindow()
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
