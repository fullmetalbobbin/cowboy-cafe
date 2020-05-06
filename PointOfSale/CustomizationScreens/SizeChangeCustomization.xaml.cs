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

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for SizeChangeCustomization.xaml
    /// </summary>
    public partial class SizeChangeCustomization : UserControl
    {
        public SizeChangeCustomization()
        {
            InitializeComponent();
        }

        public void setSizeButton()
        {
            Size s;
            if (DataContext is Drink)
            {
                Drink d = (Drink)DataContext;
                s = d.Size;
            }
            else if (DataContext is Side)
            {
                Side si = (Side)DataContext;
                s = si.Size;
            }
            else
            {
                throw new NotImplementedException("Appropriate size not selected.");
            }

            switch (s)
            {
                case Size.Small:
                    SizeSmallRadioButton.IsChecked = true;
                    break;
                case Size.Medium:
                    SizeMediumRadioButton.IsChecked = true;
                    break;
                case Size.Large:
                    SizeLargeRadioButton.IsChecked = true;
                    break;
                default:
                    throw new NotImplementedException("Appropriate size not selected.");
            }
        }


        /// <summary>
        /// Changes size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            Size s;

            switch (((RadioButton)sender).Name)
            {
                case "SizeRadioButtonSmall":
                    s = Size.Small;
                    break;
                case "SizeRadioButtonMedium":
                    s = Size.Medium;
                    break;
                case "SizeRadioButtonLarge":
                    s = Size.Large;
                    break;
                default:
                    throw new NotImplementedException("Appropriate size not selected.");
            }


            if (DataContext is Drink)
            {
                Drink dr = (Drink)DataContext;
                dr.Size = s;
            }
            else if (DataContext is Side)
            {
                Side sd = (Side)DataContext;
                sd.Size = s;
            }
            else
                throw new NotImplementedException("Appropriate size not selected.");
        }


    }
}
