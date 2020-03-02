﻿
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
        public MainWindow()
        {
            InitializeComponent();
            var order = new Order();
            this.DataContext = order;


        }

        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var order = new Order();
            this.DataContext = new Order();
        }

        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var order = new Order();
            this.DataContext = new Order();
        }
    }
}
