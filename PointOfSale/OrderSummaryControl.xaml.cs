﻿/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * OrderSummaryControl.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    { 
        /// <summary>
        /// Initializes Order Summary Control
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();          
        }

    }
}
