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
using SodaFlavor = CowboyCafe.Data.SodaFlavor;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for FlavorChangeCustomization.xaml
    /// </summary>
    public partial class FlavorChangeCustomization : UserControl
    {
        public FlavorChangeCustomization()
        {
            InitializeComponent();
        }

        private void FlavorRadioButton_Click(object sender, RoutedEventArgs e)
        {
            SodaFlavor s;

            switch (((RadioButton)sender).Name)
            {
                case "FlavorCreamSodaRadioButton":
                    s = SodaFlavor.CreamSoda;
                    break;
                case "FlavorOrangeSodaRadioButton":
                    s = SodaFlavor.OrangeSoda;
                    break;
                case "FlavorSarsparillaRadioButton":
                    s = SodaFlavor.Sarsparilla;
                    break;
                case "FlavorBirchBeerRadioButton":
                    s = SodaFlavor.BirchBeer;
                    break;
                case "FlavorRootBeerRadioButton":
                    s = SodaFlavor.RootBeer;
                    break;
                default:
                    throw new NotImplementedException("Appropriate soda flavor not selected");
            }


            if (DataContext is JerkedSoda)
            {
                JerkedSoda js = (JerkedSoda)DataContext;
                js.Flavor = s;
            }
            else
                throw new NotImplementedException("Jerked Soda Flavors only.");
        }

    }
}
