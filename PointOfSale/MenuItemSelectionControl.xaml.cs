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

using PointOfSale.CustomizationScreens;
using PecosPulledPork = CowboyCafe.Data.PecosPulledPork;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            //AddAngryChickenButton.Height = 40;
            //AddPecosPulledPorkButton.Click += AddPecosPulledPorkButton_Click;
        }

        /// <summary>
        /// Button click event for adding AngryChicken to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order o)
            {
                o.Add(new AngryChicken());

            }
        }

        /// <summary>
        /// Button click event for adding CowpokeChili to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// Button click event for adding RustlersRibs to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// Button click event for adding PecosPulledPork to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// Button click event for adding TrailBurger to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new TrailBurger());
            }
        }

        /// <summary>
        /// Button click event for adding DakotaDoubleBurger to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// Button click event for adding TxasTripleBurger to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Button click event for adding ChiliCheeseFries to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Button click event for adding CornDodgers to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Button click event for adding PanDeCampo to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Button click event for adding BakedBeans to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Button click event for adding JerkedSoda to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// Button click event for adding TexasTea to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new TexasTea());
            }
        }

        /// <summary>
        /// Button click event for adding CowboyCoffee to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// Button click event for adding Water to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new Water());
            }
        }

    }
}
